-- category table operations
SELECT * FROM category;
INSERT INTO category (category) VALUE ("Ganhos");
INSERT INTO category (category) VALUE ("Gastos");
INSERT INTO category (category) VALUE ("Aportes");
INSERT INTO category (category) VALUE ("Dividendos");
INSERT INTO category (category) VALUE ("Despesa fixa");
-- ************************************************************************************

SELECT * FROM register;
INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Conta de água", 125, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Conta de luz", 307.29, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Internet", 109.09, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Conta de telefone", 70.79, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Aluguel", 2000, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("YouTube", 24.90, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Google storage pessoal", 38.99, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Google storage imobiliário", 38.99, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Microsoft storage", 36, '2024-11-19', 5);

INSERT INTO register (description, value, register_date, idCategory) 
VALUE ("Kung fu", 150, '2024-11-19', 2);

DELETE FROM register
WHERE idRegister = 5;