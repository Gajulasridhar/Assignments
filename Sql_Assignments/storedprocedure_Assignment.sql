create procedure GetAllProducts
as
begin
select*from product
end

--GetProductByName
create procedure GetProductByName1(@pName varchar(30))
as
begin
select pname,pid,price,stock from product where pname=@pName
end
-- DeleteProductById
create procedure  DeleteProductById(@id int)
as
begin
delete from product where pid=@id
end
--UpdateProduct(Update Price and Stock of the Product using Pid)
create procedure UpdateProduct(@price int,@stock int,@pid int)
as
begin
update product set price=@price ,stock=@stock where pid=@pid
end

--GetAllProductsBy>input Price
create procedure GetAllProductsByprice(@price int)
as
begin
select *from  product where price=@price
end



---execution commands
select *from product
insert into product values(2,'KeyBoard',800,12)
exec GetAllProducts

exec GetProductByName1 'mouse'
exec  DeleteProductById 1
exec UpdateProduct 800,12,2
exec GetAllProductsByprice 800