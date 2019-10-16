USE shoeshoe;

-- CREATE TABLE brands
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE shoes
-- (
--     id VARCHAR(255) NOT NULL,
--     name VARCHAR(255) NOT NULL,
--     color VARCHAR(255) NOT NULL,
--     price DECIMAL(9, 2) NOT NULL,
--     size DECIMAL(3, 1) NOT NULL,
--     brandId INT NOT NULL,

--     FOREIGN KEY(brandId)
--         REFERENCES brands(id)
--         ON DELETE CASCADE,

--     PRIMARY KEY (id)
-- );

-- CREATE TABLE orders
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     customerName VARCHAR(255) NOT NULL,
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE shoesorders
-- (
--   id INT NOT NULL AUTO_INCREMENT,
--   shoeId VARCHAR(255) NOT NULL,
--   orderId INT NOT NULL,

--   INDEX (orderId),

--     FOREIGN KEY(shoeId) 
--         REFERENCES shoes(id) 
--         ON DELETE CASCADE,
    
--     FOREIGN KEY(orderId)
--         REFERENCES orders(id)
--         ON DELETE CASCADE,

--     PRIMARY KEY(id)
-- );