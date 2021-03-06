USE [RIS314_Exam]
GO
/****** Object:  Table [dbo].[PROPERTY_TYPE]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROPERTY_TYPE](
	[PropTypeId] [int] IDENTITY(600,1) NOT NULL,
	[PropertyType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PropTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PROPERTY_TYPE] ON
INSERT [dbo].[PROPERTY_TYPE] ([PropTypeId], [PropertyType]) VALUES (600, N'Flat')
INSERT [dbo].[PROPERTY_TYPE] ([PropTypeId], [PropertyType]) VALUES (601, N'House')
INSERT [dbo].[PROPERTY_TYPE] ([PropTypeId], [PropertyType]) VALUES (604, N'Garden cottage')
INSERT [dbo].[PROPERTY_TYPE] ([PropTypeId], [PropertyType]) VALUES (605, N'Penthouse')
SET IDENTITY_INSERT [dbo].[PROPERTY_TYPE] OFF
/****** Object:  Table [dbo].[OWNER]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OWNER](
	[OwnerId] [int] IDENTITY(900,1) NOT NULL,
	[OwnerNumber] [varchar](5) NULL,
	[OwnerStreet] [varchar](50) NOT NULL,
	[OwnerCity] [varchar](50) NOT NULL,
	[OwnerPostCode] [varchar](5) NOT NULL,
	[OwnerType] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OwnerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[OWNER] ON
INSERT [dbo].[OWNER] ([OwnerId], [OwnerNumber], [OwnerStreet], [OwnerCity], [OwnerPostCode], [OwnerType]) VALUES (900, N'C093', N'12 Park Drive', N'Johannesburg', N'2000', N'I')
INSERT [dbo].[OWNER] ([OwnerId], [OwnerNumber], [OwnerStreet], [OwnerCity], [OwnerPostCode], [OwnerType]) VALUES (901, N'C094', N'102 Aloe Drive', N'Johannesburg', N'2000', N'B')
INSERT [dbo].[OWNER] ([OwnerId], [OwnerNumber], [OwnerStreet], [OwnerCity], [OwnerPostCode], [OwnerType]) VALUES (908, N'C7', N'90 Plein Street', N'Cape Town', N'8000', N'B')
SET IDENTITY_INSERT [dbo].[OWNER] OFF
/****** Object:  Table [dbo].[BRANCH]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BRANCH](
	[BranchId] [int] IDENTITY(100,1) NOT NULL,
	[BranchNumber] [varchar](5) NOT NULL,
	[BranchStreet] [varchar](50) NOT NULL,
	[BranchCity] [varchar](50) NOT NULL,
	[BranchPostCode] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BRANCH] ON
INSERT [dbo].[BRANCH] ([BranchId], [BranchNumber], [BranchStreet], [BranchCity], [BranchPostCode]) VALUES (100, N'B003', N'163 Main Street', N'Johannesburg', N'2000')
INSERT [dbo].[BRANCH] ([BranchId], [BranchNumber], [BranchStreet], [BranchCity], [BranchPostCode]) VALUES (101, N'B004', N'50 Roeland Street', N'Cape Town', N'8000')
INSERT [dbo].[BRANCH] ([BranchId], [BranchNumber], [BranchStreet], [BranchCity], [BranchPostCode]) VALUES (102, N'B005', N'42 Musgrave Street', N'Durban', N'4000')
INSERT [dbo].[BRANCH] ([BranchId], [BranchNumber], [BranchStreet], [BranchCity], [BranchPostCode]) VALUES (103, N'B006', N'6 Algoabay Street', N'Port Elizabeth', N'6000')
INSERT [dbo].[BRANCH] ([BranchId], [BranchNumber], [BranchStreet], [BranchCity], [BranchPostCode]) VALUES (104, N'B007', N'Voortrekker Street', N'Springbok', N'8240')
SET IDENTITY_INSERT [dbo].[BRANCH] OFF
/****** Object:  Table [dbo].[STAFF_CLASS]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STAFF_CLASS](
	[StaffClassId] [int] IDENTITY(300,1) NOT NULL,
	[StaffPosition] [varchar](50) NOT NULL,
	[StaffSalary] [decimal](18, 2) NOT NULL,
	[StaffBonus] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffClassId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[STAFF_CLASS] ON
INSERT [dbo].[STAFF_CLASS] ([StaffClassId], [StaffPosition], [StaffSalary], [StaffBonus]) VALUES (300, N'Manager', CAST(24000.00 AS Decimal(18, 2)), CAST(23000.00 AS Decimal(18, 2)))
INSERT [dbo].[STAFF_CLASS] ([StaffClassId], [StaffPosition], [StaffSalary], [StaffBonus]) VALUES (301, N'Supervisor', CAST(16000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[STAFF_CLASS] ([StaffClassId], [StaffPosition], [StaffSalary], [StaffBonus]) VALUES (302, N'Assistant', CAST(8000.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[STAFF_CLASS] ([StaffClassId], [StaffPosition], [StaffSalary], [StaffBonus]) VALUES (303, N'CEO', CAST(50000.00 AS Decimal(18, 2)), CAST(25000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[STAFF_CLASS] OFF
/****** Object:  StoredProcedure [dbo].[UpdatePropertyType]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePropertyType] 
	
	@PropTypeId	int,
	@PropertyType varchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Update PROPERTY_TYPE
	set PropertyType=@PropertyType
	where PropTypeId = @PropTypeId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOwner]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOwner]
	
	@OwnerId	int,
	@OwnerNumber varchar(5),
	@OwnerStreet	varchar(50),
	@OwnerCity		varchar(50),
	@OwnerPostCode	varchar(50),
	@OwnerType		varchar(2)	
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update [OWNER]
	set 
	OwnerNumber=@OwnerNumber,
	OwnerStreet=@OwnerStreet,
	OwnerCity=@OwnerCity,
	OwnerPostCode=@OwnerPostCode,
	OwnerType=@OwnerType
	where OwnerId = @OwnerId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStaffClass]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateStaffClass]
	
	@StaffClassId	int,
	@StaffPosition	varchar(50),
	@StaffSalary	decimal(18,2),
	@StaffBonus		decimal(18,2)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update STAFF_CLASS
	set StaffPosition = @StaffPosition,StaffSalary = @StaffSalary,StaffBonus = @StaffBonus
	where StaffClassId = @StaffClassId
	
END
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STAFF](
	[StaffId] [int] IDENTITY(400,1) NOT NULL,
	[StaffNumber] [varchar](5) NOT NULL,
	[StaffTitle] [varchar](5) NOT NULL,
	[StaffLname] [varchar](50) NOT NULL,
	[StaffFname] [varchar](50) NOT NULL,
	[StaffGender] [char](1) NOT NULL,
	[StaffDOB] [date] NOT NULL,
	[StaffStartDate] [date] NOT NULL,
	[StaffSupervisor] [int] NULL,
	[StaffClassId] [int] NULL,
	[BranchId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[STAFF] ON
INSERT [dbo].[STAFF] ([StaffId], [StaffNumber], [StaffTitle], [StaffLname], [StaffFname], [StaffGender], [StaffDOB], [StaffStartDate], [StaffSupervisor], [StaffClassId], [BranchId]) VALUES (400, N'SG5', N'Mrs', N'Brown', N'Susan', N'F', CAST(0x8FEB0A00 AS Date), CAST(0x9F240B00 AS Date), NULL, 300, 100)
INSERT [dbo].[STAFF] ([StaffId], [StaffNumber], [StaffTitle], [StaffLname], [StaffFname], [StaffGender], [StaffDOB], [StaffStartDate], [StaffSupervisor], [StaffClassId], [BranchId]) VALUES (401, N'SG1', N'Mr', N'Masinga', N'Sam', N'M', CAST(0x99DF0A00 AS Date), CAST(0x2D210B00 AS Date), NULL, 303, 100)
INSERT [dbo].[STAFF] ([StaffId], [StaffNumber], [StaffTitle], [StaffLname], [StaffFname], [StaffGender], [StaffDOB], [StaffStartDate], [StaffSupervisor], [StaffClassId], [BranchId]) VALUES (402, N'SG14', N'Mr', N'Ford', N'David', N'M', CAST(0x980B0B00 AS Date), CAST(0xA5260B00 AS Date), NULL, 301, 100)
INSERT [dbo].[STAFF] ([StaffId], [StaffNumber], [StaffTitle], [StaffLname], [StaffFname], [StaffGender], [StaffDOB], [StaffStartDate], [StaffSupervisor], [StaffClassId], [BranchId]) VALUES (403, N'SG37', N'Ms', N'Beech', N'Ann', N'F', CAST(0x64120B00 AS Date), CAST(0x2E2D0B00 AS Date), 402, 302, 100)
INSERT [dbo].[STAFF] ([StaffId], [StaffNumber], [StaffTitle], [StaffLname], [StaffFname], [StaffGender], [StaffDOB], [StaffStartDate], [StaffSupervisor], [StaffClassId], [BranchId]) VALUES (404, N'SG112', N'Mrs', N'Longhorn', N'Annette', N'F', CAST(0xBD000B00 AS Date), CAST(0x80240B00 AS Date), NULL, 301, 100)
INSERT [dbo].[STAFF] ([StaffId], [StaffNumber], [StaffTitle], [StaffLname], [StaffFname], [StaffGender], [StaffDOB], [StaffStartDate], [StaffSupervisor], [StaffClassId], [BranchId]) VALUES (405, N'SG126', N'Mr', N'Lawrence', N'Chris', N'M', CAST(0x41050B00 AS Date), CAST(0x1E370B00 AS Date), 400, 300, 100)
SET IDENTITY_INSERT [dbo].[STAFF] OFF
/****** Object:  StoredProcedure [dbo].[UpdateBranch]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBranch]
	
	@BranchId	int,
	@BranchNumber	varchar(5),
	@BranchStreet	varchar(50),
	@BranchCity		varchar(50),
	@BranchPostCode	varchar(5)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update BRANCH
	set BranchNumber = @BranchNumber, BranchStreet = @BranchStreet,BranchCity = @BranchCity,BranchPostCode = @BranchPostCode
	where BranchId = @BranchId
	
END
GO
/****** Object:  Table [dbo].[OWNER_TEL_NUM]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OWNER_TEL_NUM](
	[OwnerTelId] [int] IDENTITY(1000,1) NOT NULL,
	[OwnerId] [int] NOT NULL,
	[OwnerAreaCode] [char](3) NOT NULL,
	[OwnerTelNum] [char](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OwnerTelId] ASC,
	[OwnerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[OWNER_TEL_NUM] ON
INSERT [dbo].[OWNER_TEL_NUM] ([OwnerTelId], [OwnerId], [OwnerAreaCode], [OwnerTelNum]) VALUES (1000, 900, N'011', N'2257025')
INSERT [dbo].[OWNER_TEL_NUM] ([OwnerTelId], [OwnerId], [OwnerAreaCode], [OwnerTelNum]) VALUES (1001, 901, N'011', N'5817025')
INSERT [dbo].[OWNER_TEL_NUM] ([OwnerTelId], [OwnerId], [OwnerAreaCode], [OwnerTelNum]) VALUES (1004, 908, N'021', N'6547893')
INSERT [dbo].[OWNER_TEL_NUM] ([OwnerTelId], [OwnerId], [OwnerAreaCode], [OwnerTelNum]) VALUES (1015, 901, N'011', N'1235926')
INSERT [dbo].[OWNER_TEL_NUM] ([OwnerTelId], [OwnerId], [OwnerAreaCode], [OwnerTelNum]) VALUES (1016, 900, N'012', N'1234569')
INSERT [dbo].[OWNER_TEL_NUM] ([OwnerTelId], [OwnerId], [OwnerAreaCode], [OwnerTelNum]) VALUES (1017, 900, N'   ', N'       ')
SET IDENTITY_INSERT [dbo].[OWNER_TEL_NUM] OFF
/****** Object:  StoredProcedure [dbo].[InsertStaffClass]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStaffClass] 
	
	@StaffPosition varchar(50),
	@StaffSalary	decimal,
	@StaffBonus		decimal,
	@NewStaffClassId int OUT
	
AS
BEGIN
	
	SET NOCOUNT ON;

    Insert into STAFF_CLASS
    values(@StaffPosition,@StaffSalary,@StaffBonus)
    set @NewStaffClassId = SCOPE_IDENTITY();
    
END
GO
/****** Object:  Table [dbo].[BUSINESS]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BUSINESS](
	[OwnerId] [int] NOT NULL,
	[BusinessName] [varchar](50) NOT NULL,
	[BusinessType] [varchar](50) NOT NULL,
	[BusContactLname] [varchar](50) NOT NULL,
	[BusContactFname] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OwnerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BUSINESS] ([OwnerId], [BusinessName], [BusinessType], [BusContactLname], [BusContactFname]) VALUES (901, N'Hoffmann,Inc.', N'Corporate', N'Hoffmann', N'Roahn')
INSERT [dbo].[BUSINESS] ([OwnerId], [BusinessName], [BusinessType], [BusContactLname], [BusContactFname]) VALUES (908, N'This City works for You', N'NGO', N'Zille', N'Helena')
/****** Object:  Table [dbo].[BRANCH_TEL_NUM]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BRANCH_TEL_NUM](
	[BranchTelId] [int] IDENTITY(200,1) NOT NULL,
	[BranchAreaCode] [char](3) NOT NULL,
	[BranchTelNum] [char](7) NOT NULL,
	[BranchId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BranchTelId] ASC,
	[BranchId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BRANCH_TEL_NUM] ON
INSERT [dbo].[BRANCH_TEL_NUM] ([BranchTelId], [BranchAreaCode], [BranchTelNum], [BranchId]) VALUES (200, N'011', N'3392178', 100)
INSERT [dbo].[BRANCH_TEL_NUM] ([BranchTelId], [BranchAreaCode], [BranchTelNum], [BranchId]) VALUES (201, N'011', N'3394439', 100)
INSERT [dbo].[BRANCH_TEL_NUM] ([BranchTelId], [BranchAreaCode], [BranchTelNum], [BranchId]) VALUES (202, N'021', N'5912014', 101)
INSERT [dbo].[BRANCH_TEL_NUM] ([BranchTelId], [BranchAreaCode], [BranchTelNum], [BranchId]) VALUES (203, N'031', N'7812718', 102)
INSERT [dbo].[BRANCH_TEL_NUM] ([BranchTelId], [BranchAreaCode], [BranchTelNum], [BranchId]) VALUES (204, N'041', N'5813421', 103)
INSERT [dbo].[BRANCH_TEL_NUM] ([BranchTelId], [BranchAreaCode], [BranchTelNum], [BranchId]) VALUES (205, N'027', N'7316709', 104)
SET IDENTITY_INSERT [dbo].[BRANCH_TEL_NUM] OFF
/****** Object:  StoredProcedure [dbo].[DeleteBranch]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBranch] 
	
	@BranchId	int
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from BRANCH
	where BranchId = @BranchId
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertOwner]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOwner]
	
	@OwnerNumber	varchar(5),
	@OwnerStreet	varchar(50),
	@OwnerCity		varchar(50),
	@OwnerPostCode	varchar(5),
	@OwnerType		varchar(2),
	@NewOwnerId		int output
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	insert into [OWNER]
	values(
	@OwnerNumber,
	@OwnerStreet,
	@OwnerCity,
	@OwnerPostCode,
	@OwnerType)
	set @NewOwnerId = SCOPE_IDENTITY()
 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertPropertyType]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertPropertyType]
	
	@PropType	varchar(50),
	@NewPropTypeId	int OUT
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Insert into PROPERTY_TYPE
	values(@PropType)
	set @NewPropTypeId = SCOPE_IDENTITY()
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBranch]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBranch]
	@BranchNumber	varchar(50),
	@BranchStreet	varchar(50),
	@BranchCity		varchar(50),
	@BranchPostCode	varchar(5),
	@NewBranchId	int OUT
AS
BEGIN
	
	SET NOCOUNT ON;
	if not exists (select BRANCH.BranchNumber,BRANCH.BranchCity 
				   from BRANCH
				   where BranchNumber=@BranchNumber and BranchCity=@BranchCity)
		BEGIN
		Insert into BRANCH
		values(@BranchNumber,@BranchStreet,@BranchCity,@BranchPostCode)
		set @NewBranchId = SCOPE_IDENTITY();
		END
	else
		RAISERROR('This Branch already exists',16,1)
	    
END
GO
/****** Object:  Table [dbo].[INDIVIDUAL]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INDIVIDUAL](
	[OwnerId] [int] NOT NULL,
	[IndividLname] [varchar](50) NOT NULL,
	[IndividFname] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OwnerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[INDIVIDUAL] ([OwnerId], [IndividLname], [IndividFname]) VALUES (900, N'Shaw', N'Tony')
/****** Object:  StoredProcedure [dbo].[DeleteOwner]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOwner] 
	@OwnerId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from [OWNER]
	where OwnerId = @OwnerId
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePropertyType]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePropertyType] 
	@PropTypeId	int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from PROPERTY_TYPE
	where PropTypeId = @PropTypeId
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStaffClass]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteStaffClass]
	@StaffClassId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from STAFF_CLASS
	where StaffClassId = @StaffClassId
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStaff]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteStaff] 
	@StaffId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update STAFF set StaffSupervisor = NULL
	where StaffId = @StaffId
	Delete from STAFF
	where StaffId = @StaffId
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertIndividual]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertIndividual] 
	
	@OwnerId	int,
	@IndividLname	varchar(50),
	@IndividFname	varchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Insert into INDIVIDUAL
	values(
	@OwnerId,
	@IndividLname,
	@IndividFname)

END
GO
/****** Object:  StoredProcedure [dbo].[GetOwners]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOwners]
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select INDIVIDUAL.OwnerId as OwnerId,INDIVIDUAL.IndividLname as OwnerLname,INDIVIDUAL.IndividFname as OwnerFname from INDIVIDUAL
	union
	select BUSINESS.OwnerId,BUSINESS.BusinessName,BUSINESS.BusinessType from BUSINESS
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBusiness]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBusiness] 
	
	@OwnerId	int,
	@BusinessName	varchar(50),
	@BusinessType	varchar(50),
	@BusContactLname	varchar(50),
	@BusContactFname	varchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Insert into BUSINESS
	values(
	@OwnerId,
	@BusinessName,
	@BusinessType,
	@BusContactLname,
	@BusContactFname)

END
GO
/****** Object:  StoredProcedure [dbo].[InsertBranchTelNumber]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBranchTelNumber] 
	@BranchAreaCode char(3),
	@BranchTelNum	char(7),
	@BranchId		int,
	@NewTelNumId	int OUT
AS
BEGIN
	
	SET NOCOUNT ON;
	if not exists(select BRANCH_TEL_NUM.BranchAreaCode,BRANCH_TEL_NUM.BranchTelNum
				  from BRANCH_TEL_NUM
				  where BranchId = @BranchId)
	BEGIN
	Insert into BRANCH_TEL_NUM
	values(@BranchAreaCode,@BranchTelNum,@BranchId)
    set @NewTelNumId = SCOPE_IDENTITY();
    END
    else
		raiserror('Cannot insert duplicate telephone number',16,1)
END
GO
/****** Object:  Table [dbo].[CLIENT]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENT](
	[ClientId] [int] IDENTITY(500,1) NOT NULL,
	[ClientNumber] [varchar](5) NULL,
	[ClientLname] [varchar](50) NOT NULL,
	[ClientFname] [varchar](50) NOT NULL,
	[DateRegistered] [datetime] NOT NULL,
	[StaffId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CLIENT] ON
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (500, N'CR74', N'Smith', N'Mike', CAST(0x0000000000000000 AS DateTime), 403)
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (501, N'CR76', N'Kay', N'John', CAST(0x0000000000000000 AS DateTime), 405)
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (502, N'CR56', N'Stewart', N'Aline', CAST(0x0000000000000000 AS DateTime), 403)
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (503, N'CR75', N'Ritchie', N'Mike', CAST(0x0000000000000000 AS DateTime), 405)
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (504, N'CR62', N'Tregear', N'Mary', CAST(0x0000000000000000 AS DateTime), 403)
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (507, N'C23', N'Hoffmann', N'Roahn', CAST(0x0000A1C200000000 AS DateTime), 403)
INSERT [dbo].[CLIENT] ([ClientId], [ClientNumber], [ClientLname], [ClientFname], [DateRegistered], [StaffId]) VALUES (508, N'C1', N'Jacobs', N'Willem', CAST(0x0000A1C200000000 AS DateTime), 403)
SET IDENTITY_INSERT [dbo].[CLIENT] OFF
/****** Object:  Table [dbo].[PROPERTY]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROPERTY](
	[PropertyId] [int] IDENTITY(1100,1) NOT NULL,
	[PropertyNumber] [varchar](5) NOT NULL,
	[PropertyStreet] [varchar](50) NOT NULL,
	[PropertyCity] [varchar](50) NOT NULL,
	[PropertyPostCode] [varchar](5) NOT NULL,
	[PropertyRent] [decimal](18, 2) NOT NULL,
	[PropertyRooms] [int] NOT NULL,
	[PropertyDateListed] [datetime] NOT NULL,
	[StaffId] [int] NULL,
	[PropTypeId] [int] NULL,
	[OwnerId] [int] NULL,
	[PropertyForRent] [char](1) NOT NULL,
	[PropertyOnView] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PropertyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PROPERTY] ON
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1100, N'PG16', N'5 Novar Drive', N'Johannesburg', N'2000', CAST(4450.00 AS Decimal(18, 2)), 4, CAST(0x0000000000000000 AS DateTime), 402, 600, 900, N'Y', N'N')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1101, N'PG4', N'6 Lawrence Street', N'Johannesburg', N'2000', CAST(3350.00 AS Decimal(18, 2)), 3, CAST(0x0000000000000000 AS DateTime), 404, 600, 900, N'N', N'Y')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1102, N'PG36', N'2 Manor Road', N'Johannesburg', N'2000', CAST(3375.00 AS Decimal(18, 2)), 5, CAST(0x0000000000000000 AS DateTime), 402, 600, 900, N'Y', N'N')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1103, N'PG21', N'18 Dale Road', N'Johannesburg', N'2000', CAST(6000.00 AS Decimal(18, 2)), 5, CAST(0x0000000000000000 AS DateTime), 404, 601, 900, N'Y', N'Y')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1104, N'PG77', N'100a Apple Lane', N'Johannesburg', N'2000', CAST(5600.00 AS Decimal(18, 2)), 6, CAST(0x0000000000000000 AS DateTime), 402, 601, 901, N'Y', N'N')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1105, N'PG81', N'781 Greentree Drive', N'Johannesburg', N'2000', CAST(4400.00 AS Decimal(18, 2)), 4, CAST(0x0000000000000000 AS DateTime), 404, 600, 901, N'N', N'Y')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1106, N'P7G', N'Jan Street', N'Somewhere', N'1234', CAST(2000.00 AS Decimal(18, 2)), 2, CAST(0x0000A1C0016BB4EE AS DateTime), 404, 604, NULL, N'Y', N'N')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1108, N'PG2', N'2 Novar Drive', N'Johannesburg', N'2000', CAST(4450.00 AS Decimal(18, 2)), 4, CAST(0x0000A1C0017880FE AS DateTime), 402, 600, NULL, N'Y', N'N')
INSERT [dbo].[PROPERTY] ([PropertyId], [PropertyNumber], [PropertyStreet], [PropertyCity], [PropertyPostCode], [PropertyRent], [PropertyRooms], [PropertyDateListed], [StaffId], [PropTypeId], [OwnerId], [PropertyForRent], [PropertyOnView]) VALUES (1109, N'P1', N'Back Street', N'Upington', N'8900', CAST(1000.00 AS Decimal(18, 2)), 2, CAST(0x0000A1C001889E8C AS DateTime), 400, 600, 900, N'Y', N'Y')
SET IDENTITY_INSERT [dbo].[PROPERTY] OFF
/****** Object:  StoredProcedure [dbo].[InsertStaff]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStaff] 
	
	@StaffNumber	varchar(5),
	@StaffTitle		varchar(5),
	@StaffLname		varchar(50),
	@StaffFname		varchar(50),
	@StaffGender	char(1),
	@StaffDOB		date,
	@StaffStartdate	date,
	@StaffSupervisor	int,
	@StaffClassId		int,
	@BranchId			int,
	@NewStaffId			int OUT
	
AS
BEGIN
	
	SET NOCOUNT ON;

    Insert into STAFF
    values(	@StaffNumber,
			@StaffTitle,
			@StaffLname,
			@StaffFname,
			@StaffGender,
			@StaffDOB,
			@StaffStartdate,
			@StaffSupervisor,
			@StaffClassId,
			@BranchId)
	set @NewStaffId = SCOPE_IDENTITY();
    
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBusiness]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBusiness] 
	
	@OwnerId	int,
	@BusName	varchar(50),
	@BusType	varchar(50),
	@BusContactLname	varchar(50),
	@BusContactFname	varchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update BUSINESS
	set 
	BusinessName=@BusName,
	BusinessType=@BusType,
	BusContactLname=@BusContactLname,
	BusContactFname=@BusContactFname
	where OwnerId = @OwnerId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBranchTelNumber]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBranchTelNumber] 
	
	@BranchTelId	int,
	@BranchAreaCode	char(3),
	@BranchTelNum	char(7),
	@BranchId		int
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update BRANCH_TEL_NUM
	set BranchAreaCode = @BranchAreaCode,BranchTelNum = @BranchTelNum
	where BranchTelId = @BranchTelId and BranchId = @BranchId
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateIndividual]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateIndividual] 
	
	@OwnerId	int,
	@IndividualLname varchar(50),
	@IndividualFname varchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update INDIVIDUAL
	set 
	IndividLname=@IndividualLname,
	IndividFname=@IndividualFname
	where OwnerId = @OwnerId
END
GO
/****** Object:  StoredProcedure [dbo].[InsertOwnerTelNumber]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOwnerTelNumber]
	
	@OwnerId	int,
	@OwnerAreaCode	char(3),
	@OwnerTelNum	char(7),
	@NewOwnerTelId	int OUT
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Insert into OWNER_TEL_NUM
	values(
	@OwnerId,
	@OwnerAreaCode,
	@OwnerTelNum)
	set @NewOwnerTelId = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStaff]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateStaff] 
	
	@StaffId int,
	@StaffNumber	varchar(5),
	@StaffTitle		varchar(5),
	@StaffLname		varchar(50),
	@StaffFname		varchar(50),
	@StaffGender	char(1),
	@StaffDOB		date,
	@StaffStartDate	date,
	@StaffSupervisor	int,
	@StaffClassId		int,
	@BranchId			int
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update STAFF
	set 
	StaffNumber=@StaffNumber,
	StaffTitle=@StaffTitle,
	StaffLname=@StaffLname,
	StaffFname=@StaffFname,
	StaffGender=@StaffGender,
	StaffDOB=@StaffDOB,
	StaffStartDate=@StaffStartDate,
	StaffSupervisor=@StaffSupervisor,
	StaffClassId=@StaffClassId,
	BranchId=@BranchId
	where StaffId = @StaffId
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOwnerTelNumber]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOwnerTelNumber]
	
	@OwnerTelId	int,
	@OwnerId	int,
	@OwnerAreaCode char(3),
	@OwnerTelNum	char(7)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update OWNER_TEL_NUM
	set 
	OwnerAreaCode=@OwnerAreaCode,
	OwnerTelNum=@OwnerTelNum
	where OwnerTelId = @OwnerTelId and OwnerId = @OwnerId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProperty]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProperty] 
	
	@PropertyId	int,
	@PropertyNumber varchar(5),
	@PropertyStreet	varchar(50),
	@PropertyCity	varchar(50),
	@PropertyPostCode varchar(5),
	@PropertyRent	decimal(18,2),
	@PropertyRooms	int,
	@PropertyDateListed datetime,
	@StaffId		int,
	@PropTypeId		int,
	@OwnerId		int,
	@PropertyForRent	char(1),
	@PropertyOnView		char(1)
	
	
AS
BEGIN

	SET NOCOUNT ON;
	
	Update PROPERTY
	set
	PropertyNumber=@PropertyNumber,
	PropertyStreet=@PropertyStreet,
	PropertyCity=@PropertyCity,
	PropertyPostCode=@PropertyPostCode,
	PropertyRent=@PropertyRent,
	PropertyRooms=@PropertyRooms,
	PropertyDateListed=@PropertyDateListed,
	StaffId=@StaffId,
	PropTypeId=@PropTypeId,
	OwnerId=@OwnerId,
	PropertyForRent=@PropertyForRent,
	PropertyOnView=@PropertyOnView
	where PropertyId = @PropertyId
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateClient]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateClient] 
	
	@ClientId	int,
	@ClientNumber	varchar(5),
	@ClientLname	varchar(50),
	@ClientFname	varchar(50),
	@DateRegistered	datetime,
	@StaffId		int
		
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update CLIENT
	set 
	ClientNumber=@ClientNumber,
	ClientLname=@ClientLname,
	ClientFname=@ClientFname,
	DateRegistered=@DateRegistered,
	StaffId=@StaffId
	where ClientId = @ClientId
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePropertySetPFRPOV]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePropertySetPFRPOV] 
	@PropertyId int,
	@PropertyForRent char(1),
	@PropertyOnView	char(1)
AS
BEGIN

	SET NOCOUNT ON;
	
	Update PROPERTY
	set PropertyForRent=@PropertyForRent,PropertyOnView=@PropertyOnView
	where PropertyId=@PropertyId
	
END
GO
/****** Object:  StoredProcedure [dbo].[ReportPropertiesForRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReportPropertiesForRent]
	@City varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select PROPERTY.PropertyNumber,PROPERTY.PropertyStreet,PROPERTY.PropertyCity,PROPERTY_TYPE.PropertyType,
		   PROPERTY.PropertyRooms,PROPERTY.PropertyRent
	from   PROPERTY join PROPERTY_TYPE on PROPERTY.PropTypeId = PROPERTY_TYPE.PropTypeId
	where  PropertyForRent = 'Y' and PropertyCity = @City
	
END
GO
/****** Object:  Table [dbo].[PROPERTY_ON_VIEW]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROPERTY_ON_VIEW](
	[PropertyId] [int] NOT NULL,
	[PropertyComments] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PropertyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PROPERTY_ON_VIEW] ([PropertyId], [PropertyComments]) VALUES (1101, N'')
INSERT [dbo].[PROPERTY_ON_VIEW] ([PropertyId], [PropertyComments]) VALUES (1103, N'')
INSERT [dbo].[PROPERTY_ON_VIEW] ([PropertyId], [PropertyComments]) VALUES (1105, N'')
INSERT [dbo].[PROPERTY_ON_VIEW] ([PropertyId], [PropertyComments]) VALUES (1109, N'')
/****** Object:  Table [dbo].[PROPERTY_FOR_RENT]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROPERTY_FOR_RENT](
	[PropertyId] [int] NOT NULL,
	[PropertyAvailableDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PropertyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PROPERTY_FOR_RENT] ([PropertyId], [PropertyAvailableDate]) VALUES (1100, CAST(0x0C370B00 AS Date))
INSERT [dbo].[PROPERTY_FOR_RENT] ([PropertyId], [PropertyAvailableDate]) VALUES (1102, CAST(0x2B370B00 AS Date))
INSERT [dbo].[PROPERTY_FOR_RENT] ([PropertyId], [PropertyAvailableDate]) VALUES (1103, CAST(0x2B370B00 AS Date))
INSERT [dbo].[PROPERTY_FOR_RENT] ([PropertyId], [PropertyAvailableDate]) VALUES (1104, CAST(0x49370B00 AS Date))
INSERT [dbo].[PROPERTY_FOR_RENT] ([PropertyId], [PropertyAvailableDate]) VALUES (1106, CAST(0x2A370B00 AS Date))
INSERT [dbo].[PROPERTY_FOR_RENT] ([PropertyId], [PropertyAvailableDate]) VALUES (1108, CAST(0x1C370B00 AS Date))
/****** Object:  Table [dbo].[PAYMENT]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT](
	[PaymentId] [int] IDENTITY(800,1) NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[PaymentAmount] [decimal](18, 2) NOT NULL,
	[ClientId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PAYMENT] ON
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (800, CAST(0x0000000000000000 AS DateTime), CAST(1000.00 AS Decimal(18, 2)), 500)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (801, CAST(0x0000A1BE0020E2EB AS DateTime), CAST(500.00 AS Decimal(18, 2)), 500)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (802, CAST(0x0000A1BE00211B5F AS DateTime), CAST(1000.00 AS Decimal(18, 2)), 502)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (803, CAST(0x0000A1BE00212A4A AS DateTime), CAST(500.00 AS Decimal(18, 2)), 502)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (804, CAST(0x0000A1BE002139FF AS DateTime), CAST(4000.00 AS Decimal(18, 2)), 501)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (805, CAST(0x0000A1B100000000 AS DateTime), CAST(500.00 AS Decimal(18, 2)), 503)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (806, CAST(0x0000A1BF00000000 AS DateTime), CAST(500.00 AS Decimal(18, 2)), 503)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (807, CAST(0x0000A1CD00000000 AS DateTime), CAST(1000.00 AS Decimal(18, 2)), 503)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (808, CAST(0x0000A1D000000000 AS DateTime), CAST(500.00 AS Decimal(18, 2)), 501)
INSERT [dbo].[PAYMENT] ([PaymentId], [PaymentDate], [PaymentAmount], [ClientId]) VALUES (809, CAST(0x0000A1BE012BB745 AS DateTime), CAST(2000.00 AS Decimal(18, 2)), 500)
SET IDENTITY_INSERT [dbo].[PAYMENT] OFF
/****** Object:  Table [dbo].[CLIENT_PREFERENCE]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENT_PREFERENCE](
	[ClientPrefId] [int] IDENTITY(700,1) NOT NULL,
	[ClientPrefMaxRent] [decimal](18, 2) NOT NULL,
	[ClientId] [int] NOT NULL,
	[PropTypeId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientPrefId] ASC,
	[ClientId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLIENT_PREFERENCE] ON
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (700, CAST(7500.00 AS Decimal(18, 2)), 500, 600)
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (701, CAST(5000.00 AS Decimal(18, 2)), 501, 600)
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (702, CAST(6000.00 AS Decimal(18, 2)), 502, 601)
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (703, CAST(5000.00 AS Decimal(18, 2)), 503, 600)
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (704, CAST(6000.00 AS Decimal(18, 2)), 504, 601)
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (707, CAST(7000.00 AS Decimal(18, 2)), 507, 601)
INSERT [dbo].[CLIENT_PREFERENCE] ([ClientPrefId], [ClientPrefMaxRent], [ClientId], [PropTypeId]) VALUES (708, CAST(5000.00 AS Decimal(18, 2)), 508, 601)
SET IDENTITY_INSERT [dbo].[CLIENT_PREFERENCE] OFF
/****** Object:  StoredProcedure [dbo].[GetAllPropertyForRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPropertyForRent]
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select PROPERTY.PropertyStreet,PROPERTY.PropertyCity,PROPERTY.PropertyRent,PROPERTY.PropertyRooms
	from PROPERTY
	where PropertyForRent = 'Y'
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllClients]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllClients] 
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select CLIENT.ClientNumber,CLIENT.ClientLname,CLIENT.ClientFname,CLIENT.DateRegistered
	from CLIENT
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertProperty]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertProperty]
	
	@PropertyNumber varchar(5),
	@Propertystreet	varchar(50),
	@PropertyCity	varchar(50),
	@PropertyPostCode	varchar(5),
	@Propertyrent		decimal(18,2),
	@PropertyRooms		varchar(10),
	@PropertyDateList	datetime,
	@StaffId			int,
	@PropTypeId			int,
	@OwnerId			int,
	@PropForRent		char(1),
	@PropOnView			char(1),
	@NewPropId			int output
	
AS
BEGIN
	
	SET NOCOUNT ON;
	if not exists(select * from PROPERTY where PropertyStreet=@Propertystreet and 
				  PropertyCity=@PropertyCity and PropertyPostCode=@PropertyPostCode)
	BEGIN
	Insert into PROPERTY
	values(
	@PropertyNumber,
	@Propertystreet,
	@PropertyCity,
	@PropertyPostCode,
	@Propertyrent,
	@PropertyRooms,
	@PropertyDateList,
	@StaffId,
	@PropTypeId,
	@OwnerId,
	@PropForRent,
	@PropOnView)
	set @NewPropId = SCOPE_IDENTITY()
	END
	else
		raiserror('Property already in database',16,1)
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertClient]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertClient] 
	
	@ClientNumber	varchar(5),
	@ClientLname	varchar(50),
	@ClientFname	varchar(50),
	@DateRegistered	date,
	@StaffId		int,
	@NewClientId	int output
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Insert into CLIENT
	values(
	@ClientNumber,
	@ClientLname,
	@ClientFname,
	@DateRegistered,
	@StaffId)
	set @NewClientId = SCOPE_IDENTITY()
    
END
GO
/****** Object:  StoredProcedure [dbo].[GetPropertyOnView]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPropertyOnView] 

AS
BEGIN

	SET NOCOUNT ON;
	
	select PROPERTY.PropertyId, PROPERTY.PropertyStreet, PROPERTY.PropertyCity from PROPERTY
	where PropertyOnView ='Y'
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetPropertyForRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPropertyForRent]

AS
BEGIN

	SET NOCOUNT ON;
	
	select PROPERTY.PropertyId,PROPERTY.PropertyStreet,PROPERTY.PropertyCity
	from PROPERTY
	where PropertyForRent = 'Y'
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetPropertyByCity]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPropertyByCity] 
	
	@City varchar(50),
	@ForRent char(1)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select PROPERTY.PropertyStreet,PROPERTY.PropertyCity,PROPERTY.PropertyRent,PROPERTY.PropertyRooms
	from PROPERTY
	where PropertyCity like @City + '%' and PropertyForRent=@ForRent
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteProperty]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteProperty] 
	@PropertyId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from PROPERTY
	where PropertyId = @PropertyId
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteClient]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteClient] 
	@ClientId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from CLIENT
	where ClientId = @ClientId
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePropOnView]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePropOnView] 
	@PropertyId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	delete from PROPERTY_ON_VIEW
	where PropertyId =@PropertyId
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePropertyForRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePropertyForRent] 
	@PropertyId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	delete from PROPERTY_FOR_RENT
	where PropertyId = @PropertyId
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertClientPreference]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertClientPreference] 
	
	@ClientPrefMaxRent	decimal(18,2),
	@ClientId			int,
	@PropTypeId			int,
	@NewClientPrefId		int OUT
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Insert into CLIENT_PREFERENCE
	values(
	@ClientPrefMaxRent,
	@ClientId,
	@PropTypeId)
    set @NewClientPrefId = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[GetClientMonthlyPayment]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientMonthlyPayment] 
	@ClientId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select SUM(PAYMENT.PaymentAmount)as TotalPayments from PAYMENT
	where  PAYMENT.ClientId = @ClientId and MONTH(PAYMENT.PaymentDate) = month(getdate())
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertPayment]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertPayment] 
	
	@PaymentDate	datetime,
	@PaymentAmount	decimal(18,2),
	@ClientId		int
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Insert into PAYMENT
	values(
	@PaymentDate,
	@PaymentAmount,
	@ClientId)
    
END
GO
/****** Object:  Table [dbo].[LEASE_AGREEMENT]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LEASE_AGREEMENT](
	[LeaseNumber] [int] IDENTITY(30000,1) NOT NULL,
	[LeaseStartDate] [date] NOT NULL,
	[LeaseExpiryDate] [date] NOT NULL,
	[LeasePaymentMethod] [varchar](20) NOT NULL,
	[LeaseDepositPaid] [char](1) NOT NULL,
	[ClientId] [int] NULL,
	[PropertyId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LeaseNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[LEASE_AGREEMENT] ON
INSERT [dbo].[LEASE_AGREEMENT] ([LeaseNumber], [LeaseStartDate], [LeaseExpiryDate], [LeasePaymentMethod], [LeaseDepositPaid], [ClientId], [PropertyId]) VALUES (30000, CAST(0xBE350B00 AS Date), CAST(0x2A370B00 AS Date), N'Cheque', N'Y', 500, 1100)
INSERT [dbo].[LEASE_AGREEMENT] ([LeaseNumber], [LeaseStartDate], [LeaseExpiryDate], [LeasePaymentMethod], [LeaseDepositPaid], [ClientId], [PropertyId]) VALUES (30009, CAST(0x19370B00 AS Date), CAST(0xCE380B00 AS Date), N'EFT', N'N', 501, 1102)
INSERT [dbo].[LEASE_AGREEMENT] ([LeaseNumber], [LeaseStartDate], [LeaseExpiryDate], [LeasePaymentMethod], [LeaseDepositPaid], [ClientId], [PropertyId]) VALUES (30011, CAST(0x1C370B00 AS Date), CAST(0x89380B00 AS Date), N'Cash', N'N', 503, 1104)
INSERT [dbo].[LEASE_AGREEMENT] ([LeaseNumber], [LeaseStartDate], [LeaseExpiryDate], [LeasePaymentMethod], [LeaseDepositPaid], [ClientId], [PropertyId]) VALUES (30012, CAST(0x1D370B00 AS Date), CAST(0x1D370B00 AS Date), N'EFT', N'Y', 507, 1106)
INSERT [dbo].[LEASE_AGREEMENT] ([LeaseNumber], [LeaseStartDate], [LeaseExpiryDate], [LeasePaymentMethod], [LeaseDepositPaid], [ClientId], [PropertyId]) VALUES (30013, CAST(0x9A360B00 AS Date), CAST(0x0F370B00 AS Date), N'EFT', N'N', 504, 1106)
SET IDENTITY_INSERT [dbo].[LEASE_AGREEMENT] OFF
/****** Object:  StoredProcedure [dbo].[InsertPropOnView]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertPropOnView]
	
	@PropertyId int,
	@PropertyComments varchar(500)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Insert into PROPERTY_ON_VIEW
	values(
	@PropertyId,
	@PropertyComments)

END
GO
/****** Object:  StoredProcedure [dbo].[InsertPropForRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertPropForRent] 
	
	@PropertyId int,
	@DateAvailable	date
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Insert into PROPERTY_FOR_RENT
	values(
	@PropertyId,
	@DateAvailable)
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateClientPreference]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateClientPreference] 
	
	@ClientPrefId	int,
	@ClientPrefMaxRent	decimal(18,2),
	@ClientId		int,
	@PropTypeId		int
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update CLIENT_PREFERENCE
	set 
	ClientPrefMaxRent=@ClientPrefMaxRent,
	PropTypeId=@PropTypeId
	where ClientPrefId = @ClientPrefId and ClientId = @ClientId	
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePropertyOnView]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePropertyOnView]
	
	@PropertyId	int,
	@PropertyComments varchar(500)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update PROPERTY_ON_VIEW
	set
	PropertyComments=@PropertyComments
	where PropertyId = @PropertyId
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePropertyMovePOV2PFR]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePropertyMovePOV2PFR]
	@PropertyId int,
	@AvailableDate date
AS
BEGIN
	
	SET NOCOUNT ON;
	
	if exists (select * from PROPERTY_FOR_RENT where PropertyId = @PropertyId)
		Begin
			update PROPERTY_FOR_RENT
			set PropertyId = @PropertyId,PropertyAvailableDate = @AvailableDate
		End
	else
		Begin
			If not exists (select * from PROPERTY_FOR_RENT where PropertyId=@PropertyId)
				Begin
					insert into PROPERTY_FOR_RENT
					values (@PropertyId,@AvailableDate)
				End
		End
	if exists (select * from PROPERTY_ON_VIEW where PropertyId = @PropertyId)
		Begin
			delete from PROPERTY_ON_VIEW where PropertyId = @PropertyId
		End
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePropertyMovePFR2POV]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePropertyMovePFR2POV] 
	@PropertyId int,
	@Comments varchar(500)
AS
BEGIN

	SET NOCOUNT ON;
	
	if exists(select * from PROPERTY_FOR_RENT where PropertyId = @PropertyId)
		Begin
			delete from PROPERTY_FOR_RENT where PropertyId = @PropertyId
		End
	if exists(select * from PROPERTY_ON_VIEW where PropertyId = @PropertyId)
		Begin
			update PROPERTY_ON_VIEW
			set PropertyComments=@Comments
			where PropertyId = @PropertyId
		End
	else
		Begin
			if not exists(select * from PROPERTY_ON_VIEW where PropertyId=@PropertyId)
				Begin
					insert into PROPERTY_ON_VIEW
					values (@PropertyId,@Comments)
				End
		End
	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePropertyForRent]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePropertyForRent] 
	
	@PropertyId	int,
	@PropertyAvailableDate	date
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update PROPERTY_FOR_RENT
	set 
	PropertyAvailableDate=@PropertyAvailableDate
	where PropertyId = @PropertyId
	
END
GO
/****** Object:  Table [dbo].[VIEW]    Script Date: 05/19/2013 14:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIEW](
	[ViewId] [int] IDENTITY(1200,1) NOT NULL,
	[ClientId] [int] NULL,
	[PropertyId] [int] NULL,
	[ViewDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ViewId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VIEW] ON
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1200, 501, 1101, CAST(0x12370B00 AS Date))
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1201, 502, 1101, CAST(0x13370B00 AS Date))
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1202, 503, 1101, CAST(0x15370B00 AS Date))
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1203, 504, 1101, CAST(0x17370B00 AS Date))
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1211, 504, 1101, CAST(0x18370B00 AS Date))
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1212, 504, 1105, CAST(0x1C370B00 AS Date))
INSERT [dbo].[VIEW] ([ViewId], [ClientId], [PropertyId], [ViewDate]) VALUES (1213, 502, 1103, CAST(0x1C370B00 AS Date))
SET IDENTITY_INSERT [dbo].[VIEW] OFF
/****** Object:  View [dbo].[vReportRental]    Script Date: 05/19/2013 14:58:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vReportRental]
AS
SELECT        dbo.PAYMENT.ClientId, dbo.CLIENT.ClientNumber, dbo.CLIENT.ClientLname, dbo.CLIENT.ClientFname, dbo.PROPERTY.PropertyRent, 
                         SUM(dbo.PAYMENT.PaymentAmount) AS TotalPayments
FROM            dbo.PAYMENT INNER JOIN
                         dbo.CLIENT ON dbo.PAYMENT.ClientId = dbo.CLIENT.ClientId INNER JOIN
                         dbo.LEASE_AGREEMENT ON dbo.CLIENT.ClientId = dbo.LEASE_AGREEMENT.ClientId INNER JOIN
                         dbo.PROPERTY_FOR_RENT ON dbo.LEASE_AGREEMENT.PropertyId = dbo.PROPERTY_FOR_RENT.PropertyId INNER JOIN
                         dbo.PROPERTY ON dbo.PROPERTY_FOR_RENT.PropertyId = dbo.PROPERTY.PropertyId
WHERE        (MONTH(dbo.PAYMENT.PaymentDate) = MONTH(GETDATE()))
GROUP BY dbo.PAYMENT.ClientId, dbo.CLIENT.ClientNumber, dbo.CLIENT.ClientLname, dbo.CLIENT.ClientFname, dbo.PROPERTY.PropertyRent
HAVING        (SUM(dbo.PAYMENT.PaymentAmount) < dbo.PROPERTY.PropertyRent)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PAYMENT"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENT"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 135
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LEASE_AGREEMENT"
            Begin Extent = 
               Top = 6
               Left = 464
               Bottom = 135
               Right = 671
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PROPERTY_FOR_RENT"
            Begin Extent = 
               Top = 138
               Left = 265
               Bottom = 233
               Right = 471
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PROPERTY"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vReportRental'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vReportRental'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vReportRental'
GO
/****** Object:  View [dbo].[vReportProperty]    Script Date: 05/19/2013 14:58:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vReportProperty]
AS
SELECT        TOP (100) PERCENT dbo.LEASE_AGREEMENT.LeaseNumber, dbo.LEASE_AGREEMENT.LeaseStartDate, dbo.LEASE_AGREEMENT.LeaseExpiryDate, 
                         dbo.PROPERTY.PropertyNumber, dbo.PROPERTY.PropertyStreet, dbo.PROPERTY.PropertyCity, dbo.PROPERTY.PropertyRent, dbo.PROPERTY.PropertyRooms
FROM            dbo.PROPERTY INNER JOIN
                         dbo.PROPERTY_FOR_RENT ON dbo.PROPERTY.PropertyId = dbo.PROPERTY_FOR_RENT.PropertyId RIGHT OUTER JOIN
                         dbo.LEASE_AGREEMENT ON dbo.PROPERTY_FOR_RENT.PropertyId = dbo.LEASE_AGREEMENT.PropertyId
ORDER BY dbo.LEASE_AGREEMENT.LeaseStartDate DESC
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[31] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PROPERTY"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LEASE_AGREEMENT"
            Begin Extent = 
               Top = 6
               Left = 265
               Bottom = 135
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PROPERTY_FOR_RENT"
            Begin Extent = 
               Top = 6
               Left = 510
               Bottom = 101
               Right = 716
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vReportProperty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vReportProperty'
GO
/****** Object:  StoredProcedure [dbo].[UpdateLeaseAgreement]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateLeaseAgreement] 
	
	@LeaseNumber	int,
	@LeaseStartDate date,
	@LeaseExpiryDate date,
	@PaymentMethod	varchar(20),
	@DepositPaid	char(1)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Update LEASE_AGREEMENT
	set
	LeaseStartDate = @LeaseStartDate,
	LeaseExpiryDate = @LeaseExpiryDate,
	LeasePaymentMethod=@PaymentMethod,
	LeaseDepositPaid=@DepositPaid
	where LeaseNumber = @LeaseNumber
END
GO
/****** Object:  StoredProcedure [dbo].[ReportOnClients]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReportOnClients]

AS
BEGIN

	SET NOCOUNT ON;
	select ClientNumber,ClientLname,ClientFname,DateRegistered
	from CLIENT left join LEASE_AGREEMENT on CLIENT.ClientId=LEASE_AGREEMENT.ClientId 
	where LEASE_AGREEMENT.LeaseNumber is null
END
GO
/****** Object:  StoredProcedure [dbo].[spNationalRealtors]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spNationalRealtors]
	
AS
BEGIN
	
	SET NOCOUNT ON;
	--Creating Tables
	CREATE TABLE BRANCH(
	BranchId		int primary key identity(100,1),
	BranchNumber	varchar(5)			NOT NULL,
	BranchStreet	varchar(50)			NOT NULL,
	BranchCity		varchar(50)			NOT NULL,
	BranchPostCode	varchar(5)			NOT NULL);
	CREATE UNIQUE INDEX UI_BranchNumber ON BRANCH(BranchNumber);
	CREATE INDEX I_BranchCity ON BRANCH(BranchCity);
	
	CREATE TABLE BRANCH_TEL_NUM(
	BranchTelId		int identity(200,1)	NOT NULL,
	BranchAreaCode	char(3)				NOT NULL,
	BranchTelNum	char(7)				NOT NULL,
	BranchId		int					NOT NULL,
	PRIMARY KEY (BranchTelId,BranchId),
	FOREIGN KEY (BranchId) REFERENCES BRANCH ON DELETE CASCADE);
	
	CREATE TABLE STAFF_CLASS(
	StaffClassId	int primary key identity(300,1),
	StaffPosition	varchar(50)			NOT NULL,
	StaffSalary		decimal(18,2)		NOT NULL,
	StaffBonus		decimal(18,2));
	CREATE UNIQUE INDEX UI_StaffPos ON STAFF_CLASS(StaffPosition);
	
	CREATE TABLE STAFF(
	StaffId		int primary key identity(400,1),
	StaffNumber	varchar(5)	NOT NULL,
	StaffTitle	varchar(5)	NOT NULL,
	StaffLname	varchar(50) NOT NULL,
	StaffFname	varchar(50) NOT NULL,
	StaffGender	char(1)		NOT NULL,
	StaffDOB	date		NOT NULL,
	StaffStartDate	date	NOT NULL,
	StaffSupervisor int,
	StaffClassId	int,
	BranchId		int,
	FOREIGN KEY (StaffSupervisor) REFERENCES STAFF(StaffId),
	FOREIGN KEY (StaffClassId) REFERENCES STAFF_CLASS(StaffClassId)ON DELETE SET NULL,
	FOREIGN KEY (BranchId) REFERENCES BRANCH(BranchId)ON DELETE SET NULL);
	CREATE UNIQUE INDEX UI_StaffNumber ON STAFF(StaffNumber);
	CREATE INDEX I_StaffLname ON STAFF(StaffLname);
	
	CREATE TABLE CLIENT(
	ClientId		int primary key identity(500,1),
	ClientNumber	varchar(5),
	ClientLname		varchar(50)	NOT NULL,
	ClientFname		varchar(50)	NOT NULL,
	DateRegistered	datetime	NOT NULL DEFAULT  GETDATE(),
	StaffId			int,
	FOREIGN KEY (StaffId) REFERENCES STAFF(StaffId)ON DELETE SET NULL);
	
	CREATE TABLE PROPERTY_TYPE(
	PropTypeId		int		primary key identity(600,1),
	PropertyType	varchar(50));
	
	CREATE TABLE CLIENT_PREFERENCE(
	ClientPrefId		int identity(700,1),
	ClientPrefMaxRent	decimal(18,2)		NOT NULL,
	ClientId			int			NOT NULL,
	PropTypeId			int			NOT NULL,
	PRIMARY KEY (ClientPrefId,ClientId),
	FOREIGN KEY (ClientId) REFERENCES CLIENT ON DELETE CASCADE);
	
	CREATE TABLE PAYMENT(
	PaymentId			int primary key identity(800,1),
	PaymentDate			datetime	NOT NULL DEFAULT  GETDATE(),
	PaymentAmount		decimal(18,2)		NOT NULL,
	ClientId			int,
	FOREIGN KEY (ClientId) REFERENCES CLIENT(ClientId));
	
	CREATE TABLE [OWNER](
	OwnerId			int primary key identity(900,1),
	OwnerNumber		varchar(5),
	OwnerStreet		varchar(50)	NOT NULL,
	OwnerCity		varchar(50) NOT NULL,
	OwnerPostCode	varchar(5)	NOT NULL,
	OwnerType		varchar(2)	NOT NULL);
	
	CREATE TABLE OWNER_TEL_NUM(
	OwnerTelId		int identity(1000,1),
	OwnerId			int		NOT NULL,
	OwnerAreaCode	char(3) NOT NULL,
	OwnerTelNum		char(7)	NOT NULL,
	PRIMARY KEY(OwnerTelId,OwnerId),
	FOREIGN KEY(OwnerId)REFERENCES [OWNER] ON DELETE CASCADE);
	
	CREATE TABLE INDIVIDUAL(
	OwnerId			int primary key,
	IndividLname	varchar(50)	NOT NULL,
	IndividFname	varchar(50)	NOT NULL,
	FOREIGN KEY (OwnerId) REFERENCES [OWNER](OwnerId) ON DELETE CASCADE);
	CREATE INDEX I_IndividLname ON INDIVIDUAL(IndividLname);
	
	CREATE TABLE BUSINESS(
	OwnerId			int primary key,
	BusinessName	varchar(50)	NOT NULL,
	BusinessType	varchar(50) NOT NULL,
	BusContactLname	varchar(50)	NOT NULL,
	BusContactFname	varchar(50)	NOT NULL,
	FOREIGN KEY (OwnerId) REFERENCES [OWNER](OwnerId) ON DELETE CASCADE);
	CREATE INDEX I_BusContactLname ON BUSINESS(BusContactLname);
	
	CREATE TABLE PROPERTY(
	PropertyId		int primary key identity(1100,1),
	PropertyNumber	varchar(5)		NOT NULL,
	PropertyStreet	varchar(50)		NOT NULL,
	PropertyCity	varchar(50)		NOT NULL,
	PropertyPostCode	varchar(5)	NOT NULL,
	PropertyRent		decimal(18,2)		NOT NULL,
	PropertyRooms		int			NOT NULL,
	PropertyDateListed	datetime	NOT NULL DEFAULT  GETDATE(),
	StaffId				int,
	PropTypeId			int,
	OwnerId				int,
	PropertyForRent		char(1)		NOT NULL,
	PropertyOnView		char(1)		NOT NULL,
	FOREIGN KEY (StaffId) REFERENCES STAFF(StaffId)ON DELETE SET NULL,
	FOREIGN KEY (PropTypeId)REFERENCES PROPERTY_TYPE(PropTypeId)ON DELETE SET NULL,
	FOREIGN KEY (OwnerId)REFERENCES [OWNER](OwnerId)ON DELETE SET NULL);
	CREATE UNIQUE INDEX UI_PropNumber ON PROPERTY(PropertyNumber);
	CREATE INDEX I_PropCity ON PROPERTY(PropertyCity);
	
	CREATE TABLE PROPERTY_ON_VIEW(
	PropertyId			int primary key,
	PropertyComments	varchar(500),
	FOREIGN KEY (PropertyId)REFERENCES PROPERTY ON DELETE CASCADE);
	
	CREATE TABLE [VIEW](
	ViewId	int primary key identity(1200,1),
	ClientId	int,
	PropertyId	int,
	ViewDate	date NOT NULL,
	FOREIGN KEY (ClientId)REFERENCES CLIENT(ClientId)ON DELETE CASCADE,
	FOREIGN KEY (PropertyId)REFERENCES PROPERTY_ON_VIEW(PropertyId)ON DELETE SET NULL);
	
	CREATE TABLE PROPERTY_FOR_RENT(
	PropertyId				int primary key,
	PropertyAvailableDate	date NOT NULL,
	FOREIGN KEY (PropertyId)REFERENCES PROPERTY ON DELETE CASCADE);
	
	CREATE TABLE LEASE_AGREEMENT(
	LeaseNumber			int primary key identity(30000,1),
	LeaseStartDate		date		NOT NULL,
	LeaseExpiryDate		date		NOT NULL,
	LeasePaymentMethod	varchar(20) NOT NULL,
	LeaseDepositPaid	char(1)		NOT NULL,
	ClientId			int,
	PropertyId			int,
	FOREIGN KEY(ClientId)REFERENCES CLIENT(ClientId)ON DELETE SET NULL,
	FOREIGN KEY(PropertyId)REFERENCES PROPERTY_FOR_RENT(PropertyId)ON DELETE SET NULL);
	
	--INSERT DATA
	--Branch
	Insert into BRANCH
	values('B003','163 Main Street','Johannesburg','2000')
	Insert into BRANCH
	values('B004','50 Roeland Street','Cape Town','8000')
	Insert into BRANCH
	values('B005','42 Musgrave Street','Durban','4000')
	Insert into BRANCH
	values('B006','6 Algoabay Street','Port Elizabeth','6000')
	--BranchTelNum
	Insert into BRANCH_TEL_NUM
	values('011','3392178',100)
	Insert into BRANCH_TEL_NUM
	values('011','3394439',100)
	Insert into BRANCH_TEL_NUM
	values('021','5912014',101)
	Insert into BRANCH_TEL_NUM
	values('031','7812718',102)
	Insert into BRANCH_TEL_NUM
	values('041','5813421',103)
	--StaffClass
	Insert into STAFF_CLASS
	values('Manager',24000.00,NULL)
	Insert into STAFF_CLASS
	values('Supervisor',16000.00,NULL)
	Insert into STAFF_CLASS
	values('Assistant',8000.00,NULL)
	Insert into STAFF_CLASS
	values('CEO',50000.00,NULL)
	--Staff
	Insert into STAFF
	values('SG5','Mrs','Brown','Susan','F','3-Jun-1960','1-Jun-2000',NULL,300,100)
	Insert into STAFF
	values('SG1','Mr','Masinga','Sam','M','15-Jan-1952','1-Jan-1998',NULL,303,100)
	Insert into STAFF
	values('SG14','Mr','Ford','David','M','16-Nov-1982','1-Nov-2001',NULL,301,100)
	Insert into STAFF
	values('SG37','Ms','Beech','Ann','F','22-Aug-1987','1-Jun-2006',402,302,100)
	Insert into STAFF
	values('SG112','Mrs','Longhorn','Annette','F','8-Apr-1975','1-May-2000',NULL,301,100)
	Insert into STAFF
	values('SG126','Mr','Lawrence','Chris','M','7-Jun-1978','1-Dec-2003',404,302,100)
	--Client
	Insert into CLIENT
	values('CR74','Smith','Mike','',403)
	Insert into CLIENT
	values('CR76','Kay','John','',405)
	Insert into CLIENT
	values('CR56','Stewart','Aline','',403)
	Insert into CLIENT
	values('CR75','Ritchie','Mike','',405)
	Insert into CLIENT
	values('CR62','Tregear','Mary','',403)
	--PropertyType
	Insert into PROPERTY_TYPE
	values('Flat')
	Insert into PROPERTY_TYPE
	values('House')
	--ClientPreference
	Insert into CLIENT_PREFERENCE
	values(7500.00,500,600)
	Insert into CLIENT_PREFERENCE
	values(5000.00,501,600)
	Insert into CLIENT_PREFERENCE
	values(6000.00,502,601)
	Insert into CLIENT_PREFERENCE
	values(5000.00,503,600)
	Insert into CLIENT_PREFERENCE
	values(6000.00,504,601)
	--Payment
	Insert into PAYMENT
	values('',1000.00,500)
	--Owner
	Insert into [OWNER]
	values('C093','12 Park Drive','Johannesburg','2000','I')
	Insert into INDIVIDUAL
	values(900,'Shaw','Tony')
	Insert into [OWNER]
	values('C094','102 Aloe Drive','Johannesburg','2000','B')
	Insert into BUSINESS
	values(901,'Hoffmann,Inc.','Corporate','Hoffmann','Roahn')
	--OwnerTelNum
	Insert into OWNER_TEL_NUM
	values(900,'011','2257025')
	Insert into OWNER_TEL_NUM
	values(901,'011','5817025')
	--Property
	Insert into PROPERTY
	values('PG16','5 Novar Drive','Johannesburg','2000',4450.00,4,'',402,600,900,'Y','N')
	Insert into PROPERTY_FOR_RENT
	values(1100,'1-May-2013')
	
	Insert into PROPERTY
	values('PG4','6 Lawrence Street','Johannesburg','2000',3350.00,3,'',404,600,900,'N','Y')
	Insert into PROPERTY_ON_VIEW
	values(1101,NULL)
	
	Insert into PROPERTY
	values('PG36','2 Manor Road','Johannesburg','2000',3375.00,5,'',402,600,900,'Y','N')
	Insert into PROPERTY_FOR_RENT
	values(1102,'1-Jun-2013')
	
	Insert into PROPERTY
	values('PG21','18 Dale Road','Johannesburg','2000',6000.00,5,'',404,601,900,'Y','Y')
	Insert into PROPERTY_FOR_RENT
	values(1103,'1-Jun-2013')
	Insert into PROPERTY_ON_VIEW
	values(1103,NULL)
	
	Insert into PROPERTY
	values('PG77','100a Apple Lane','Johannesburg','2000',5600.00,6,'',402,601,901,'Y','N')
	Insert into PROPERTY_FOR_RENT
	values(1104,'1-Jul-2013')
	
	Insert into PROPERTY
	values('PG81','781 Greentree Drive','Johannesburg','2000',4400.00,4,'',404,600,901,'N','Y')
	Insert into PROPERTY_ON_VIEW
	values(1105,NULL)
	--View
	Insert into [VIEW]
	values(501,1101,'07-May-2013')
	Insert into [VIEW]
	values(502,1101,'08-May-2013')
	Insert into [VIEW]
	values(503,1101,'10-May-2013')
	Insert into [VIEW]
	values(504,1101,'12-May-2013')
	--LeaseAgreement
	insert into LEASE_AGREEMENT
	values('1-Jun-2012','31-May-2013','Cheque','Y',500,1100)
END
GO
/****** Object:  StoredProcedure [dbo].[ReportRentalDistribution]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReportRentalDistribution] 
	@City varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select PROPERTY.PropertyNumber,PROPERTY.PropertyStreet,PROPERTY.PropertyCity,LEASE_AGREEMENT.PropertyId
	from PROPERTY join PROPERTY_FOR_RENT on PROPERTY.PropertyId=PROPERTY_FOR_RENT.PropertyId
	join LEASE_AGREEMENT on PROPERTY_FOR_RENT.PropertyId=LEASE_AGREEMENT.PropertyId
	where PropertyCity = @City
END
GO
/****** Object:  StoredProcedure [dbo].[ReportRental]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReportRental] 
	
AS
BEGIN
	
	SET NOCOUNT ON;
	select PAYMENT.ClientId,CLIENT.ClientNumber,CLIENT.ClientLname,CLIENT.ClientFname,PROPERTY.PropertyRent,SUM(PAYMENT.PaymentAmount)
	from PAYMENT join CLIENT on PAYMENT.ClientId=CLIENT.ClientId join LEASE_AGREEMENT on CLIENT.ClientId=LEASE_AGREEMENT.ClientId
	 join PROPERTY_FOR_RENT on LEASE_AGREEMENT.PropertyId=PROPERTY_FOR_RENT.PropertyId
	 join PROPERTY on PROPERTY_FOR_RENT.PropertyId=PROPERTY.PropertyId
	where MONTH(PAYMENT.PaymentDate) = month(getdate())
	group by PAYMENT.ClientId,ClientNumber,ClientLname,ClientFname,PropertyRent
	having (SUM(PaymentAmount)<PROPERTY.PropertyRent)
END
GO
/****** Object:  StoredProcedure [dbo].[ReportPropertyViewings]    Script Date: 05/19/2013 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReportPropertyViewings]
	@PropertyId int
AS
BEGIN

	SET NOCOUNT ON;
	select CLIENT.ClientNumber,
		   CLIENT.ClientLname,
		   CLIENT.ClientFname,
		   [VIEW].ViewDate,
		   PROPERTY_ON_VIEW.PropertyComments,
		   PROPERTY.PropertyNumber,
		   PROPERTY.PropertyRent,
		   PROPERTY.PropertyStreet,
		   PROPERTY.PropertyCity,
		   PROPERTY_TYPE.PropertyType
	from CLIENT
		 join [VIEW] on CLIENT.ClientId = [VIEW].ClientId
		 join PROPERTY_ON_VIEW on [VIEW].PropertyId = PROPERTY_ON_VIEW.PropertyId 
		 join PROPERTY on PROPERTY_ON_VIEW.PropertyId=PROPERTY.PropertyId
		 join PROPERTY_TYPE on PROPERTY.PropTypeId=PROPERTY_TYPE.PropTypeId
	where [VIEW].PropertyId = @PropertyId

END
GO
/****** Object:  StoredProcedure [dbo].[ReportProperty]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReportProperty] 
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select LEASE_AGREEMENT.LeaseNumber,LEASE_AGREEMENT.LeaseStartDate,LEASE_AGREEMENT.LeaseExpiryDate,PROPERTY.PropertyNumber,PROPERTY.PropertyStreet,PROPERTY.PropertyCity,PROPERTY.PropertyRent,PROPERTY.PropertyRooms
	from   PROPERTY join PROPERTY_FOR_RENT on PROPERTY.PropertyId=PROPERTY_FOR_RENT.PropertyId
		   right join LEASE_AGREEMENT on PROPERTY_FOR_RENT.PropertyId=LEASE_AGREEMENT.PropertyId 
	order by LeaseStartDate DESC
	
END
GO
/****** Object:  StoredProcedure [dbo].[InsertView]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertView]
	
	@ClientId	int,
	@PropertyId	int,
	@ViewDate	date
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Insert into [VIEW]
	values(
	@ClientId,
	@PropertyId,
	@ViewDate)
    
END
GO
/****** Object:  StoredProcedure [dbo].[InsertLease]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertLease]
	
	@StartDate	date,
	@ExpiryDate	date,
	@PaymentMethod	varchar(20),
	@DepositPaid	char(1),
	@ClientId		int,
	@PropertyId		int,
	@NewLeaseNumber int OUT
	
AS
BEGIN
	
	SET NOCOUNT ON;

	Insert into LEASE_AGREEMENT
	values(
	@StartDate,
	@ExpiryDate,
	@PaymentMethod,
	@DepositPaid,
	@ClientId,
	@PropertyId)
	set @NewLeaseNumber = SCOPE_IDENTITY();
    
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteView]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteView] 
	@ViewId	int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from [VIEW]
	where ViewId = @ViewId
END
GO
/****** Object:  StoredProcedure [dbo].[GetClientsWTR]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientsWTR]
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select ClientNumber,ClientLname,ClientFname,DateRegistered,ClientPrefMaxRent,PropertyType 
	from CLIENT join CLIENT_PREFERENCE on CLIENT.ClientId=CLIENT_PREFERENCE.ClientId
	join PROPERTY_TYPE on CLIENT_PREFERENCE.PropTypeId=PROPERTY_TYPE.PropTypeId
	left join LEASE_AGREEMENT on CLIENT.ClientId=LEASE_AGREEMENT.ClientId
	where LEASE_AGREEMENT.LeaseNumber is null
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetClientsWishingToRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientsWishingToRent] 
	@ClientId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	if not exists (select * from LEASE_AGREEMENT where LEASE_AGREEMENT.ClientId=@ClientId)
	Begin
		select CLIENT.ClientLname,CLIENT.ClientFname
		from CLIENT
		where ClientId=@ClientId
	End
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetClientMonthlyRent]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientMonthlyRent]
	@ClientId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	select	PROPERTY.PropertyRent
	from	CLIENT join LEASE_AGREEMENT on CLIENT.ClientId = LEASE_AGREEMENT.ClientId
		join PROPERTY_FOR_RENT on LEASE_AGREEMENT.PropertyId = PROPERTY_FOR_RENT.PropertyId 
		join PROPERTY on PROPERTY_FOR_RENT.PropertyId = PROPERTY.PropertyId
	where	CLIENT.ClientId = @ClientId
	
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteLeaseAgreement]    Script Date: 05/19/2013 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteLeaseAgreement]
	@LeaseNumber int
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete from LEASE_AGREEMENT
	where LeaseNumber = @LeaseNumber
	
END
GO
/****** Object:  Default [DF__CLIENT__DateRegi__0AA882D3]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[CLIENT] ADD  DEFAULT (getdate()) FOR [DateRegistered]
GO
/****** Object:  Default [DF__PAYMENT__Payment__18F6A22A]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PAYMENT] ADD  DEFAULT (getdate()) FOR [PaymentDate]
GO
/****** Object:  Default [DF__PROPERTY__Proper__30CE2BBB]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PROPERTY] ADD  DEFAULT (getdate()) FOR [PropertyDateListed]
GO
/****** Object:  ForeignKey [FK__BRANCH_TE__Branc__7B663F43]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[BRANCH_TEL_NUM]  WITH CHECK ADD FOREIGN KEY([BranchId])
REFERENCES [dbo].[BRANCH] ([BranchId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__BUSINESS__OwnerI__2C09769E]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[BUSINESS]  WITH CHECK ADD FOREIGN KEY([OwnerId])
REFERENCES [dbo].[OWNER] ([OwnerId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__CLIENT__StaffId__0B9CA70C]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[CLIENT]  WITH CHECK ADD FOREIGN KEY([StaffId])
REFERENCES [dbo].[STAFF] ([StaffId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__CLIENT_PR__Clien__1431ED0D]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[CLIENT_PREFERENCE]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[CLIENT] ([ClientId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__INDIVIDUA__Owner__2744C181]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[INDIVIDUAL]  WITH CHECK ADD FOREIGN KEY([OwnerId])
REFERENCES [dbo].[OWNER] ([OwnerId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__LEASE_AGR__Clien__47B19113]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[LEASE_AGREEMENT]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[CLIENT] ([ClientId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__LEASE_AGR__Prope__48A5B54C]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[LEASE_AGREEMENT]  WITH CHECK ADD FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PROPERTY_FOR_RENT] ([PropertyId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__OWNER_TEL__Owner__22800C64]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[OWNER_TEL_NUM]  WITH CHECK ADD FOREIGN KEY([OwnerId])
REFERENCES [dbo].[OWNER] ([OwnerId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__PAYMENT__ClientI__19EAC663]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PAYMENT]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[CLIENT] ([ClientId])
GO
/****** Object:  ForeignKey [FK__PROPERTY__OwnerI__33AA9866]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PROPERTY]  WITH CHECK ADD FOREIGN KEY([OwnerId])
REFERENCES [dbo].[OWNER] ([OwnerId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__PROPERTY__PropTy__32B6742D]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PROPERTY]  WITH CHECK ADD FOREIGN KEY([PropTypeId])
REFERENCES [dbo].[PROPERTY_TYPE] ([PropTypeId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__PROPERTY__StaffI__31C24FF4]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PROPERTY]  WITH CHECK ADD FOREIGN KEY([StaffId])
REFERENCES [dbo].[STAFF] ([StaffId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__PROPERTY___Prope__42ECDBF6]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PROPERTY_FOR_RENT]  WITH CHECK ADD FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PROPERTY] ([PropertyId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__PROPERTY___Prope__386F4D83]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[PROPERTY_ON_VIEW]  WITH CHECK ADD FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PROPERTY] ([PropertyId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__STAFF__BranchId__05E3CDB6]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD FOREIGN KEY([BranchId])
REFERENCES [dbo].[BRANCH] ([BranchId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__STAFF__StaffClas__04EFA97D]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD FOREIGN KEY([StaffClassId])
REFERENCES [dbo].[STAFF_CLASS] ([StaffClassId])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__STAFF__StaffSupe__03FB8544]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD FOREIGN KEY([StaffSupervisor])
REFERENCES [dbo].[STAFF] ([StaffId])
GO
/****** Object:  ForeignKey [FK__VIEW__ClientId__3D3402A0]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[VIEW]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[CLIENT] ([ClientId])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__VIEW__PropertyId__3E2826D9]    Script Date: 05/19/2013 14:58:48 ******/
ALTER TABLE [dbo].[VIEW]  WITH CHECK ADD FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PROPERTY_ON_VIEW] ([PropertyId])
ON DELETE SET NULL
GO
