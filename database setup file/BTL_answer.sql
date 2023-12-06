use BTL_db_official
go
--1/ create trigger
--drop trigger update_no_product
create trigger update_no_product 
on Product
after insert, delete
as
begin
	set nocount on;
	
	----------------
	declare @exceed int;
	--declare @change_table table (shop_id varchar(9));
	declare @shop_id varchar(9);
	

	if exists (select 0 from inserted) --insert
	begin
		declare cur Cursor for select shop_id from inserted;
		set @exceed = 1
	end
	else
	begin
		declare cur Cursor for select shop_id from deleted;
		set @exceed = -1
	end
	open cur;
	fetch next from cur into @shop_id;
	----------------
	while @@FETCH_STATUS = 0
	begin
		update Shop
		set no_product = no_product  + @exceed
		where shop_id = @shop_id
		fetch next from cur into @shop_id
	end

	close cur;
	deallocate cur;
end;
go
create trigger update_min_max_totalremain
on Variant
after insert, delete,update
as
begin
	set nocount on;

	--------------------
	if exists (select 0 from inserted) --insert or update
	begin
		declare cur Cursor for select distinct product_id from inserted
	end
	else
	begin
		declare cur Cursor for select distinct product_id from deleted
	end

	declare @product_id varchar(9);
	declare @min decimal(10,1) = 0;
	declare @max decimal(10,1) = 0;
	declare @totalremain int = 0;
	open cur
	fetch next from cur into @product_id
	--------------------
	while @@FETCH_STATUS = 0
	begin
		set @min = (
			select min(price) 
			from Variant 
			where product_id = @product_id)
		set @max = (
			select max(price)
			from Variant
			where product_id = @product_id)
		set @totalremain = (
			select sum(remaining_amount)
			from Variant
			where product_id = @product_id)


		if @min is null set @min = 0
		if @max is null set @max = 0
		if @totalremain is null set @totalremain = 0
		
		
		update Product
		set minimum_price = @min ,
			maximum_price = @max,
			total_remaining = @totalremain
		where product_id = @product_id
		fetch next from cur into @product_id
	end
	close cur
	deallocate cur
	--------------------
end
go
--drop trigger update_no_productname_of_order
create trigger update_no_product_of_order
on Is_contained
after insert, delete
as
begin
	set nocount on;

	--------------------
	if exists (select 0 from inserted)
	begin
		declare cur Cursor for (select distinct order_id from inserted);
	end
	else
	begin
		declare cur cursor for (select distinct order_id from deleted);
	end
	declare @order_id varchar(14);
	declare @no_product int;
	declare @list_product table(product_id varchar(9));
	open cur
	fetch next from cur into @order_id
	--------------------
	while @@FETCH_STATUS = 0
	begin
		insert into @list_product
		select distinct p.product_id
		from Is_contained i, Product_instance p
		where i.order_id = @order_id and p.instance_id = i.instance_id;
		
		set @no_product = (select count(*) from @list_product)
		update [Order]
		set no_product = @no_product
		where order_id = @order_id
		fetch next from cur into @order_id
		delete @list_product
	end
	close cur
	deallocate cur
end
go
create trigger update_no_product_of_cart
on [Add]
after insert,delete
as
begin
	set nocount on;

	--------------------
	if exists (select 0 from inserted)
	begin
		declare cur Cursor for (select distinct user_id,number  from inserted);
	end
	else
	begin
		declare cur cursor for (select distinct user_id,number from deleted);
	end
	declare @user_id varchar(9);
	declare @number		int;
	open cur;
	fetch next from cur into @user_id, @number;
	---------------------
	while @@FETCH_STATUS = 0
	begin
		update Shopping_cart
		set no_product = (select count(*) from [Add] where user_id = @user_id and number = @number )
		where user_id = @user_id and number = @number;

		fetch next from cur into @user_id, @number;
	end
	close cur
	deallocate cur

