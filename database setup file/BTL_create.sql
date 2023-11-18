use BTL
/*all id is varchar(9) except order_id varchar(14) (ref on Shopee)*/
--Set id: set Char + set Number(length)
--User: 'UID(6)'d, Contact_info: 'CID(6)'d, Shop: 'SID(6)'d, Category: 'CAT(6)'d, ProductName: 'PNI(6)'d
--Product: 'PID(6)'d, Review: 'RID(6)'d, Payment: 'PAY(6)'d, Voucher: 'VCH(6)'d, Delivery: 'DEL(6)'d
--Order: 'ORD(11)'d
/*
fix :
phone -> varchar(10) d
english language d
can_applied them default de xac dinh cho all shop hoac all category d
them cot no_product lam triger d
co nen xoa cot user_contact_id ?
*/
use BTL
create table [User] (
	user_id		varchar(9)		,
	user_name	varchar(15)		not null,
	nickname	varchar(15)		not null,
	linking_phone_number	char(10) not null,
	linking_email	varchar(100)	not null,
	password	varchar(100)	not null,
	user_id_contact	varchar(9)	not null,
	contact_id	varchar(9)	not null
	constraint PK_user
		primary key (user_id),
	constraint Domain_phone_user 
		check(isNumeric(linking_phone_number)=1 and len(linking_phone_number) = 10),
	constraint Domain_email_user 
		check(linking_email like '%@%'),
	constraint UQ_user_name 
		unique (user_name),
	constraint UQ_linking_phone_number 
		unique (linking_phone_number),
	constraint UQ_linking_email 
		unique (linking_email),
	constraint user_id_format
		check (user_id like 'UID%' and len(user_id) = 9),
)
drop table [User]

create table Contact_info (
	user_id		varchar(9),
	contact_id	varchar(9),
	full_name	varchar(50) not null,
	phone_number char(10) not null,
	email		varchar(100) default null,
	number		int		not null,
	street		varchar(30)	not null,
	ward		varchar(30)	not null,
	district	varchar(30)	not null,
	city		varchar(30)	not null,
	country		varchar(30)	not null,
	constraint PK_Contact_info
		primary key (user_id,contact_id),
	constraint CheckNumber 
		check(number > 0),
	constraint Domain_phone_contact 
		check(isnumeric(phone_number) = 1 and len(phone_number) = 10),
	constraint Domain_email_contact 
		check(email like '%@%'),
	constraint contact_id_format
		check(contact_id like 'CID%' and len(contact_id) = 9)
)
drop table Contact_info
--alter table Contact_info add constraint Domain_phone_contact check(isnumeric(phone_number) = 1)
--alter table Contact_info add constraint Domain_email_contact check(email like '%@%')


create table Follow (
	follower_id	varchar(9),
	following_id	varchar(9),
	constraint PK_Follow
		primary key(follower_id,following_id)
)

create table Seller (
	user_id		varchar(9),
	shop_id		varchar(9)	not null,
	constraint PK_seller
		primary key (user_id)
)

create table Buyer (
	user_id		varchar(9),
	constraint PK_buyer
		primary key (user_id)
)

create table Shopping_cart (
	user_id		varchar(9),
	number		int,
	no_productname	int not null default 0,
	date_created	Date	not null default convert(date,getdate()),
	constraint PK_cart
		primary key (user_id, number),
	constraint CheckNumber_No 
		check(number >0 and no_productname >= 0)
)

create table Places (
	order_id	varchar(14),
	user_id		varchar(9) default null,
	user_id_cart	varchar(9) default null,
	number	int	default null,
	constraint notNull
		check(user_id is not null or (user_id_cart is not null and number is not null)),
	constraint PK_places
		primary key (order_id),
)

create table Shop_phone_number (
	shop_id		varchar(9),
	phone_number	char(10),
	constraint PK_shop_phone_number
		primary key (shop_id, phone_number),
	constraint Domain_shop_phone
		check(isnumeric(phone_number) = 1 and len(phone_number) = 10)
)
drop table Shop_phone_number


create table Shop_address (
	shop_id		varchar(9),
	number		int,
	street		varchar(30),
	ward		varchar(30),
	district	varchar(30),
	city		varchar(30),
	country		varchar(30),
	constraint PK_shop_address
		primary key (shop_id,number,street,ward,district,city,country),
	constraint CheckNumber_shop 
		check(number > 0)
)

create table [Add] (
	product_id	varchar(9),
	user_id		varchar(9) not null,
	number		int			not null,
	constraint PK_add
		primary key (product_id)
)

create table Shop (
	shop_id		varchar(9),
	bio			varchar(1000) not null default 'No description',
	no_following	int		not null default 0,
	no_follower		int		not null default 0,
	url_link	varchar(100)	not null,
	rating		decimal(2,1)	not null default 0,
	name		varchar(15)	not null,
	date_joined	date	not null default convert(date,getdate()),
	no_productname	int	not null default 0 , --trigger here
	constraint rating_domain
		check(rating between 0 and 5),
	constraint PK_shop
		primary key (shop_id),
	constraint DomainShop 
		check (no_following >= 0 and no_follower >= 0 and (rating between 0 and 5)),
	constraint shop_id_format
		check(shop_id like 'SID%' and len(shop_id) = 9),
	constraint no_productname_domain
		check(no_productname >= 0)
)
drop table Shop

create table Review (
	review_id	varchar(9),
	no_stars	int		not null default 0,
	content		varchar(1000) not null default 'No description',
	time_created	datetime	not null default getdate(),
	productname_id	varchar(9)	not null,
	user_id		varchar(9)	not null,
	constraint stars_domain
		check(no_stars between 0 and 5),
	constraint PK_review
		primary key (review_id),
	constraint review_id_format
		check (review_id like 'RID%' and len(review_id) = 9)
)
drop table Review


