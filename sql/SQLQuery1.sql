CREATE TABLE employees (
    id INT NOT NULL PRIMARY KEY IDENTITY,
    name VARCHAR (100) NOT NULL,
    email VARCHAR (150) NOT NULL UNIQUE,
    phone VARCHAR(20) NULL,
    address VARCHAR(100) NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    task VARCHAR(100) NULL
);


INSERT INTO employees (name, email, phone, address, task)
VALUES
('Bill Gates', 'bill.gates@microsoft.com', '+123456789', 'New York, USA',''),
('Elon Musk', 'elon.musk@spacex.com', '+111222333', 'Florida, USA','Clean');
