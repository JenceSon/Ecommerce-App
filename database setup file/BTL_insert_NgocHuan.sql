--change phonenumber to char(15)
ALTER TABLE [User] DROP constraint UQ_linking_phone_number;
ALTER TABLE [User] ALTER COLUMN linking_phone_number char(15) not null;
alter table [User] add constraint UQ_linking_phone_number unique (linking_phone_number);

--Add User
--ALTER TABLE [User] ADD user_id_contact AS user_id;

INSERT INTO [dbo].[User]([user_id], [user_id_contact], [user_name], [nickname], [linking_phone_number], [linking_email], [password], [contact_id]) VALUES 
('UID000001', 'UID000001', 'NguyenHuan', 'huan2114', '0356382638', 'huan1122@gmail.com', 'nothing@@ink', 'CID000001'),
('UID000002', 'UID000002', 'JohnDoe', 'johndoe123', '0234567890', 'john.doe@gmail.com', 'securePass123', 'CID000002'),
('UID000003', 'UID000003', 'AliceSmith', 'ali_smith', '0876543210', 'alice.smith@gmail.com', 'strongPassword', 'CID000003'),
('UID000004', 'UID000004', 'BobJohnson', 'bobJ', '051234567', 'bob.j@gmail.com', 'pass1234', 'CID000004'),
('UID000005', 'UID000005', 'EmilyJones', 'emily_j', '0367890123', 'emily.jones@gmail.com', 'mySecurePassword', 'CID000005'),
('UID000006', 'UID000006', 'DavidMiller', 'david_m', '0890123456', 'david.miller@gmail.com', 'p@ssw0rd', 'CID000006'),
('UID000007', 'UID000007', 'SophiaBrown', 'sophia_b', '0345678901', 'sophia.brown@gmail.com', 'brownie123', 'CID000007'),
('UID000008', 'UID000008', 'DanielWhite', 'danW', '0765432109', 'daniel.white@gmail.com', 'danielPass', 'CID000008'),
('UID000009', 'UID000009', 'OliviaDavis', 'olivia_d', '0210987654', 'olivia.davis@gmail.com', 'oliviaPassword', 'CID000009'),
('UID000010', 'UID000010', 'WilliamWilson', 'willW', '0087654321', 'william.w@gmail.com', 'wilsonPass', 'CID000010'),
('UID000011', 'UID000011', 'AvaTaylor', 'ava_t', '0357924680', 'ava.taylor@gmail.com', 'taylor123', 'CID000011');

--Change phonenumber to char(15)
ALTER TABLE Contact_info ALTER COLUMN phone_number char(15) not null;

--Add contact info
INSERT INTO [dbo].[Contact_info]([user_id], [contact_id], [full_name], [phone_number], [email], [number], [street], [ward], [district], [city], [country]) VALUES
('UID000001', 'CID000001', 'Nguyen Huan', '0356382638', 'huan1122@gmail.com', 20, 'Ta Quang Buu', 'Dong Hoa', 'Di An', 'Binh Duong', 'Vietnam'),
('UID000002', 'CID000002', 'John Doe', '0234567890', 'john.doe@gmail.com', 25, 'Main St', 'West', 'Central', 'Cityville', 'USA'),
('UID000003', 'CID000003', 'Alice Smith', '0876543210', 'alice.smith@gmail.com', 30, 'Oak Ave', 'East', 'Suburbia', 'Townsville', 'USA'),
('UID000004', 'CID000004', 'Bob Johnson', '051234567', 'bob.j@gmail.com', 15, 'Elm St', 'North', 'Downtown', 'Metropolis', 'USA'),
('UID000005', 'CID000005', 'Emily Jones', '0367890123', 'emily.jones@gmail.com', 40, 'Maple St', 'South', 'Village', 'Ruraltown', 'USA'),
('UID000006', 'CID000006', 'David Miller', '0890123456', 'david.miller@gmail.com', 10, 'Cedar St', 'West', 'Central', 'Cityville', 'USA'),
('UID000007', 'CID000007', 'Sophia Brown', '0345678901', 'sophia.brown@gmail.com', 35, 'Pine St', 'East', 'Suburbia', 'Townsville', 'USA'),
('UID000008', 'CID000008', 'Daniel White', '0765432109', 'daniel.white@gmail.com', 5, 'Willow St', 'North', 'Downtown', 'Metropolis', 'USA'),
('UID000009', 'CID000009', 'Olivia Davis', '0210987654', 'olivia.davis@gmail.com', 45, 'Birch St', 'South', 'Village', 'Ruraltown', 'USA'),
('UID000010', 'CID000010', 'William Wilson', '0087654321', 'william.w@gmail.com', 15, 'Spruce St', 'West', 'Central', 'Cityville', 'USA'),
('UID000011', 'CID000011', 'Ava Taylor', '0357924680', 'ava.taylor@gmail.com', 50, 'Cherry St', 'East', 'Suburbia', 'Townsville', 'USA');

