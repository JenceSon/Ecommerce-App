use BTL
go
--1/ create trigger
create trigger update_no_productname 
on Product_name
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
		set no_productname = no_productname + @exceed
		where shop_id = @shop_id
		fetch next from cur into @shop_id
	end

	close cur;
	deallocate cur;
end;
go
create trigger update_min_max_totalremain
on Version
after insert, delete,update
as
begin
	set nocount on;

	--------------------
	if exists (select 0 from inserted) --insert or update
	begin
		declare cur Cursor for select distinct productname_id from inserted
	end
	else
	begin
		declare cur Cursor for select distinct productname_id from deleted
	end

	declare @productname_id varchar(9);
	declare @min decimal(10,1);
	declare @max decimal(10,1);
	declare @totalremain int;
	open cur
	fetch from cur into @productname_id
	--------------------
	while @@FETCH_STATUS = 0
	begin
		set @min = (
			select min(price) 
			from version 
			where productname_id = @productname_id)
		set @max = (
			select max(price)
			from Version
			where productname_id = @productname_id)
		set @totalremain = (
			select sum(remaining_amount)
			from Version
			where productname_id = @productname_id)


		if @min is null set @min = 0
		if @max is null set @max = 0
		if @totalremain is null set @totalremain = 0
		
		
		update Product_name
		set minimum_price = @min ,
			maximum_price = @max,
			total_remaining = @totalremain
		where productname_id = @productname_id
		fetch from cur into @productname_id
	end
	close cur
	deallocate cur
	--------------------
end
go
create trigger update_no_productname_of_order
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
	declare @no_productname int;
	declare @list_productname table(productname_id varchar(9));
	open cur
	fetch from cur into @order_id
	--------------------
	while @@FETCH_STATUS = 0
	begin
		insert into @list_productname
		select distinct p.productname_id
		from Is_contained i, Product p
		where i.order_id = @order_id and p.product_id = i.product_id;
		
		set @no_productname = (select count(*) from @list_productname)
		update [Order]
		set no_productname = @no_productname
		where order_id = @order_id
		fetch from cur into @order_id
		delete @list_productname
	end
	close cur
	deallocate cur
end
go
create trigger update_no_productname_of_cart
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
	declare @list_productname table (productname_id varchar(9));
	open cur;
	fetch from cur into @user_id, @number;
	---------------------
	while @@FETCH_STATUS = 0
	begin
		insert into @list_productname
		select distinct productname_id
		from Product p, [Add] a
		where p.product_id = a.product_id and a.number = @number and a.user_id=@user_id;

		update Shopping_cart
		set no_productname = (select count(*) from @list_productname)
		where user_id = @user_id and number = @number;

		fetch from cur into @user_id, @number;
		delete @list_productname
	end
	close cur
	deallocate cur

end
go
---2 insert, delete, update
--drop procedure insert_productname
create procedure insert_productname 
@productname_id varchar(9), --mendatory
@des varchar(1000) = null, --optional
@name varchar(50),	--mendatory
@total_remaining int, --mendatory
@price	decimal(10,1), --mendatory
@cat varchar(9) = null, --optional
@sid varchar(9), --mendatory
@result varchar(1000) = '' Output --default = ''
as
begin
	if exists (select productname_id from Product_name where productname_id = @productname_id)
		set @result = @result + 'Product name has already existed_'
	if not exists (select shop_id from Shop where shop_id = @sid)
		set @result = @result + 'Invalid Shop_'
	if @cat is not null and not exists (select category_id from Category where category_id = @cat)
		set @result = @result + 'Invalid Catgory_'
	if @total_remaining < 0
		set @result = @result + 'Total remaining can not be a negative number_'
	if @price < 0 
		set @result = @result + 'Price can not be a negative number_'
	if @productname_id not like 'PNI%' or LEN(@productname_id) != 9
		set @result = @result + 'Invalid Productname id format_'
	if @result = ''
	begin
		if @des is not null
			insert into Product_name values (
				@productname_id,
				@des,
				@name,
				@total_remaining,
				default,
				@price,
				@price,
				@cat,
				@sid)
		else 
			insert into Product_name values (
				@productname_id,
				default,
				@name,
				@total_remaining,
				default,
				@price,
				@price,
				@cat,
				@sid)
		set @result = 'Successfully adding'
	end
end
go
--drop procedure delete_productname
create procedure delete_productname
@productname_id varchar(9),
@result varchar(100) = '' output
as
begin
	if not exists (select * from Product_name where productname_id = @productname_id)
		set @result = @result + 'Invalid product name_'
	if @result = ''
	begin
		--delete belong and version fisrt
		delete Belong_to where productname_id = @productname_id
		delete Version where productname_id = @productname_id

		--not exist in add and is contained => delete
		delete Product
		where productname_id = @productname_id and
		not exists (select * from [Add] a where a.product_id = product_id) and
		not exists (select * from Is_contained i where i.product_id = product_id);

		--exist in add or is contained => set to null productname_id pniffffff)
		update Product
		set productname_id = 'PNIffffff'
		where productname_id = @productname_id;

		--update review
		update Review
		set productname_id = 'PNIffffff'
		where productname_id = @productname_id;

		--delete product_name
		delete Product_name where productname_id = @productname_id
		set @result = 'Successfully deleting'
	end
