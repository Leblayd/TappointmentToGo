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
           ,'Saláta csirkemellel, uborkával, pirított kenyérkockával'
           ,'Cézár saláta'
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
           ,'Amerikai káposztasaláta'
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
           ,'Tökmag pestoval'
           ,'Tócsni'
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
           ,'Csigatésztával vagy májgaluskával'
           ,'Húsleves'
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
           ,'Tejfölös csülkös'
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
           ,'Tejszínhabbal, erdei gyümölcsökkel'
           ,'Gyümölcsleves'
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
           ,'Pontyból, harcsából és busából'
           ,'Halászlé'
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
           ,'Törtburgonyával'
           ,'Pacalpörkölt'
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
           ,'Törtburgonyával'
	   ,'Pacalpörkölt'
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
           ,'Bécsi szelet'
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
           ,'Rizzsel, vagy hasábburgonyával'
           ,'Rántott cukkini'
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
           ,'Galuskával'
	   ,'Marhapörkölt'
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
	   ,'Paradicsomszósz, bazsalikom'
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
	   ,'Tonhalas, paradicsomos, mozzarellás'
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
           ,'Négyféle sajttal'
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
           ,'Sonkával, pikáns szalámival, füstölt kolbásszal'
	   ,'Húsimádó Pizza'
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
           ,'Somlói galuska'
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
	   ,'Ásványvíz'
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
           ,'Házi limonádé'
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