--Add Follow
INSERT INTO Follow (follower_id, following_id)
VALUES
('UID000002', 'UID000003'),
('UID000002', 'UID000004'),
('UID000003', 'UID000002'),
('UID000003', 'UID000005'),
('UID000004', 'UID000002'),
('UID000004', 'UID000006'),
('UID000005', 'UID000002'),
('UID000005', 'UID000007'),
('UID000006', 'UID000002'),
('UID000006', 'UID000008'),
('UID000007', 'UID000002'),
('UID000007', 'UID000009'),
('UID000008', 'UID000002'),
('UID000008', 'UID000010'),
('UID000009', 'UID000002'),
('UID000009', 'UID000011'),
('UID000010', 'UID000002'),
('UID000011', 'UID000002'),
('UID000011', 'UID000004');

--Add seller
INSERT INTO Seller (user_id, shop_id)
VALUES
('UID000002', 'SID000001'),
('UID000003', 'SID000002'),
('UID000004', 'SID000003'),
('UID000005', 'SID000004'),
('UID000006', 'SID000005');

--Add Buyer
INSERT INTO Buyer (user_id)
VALUES
('UID000001'),
('UID000002'),
('UID000003'),
('UID000004'),
('UID000005'),
('UID000006'),
('UID000007'),  -- Seller and Buyer
('UID000008'),  -- Seller and Buyer
('UID000009'),  -- Seller and Buyer
('UID000010'),  -- Seller and Buyer
('UID000011');  -- Seller and Buyer

--Add shop phone number
INSERT INTO Shop_phone_number (shop_id, phone_number)
VALUES
('SID000001', '0234567890'),
('SID000002', '0876543210'),
('SID000003', '051234567'),
('SID000004', '051234567'),
('SID000005', '0890123456');

--Add shop address
INSERT INTO Shop_address (shop_id, number, street, ward, district, city, country)
VALUES
('SID000001', 20, 'Main St', 'Downtown', 'Central', 'Cityville', 'USA'),
('SID000002', 30, 'Oak Ave', 'Suburbia', 'East', 'Townsville', 'USA'),
('SID000003', 15, 'Elm St', 'Downtown', 'North', 'Metropolis', 'USA'),
('SID000004', 40, 'Maple St', 'Village', 'South', 'Ruraltown', 'USA'),
('SID000005', 10, 'Cedar St', 'Central', 'West', 'Cityville', 'USA');


