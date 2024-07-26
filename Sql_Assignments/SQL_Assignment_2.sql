-- Drop tables if they exist to avoid conflicts
DROP TABLE IF EXISTS works_on;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS project;
DROP TABLE IF EXISTS Department;

-- Create Department table
CREATE TABLE Department (
    Dept_no VARCHAR(2) PRIMARY KEY,
    Dept_name VARCHAR(20),
    location VARCHAR(30)
);

-- Create Employee table
CREATE TABLE Employee (
    emp_no INT PRIMARY KEY,
    emp_fname VARCHAR(20),
    emp_lname VARCHAR(20),
    Dept_no VARCHAR(2),
    FOREIGN KEY (Dept_no) REFERENCES Department(Dept_no)
);

-- Create project table
CREATE TABLE project (
    project_no VARCHAR(2) PRIMARY KEY,
    project_nameabk VARCHAR(20),
    Budget INT
);

-- Create works_on table
CREATE TABLE works_on (
    emp_no INT,
    project_no VARCHAR(2),
    Job VARCHAR(20),
    enter_date DATE,
    FOREIGN KEY (emp_no) REFERENCES Employee(emp_no),
    FOREIGN KEY (project_no) REFERENCES project(project_no)
);

-- Insert data into Department table
INSERT INTO Department VALUES
('d1', 'Research', 'Dallas'),
('d2', 'Accounting', 'Seattle'),
('d3', 'Marketing', 'Dallas');

-- Insert data into Employee table
INSERT INTO Employee VALUES
(25348, 'Matthew', 'Smith', 'd3'),
(10102, 'Ann', 'Jones', 'd3'),
(18316, 'John', 'Barrimore', 'd1'),
(29346, 'James', 'James', 'd2');

-- Insert data into project table
INSERT INTO project VALUES
('p1', 'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3', 'Mercury', 185600);

-- Insert data into works_on table
INSERT INTO works_on VALUES
(10102, 'p1', 'Analyst', '1997-10-01'),
(10102, 'p3', 'Manager', '1999-01-01'),
(25348, 'p2', 'Clerk', '1998-02-15'),
(18316, 'p2', 'NULL', '1998-06-01'),
(29346, 'p2', 'NULL', '1997-12-15'),
(29346, 'p1', 'Clerk', '1998-01-04');


--Now Performing queries 

--Q1)
select *from works_on 

--Q2)
select emp_no from works_on where job='clerk'

--Q3)

select emp_no from works_on where project_no='p2' and emp_no <10000;

--Q4)
select emp_no from works_on where year(enter_date)!=1998

--Q5)
select emp_no from works_on  where project_no='p1' and job in('Analyst','manager')

--Q6)
select enter_date from works_on where project_no='p2' and job not in('Analyst','manager','Clerk')

--Q7)
select emp_no,emp_lname from Employee where emp_fname like '%tt%'

--Q8)
select emp_no,emp_fname from Employee where emp_lname like '_o%es' or emp_lname like '_a%es'

--Q9)

select e.emp_no from Employee e join Department d on e.Dept_no=d.Dept_no where d.location='Seattle'

--Q10)
select e.emp_fname,e.emp_lname from Employee e join works_on w on e.emp_no=w.emp_no where w.enter_date='1998-01-04'

--Q11)

SELECT 
    e.emp_no, 
    e.emp_fname, 
    e.emp_lname, 
    e.dept_no, 
    d.Dept_name, 
    d.location 
FROM 
    Employee e 
JOIN 
    Department d 
ON 
    d.Dept_no = e.Dept_no 
GROUP BY 
    d.location, 
    e.emp_no, 
    e.emp_fname, 
    e.emp_lname, 
    e.dept_no, 
    d.Dept_name;
--12Q)
select MAX(emp_no) from works_on
--13Q)

SELECT Job FROM Works_on GROUP BY Job HAVING COUNT(emp_no) > 2;

--14Q)

SELECT emp_no FROM Works_on WHERE Job = 'Clerk'
UNION
SELECT emp_no FROM Employee WHERE dept_no = 'd3';
