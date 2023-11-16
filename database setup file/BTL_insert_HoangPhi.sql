--Set id: Char + set Number [+ Char]
--Set id for product, review, category: set Number
--Set number's length: User(6), Contact_info(8), Shop(6), Product(9), Review(9), Cart(6), Category(6), Voucher(4)
--change phone_number to char(15), payment number to char(16): (0xx)
ALTER TABLE [User] DROP constraint UQ_linking_phone_number;
ALTER TABLE [User] ALTER COLUMN linking_phone_number char(15) not null;
ALTER TABLE [User] ADD CONSTRAINT UQ_linking_phone_number unique (linking_phone_number);

ALTER TABLE Contact_info ALTER COLUMN phone_number char(15) not null;
ALTER TABLE E_wallet ALTER COLUMN wallet_number char(16) not null;
ALTER TABLE Card_payment ALTER COLUMN card_number char(16) not null;
ALTER TABLE Internet_banking ALTER COLUMN account_number char(16) not null;

--insert User
INSERT INTO [User] VALUES ('UID100013', 'son_0175', 'son_0175', '0167502421', 'son_0175@gmail.com', '12345678', 'UID100013', 'C10001300');
INSERT INTO [User] VALUES ('UID100046', 'tong_01', 'tong_01', '08543425311', 'tong_01@gmail.com', '12345678', 'UID100046', 'C10004600');
INSERT INTO [User] VALUES ('UID100049', 'hoangaaa', 'hoangaaa', '0761712741', 'hoangaaa@gmail.com', '12345678', 'UID100049', 'C10004900');
INSERT INTO [User] VALUES ('UID100052', 'tungbbb', 'tiem_giat_ui', '0075948675', 'tungbbb@gmail.com', '12345678', 'UID100052', 'C10005200');
INSERT INTO [User] VALUES ('UID100074', 'huanccc', 'banh_trang_00', '0345138094', 'huanccc@gmail.com', '12345678', 'UID100074', 'C10007400');
INSERT INTO [User] VALUES ('UID100083', 'sonddd', 'secondhand_gau', '0429363132', 'sonddd@gmail.com', '12345678', 'UID100083', 'C10008300');

--insert Contact_info
INSERT INTO Contact_info VALUES ('UID100013', 'C10001300', 'Dong Hoang Son', '0167502421', 'son_0175@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100052', 'C10005200', 'Duy Tung', '0075948675', 'tungbbb@gmail.com', 248, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100074', 'C10007400', 'Ngoc Huan', '0345138094', 'huanccc@gmail.com', 13, 'Tan Lap, khu pho 6', 'Linh Trung', 'Thu Duc', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100046', 'C10004600', 'Dinh Tong', '08543425311', 'tong_01@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100083', 'C10008300', 'Dinh Hong Son', '0429363132', 'sonddd@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100049', 'C10004900', 'Minh Hoang', '0761712741', 'hoangaaa@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100013', 'C10001301', 'Dong Hoang Son', '0273332234', 'son_0175@gmail.com', 1, 'ki tuc xa khu A, khu pho 6', 'Linh Trung', 'Thu Duc', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100013', 'C10001302', 'Dong Hoang Son', '0375024240', 'son_0175@gmail.com', 12, 'Dong Nai', 'phuong 10', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Contact_info VALUES ('UID100052', 'C10005201', 'Duy Tung', '0075948675', 'tungbbb@gmail.com', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');

--insert Follow
INSERT INTO Follow VALUES ('UID100013','UID100049');
INSERT INTO Follow VALUES ('UID100049','UID100013');
INSERT INTO Follow VALUES ('UID100049','UID100083');
INSERT INTO Follow VALUES ('UID100049','UID100052');
INSERT INTO Follow VALUES ('UID100049','UID100074');

--insert Buyer
INSERT INTO Buyer VALUES ('UID100013');
INSERT INTO Buyer VALUES ('UID100046');
INSERT INTO Buyer VALUES ('UID100049');
INSERT INTO Buyer VALUES ('UID100052');
INSERT INTO Buyer VALUES ('UID100074');
INSERT INTO Buyer VALUES ('UID100083');