--Add Shop
INSERT INTO Shop (shop_id, bio, no_following, no_follower, url_link, rating, name, date_joined)
VALUES
('SID000001', 'Fashion paradise offering the latest trends.', 100, 500, 'http://shop1.com', 4.5, 'Chic Boutique', '2023-01-01'),
('SID000002', 'Handcrafted treasures for your home.', 150, 300, 'http://shop2.com', 3.8, 'Artisan Haven', '2023-02-15'),
('SID000003', 'Explore tech innovations at our electronic hub.', 200, 700, 'http://shop3.com', 4.2, 'Gadget Galaxy', '2023-03-20'),
('SID000004', 'Books, coffee, and cozy corners - your reading escape.', 50, 100, 'http://shop4.com', 4.0, 'Book Nook', '2023-04-10'),
('SID000005', 'Outdoor gear and adventure essentials.', 80, 200, 'http://shop5.com', 4.8, 'Adventure Out', '2023-05-05');

--Add product
INSERT INTO Product (product_id, current_price, productname_id)
VALUES
-- Existing rows
('PID000001', 49000.99, 'PNI000001'),
('PID000002', 29000.95, 'PNI000002'),
('PID000003', 99000.99, 'PNI000003'),
('PID000004', 14000.99, 'PNI000004'),
('PID000005', 79000.99, 'PNI000005'),
-- Additional rows for Belong_to
('PID000006', 39000.99, 'PNI000006'),
('PID000007', 59000.95, 'PNI000007'),
('PID000008', 19000.99, 'PNI000008'),
('PID000009', 44000.99, 'PNI000009'),
('PID000010', 69000.99, 'PNI000010'),
('PID000011', 34000.99, 'PNI000011'),
('PID000012', 24000.95, 'PNI000012'),
('PID000013', 89000.99, 'PNI000013'),
('PID000014', 54000.99, 'PNI000014'),
('PID000015', 49000.99, 'PNI000015'),
('PID000016', 69000.99, 'PNI000001'), -- Adjusted price for 'Premium' version
('PID000017', 29000.95, 'PNI000002'), -- Adjusted price for 'Classic Fit' version
('PID000018', 49000.95, 'PNI000002'), -- Adjusted price for 'Slim Fit' version
('PID000019', 89000.99, 'PNI000003'), -- Adjusted price for '32GB' version
('PID000020', 119000.99, 'PNI000003'), -- Adjusted price for '64GB' version
('PID000021', 14000.99, 'PNI000004'), -- Adjusted price for 'Copper' version
('PID000022', 24000.99, 'PNI000004'), -- Adjusted price for 'Silver' version
('PID000023', 49000.99, 'PNI000005'), -- Adjusted price for 'Basic Kit' version
('PID000024', 99000.99, 'PNI000005'), -- Adjusted price for 'Deluxe Kit' version
('PID000025', 34000.99, 'PNI000006'), -- Adjusted price for 'Statement Piece' version
('PID000026', 74000.99, 'PNI000006'), -- Adjusted price for 'Classic Elegance' version
('PID000027', 24000.95, 'PNI000007'), -- Adjusted price for 'Bifold' version
('PID000028', 59000.95, 'PNI000007'), -- Adjusted price for 'Trifold' version
('PID000029', 19000.99, 'PNI000008'), -- Adjusted price for 'Basic Model' version
('PID000030', 1449000.99, 'PNI000008'); -- Adjusted price for 'Pro Model' version