end
go
--drop trigger check_n_update_quantity_Voucher
create trigger check_n_update_quantity_Voucher
on Applies
after Insert
as
begin
	--check available
	declare cur Cursor for (select * from inserted)
	declare @ord varchar(14)
	declare @vch varchar(9)

	open cur
	fetch next from cur into @ord, @vch

	while @@FETCH_STATUS = 0
	begin
		if not exists (
			select * from Can_apply
			where voucher_id = @vch and
			(category_id = 'CATffffff' or category_id in (
				select distinct p.category_id from Is_contained i, Product_instance pin, Product p
				where i.order_id = @ord and i.instance_id = pin.instance_id and pin.product_id = p.product_id)) and
			(shop_id = 'SIDffffff' or shop_id in (
				select distinct p.shop_id from Is_contained i, Product_instance pin, Product p
				where i.order_id = @ord and i.instance_id = pin.instance_id and pin.product_id = p.product_id))
		) and (select quantity from Voucher where voucher_id = @vch) <= 0
		begin
			print 'Can not apply voucher due to its conditions'
			close cur
			deallocate cur
			rollback transaction
			return
		end

		fetch next from cur into @ord, @vch
	end
	close cur
	deallocate cur

	-- update quantity
	declare cur Cursor for (select voucher_id from inserted);

	open cur
	fetch next from cur into @vch;

	while @@FETCH_STATUS = 0
	begin
		update Voucher
		set quantity = quantity - 1
		where voucher_id = @vch

		fetch next from cur into @vch
	end
	close cur
	deallocate cur
end
go
-- trigger to calculate the avg rating of a shop base on review
create trigger cal_avg_rating
on Review
after insert, update
as
begin
	declare cur Cursor for (
	select distinct s.shop_id from inserted i,Shop s, Product p
	where i.product_id = p.product_id and p.shop_id = s.shop_id)

	declare @shop_id varchar(9)
	open cur
	fetch next from cur into @shop_id
	while @@FETCH_STATUS = 0
	begin
		declare @avgRating decimal(2,1)
		set @avgRating = (
			select AVG(cast(r.no_stars as decimal(2,1))) as avgRate
			from Review r, Product p
			where r.product_id = p.product_id and p.shop_id = @shop_id)
		if @avgRating is null 
			set @avgRating = 0
		
		update Shop
		set rating = @avgRating
		where shop_id = @shop_id;

		fetch next from cur into @shop_id

	end
	close cur
	deallocate cur
end
-- trigger for current price
go
--drop trigger check_before_update
create trigger check_before_update 
on Product_instance
for update
as
begin
	declare cur Cursor for (select instance_id from inserted)

	declare @instance_id varchar(9)

	open cur
	fetch next from cur into @instance_id

	while @@FETCH_STATUS = 0
	begin
		if exists (select * from Is_contained where instance_id = @instance_id) -- exists in order
		begin
			print 'Error in product instance ' + @instance_id
			print 'Can not change current price of a instance that is in order'
			close cur
			deallocate cur
			rollback transaction
			return
		end

		fetch next from cur into @instance_id
	end
	close cur
	deallocate cur
end
go

go
---2 insert, delete, update
--drop procedure insert_product
create procedure insert_product 
@product_id varchar(9), --mendatory
@des varchar(1000) = null, --optional
@name varchar(50),	--mendatory
@total_remaining int, --mendatory
@price	decimal(10,1), --mendatory
@cat varchar(9) = null, --optional
@sid varchar(9), --mendatory
@img varchar(1000) = null,
@result varchar(1000) = '' Output --default = ''
as
begin
	if exists (select product_id from Product where product_id = @product_id)
		set @result = @result + 'Product ID has already existed_'
	if not exists (select shop_id from Shop where shop_id = @sid)
		set @result = @result + 'Invalid Shop ID_'
	if @cat is not null and not exists (select category_id from Category where category_id = @cat)
		set @result = @result + 'Invalid Catgory ID_'
	if @total_remaining < 0
		set @result = @result + 'Total remaining can not be a negative number_'
	if @price < 0 
		set @result = @result + 'Price can not be a negative number_'
	if @product_id not like 'PNI%' or LEN(@product_id) != 9
		set @result = @result + 'Invalid product id format_'
	if @result = ''
	begin
		if @des is not null
			insert into Product values (
				@product_id,
				@des,
				@name,
				@total_remaining,
				default,
				@price,
				@price,
				@cat,
				@sid,
				@img)
		else 
			insert into Product values (
				@product_id,
				default,
				@name,
				@total_remaining,
				default,
				@price,
				@price,
				@cat,
				@sid,
				@img)
		set @result = 'Successfully adding'
	end
end
go
--drop procedure delete_product
create procedure delete_product
@product_id varchar(9),
@result varchar(100) = '' output
as
begin
	if not exists (select * from Product where product_id = @product_id)
		set @result = @result + 'Invalid product name_'
	if @result = ''
	begin
		--delete belong and variant fisrt
		delete Belong_to where product_id = @product_id
		delete Variant where product_id = @product_id

		--not exist in is contained (mean is in order) => delete
		delete Product_instance
		where product_id = @product_id and
		not exists (select * from Is_contained i where i.instance_id = instance_id);

		--exist in is contained => ref to null product_id pniffffff)
		update Product_instance
		set product_id = 'PIDffffff'
		where product_id = @product_id;

		--update review
		update Review
		set product_id = 'PIDffffff'
		where product_id = @product_id;

		--update Add
		update [Add]
		set product_id = 'PIDffffff'
		where product_id = @product_id

		--delete Product
		delete Product where product_id = @product_id
		set @result = 'Successfully deleting'
	end
