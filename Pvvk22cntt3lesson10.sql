USE [PvvK22cntt3lesson10]
GO
/****** Object:  Table [dbo].[PvvAccount]    Script Date: 03/07/2024 9:13:02 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PvvAccount](
	[PvvID] [int] NOT NULL,
	[PvvUsersName] [nvarchar](50) NULL,
	[PvvPassword] [nvarchar](50) NULL,
	[PvvFullName] [nvarchar](50) NULL,
	[PvvEmail] [nvarchar](50) NULL,
	[PvvPhone] [nvarchar](50) NULL,
	[PvvActive] [bit] NULL,
 CONSTRAINT [PK_PvvAccount] PRIMARY KEY CLUSTERED 
(
	[PvvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PvvAccount] ([PvvID], [PvvUsersName], [PvvPassword], [PvvFullName], [PvvEmail], [PvvPhone], [PvvActive]) VALUES (1, N'PhanVuong ', N'12345', N'phan viet vượng', N'phanvuong0601@gmail.com', N'0123456789', 1)
GO
