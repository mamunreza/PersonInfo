USE [PersonInfo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 09-Nov-23 3:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 09-Nov-23 3:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[SectorId] [int] NOT NULL,
	[AgreeToTerms] [bit] NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sectors]    Script Date: 09-Nov-23 3:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ParentId] [int] NOT NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231109123139_Init', N'7.0.13')
GO
SET IDENTITY_INSERT [dbo].[Sectors] ON 
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (-1, N'Select Sector', -1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (1, N'Manufacturing', -1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (2, N'Construction materials', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (3, N'Electronics and Optics', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (4, N'Food and Beverage', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (5, N'Bakery & confectionery products', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (6, N'Beverages', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (7, N'Fish & fish products', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (8, N'Meat & meat products', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (9, N'Milk & dairy products', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (10, N'Other', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (11, N'Sweets & snack food', 4)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (12, N'Furniture', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (13, N'Bathroom/sauna', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (14, N'Bedroom', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (15, N'Children''s room', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (16, N'Kitchen', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (17, N'Living room', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (18, N'Office', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (19, N'Other (Furniture)', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (20, N'Outdoor', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (21, N'Project furniture', 12)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (22, N'Machinery', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (23, N'Machinery components', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (24, N'Machinery equipment/tools', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (25, N'Manufacture of machinery', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (26, N'Maritime', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (27, N'Aluminium and steel workboats', 26)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (28, N'Boat/Yacht building', 26)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (29, N'Ship repair and conversion', 26)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (30, N'Metal structures', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (31, N'Other', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (32, N'Repair and maintenance service', 22)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (33, N'Metalworking', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (34, N'Construction of metal structures', 33)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (35, N'Houses and buildings', 33)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (36, N'Metal products', 33)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (37, N'Metal works', 33)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (38, N'CNC-machining', 37)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (39, N'Forgings, Fasteners', 37)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (40, N'Gas, Plasma, Laser cutting', 37)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (41, N'MIG, TIG, Aluminum welding', 37)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (42, N'Plastic and Rubber', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (43, N'Packaging', 42)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (44, N'Plastic goods', 42)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (45, N'Plastic processing technology', 42)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (46, N'Blowing', 45)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (47, N'Moulding', 45)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (48, N'Plastics welding and processing', 45)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (49, N'Plastic profiles', 42)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (50, N'Printing', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (51, N'Advertising', 50)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (52, N'Book/Periodicals printing', 50)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (53, N'Labelling and packaging printing', 50)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (54, N'Textile and Clothing', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (55, N'Clothing', 54)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (56, N'Textile', 54)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (57, N'Wood', 1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (58, N'Other (Wood)', 57)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (59, N'Wooden building materials', 57)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (60, N'Wooden houses', 57)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (61, N'Other', -1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (62, N'Creative industries', 61)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (63, N'Energy technology', 61)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (64, N'Environment', 61)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (65, N'Service', -1)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (66, N'Business services', 65)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (67, N'Engineering', 65)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (68, N'Information Technology and Telecommunications', 65)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (69, N'Data processing, Web portals, E-marketing', 68)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (70, N'Programming, Consultancy', 68)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (71, N'Software, Hardware', 68)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (72, N'Telecommunications', 68)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (73, N'Tourism', 65)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (74, N'Translation services', 65)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (75, N'Transport and Logistics', 65)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (76, N'Air', 75)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (77, N'Rail', 75)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (78, N'Road', 75)
GO
INSERT [dbo].[Sectors] ([Id], [Name], [ParentId]) VALUES (79, N'Water', 75)
GO
SET IDENTITY_INSERT [dbo].[Sectors] OFF
GO
ALTER TABLE [dbo].[Sectors]  WITH CHECK ADD  CONSTRAINT [FK_Sectors_Sectors_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Sectors] ([Id])
GO
ALTER TABLE [dbo].[Sectors] CHECK CONSTRAINT [FK_Sectors_Sectors_ParentId]
GO