--Add product name
INSERT INTO Product_name (productname_id, description, name, total_remaining, no_sales, minimum_price, maximum_price, category_id, shop_id)
VALUES
('PNI000001', 'Stylish and comfortable.', 'Comfort Shoes', 100, 50, 29000.99, 69000.99, 'CAT000001', 'SID000001'),
('PNI000002', 'A classic addition to your wardrobe.', 'Casual Shirt', 80, 30, 19000.95, 49000.95, 'CAT000002', 'SID000002'),
('PNI000003', 'High-performance electronics.', 'Smartphone', 150, 100, 89000.99, 199000.99, 'CAT000003', 'SID000003'),
('PNI000004', 'Perfect for cozy evenings.', 'Candle Holder', 50, 20, 9000.99, 24000.99, 'CAT000004', 'SID000004'),
('PNI000005', 'Outdoor adventure essentials.', 'Camping Gear', 120, 70, 49000.99, 99000.99, 'CAT000005', 'SID000005'),
('PNI000006', 'Unique and stylish design.', 'Necklace', 60, 40, 34000.99, 74000.99, 'CAT000006', 'SID000001'),
('PNI000007', 'A modern twist on a classic.', 'Leather Wallet', 90, 60, 24000.95, 59000.95, 'CAT000002', 'SID000002'),
('PNI000008', 'Efficient and reliable.', 'Laptop', 110, 80, 19000.99, 1449000.99, 'CAT000003', 'SID000003'),
('PNI000009', 'Elegant and functional.', 'Table Lamp', 40, 15, 44000.99, 89000.99, 'CAT000004', 'SID000004'),
('PNI000010', 'Stay hydrated on the go.', 'Water Bottle', 70, 25, 9000.99, 29000.99, 'CAT000005', 'SID000005'),
('PNI000011', 'Perfect for everyday wear.', 'Sneakers', 90, 60, 39000.99, 79000.99, 'CAT000001', 'SID000001'),
('PNI000012', 'A versatile addition to any outfit.', 'Denim Jeans', 120, 80, 29000.95, 69000.95, 'CAT000002', 'SID000002'),
('PNI000013', 'Capture every moment.', 'Digital Camera', 30, 15, 149000.99, 499000.99, 'CAT000003', 'SID000003'),
('PNI000014', 'Create a cozy atmosphere.', 'Throw Blanket', 65, 35, 14000.99, 34000.99, 'CAT000004', 'SID000004'),
('PNI000015', 'Gear up for your next adventure.', 'Hiking Boots', 100, 50, 59000.99, 119000.99, 'CAT000005', 'SID000005');

--Insert category
INSERT INTO Category (category_id, category_name)
VALUES
('CAT000001', 'Footwear'),
('CAT000002', 'Apparel'),
('CAT000003', 'Electronics'),
('CAT000004', 'Home Decor'),
('CAT000005', 'Outdoor Gear'),
('CAT000006', 'Jewelry');