end
go
--drop procedure update_product
create procedure update_product --when update, get all information from edit panel
@pid_current varchar(9),
@pid_new	varchar(9),
@des varchar(1000), 
@name varchar(50),	
@total_remaining int,
@no_sales	int, --ignore because mustn't modify
@min_price	decimal(10,1),
@max_price	decimal(10,1),
@cat varchar(9), 
@sid varchar(9),
@img varchar(1000),
@result varchar(1000) = '' Output --default = ''
as
begin
	declare @min_price_cur decimal(10,1) = (select minimum_price from Product where product_id = @pid_current)
	declare @max_price_cur decimal(10,1) = (select maximum_price from Product where product_id = @pid_current)
	
	if @pid_current != @pid_new and exists(select * from Product where product_id=@pid_new)
		set @result = @result + 'Product ID has already existed_'
	if @pid_current != @pid_new and (@pid_new not like 'PNI%' or len(@pid_new) != 9)
		set @result = @result + 'Invalid product id format_'
	if @total_remaining < 0
		set @result = @result + 'Total remaining can not be a negative number_'
	if @cat is not null and not exists (select * from Category where category_id = @cat)
		set @result = @result + 'Invalid category_'
	if not exists (select * from Shop where shop_id = @sid)
		set @result = @result + 'Invalid shop_'
	if exists (select * from Variant where product_id = @pid_current) -- has Variant => can't modify total remaining or price
	begin
		if @max_price_cur != @max_price or @min_price_cur != @min_price
			set @result = @result + 'This product name has 1 or more Variants,so the price cannot be modified here_'
		if @total_remaining != (select total_remaining from Product where product_id = @pid_current)
			set @result = @result + 'This product name has 1 or more Variants, so total remaining cannot be modified here_'
	end
	if not exists (select * from Variant where product_id = @pid_current) -- no Variant => max = min and >= 0
	begin
		if @min_price != @max_price
			set @result = @result + 'There are not any Variants in this product, so the minimum price and maximum price must have the same value_'
		if @min_price <0 or @max_price < 0
			set @result = @result + 'The price can not be a negative number_'
	end

	if @result = ''
	begin
		update Product
		set [description] = @des,
		[name] = @name,
		total_remaining = @total_remaining,
		no_sales = @no_sales,
		minimum_price = @min_price,
		maximum_price = @max_price,
		category_id = @cat,
		shop_id = @sid,
		product_id = @pid_new, --update cascade, no need to update on belong, Variant, product, review, add
		img = @img
		where product_id = @pid_current;

		set @result = 'Successfully updating'
	end
end
go
---3 procedure
-- procedure to update shop bio
-- drop procedure filter_product
create procedure filter_product
@total_remaining_min_filter int = -1,
@total_remaining_max_filter int = -1,
@no_sales_min_filter int = -1,
@no_sales_max_filter int = -1,
@min_price_filter decimal(10,1) = -1,
@max_price_filter decimal(10,1) = -1,
@cat_filter varchar(9) = '',
@sid_filter varchar(9) = ''
as
begin
	select 
	s.[name],
	c.category_name,
	p.product_id, 
	p.[name], p.[description], p.no_sales,
	p.total_remaining, 
	p.minimum_price,
	p.maximum_price,
	p.img
	from Product p, Shop s, Category c
	where
		(@total_remaining_min_filter = -1 or p.total_remaining >= @total_remaining_min_filter) and
		(@total_remaining_min_filter = -1 or p.total_remaining <= @total_remaining_max_filter) and
		(@no_sales_min_filter = -1 or p.no_sales >= @no_sales_min_filter) and
		(@no_sales_max_filter = -1 or p.no_sales <= @no_sales_max_filter) and
		(@min_price_filter = -1 or p.minimum_price >= @min_price_filter) and
		(@max_price_filter = -1 or p.maximum_price <= @max_price_filter) and
		(@cat_filter = '' or p.category_id = @cat_filter) and
		(@sid_filter = '' or p.shop_id = @sid_filter) and
		p.shop_id = s.shop_id and p.category_id = c.category_id
	order by p.minimum_price asc;
