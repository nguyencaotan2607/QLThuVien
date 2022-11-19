USE [QLThuVien]
GO
/****** Object:  Table [dbo].[CTPM]    Script Date: 9/29/2021 9:26:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPM](
	[Maphieu] [varchar](10) NOT NULL,
	[Manv] [varchar](10) NOT NULL,
	[Madg] [varchar](10) NOT NULL,
	[Masach] [varchar](10) NOT NULL,
	[Ngaylapphieu] [datetime] NULL,
 CONSTRAINT [pk_CTPM] PRIMARY KEY CLUSTERED 
(
	[Maphieu] ASC,
	[Manv] ASC,
	[Madg] ASC,
	[Masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docgia]    Script Date: 9/29/2021 9:26:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docgia](
	[Madg] [varchar](10) NOT NULL,
	[Tendg] [nvarchar](50) NULL,
	[Namsinh] [date] NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Lop] [nvarchar](50) NULL,
	[Ngaytaothe] [date] NULL,
	[Manv] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Madg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 9/29/2021 9:26:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manv] [varchar](10) NOT NULL,
	[Tennv] [nvarchar](50) NULL,
	[Namsinh] [datetime] NULL,
	[Gioitinh] [varchar](4) NULL,
	[Diachi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[Ngaylamviec] [datetime] NULL,
	[Tk] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieumuon]    Script Date: 9/29/2021 9:26:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieumuon](
	[Maphieu] [varchar](10) NOT NULL,
	[Manv] [varchar](10) NULL,
	[Ngaylapphieu] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 9/29/2021 9:26:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Masach] [varchar](10) NOT NULL,
	[Tensach] [nvarchar](50) NULL,
	[Loaisach] [nvarchar](50) NULL,
	[Linhvuc] [nvarchar](50) NULL,
	[Tacgia] [nvarchar](50) NULL,
	[NXB] [nvarchar](50) NULL,
	[Ngayxuatban] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 9/29/2021 9:26:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[Tk] [nvarchar](50) NOT NULL,
	[Mk] [nvarchar](50) NULL,
	[loai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Docgia] ([Madg], [Tendg], [Namsinh], [Gioitinh], [Diachi], [Lop], [Ngaytaothe], [Manv]) VALUES (N'123', N'sssss1ds', CAST(N'2021-09-29' AS Date), N'dsadaád', N'dsdsdsa', N'dsdsadsa', CAST(N'2021-09-13' AS Date), N'2')
GO
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Namsinh], [Gioitinh], [Diachi], [SDT], [Ngaylamviec], [Tk]) VALUES (N'1', N'thoai', CAST(N'2021-09-28T00:00:00.000' AS DateTime), N'Nam', N'HCM', N'3123443434', CAST(N'2021-09-28T00:00:00.000' AS DateTime), N'admin1')
GO
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Namsinh], [Gioitinh], [Diachi], [SDT], [Ngaylamviec], [Tk]) VALUES (N'2', N'quangg', CAST(N'2021-09-28T00:00:00.000' AS DateTime), N'Nam', N'HN', N'1235123124', CAST(N'2021-09-28T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'', N'', N'ew', N'ư', N'', N'd', CAST(N'2021-09-29T14:43:42.243' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'1', N'ksksks', N'ew', N'ư', N's', N'd', CAST(N'2021-09-28T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'2', N'ewew', N'g', N'e', N'x', N'g', CAST(N'2021-09-28T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'3', N'trtrtr', N'd', N'a', N'g', N'v', CAST(N'2021-09-28T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'4', N'a', N'ew', N'ư', N'a', N'd', CAST(N'2021-09-14T14:42:53.000' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'5', N'a', N'ew', N'ư', N'a', N'd', CAST(N'2021-09-14T14:42:53.000' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'6', N'a', N'ew', N'ư', N'a', N'd', CAST(N'2021-09-29T14:42:53.000' AS DateTime))
GO
INSERT [dbo].[Sach] ([Masach], [Tensach], [Loaisach], [Linhvuc], [Tacgia], [NXB], [Ngayxuatban]) VALUES (N'77', N'qưeq', N'ew', N'ư', N's', N'd', CAST(N'2021-09-28T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Taikhoan] ([Tk], [Mk], [loai]) VALUES (N'admin1', N'123456', N'admin')
GO
INSERT [dbo].[Taikhoan] ([Tk], [Mk], [loai]) VALUES (N'nhanvien1', N'123456', N'nhanvien')
GO
ALTER TABLE [dbo].[Taikhoan] ADD  CONSTRAINT [DF_Taikhoan_Tk]  DEFAULT (N'nhanvien') FOR [Tk]
GO
ALTER TABLE [dbo].[Taikhoan] ADD  CONSTRAINT [defaultloai]  DEFAULT (N'nhanvien') FOR [loai]
GO
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([Madg])
REFERENCES [dbo].[Docgia] ([Madg])
GO
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([Maphieu])
REFERENCES [dbo].[Phieumuon] ([Maphieu])
GO
ALTER TABLE [dbo].[CTPM]  WITH CHECK ADD FOREIGN KEY([Masach])
REFERENCES [dbo].[Sach] ([Masach])
GO
ALTER TABLE [dbo].[Docgia]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Taikhoan] FOREIGN KEY([Tk])
REFERENCES [dbo].[Taikhoan] ([Tk])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Taikhoan]
GO
ALTER TABLE [dbo].[Phieumuon]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