--insert version
INSERT INTO Version (productname_id, version_name, price, remaining_amount, details)
VALUES
('PNI000001', 'Standard', 49000.99, 50, 'Standard version of Comfort Shoes.'),
('PNI000001', 'Premium', 69000.99, 30, 'Premium version with extra comfort features.'),
('PNI000002', 'Classic Fit', 29000.95, 40, 'Classic fit Casual Shirt for everyday wear.'),
('PNI000002', 'Slim Fit', 49000.95, 20, 'Slim fit Casual Shirt for a modern look.'),
('PNI000003', '32GB', 89000.99, 100, '32GB version of Smartphone with advanced features.'),
('PNI000003', '64GB', 119000.99, 50, '64GB version with extended storage capacity.'),
('PNI000004', 'Copper', 14000.99, 30, 'Copper Candle Holder for a rustic touch.'),
('PNI000004', 'Silver', 24000.99, 20, 'Silver Candle Holder for a sleek look.'),
('PNI000005', 'Basic Kit', 49000.99, 80, 'Basic Camping Gear for outdoor enthusiasts.'),
('PNI000005', 'Deluxe Kit', 99000.99, 40, 'Deluxe Camping Gear with additional features.'),
('PNI000006', 'Statement Piece', 34000.99, 25, 'Statement Necklace with unique design.'),
('PNI000006', 'Classic', 74000.99, 15, 'Classic Elegance Necklace for formal occasions.'),
('PNI000007', 'Bifold', 24000.95, 50, 'Bifold Leather Wallet for everyday use.'),
('PNI000007', 'Trifold', 59000.95, 30, 'Trifold Leather Wallet with multiple compartments.'),
('PNI000008', 'Basic Model', 19000.99, 70, 'Basic Laptop for everyday tasks.'),
('PNI000008', 'Pro Model', 1449000.99, 20, 'Pro Laptop with advanced specifications.'),
('PNI000009', 'Modern Design', 44000.99, 15, 'Modern Table Lamp for contemporary spaces.'),
('PNI000009', 'Vintage Style', 89000.99, 25, 'Vintage Style Lamp for a touch of nostalgia.'),
('PNI000010', 'Classic Blue', 9000.99, 45, 'Classic Blue Water Bottle for on-the-go hydration.'),
('PNI000010', 'Stainless Steel', 29000.99, 25, 'Stainless Steel Water Bottle for durability.'),
('PNI000011', 'Athletic Style', 39000.99, 30, 'Athletic Style Sneakers for active lifestyles.'),
('PNI000011', 'Casual Comfort', 79000.99, 20, 'Casual Comfort Sneakers for everyday wear.'),
('PNI000012', 'Relaxed Fit', 29000.95, 35, 'Relaxed Fit Denim Jeans for comfortable style.'),
('PNI000012', 'Skinny Fit', 69000.95, 15, 'Skinny Fit Denim Jeans for a modern look.'),
('PNI000013', 'Pro Camera', 149000.99, 10, 'Pro Digital Camera for professional photography.'),
('PNI000013', 'Compact Camera', 499000.99, 20, 'Compact Digital Camera for on-the-go shooting.'),
('PNI000014', 'Cozy Plaid', 14000.99, 15, 'Cozy Plaid Throw Blanket for chilly evenings.'),
('PNI000014', 'Luxury Velvet', 34000.99, 10, 'Luxury Velvet Throw Blanket for added comfort.'),
('PNI000015', 'Trailblazer', 59000.99, 25, 'Trailblazer Hiking Boots for outdoor adventures.'),
('PNI000015', 'Explorer', 119000.99, 15, 'Explorer Hiking Boots for the adventurous spirit.');

--add belongs to
INSERT INTO Belong_to (product_id, productname_id, version_name)
VALUES
('PID000001', 'PNI000001', 'Standard'),
('PID000002', 'PNI000001', 'Premium'),
('PID000003', 'PNI000002', 'Classic Fit'),
('PID000004', 'PNI000002', 'Slim Fit'),
('PID000005', 'PNI000003', '32GB'),
('PID000006', 'PNI000003', '64GB'),
('PID000007', 'PNI000004', 'Copper'),
('PID000008', 'PNI000004', 'Silver'),
('PID000009', 'PNI000005', 'Basic Kit'),
('PID000010', 'PNI000005', 'Deluxe Kit'),
('PID000011', 'PNI000006', 'Statement Piece'),
('PID000012', 'PNI000006', 'Classic'),
('PID000013', 'PNI000007', 'Bifold'),
('PID000014', 'PNI000007', 'Trifold'),
('PID000015', 'PNI000008', 'Basic Model'),
('PID000016', 'PNI000008', 'Pro Model'),
('PID000017', 'PNI000009', 'Modern Design'),
('PID000018', 'PNI000009', 'Vintage Style'),
('PID000019', 'PNI000010', 'Classic Blue'),
('PID000020', 'PNI000010', 'Stainless Steel'),
('PID000021', 'PNI000011', 'Athletic Style'),
('PID000022', 'PNI000011', 'Casual Comfort'),
('PID000023', 'PNI000012', 'Relaxed Fit'),
('PID000024', 'PNI000012', 'Skinny Fit'),
('PID000025', 'PNI000013', 'Pro Camera'),
('PID000026', 'PNI000013', 'Compact Camera'),
('PID000027', 'PNI000014', 'Cozy Plaid'),
('PID000028', 'PNI000014', 'Luxury Velvet'),
('PID000029', 'PNI000015', 'Trailblazer'),
('PID000030', 'PNI000015', 'Explorer');