create table Product (
	product_id	varchar(9),
	current_price	decimal(10,1)	not null,
	productname_id	varchar(9)	not null
	constraint PK_product
		primary key (product_id),
	constraint product_id_domain
		check(product_id like 'PID%' and len(product_id) = 9),
	constraint cur_price_domain
		check (current_price >= 0)
)
drop table Product


create table Belong_to (
	product_id	varchar(9),
	productname_id	varchar(9)	not null,
	version_name	varchar(15)	not null,
	constraint PK_belongto
		primary key (product_id)
)

create table Version (
	productname_id	varchar(9),
	version_name	varchar(15),
	price	decimal(10,1) not null, -- trigger here
	remaining_amount	int	not null default 0 check(remaining_amount >= 0),
	details		varchar(1000)	not null default 'No description',
	constraint PK_version
		primary key (productname_id, version_name),
	constraint price_ver_domain
		check(price >= 0)
)
drop table Version

create table Product_name (
	productname_id	varchar(9),
	description		varchar(1000) not null default 'No description',
	name	varchar(15) not null,
	total_remaining	int not null default 0 check(total_remaining >= 0),
	no_sales	int not null default 0 check (no_sales >= 0),
	minimum_price	decimal(10,1) not null,
	maximum_price	decimal(10,1) not null,
	category_id		varchar(9),
	shop_id		varchar(9)	not null,
	constraint PK_productname
		primary key (productname_id),
	constraint CheckMinMax
		check(minimum_price <= maximum_price),
	constraint productname_id_format
		check(productname_id like 'PNI%' and len(productname_id) = 9)
)
drop table Product_name

create table Category(
	category_id	varchar(9),
	category_name	varchar(15),
	constraint PK_category
		primary key(category_id),
	constraint cat_format
		check(category_id like 'CAT%' and len(category_id) = 9)
)
drop table Category

create table Applies (
	order_id	varchar(14),
	voucher_id	varchar(9),
	constraint PK_applies
		primary key (order_id, voucher_id),
)
drop table Applies

create table Can_apply (
	category_id	varchar(9) default 'CATffffff', -- applies all category
	voucher_id	varchar(9),
	shop_id		varchar(9)	default 'SIDffffff', -- applies all shop
	constraint PK_can_apply
		primary key(category_id, voucher_id, shop_id)
)
drop table Can_apply

create table [Order] (
	order_id	varchar(14),
	status		varchar(15) not null,
	no_productname	int not null check(no_productname >= 1),
	time_order	datetime	not null default getdate(),
	ID_payment	varchar(9)	not null,
	delivery_id	varchar(9)	not null,
	constraint order_id_format
		check(order_id like 'ORD%' and len(order_id) = 14),
	constraint PK_order
		primary key (order_id),
	constraint Status_domain
		check (
			status = 'Confirming' or
			status = 'Waiting pickup' or
			status = 'Delivering'	or
			status = 'Done'or
			status = 'Cancelled' or
			status = 'Refund'
		)
)
drop table [Order]

create table Voucher (
	voucher_id	varchar(9),
	quantity	int		not null default 0 check(quantity >= 0),
	discount	decimal(10,1) check(discount >= 0),
	lowest_applied_price	decimal(10,1) not null default 0 check(lowest_applied_price >=0),
	start_time	datetime	not null default getdate(),
	end_time	datetime,
	[type]		varchar(15)	not null,
	maximum_cash_discount	decimal(10,1),
	[percent]		decimal(2,2),
	constraint vch_format
		check(voucher_id like 'VCH%' and len(voucher_id) = 9),
	constraint PK_voucher
		primary key (voucher_id),
	constraint Check_dis_per
		check(
			discount is not null or 
			(maximum_cash_discount is not null and [percent] is not null)),
	constraint Type_domain
		check(
			[type] = 'For delivery' or
			[type] = 'For products' 
		),
	constraint start_end_time
		check(end_time > start_time),
)
drop table Voucher

create table Delivery_service(
	delivery_id		varchar(9),
	name		varchar(15)	not null,
	price	decimal(10,1)	not null check (price >= 0),
	estimated_time	int not null check(estimated_time >= 0),
	constraint PK_delivery
		primary key (delivery_id),
	constraint del_format
		check(delivery_id like 'DEL%' and len(delivery_id) = 9)
)
drop table Delivery_service

create table Is_contained(
	product_id		varchar(9),
	order_id		varchar(14) not null,
	constraint PK_contained
		primary key (product_id)
)

create table Payment(
	ID_payment	varchar(9),
	owner_name	varchar(50) not null,
	user_id		varchar(9) not null,
	constraint PK_payment
		primary key (ID_payment),
	constraint pay_format
		check(ID_payment like 'PAY%' and len(ID_payment) = 9)
)
drop table Payment

create table E_wallet (
	ID_payment	varchar(9)	primary key,
	wallet_number char(16) not null,
	constraint wallet_format
		check(isnumeric(wallet_number) = 1 and len(wallet_number) = 16)

)
drop table E_wallet

create table Card_payment (
	ID_payment	varchar(9)	primary key,
	card_number char(16) not null,
	[type]		varchar(15) not null check([type] = 'Debit' or [type] = 'Credit' or [type] = 'Napas'),
	constraint card_format
		check(isnumeric(card_number) = 1 and len(card_number) = 16)
)
drop table Card_payment

create table Internet_banking (
	ID_payment	varchar(9)	primary key,
	account_number	char(16) not null,
	constraint account_format
		check(isnumeric(account_number) = 1 and len(account_number) = 16)
)
drop table Internet_banking

create table COD(
	ID_payment	varchar(9)	primary key,
)

