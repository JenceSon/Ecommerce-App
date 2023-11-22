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
---2 insert, delete, update
---3 procedure 
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