--Add review
INSERT INTO Review (review_id, no_stars, content, time_created, productname_id, user_id)
VALUES
('RID000001', 4, 'Great product! Very comfortable and stylish.', '2023-01-15 08:30:00', 'PNI000001', 'UID000001'),
('RID000002', 5, 'Excellent service and fast delivery!', '2023-02-02 12:45:00', 'PNI000002', 'UID000002'),
('RID000003', 3, 'Average quality, expected more.', '2023-03-10 15:20:00', 'PNI000003', 'UID000003'),
('RID000004', 5, 'Love it! Best purchase ever.', '2023-04-05 09:10:00', 'PNI000004', 'UID000004'),
('RID000005', 2, 'Not satisfied with the product. Poor design.', '2023-05-20 14:55:00', 'PNI000005', 'UID000005'),
('RID000006', 4, 'Impressive product quality. Would recommend!', '2023-06-12 11:25:00', 'PNI000006', 'UID000006'),
('RID000007', 3, 'Decent price for the features provided.', '2023-07-18 08:40:00', 'PNI000007', 'UID000007'),
('RID000008', 5, 'Absolutely love the design. A+++', '2023-08-23 13:15:00', 'PNI000008', 'UID000008'),
('RID000009', 2, 'Disappointed with the shipping time.', '2023-09-30 17:30:00', 'PNI000009', 'UID000009'),
('RID000010', 4, 'Good value for the money. Happy with the purchase.', '2023-10-05 09:55:00', 'PNI000010', 'UID000010'),
('RID000011', 1, 'Terrible experience. The product broke within a week.', '2023-11-11 14:20:00', 'PNI000011', 'UID000011'),
('RID000012', 5, 'Exactly what I was looking for. Great product!', '2023-12-15 10:45:00', 'PNI000012', 'UID000012'),
('RID000013', 3, 'Average product. Nothing special.', '2023-01-20 16:10:00', 'PNI000013', 'UID000013'),
('RID000014', 5, 'Amazing customer service. Quick response to queries.', '2023-02-25 12:35:00', 'PNI000014', 'UID000014'),
('RID000015', 2, 'Not as described. Misleading product information.', '2023-03-03 08:00:00', 'PNI000015', 'UID000015'),
('RID000016', 4, 'Sturdy construction. Happy with the durability.', '2023-04-08 13:25:00', 'PNI000001', 'UID000016'),
('RID000017', 1, 'Waste of money. Poor quality material.', '2023-05-15 17:50:00', 'PNI000002', 'UID000017'),
('RID000018', 5, 'Excellent packaging. Product arrived in perfect condition.', '2023-06-20 11:15:00', 'PNI000003', 'UID000018'),
('RID000019', 3, 'Satisfactory purchase. Could be better.', '2023-07-25 16:40:00', 'PNI000004', 'UID000019'),
('RID000020', 4, 'Good product overall. Met my expectations.', '2023-08-30 12:05:00', 'PNI000005', 'UID000020'),
('RID000021', 2, 'Unpleasant odor from the product. Disappointed.', '2023-09-05 08:30:00', 'PNI000006', 'UID000021'),
('RID000022', 5, 'Outstanding performance. Worth every penny.', '2023-10-10 13:55:00', 'PNI000007', 'UID000022'),
('RID000023', 3, 'Not user-friendly. Complicated to operate.', '2023-11-15 17:20:00', 'PNI000008', 'UID000023'),
('RID000024', 5, 'Exceptional design. Adds elegance to my space.', '2023-12-20 11:45:00', 'PNI000009', 'UID000024'),
('RID000025', 4, 'Reliable and efficient. Happy with the purchase.', '2023-01-25 16:10:00', 'PNI000010', 'UID000025');

