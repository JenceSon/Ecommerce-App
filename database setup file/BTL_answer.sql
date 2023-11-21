use BTL

---1
go
--drop trigger update_no_productname
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
end
go

---2
go
--drop trigger update_min_max_totalremain
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