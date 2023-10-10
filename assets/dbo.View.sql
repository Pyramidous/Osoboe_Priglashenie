CREATE VIEW [dbo].[View]
	AS SELECT        ID_Order, INN_Client, INN_Staff, ID_Product, Count, Price
	FROM             [Order]
	WHERE            (INN_Staff IS NULL)
