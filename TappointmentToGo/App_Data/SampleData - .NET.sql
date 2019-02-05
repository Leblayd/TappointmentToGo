DELETE FROM [dbo].[MenuItems]
DELETE FROM [dbo].[Categories]

SET IDENTITY_INSERT [dbo].[Categories] ON

INSERT INTO [dbo].[Categories]
		   ([Id],
		   [Name])
	   VALUES
		   (1
		   ,'Starter')

INSERT INTO [dbo].[Categories]
		   ([Id],
		   [Name])
	   VALUES
		   (2
		   ,'Soup')

INSERT INTO [dbo].[Categories]
		   ([Id],
		   [Name])
	   VALUES
		   (3
		   ,'Main Dish')

INSERT INTO [dbo].[Categories]
		   ([Id],
		   [Name])
	   VALUES
		   (4
		   ,'Pizza')

INSERT INTO [dbo].[Categories]
		   ([Id],
		   [Name])
	   VALUES
		   (5
		   ,'Dessert')

INSERT INTO [dbo].[Categories]
		   ([Id],
		   [Name])
	   VALUES
		   (6
		   ,'Drink')

SET IDENTITY_INSERT [dbo].[Categories] OFF


INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (1
           ,'Sal�ta csirkemellel, ubork�val, pir�tott keny�rkock�val'
           ,'C�z�r sal�ta'
           ,700
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (1
           ,'Amerikai k�posztasal�ta'
           ,'Coleslaw'
           ,500
           ,0
           ,0)
 

INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (1
           ,'T�kmag pestoval'
           ,'T�csni'
           ,750
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (2
           ,'Csigat�szt�val vagy m�jgalusk�val'
           ,'H�sleves'
	   ,800
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (2
           ,'Tejf�l�s cs�lk�s'
           ,'Bableves'
	   ,1000
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (2
           ,'Tejsz�nhabbal, erdei gy�m�lcs�kkel'
           ,'Gy�m�lcsleves'
	   ,1000
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (2
           ,'Pontyb�l, harcs�b�l �s bus�b�l'
           ,'Hal�szl�'
	   ,1500
           ,1
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (3
           ,'T�rtburgony�val'
           ,'Pacalp�rk�lt'
	   ,1200
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (3
           ,'T�rtburgony�val'
	   ,'Pacalp�rk�lt'
           ,1200
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (3
           ,''
           ,'B�csi szelet'
	   ,2500
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (3
           ,'Rizzsel, vagy has�bburgony�val'
           ,'R�ntott cukkini'
	   ,1500
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (3
           ,'Galusk�val'
	   ,'Marhap�rk�lt'
           ,2500
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (4
	   ,'Paradicsomsz�sz, bazsalikom'
           ,'Pizza Margherita'
           ,1000
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (4
	   ,'Tonhalas, paradicsomos, mozzarell�s'
           ,'Pizza Tonno'
           ,1500
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (4
           ,'N�gyf�le sajttal'
	   ,'Pizza Quattro Formaggi'
           ,2000
           ,0
           ,1)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (4
           ,'Sonk�val, pik�ns szal�mival, f�st�lt kolb�sszal'
	   ,'H�sim�d� Pizza'
           ,2000
           ,1
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (5
	   ,''
           ,'Soml�i galuska'
           ,1000
           ,0
           ,0)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (6
           ,null
	   ,'Coca-Cola'
           ,300
           ,null
           ,null)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (6
           ,null
	   ,'�sv�nyv�z'
           ,300
           ,null
           ,null)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (6
           ,null
           ,'H�zi limon�d�'
           ,650
           ,null
           ,null)
 
INSERT INTO [dbo].[MenuItems]
           ([Category_Id]
           ,[Description]
           ,[Name]
           ,[Price]
           ,[Spicy]
           ,[Vegetarian])
     VALUES
           (6
           ,null
           ,'Red Bull'
	   ,700
           ,null
           ,null)