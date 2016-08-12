insert into sale (otro) values ('algo');

select * from sale

select * from Products

select Products.Id from Products

select * from SaleProducts

select Products.NProducto, Products.Price, Products.Descripcion from SaleProducts, Products where SaleProducts.Id_Product = Products.Id and SaleProducts.Id_Sale = 1

select pro.descripcion, pro.price from Products pro, SaleProducts where Products.Id = SaleProducts.Id_Product and SaleProducts.Id_Sale = 1

select Products.NProducto from Products, SaleProducts wh

select * from Client

select DISTINCT cli.rfc, cli.nombre,cli.telephone, cli.mail, ad.Street, ad.NumExt, ad.NumInt, ad.Colonia, ad.CP, ad.Municipio, ad.Ciudad, ad.Estado from Client cli, Address ad where ad.Id = cli.Id_Address and cli.rfc like 'LOFA620207QW5'




select * from Client, Address where Address.Id = Client.Id_Address and Client.RFC = 'LOFA620207QW5'

select * from Address

UPDATE Client
SET RFC='ALGO'
WHERE Client.Id=6;