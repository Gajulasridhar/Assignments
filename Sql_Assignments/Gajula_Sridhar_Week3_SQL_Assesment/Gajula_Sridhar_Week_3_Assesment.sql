create database Week_3_assesment

create table Subject(subjectId int primary key , subtitle varchar(20))

create table Book(
bookId int,
  
title  varchar(20),
  
price  int,
  
volume  int,
  
author varchar(20),
  
publishDate  Date,
  
subjectId   int foreign key(subjectId) references Subject(subjectId)
)

--1)
insert into Subject values (101,'Clang' ),(102,'python'),(103,' DSA'),(104,'java'),(105,'c# ')
--2)

INSERT INTO Book VALUES 
(1, 'Clang', 500, 1, 'Author A', '2021-01-01', 101),
(2, 'C++lang', 600, 2, 'Author B', '2021-02-01', 101),
(3, 'Adv C', 550, 3, 'Author C', '2021-03-01', 101),
(4, 'Python', 450, 1, 'Author D', '2021-04-01', 102),
(5, 'Python DS', 650, 2, 'Author E', '2021-05-01', 102),
(6, 'Python WB', 700, 3, 'Author F', '2021-06-01', 102),
(7, 'DSA', 400, 1, 'Author G', '2021-07-01', 103),
(8, 'Algo in DSA', 500, 2, 'Author H', '2021-08-01', 103),
(9, 'DSA Problems', 550, 3, 'Author I', '2021-09-01', 103),
(10, 'Java Prog', 600, 1, 'Author J', '2021-10-01', 104),
(11, 'Java for Beg', 550, 2, 'Author K', '2021-11-01', 104),
(12, 'Advanced Java', 700, 3, 'Author L', '2021-12-01', 104),
(13, 'C# Fund', 500, 1, 'Author M', '2022-01-01', 105),
(14, 'C# for Prof', 650, 2, 'Author N', '2022-02-01', 105),
(15, 'C# and .NET', 750, 3, 'Author O', '2022-03-01', 105);

--3)
SELECT 
    Book.bookId,
    Book.title,
    Book.price,
    Book.volume,
    Book.author,
    Book.publishDate,
    Subject.subjectId,
    Subject.subtitle
FROM 

    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId where Book.subjectId=101;

	--4)

SELECT 
    Book.bookId,
    Book.title,
    Book.price,
    Book.volume,
    Book.author,
    Book.publishDate,
    Subject.subjectId,
    Subject.subtitle
FROM 

    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId where Book.publishDate between '2021-01-01' and '2021-03-01' ;

--5)
SELECT 
    author, COUNT(*) AS numberOfBooks
FROM 
    Book
GROUP BY 
    author;
--6)
SELECT 
    Subject.subjectId, Subject.subtitle, COUNT(Book.bookId) AS numberOfBooks
FROM 
    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId
GROUP BY 
    Subject.subjectId, Subject.subtitle;

--7)
SELECT 
    COUNT(*) AS numberOfBooks
FROM 
    Book
WHERE 
    YEAR(publishDate) = 2021;
--8)

UPDATE 
    Book
SET 
    price = 350, 
    volume = 2
WHERE 
    bookId = 101;
--9)
UPDATE 
    Book
SET 
    price = price * 1.10
WHERE 
    subjectId IN (SELECT subjectId FROM Subject WHERE subtitle = 'python');

--10)

DELETE FROM 
    Book
WHERE 
    bookId = 101;

--11)
SELECT 
    Book.bookId, Book.title, Book.price, Book.volume, Book.author, Book.publishDate, Book.subjectId
FROM 
    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId
WHERE 
    Book.price > 500 AND Subject.subtitle = 'python';

	--12)
SELECT 
    Book.bookId, Book.title, Book.price, Book.volume, Book.author, Book.publishDate, Subject.subjectId, Subject.subtitle
FROM 
    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId
ORDER BY 
    Subject.subjectId;

--13)
SELECT 
    *
FROM 
    Book
WHERE 
    price = (SELECT MIN(price) FROM Book);


--14)
SELECT 
    *
FROM 
    Book
WHERE 
    price = (SELECT MIN(price) FROM Book);

--15)
SELECT 
    COUNT(Book.bookId) AS numberOfBooks
FROM 
    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId
WHERE 
    Subject.subtitle = 'python';

--16)
SELECT 
    Book.bookId, Book.title, Book.price, Book.volume, Book.author, Book.publishDate, Subject.subjectId, Subject.subtitle
FROM 
    Book
INNER JOIN 
    Subject ON Book.subjectId = Subject.subjectId
WHERE 
    Subject.subtitle IN ('python', 'clang', 'c++ lang');