--Add payment
INSERT INTO Payment (ID_payment, owner_name, user_id)
VALUES
('PAYID0001', 'Nguyen Huan', 'UID000001'),
('PAYID0002', 'John Doe', 'UID000002'),
('PAYID0003', 'Alice Smith', 'UID000003'),
('PAYID0004', 'Alice Smith', 'UID000004'),
('PAYID0005', 'Emily Jones', 'UID000005'),
('PAYID0006', 'David Miller', 'UID000006'),
('PAYID0007', 'Sophia Brown', 'UID000007'),
('PAYID0008', 'Daniel White', 'UID000008'),
('PAYID0009', 'Olivia Davis', 'UID000009'),
('PAYID0010', 'William Wilson', 'UID000010'),
('PAYID0011', 'Ava Taylor', 'UID000011');

--Add e-wallet
INSERT INTO E_wallet (ID_payment, wallet_number)
VALUES
('PAYID0001', ''1234567890123456''),
('PAYID0002', ''2345678901234567''),
('PAYID0003', ''3456789012345678''),
('PAYID0004', ''4567890123456789''),
('PAYID0005', ''5678901234567890''),
('PAYID0006', ''6789012345678901''),
('PAYID0007', ''7890123456789012''),
('PAYID0008', ''8901234567890123''),
('PAYID0009', ''9012345678901234''),
('PAYID0010', ''1234901234567890''),
('PAYID0011', ''2345012345678901'');

--Add Card-payment
INSERT INTO Card_payment (ID_payment, card_number, [type])
VALUES
('PAYID0001', '1234567890123456', 'Debit'),
('PAYID0002', '2345678901234567', 'Credit'),
('PAYID0003', '3456789012345678', 'Napas'),
('PAYID0004', '4567890123456789', 'Debit'),
('PAYID0005', '5678901234567890', 'Credit'),
('PAYID0006', '6789012345678901', 'Napas'),
('PAYID0007', '7890123456789012', 'Debit'),
('PAYID0008', '8901234567890123', 'Credit'),
('PAYID0009', '9012345678901234', 'Napas'),
('PAYID0010', '1234901234567890', 'Debit'),
('PAYID0011', '2345012345678901', 'Credit');

--Add internet-banking
INSERT INTO Internet_banking (ID_payment, account_number)
VALUES
('PAYID0001', '1234567890123456'),
('PAYID0002', '2345678901234567'),
('PAYID0003', '3456789012345678'),
('PAYID0004', '4567890123456789'),
('PAYID0005', '5678901234567890'),
('PAYID0006', '6789012345678901'),
('PAYID0007', '7890123456789012'),
('PAYID0008', '8901234567890123'),
('PAYID0009', '9012345678901234'),
('PAYID0010', '1234901234567890'),
('PAYID0011', '2345012345678901');

--Add COD
INSERT INTO COD (ID_payment)
VALUES
('PAYID0001'),
('PAYID0002'),
('PAYID0003'),
('PAYID0004'),
('PAYID0005'),
('PAYID0006'),
('PAYID0007'),
('PAYID0008'),
('PAYID0009'),
('PAYID0010'),
('PAYID0011');

--Add voucher
INSERT INTO Voucher (voucher_id, quantity, discount, lowest_applied_price, start_time, end_time, [type], maximum_cash_discount, [percent])
VALUES
('VCHID0001', 50, NULL, 10000.0, '2023-01-01 00:00:00', '2023-02-01 00:00:00', 'For delivery', 10000.0, 0.05),
('VCHID0002', 100, 20.0, 50000.0, '2023-02-15 00:00:00', '2023-03-15 00:00:00', 'For products', 12000.5, 0.1),
('VCHID0003', 30, NULL, 15000.0, '2023-03-01 00:00:00', '2023-04-01 00:00:00', 'For products', 5000.0, 0.3),
('VCHID0004', 80, 25.0, 100000.0, '2023-04-15 00:00:00', '2023-05-15 00:00:00', 'For delivery', 4000.0, 0.4),
('VCHID0005', 20, NULL, 30000.0, '2023-05-01 00:00:00', '2023-06-01 00:00:00', 'For delivery', 8000.0, 0.6),
('VCHID0006', 40, NULL, 25000.0, '2023-06-15 00:00:00', '2023-07-15 00:00:00', 'For products', 10000.0, 0.2),
('VCHID0007', 60, 15.0, 70000.0, '2023-07-01 00:00:00', '2023-08-01 00:00:00', 'For delivery', 13000.0, 0.08),
('VCHID0008', 25, NULL, 20000.0, '2023-08-15 00:00:00', '2023-09-15 00:00:00', 'For products', 5000.0, 0.5),
('VCHID0009', 70, 30.0, 120000.0, '2023-09-01 00:00:00', '2023-10-01 00:00:00', 'For delivery', 12000.3, 0.5),
('VCHID0010', 15, NULL, 40000.0, '2023-10-15 00:00:00', '2023-11-15 00:00:00', 'For products', 12000.0, 0.19);