--insert Shopping_cart
INSERT INTO Shopping_cart VALUES ('UID100013', 1, 0, CONVERT(datetime, '14-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100046', 1, 0, CONVERT(datetime, '14-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100049', 1, 0, CONVERT(datetime, '14-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100052', 1, 0, CONVERT(datetime, '14-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100074', 1, 0, CONVERT(datetime, '14-11-2023', 105));
INSERT INTO Shopping_cart VALUES ('UID100083', 1, 0, CONVERT(datetime, '14-11-2023', 105));

--insert Shop
INSERT INTO Shop VALUES ('SID100052', 'Sell something to wash clothes', 0, 0, 'giatui01', 0, 'Tiem giat ui', CONVERT(datetime, '14-09-2023', 105));
INSERT INTO Shop VALUES ('SID100074', 'A thing to eat', 0, 0, 'banhtrangcuonbo', 0, 'Banh trang', CONVERT(datetime, '14-09-2023', 105));
INSERT INTO Shop VALUES ('SID100083', 'A thing to wear', 0, 0, 'secondhandgau', 0, 'Secondhand', CONVERT(datetime, '14-09-2023', 105));

--insert Seller
INSERT INTO Seller VALUES ('UID100052', 'SID100052');
INSERT INTO Seller VALUES ('UID100074', 'SID100074');
INSERT INTO Seller VALUES ('UID100083', 'SID100083');
--insert Shop_phone_number
INSERT INTO Shop_phone_number VALUES ('SID100052', '0075948675');
INSERT INTO Shop_phone_number VALUES ('SID100074', '0345138094');
INSERT INTO Shop_phone_number VALUES ('SID100083', '0429363132');

--insert Shop_address
INSERT INTO Shop_address VALUES ('SID100052', 248, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Shop_address VALUES ('SID100074', 13, 'Tan Lap, khu pho 6', 'Linh Trung', 'Thu Duc', 'thanh pho Ho Chi Minh', 'Viet Nam');
INSERT INTO Shop_address VALUES ('SID100083', 1, 'Ly Thuong Kiet', 'phuong 15', 'quan 10', 'thanh pho Ho Chi Minh', 'Viet Nam');

--insert Category
INSERT INTO Category VALUES('CAT000010', 'Household');
INSERT INTO Category VALUES('CAT000011', 'Market');
INSERT INTO Category VALUES('CAT000012', 'Beauty');
INSERT INTO Category VALUES('CAT000013', 'Women Clothes');
INSERT INTO Category VALUES('CAT000014', 'Men Clothes');

--insert Product_name
INSERT INTO Product_name VALUES ('PNI144103', 'No description', 'Nuoc xa Domy', 0, 0, 47000, 47000, 'CAT000010', 'SID100052');
INSERT INTO Product_name VALUES ('PNI110464', 'No description', 'Nuoc xa Comfo', 0, 0, 52000, 69000, 'CAT000010', 'SID100052');
INSERT INTO Product_name VALUES ('PNI138894', 'No description', 'Bot giat Omo', 0, 0, 14000, 14000, 'CAT000010', 'SID100052');
INSERT INTO Product_name VALUES ('PNI186682', 'No description', 'Banh trang', 0, 0, 24000, 112000, 'CAT000011', 'SID100074');
INSERT INTO Product_name VALUES ('PNI163853', 'No description', 'Bo beo', 0, 0, 5000, 20000, 'CAT000011', 'SID100074');

--insert Version
INSERT INTO Version VALUES ('PNI110464', '500g', 52000, 0, 'No description');
INSERT INTO Version VALUES ('PNI110464', '1kg', 69000, 0, 'No description');
INSERT INTO Version VALUES ('PNI186682', 'Combo1', 24000, 0, 'No description');
INSERT INTO Version VALUES ('PNI186682', 'Combo2', 112000, 0, 'No description');
INSERT INTO Version VALUES ('PNI163853', '100g', 5000, 0, 'No description');
INSERT INTO Version VALUES ('PNI163853', '500g', 20000, 0, 'No description');

--insert Product
INSERT INTO Product VALUES ('450080466', 47000, 'PNI144103');
INSERT INTO Product VALUES ('450080467', 47000, 'PNI144103');
INSERT INTO Product VALUES ('450080468', 47000, 'PNI144103');
INSERT INTO Product VALUES ('450080469', 47000, 'PNI144103');
INSERT INTO Product VALUES ('450080460', 47000, 'PNI144103');
INSERT INTO Product VALUES ('257684325', 52000, 'PNI110464');
INSERT INTO Product VALUES ('411694971', 69000, 'PNI110464');
INSERT INTO Product VALUES ('684691489', 14000, 'PNI138894');
INSERT INTO Product VALUES ('517339757', 24000, 'PNI186682');
INSERT INTO Product VALUES ('664270747', 112000, 'PNI186682');
INSERT INTO Product VALUES ('393774582', 5000, 'PNI163853');
INSERT INTO Product VALUES ('269757288', 20000, 'PNI163853');

--Insert Belong_to
INSERT INTO Belong_to VALUES ('257684325', 'PNI110464', '500g');
INSERT INTO Belong_to VALUES ('411694971', 'PNI110464', '1kg');
INSERT INTO Belong_to VALUES ('517339757', 'PNI186682', 'Combo1');
INSERT INTO Belong_to VALUES ('664270747', 'PNI186682', 'Combo2');
INSERT INTO Belong_to VALUES ('393774582', 'PNI163853', '100g');
INSERT INTO Belong_to VALUES ('269757288', 'PNI163853', '500g');

--Insert Voucher
INSERT INTO Voucher VALUES ('VCHID0010', 0, 8000, 0, CONVERT(datetime, '14-11-2023', 105), null, 'For products', null, null);

--Insert Payment
INSERT INTO Payment VALUES ('P10001300', 'Dong Hoang Son', 'UID100013');
INSERT INTO Payment VALUES ('P10001301', 'Dong Hoang Son', 'UID100013');
INSERT INTO Payment VALUES ('P10001302', 'Dong Hoang Son', 'UID100013');
INSERT INTO Payment VALUES ('P10005200', 'Duy Tung', 'UID100052');
INSERT INTO Payment VALUES ('P10007400', 'Ngoc Huan', 'UID100074');
INSERT INTO Payment VALUES ('P10004600', 'Dinh Tong', 'UID100046');
INSERT INTO Payment VALUES ('P10004900', 'Minh Hoang', 'UID100049');
INSERT INTO Payment VALUES ('P10008300', 'Dinh Hong Son', 'UID100083');

--Insert E_wallet
INSERT INTO E_wallet VALUES ('P10001300', '01231231232323');
INSERT INTO E_wallet VALUES ('P10005200', '01231231232324');

--Insert Card_payment
INSERT INTO Card_payment VALUES ('P10001301', '0987654321123456', 'Debit');
INSERT INTO Card_payment VALUES ('P10007400', '0987654321123477', 'Debit');

--Insert Internet_banking
INSERT INTO Internet_banking VALUES ('P10004600', '03551234123321');

--Insert COD
INSERT INTO COD VALUES ('P10001302');
INSERT INTO COD VALUES ('P10004900');
INSERT INTO COD VALUES ('P10008300');

--insert Add
INSERT INTO [Add] VALUES ('450080466', 'UID100013', 1);
INSERT INTO [Add] VALUES ('450080467', 'UID100046', 1);
INSERT INTO [Add] VALUES ('450080468', 'UID100049', 1);
INSERT INTO [Add] VALUES ('450080469', 'UID100052', 1);

--insert Review
INSERT INTO Review VALUES ('668399786', 4, 'Good. Sau khi phoi con co mui thom', CONVERT(datetime, '14-11-2023', 105), 'PNI144103', 'UID100013');
INSERT INTO Review VALUES ('772411285', 5, 'Binh luan mang tinh chat nhan xu', CONVERT(datetime, '14-11-2023', 105), 'PNI144103', 'UID100046');

--insert Delivery_service
INSERT INTO Delivery_service VALUES ('DELID0011', 'GHN', 27000, 2);
INSERT INTO Delivery_service VALUES ('DELID0012', 'GHTK', 15000, 4);

--insert Order
INSERT INTO [Order] VALUES ('ORDID0000011', 'Done', 1,  CONVERT(datetime, '14-11-2023', 105), 'P10001300', 'DELID0011');
INSERT INTO [Order] VALUES ('ORDID0000012', 'Done', 1, CONVERT(datetime, '14-11-2023', 105), 'P10007400', 'DELID0011');
INSERT INTO [Order] VALUES ('ORDID0000013', 'Confirming', 1, CONVERT(datetime, '14-11-2023', 105), 'P10007400', 'DELID0011');

--insert Is_contained
INSERT INTO Is_contained VALUES ('450080466', 'ORDID0000011');
INSERT INTO Is_contained VALUES ('450080467', 'ORDID0000012');
INSERT INTO Is_contained VALUES ('450080468', 'ORDID0000013');

--insert Can_apply
INSERT INTO Can_apply VALUES ('CAT000010', 'VCHID0010', 'UID100052');
INSERT INTO Can_apply VALUES ('CAT000011', 'VCHID0010', 'UID100052');
INSERT INTO Can_apply VALUES ('CAT000012', 'VCHID0010', 'UID100052');

--insert Applies
INSERT INTO Applies VALUES ('ORDID0000011', 'VCHID0010');
INSERT INTO Applies VALUES ('ORDID0000012', 'VCHID0010');

--insert Places
INSERT INTO Places VALUES ('ORDID0000011', 'UID100013', null, null);
INSERT INTO Places VALUES ('ORDID0000012', 'UID100074', null, null);
INSERT INTO Places VALUES ('ORDID0000013', 'UID100074', null, null);