USE [Personnel]
GO
/****** Object:  Table [mmcconnell].[Employee]    Script Date: 8/12/2021 10:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
DROP TABLE [mmcconnell].[EmployeeRole];
DROP TABLE [mmcconnell].[Employee];
DROP TABLE [mmcconnell].[Role];

CREATE TABLE [mmcconnell].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[ManagerID] [int] NULL,
	[EmployeeCode] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[CreatedOn] [DATETIME] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [mmcconnell].[EmployeeRole]    Script Date: 8/12/2021 10:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mmcconnell].[EmployeeRole](
	[EmployeeID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	 CONSTRAINT [PK_EmployeeRole] PRIMARY KEY CLUSTERED 
(
[EmployeeID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [mmcconnell].[Role]    Script Date: 8/12/2021 10:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [mmcconnell].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [mmcconnell].[Employee] ON 

GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode], [FirstName], [LastName], [CreatedOn]) VALUES (1,NULL, N'JWells', N'Jeffrey', N'Wells', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (2, 1, N'VAtkins', N'Victor', N'Atkins', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (3, 1, N'KHamilton', N'Kelli', N'Hamilton', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (4, 2, N'ABraun', N'Adam', N'Braun', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (5, 2, N'BCruz', N'Brian', N'Cruz', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (6, 2, N'KFloyd', N'Kristin', N'Floyd', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (7, 3, N'LMartinez', N'Lois', N'Martinez', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID],[EmployeeCode], [FirstName], [LastName], [CreatedOn]) VALUES (8, 3, N'MLind', N'Michael', N'Lind', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (9, 3, N'EBay', N'Eric', N'Bay', GETDATE())
GO
INSERT [mmcconnell].[Employee] ([EmployeeID], [ManagerID], [EmployeeCode],[FirstName], [LastName], [CreatedOn]) VALUES (10, 3, N'BYoung', N'Brandon', N'Young', GETDATE())
GO
SET IDENTITY_INSERT [mmcconnell].[Employee] OFF
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (1, 1)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (2, 1)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (3, 1)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (4, 3)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (4, 5)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (5, 4)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (6, 2)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (6, 6)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (7, 5)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (8, 6)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (9, 2)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (9, 3)
GO
INSERT [mmcconnell].[EmployeeRole] ([EmployeeID], [RoleID]) VALUES (10, 4)
GO
SET IDENTITY_INSERT [mmcconnell].[Role] ON 

GO
INSERT [mmcconnell].[Role] ([RoleID], [Description]) VALUES (1, N'Director')
GO
INSERT [mmcconnell].[Role] ([RoleID], [Description]) VALUES (2, N'Sales')
GO
INSERT [mmcconnell].[Role] ([RoleID], [Description]) VALUES (3, N'IT')
GO
INSERT [mmcconnell].[Role] ([RoleID], [Description]) VALUES (4, N'Accounting')
GO
INSERT [mmcconnell].[Role] ([RoleID], [Description]) VALUES (5, N'Support')
GO
INSERT [mmcconnell].[Role] ([RoleID], [Description]) VALUES (6, N'Analyst')
GO
SET IDENTITY_INSERT [mmcconnell].[Role] OFF
GO
ALTER TABLE [mmcconnell].[EmployeeRole]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeRole_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [mmcconnell].[Employee] ([EmployeeID])
GO
ALTER TABLE [mmcconnell].[EmployeeRole] CHECK CONSTRAINT [FK_EmployeeRole_Employee]
GO
ALTER TABLE [mmcconnell].[EmployeeRole]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeRole_Role] FOREIGN KEY([RoleID])
REFERENCES [mmcconnell].[Role] ([RoleID])
GO
ALTER TABLE [mmcconnell].[EmployeeRole] CHECK CONSTRAINT [FK_EmployeeRole_Role]
GO