end
go
create procedure best_selling_store
@no_sales_min int,
@no_product_min int
as
begin
	select s.shop_id, s.[name], count(*) as no_most_selling_product
	from Shop s, Product p
	where s.shop_id = p.shop_id and p.no_sales >= @no_sales_min
	group by s.shop_id, s.[name]
	having count(*) >= @no_product_min
	order by no_most_selling_product desc
end
go
---4 function
--drop function check_login_seller
create function check_login_seller(
@user_name varchar(15),
@email	varchar(100),
@pwd	varchar(100)
)
returns varchar(9)
as
begin
	declare @sid varchar(9) = 'Deny'
	if not exists(select * from [User] where ((@user_name is not null and @user_name = user_name)
	or (@email is not null and @email = linking_email)) and [password] = @pwd)
		return @sid
	set @sid = (select shop_id from Seller s, [User] u where s.user_id = u.user_id and u.user_name = @user_name)
	return @sid
end
/*select * from Shop
select * from Product
select * from Is_contained
select * from Product
select * from [Order]*/

/*select sum(Prod.current_price)
from Shop as Sh, Product as Prod_name, [Order] as Ord, Is_contained as Cont, Product as Prod
where Sh.shop_id = Prod_name.shop_id
	and Prod_name.product_id = Prod.product_id
	and Prod.product_id = Cont.product_id
	and Ord.order_id = Cont.order_id*/

go
create function sum_revenue(@shopID varchar(9),@startDate date,@endDate date)
returns table as
return(
	select p.product_id,p.name,sum(pin.current_price) as total_revenue
	from ((Product_instance pin join Is_contained i on pin.instance_id=i.instance_id)
		join [Order] o on (o.order_id = i.order_id and o.status = 'Done'))
		join Product p on (pin.product_id = p.product_id and p.shop_id = @shopID)
	where cast(o.time_order as date) between @startDate and @endDate
	group by p.product_id,p.name
)
go
create function list_order(@buyerID varchar(9),@startDate date,@endDate date)
returns table as
return(
	select o.status, count(*) as num
	from Places p, [Order] o
	where
		(@buyerID = p.user_id or @buyerID = p.user_id_cart) and
		p.order_id = o.order_id and
		((cast(o.time_order as date) between @startDate and @endDate) or
		(@startDate is null and @endDate is null) or
		(@startDate is null and cast(o.time_order as date) <= @endDate) or
		(@endDate is null and cast(o.time_order as date) >= @startDate)) 
	group by o.status
	)
go

/*
Must do
add trigger current X
generate ID function X
insert place (maybe no need)
*/
--drop function generate_PID
create function generate_PID() -- use in application
returns varchar(9)
as
begin
	if not exists (select * from Product)
		return 'PID000000'

	declare @newPID varchar(9)
	declare @listPID table (postfix int)

	insert into @listPID 
	select Convert(int,REPLACE(p.product_id,'PID','1')) as pid_trans 
	from Product p 
	where p.product_id != 'PIDffffff' 
	order by pid_trans asc
	
	declare cur Cursor for (select * from @listPID)
	declare @pre int
	declare @current int

	open cur
	fetch next from cur into @pre

	if @pre > 1000000 return 'PID000000'

	fetch next from cur into @current
	
	while @@FETCH_STATUS = 0
	begin
		if @current != (@pre + 1)
			break

		set @pre = @current
		fetch next from cur into @current
	end
	
	if @pre = 1999999 
	begin
		return null
	end
	set @newPID = 'PID' + substring(convert(varchar(7),@pre + 1),2,6)
	return @newPID
end
go
create function generate_IID() -- ignore, just use to insert data more easily
returns varchar(9)
as
begin
	if not exists (select * from Product_instance)
		return 'IID000000'

	declare @newIID varchar(9)
	declare @listIID table (postfix int)

	insert into @listIID 
	select Convert(int,REPLACE(p.instance_id,'PID','1')) as iid_trans 
	from Product_instance p  
	order by iid_trans asc
	
	declare cur Cursor for (select * from @listIID)
	declare @pre int
	declare @current int

	open cur
	fetch next from cur into @pre

	if @pre > 1000000 return 'IID000000'

	fetch next from cur into @current
	
	while @@FETCH_STATUS = 0
	begin
		if @current != (@pre + 1)
			break

		set @pre = @current
		fetch next from cur into @current
	end
	
	if @pre = 1999999 
	begin
		return null
	end
	set @newIID = 'IID' + substring(convert(varchar(7),@pre + 1),2,6)
	return @newIID
end

go