--add can apply
INSERT INTO Can_apply (category_id, voucher_id, shop_id)
VALUES
('CATID0001', 'VCHID0006', 'SID000001'),
('CATID0002', 'VCHID0007', 'SID000002'),
('CATID0003', 'VCHID0008', 'SID000003'),
('CATID0004', 'VCHID0009', 'SID000004'),
('CATID0005', 'VCHID0010', 'SID000005');

--add shopping cart
INSERT INTO Shopping_cart (user_id, number, no_productname)
VALUES
('UID000001', 1, 3),
('UID000002', 2, 2),
('UID000003', 3, 1),
('UID000004', 4, 4),
('UID000005', 5, 0);

--add Add
INSERT INTO [Add] (product_id, user_id, number)
VALUES
('PID000001', 'UID000001', 2),
('PID000002', 'UID000002', 3),
('PID000003', 'UID000003', 1),
('PID000004', 'UID000004', 5),
('PID000005', 'UID000005', 2);

--add deli service
INSERT INTO Delivery_service (delivery_id, name, price, estimated_time)
VALUES
('DELID0001', 'Standard Deli', 5000.0, 3),
('DELID0002', 'Express Deli', 10000.0, 2),
('DELID0003', 'Next-Day Deli', 15000.0, 1),
('DELID0004', 'Free Pickup', 0.0, 0),
('DELID0005', 'Two-Day Ship', 8000.0, 2);

--add order
INSERT INTO [Order] (order_id, status, no_productname, ID_payment, delivery_id)
VALUES
('ORDID0000001', 'Confirming', 3, 'PAYID0001', 'DELID0001'),
('ORDID0000002', 'Waiting pickup', 2, 'PAYID0002', 'DELID0002'),
('ORDID0000003', 'Delivering', 1, 'PAYID0003', 'DELID0003'),
('ORDID0000004', 'Done', 4, 'PAYID0004', 'DELID0004'),
('ORDID0000005', 'Cancelled', 2, 'PAYID0005', 'DELID0005');

--add applies
INSERT INTO Applies (order_id, voucher_id)
VALUES
('ORDID0000001', 'VCHID0006'),
('ORDID0000002', 'VCHID0007'),
('ORDID0000003', 'VCHID0008'),
('ORDID0000004', 'VCHID0009'),
('ORDID0000005', 'VCHID0010');

--add is contained
INSERT INTO Is_contained (product_id, order_id)
VALUES
('PID000001', 'ORDID0000001'),
('PID000002', 'ORDID0000001'),
('PID000003', 'ORDID0000002'),
('PID000004', 'ORDID0000002'),
('PID000005', 'ORDID0000003');

--add places
INSERT INTO Places (order_id, user_id, user_id_cart, number)
VALUES
('ORDID0000001', 'UID000001', NULL, NULL),
('ORDID0000002', NULL, 'UID000002', 2),
('ORDID0000003', 'UID000003', NULL, NULL),
('ORDID0000004', NULL, 'UID000004', 3),
('ORDID0000005', 'UID000005', NULL, NULL);
