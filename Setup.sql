USE shoeshoe;

CREATE TABLE shoes
(
    id VARCHAR(255) NOT NULL,
    name VARCHAR(255) NOT NULL,
    color VARCHAR(255) NOT NULL,
    price DECIMAL(9, 2) NOT NULL,
    size DECIMAL(3, 1) NOT NULL,

    PRIMARY KEY (id)
);