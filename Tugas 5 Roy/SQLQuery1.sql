SELECT * FROM dependents
SELECT * FROM employees
Select * from jobs

/*SET IDENTITY_INSERT dependents ON
INSERT INTO dependents (dependent_id, first_name, last_name, relationship, employee_id) Values (31,'Budi', 'King' , 'Father' , 100)
INSERT INTO dependents (dependent_id, first_name, last_name, relationship, employee_id) Values (32,'Diana', 'King' , 'Mother' , 100)
INSERT INTO dependents (dependent_id, first_name, last_name, relationship, employee_id) Values (33,'Meister', 'King' , 'Child' , 100)
INSERT INTO dependents (dependent_id, first_name, last_name, relationship, employee_id) Values (34,'Alexa', 'Khoo' , 'Mother' , 115)*/

SELECT DISTINCT 
	employees.first_name + ' ' + employees.last_name AS Fullname, 
	(SELECT count(employee_id) from dependents where employees.employee_id = dependents.employee_id) AS FamilyCount
FROM
	employees
	INNER JOIN dependents on employees.employee_id = dependents.employee_id






SELECT DISTINCT
	employees.first_name + ' ' + employees.last_name AS Fullname,
	(SELECT COUNT(relationship) from dependents where relationship = 'Child' AND dependents.employee_id = employees.employee_id) AS ChildCount,
	(SELECT COUNT(relationship) from dependents where relationship = 'Father' AND dependents.employee_id = employees.employee_id) AS FatherCount,
	(SELECT COUNT(relationship) from dependents where relationship = 'Mother' AND dependents.employee_id = employees.employee_id) AS MotherCount
FROM
	employees
	INNER JOIN dependents on employees.employee_id = dependents.employee_id

