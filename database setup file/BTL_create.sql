use BTL
/*all id is varchar(9) except order_id varchar(14) (ref on Shopee)*/

create table [User] (
	user_id		varchar(9)		,
	user_name	varchar(15)		not null,
	nickname	varchar(15)		not null,
	linking_phone_number	decimal(10,0)	not null,
	linking_email	varchar(100)	not null,
	password	varchar(100)	not null,
	user_id_contact	varchar(9)	not null,
	contact_id	varchar(9)	not null
	constraint PK_user
		primary key (user_id),	
)
alter table [User] add constraint UQ_user_name unique (user_name)
alter table [User] add constraint UQ_linking_phone_number unique (linking_phone_number)
alter table [User] add constraint UQ_linking_email unique (linking_email)
create table Contact_info (
	user_id		varchar(9),
	contact_id	varchar(9),
	full_name	varchar(50) not null,
	phone_number	decimal(10,0) not null,
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
		check(number > 0)
)

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
	phone_number	decimal(10,0),
	constraint PK_shop_phone_number
		primary key (shop_id, phone_number)
)

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
	bio			varchar(1000) not null default 'Không có mô t?',
	no_following	int		not null default 0,
	no_follower		int		not null default 0,
	url_link	varchar(100)	not null,
	rating		decimal(2,1)	not null default 0,
	name		varchar(15)	not null,
	date_joined	date	not null default convert(date,getdate()),
	constraint rating_domain
		check(rating between 0 and 5),
	constraint PK_shop
		primary key (shop_id),
	constraint DomainShop 
		check (no_following >= 0 and no_follower >= 0 and (rating between 0 and 5))
)

create table Review (
	review_id	varchar(9),
	no_stars	int		not null default 0,
	content		varchar(1000) not null default 'Không có ?ánh giá c? th?',
	time_created	datetime	not null default getdate(),
	productname_id	varchar(9)	not null,
	user_id		varchar(9)	not null,
	constraint stars_domain
		check(no_stars between 0 and 5),
	constraint PK_review
		primary key (review_id)
)

create table Product (
	product_id	varchar(9),
	current_price	decimal(10,1)	not null,
	productname_id	varchar(9)	not null
	constraint PK_product
		primary key (product_id)
)

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
	price	decimal(10,1) not null,
	remaining_amount	int	not null default 0 check(remaining_amount >= 0),
	details		varchar(1000)	not null default 'Không có thông tin chi ti?t',
	constraint PK_version
		primary key (productname_id, version_name)
)

create table Product_name (
	productname_id	varchar(9),
	description		varchar(1000) not null default 'Không có thông tin chi ti?t',
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
)
create table Category(
	category_id	varchar(9),
	category_name	varchar(15),
	constraint PK_category
		primary key(category_id),
)

create table Applies (
	order_id	varchar(14),
	voucher_id	varchar(9),
	constraint PK_applies
		primary key (order_id, voucher_id),
)

create table Can_apply (
	category_id	varchar(9),
	voucher_id	varchar(9),
	shop_id		varchar(9),
	constraint PK_can_apply
		primary key(category_id, voucher_id, shop_id)
)

create table [Order] (
	order_id	varchar(14),
	status		varchar(15) not null,
	no_productname	int not null check(no_productname >= 1),
	time_order	datetime	not null default getdate(),
	ID_payment	varchar(9)	not null,
	delivery_id	varchar(9)	not null,
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
)

create table Delivery_service(
	delivery_id		varchar(9),
	name		varchar(15)	not null,
	price	decimal(10,1)	not null check (price >= 0),
	estimated_time	int not null check(estimated_time >= 0),
	constraint PK_delivery
		primary key (delivery_id),
)

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
)

create table E_wallet (
	ID_payment	varchar(9)	primary key,
	wallet_number	decimal(16,0) not null,
)
create table Card_payment (
	ID_payment	varchar(9)	primary key,
	card_number	decimal(16,0) not null,
	[type]		varchar(15) not null check([type] = 'Debit' or [type] = 'Credit' or [type] = 'Napas')
)

create table Internet_banking (
	ID_payment	varchar(9)	primary key,
	account_number	decimal(16,0) not null,
)

create table COD(
	ID_payment	varchar(9)	primary key,
)