end
go
--drop procedure update_productname
create procedure update_productname --when update, get all information from edit panel
@pni_current varchar(9),
@pni_new	varchar(9),
@des varchar(1000), 
@name varchar(50),	
@total_remaining int,
@no_sales	int, --ignore because mustn't modify
@min_price	decimal(10,1),
@max_price	decimal(10,1),
@cat varchar(9), 
@sid varchar(9), 
@result varchar(1000) = '' Output --default = ''
as
begin
	declare @min_price_cur decimal(10,1) = (select minimum_price from Product_name where productname_id = @pni_current)
	declare @max_price_cur decimal(10,1) = (select maximum_price from Product_name where productname_id = @pni_current)
	
	if @pni_current != @pni_new and exists(select * from Product_name where productname_id=@pni_new)
		set @result = @result + 'Product name has already existed_'
	if @pni_current != @pni_new and (@pni_new not like 'PNI%' or len(@pni_new) != 9)
		set @result = @result + 'Invalid Productname id format_'
	if @total_remaining < 0
		set @result = @result + 'Total remaining can not be a negative number_'
	if @cat is not null and not exists (select * from Category where category_id = @cat)
		set @result = @result + 'Invalid category_'
	if not exists (select * from Shop where shop_id = @sid)
		set @result = @result + 'Invalid shop_'
	if exists (select * from Version where productname_id = @pni_current) -- has version => can't modify total remaining or price
	begin
		if @max_price_cur != @max_price or @min_price_cur != @min_price
			set @result = @result + 'This product name has 1 or more versions,so the price cannot be modified here_'
		if @total_remaining != (select total_remaining from Product_name where productname_id = @pni_current)
			set @result = @result + 'This product name has 1 or more versions, so total remaining cannot be modified here_'
	end
	if not exists (select * from Version where productname_id = @pni_current) -- no version => max = min and >= 0
	begin
		if @min_price != @max_price
			set @result = @result + 'There are not any versions in this product name, so the minimum price and maximum price must have the same value_'
		if @min_price <0 or @max_price < 0
			set @result = @result + 'The price can not be a negative number_'
	end

	if @result = ''
	begin
		/*if @pni_current != @pni_new -- new pni => need to update product, belong, version and review
		begin
			-- drop constraint => update => add constrain
			alter table Product drop constraint FK_product_pni
			update Product
			set productname_id = @pni_new
			where productname_id = @pni_current;

			alter table Version drop constraint FK_version_pni
			update Version --update cascade, no need to update belong
			set productname_id = @pni_new
			where productname_id = @pni_current;

			alter table Reiview drop constraint FK_review_pni
			update Review
			set productname_id = @pni_new
			where productname_id = @pni_current;

			--update product_name
			update Product_name
			set productname_id = @pni_new
			where productname_id = @pni_current;

			alter table Product add constraint FK_product_pni foreign key (productname_id) references Product_name(productname_id)
			alter table Version add constraint FK_version_pni foreign key (productname_id) references Product_name(productname_id)
			alter table Review add constraint FK_review_pni foreign key (productname_id) references Product_name(productname_id)
		end*/

		update Product_name
		set [description] = @des,
		[name] = @name,
		total_remaining = @total_remaining,
		no_sales = @no_sales,
		minimum_price = @min_price,
		maximum_price = @max_price,
		category_id = @cat,
		shop_id = @sid,
		productname_id = @pni_new --update cascade, no need to update on belong, version, product, review
		where productname_id = @pni_current;

		set @result = 'Successfully updating'
	end
end
go
---3 procedure
-- drop procedure filter_productname
create procedure filter_productname
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
	p.productname_id, 
	p.[name], p.[description], p.no_sales,
	p.total_remaining, 
	p.minimum_price,
	p.maximum_price
	from Product_name p, Shop s, Category c
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
@no_productname_min int
as
begin
	select s.shop_id, s.[name], count(*) as no_most_selling_pni
	from Shop s, Product_name p
	where s.shop_id = p.productname_id and p.no_sales >= @no_sales_min
	group by s.shop_id, s.[name]
	having count(*) >= @no_productname_min
	order by no_most_selling_pni desc
end
go
---4
/*select * from Shop
select * from Product_name
select * from Is_contained
select * from Product
select * from [Order]*/

/*select sum(Prod.current_price)
from Shop as Sh, Product_name as Prod_name, [Order] as Ord, Is_contained as Cont, Product as Prod
where Sh.shop_id = Prod_name.shop_id
	and Prod_name.productname_id = Prod.productname_id
	and Prod.product_id = Cont.product_id
	and Ord.order_id = Cont.order_id*/
