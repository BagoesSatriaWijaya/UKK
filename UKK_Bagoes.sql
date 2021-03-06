USE [master]
GO
/****** Object:  Database [db_UKK_Bagoes]    Script Date: 06/04/2021 16:32:18 ******/
CREATE DATABASE [db_UKK_Bagoes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_UKK_Bagoes', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_UKK_Bagoes.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_UKK_Bagoes_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_UKK_Bagoes_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_UKK_Bagoes] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_UKK_Bagoes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_UKK_Bagoes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_UKK_Bagoes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_UKK_Bagoes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_UKK_Bagoes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_UKK_Bagoes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_UKK_Bagoes] SET  MULTI_USER 
GO
ALTER DATABASE [db_UKK_Bagoes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_UKK_Bagoes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_UKK_Bagoes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_UKK_Bagoes] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_UKK_Bagoes] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_UKK_Bagoes]
GO
/****** Object:  Table [dbo].[tb_detail_transaksi]    Script Date: 06/04/2021 16:32:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_detail_transaksi](
	[id_detail] [char](10) NOT NULL,
	[id_transaksi] [char](10) NULL,
	[id_paket] [char](10) NULL,
	[jumlah] [int] NULL,
	[total] [int] NULL,
	[keterangan] [text] NULL,
 CONSTRAINT [PK_tb_detail_transaksi] PRIMARY KEY CLUSTERED 
(
	[id_detail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_member]    Script Date: 06/04/2021 16:32:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_member](
	[id_member] [char](10) NOT NULL,
	[nama] [varchar](30) NULL,
	[alamat] [varchar](50) NULL,
	[jenis_kelamin] [char](12) NULL,
	[telp] [varchar](15) NULL,
 CONSTRAINT [PK_tb_member] PRIMARY KEY CLUSTERED 
(
	[id_member] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_outlet]    Script Date: 06/04/2021 16:32:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_outlet](
	[id_outlet] [char](10) NOT NULL,
	[nama] [varchar](100) NULL,
	[alamat] [text] NULL,
	[telp] [varchar](15) NULL,
 CONSTRAINT [PK_tb_outlet] PRIMARY KEY CLUSTERED 
(
	[id_outlet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_paket]    Script Date: 06/04/2021 16:32:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_paket](
	[id_paket] [char](10) NOT NULL,
	[id_outlet] [char](10) NULL,
	[jenis] [varchar](30) NULL,
	[nama_paket] [varchar](30) NULL,
	[harga] [int] NULL,
 CONSTRAINT [PK_tb_paket] PRIMARY KEY CLUSTERED 
(
	[id_paket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_transaksi]    Script Date: 06/04/2021 16:32:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_transaksi](
	[id_transaksi] [char](10) NOT NULL,
	[id_outlet] [char](10) NULL,
	[kode_invoice] [varchar](100) NULL,
	[id_member] [char](10) NULL,
	[tgl] [varchar](50) NULL,
	[batas_waktu] [varchar](50) NULL,
	[tgl_bayar] [varchar](50) NULL,
	[biaya_tambahan] [int] NULL,
	[diskon] [int] NULL,
	[pajak] [int] NULL,
	[status] [varchar](20) NULL,
	[dibayar] [varchar](20) NULL,
	[id_user] [char](10) NULL,
 CONSTRAINT [PK_tb_transaksi] PRIMARY KEY CLUSTERED 
(
	[id_transaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 06/04/2021 16:32:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[id_user] [char](10) NOT NULL,
	[nama] [varchar](100) NULL,
	[username] [varchar](30) NULL,
	[password] [varchar](100) NULL,
	[id_outlet] [char](10) NULL,
	[role] [varchar](10) NULL,
 CONSTRAINT [PK_tb_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-01     ', N'TR-03     ', N'PK-02     ', 2, 29794, N'Sepatu Sekolah')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-02     ', N'TR-05     ', N'PK-02     ', 2, 30694, N'Laundry')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-03     ', N'TR-01     ', N'PK-02     ', 2, 28785, N'Sepatu Nike')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-04     ', N'TR-02     ', N'PK-03     ', 5, 120038, N'Jas Tuxedo')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-05     ', N'TR-04     ', N'PK-01     ', 3, 60600, N'Seragam Kerja')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-06     ', N'TR-06     ', N'PK-02     ', 3, 47450, N'-')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-07     ', N'TR-07     ', N'PK-01     ', 2, 61000, N'Cuci Laundry')
INSERT [dbo].[tb_detail_transaksi] ([id_detail], [id_transaksi], [id_paket], [jumlah], [total], [keterangan]) VALUES (N'DT-08     ', N'TR-08     ', N'PK-04     ', 5, 101000, N'Cuci Kiloan')
INSERT [dbo].[tb_member] ([id_member], [nama], [alamat], [jenis_kelamin], [telp]) VALUES (N'MB-01     ', N'Saifudin', N'Jl. Nangka Besar', N'Laki Laki   ', N'082716283612')
INSERT [dbo].[tb_member] ([id_member], [nama], [alamat], [jenis_kelamin], [telp]) VALUES (N'MB-02     ', N'Silvia', N'Jl. Udang 1', N'Perempuan   ', N'087626182017')
INSERT [dbo].[tb_member] ([id_member], [nama], [alamat], [jenis_kelamin], [telp]) VALUES (N'MB-03     ', N'Nandar', N'Jl. Baru 8', N'Laki Laki   ', N'086281937288')
INSERT [dbo].[tb_member] ([id_member], [nama], [alamat], [jenis_kelamin], [telp]) VALUES (N'MB-04     ', N'Filsia Fitri', N'Jl. Timbun Ujung', N'Perempuan   ', N'082638261871')
INSERT [dbo].[tb_member] ([id_member], [nama], [alamat], [jenis_kelamin], [telp]) VALUES (N'MB-05     ', N'Lisa Viola', N'Jl. Piano 29', N'Perempuan   ', N'086293017381')
INSERT [dbo].[tb_member] ([id_member], [nama], [alamat], [jenis_kelamin], [telp]) VALUES (N'MB-06     ', N'Husein', N'Jl. Baru 4', N'Laki Laki   ', N'082719273912')
INSERT [dbo].[tb_outlet] ([id_outlet], [nama], [alamat], [telp]) VALUES (N'OT-01     ', N'Murah Laundry', N'Jl. Pangeran Diponegoro No.32', N'083647392739')
INSERT [dbo].[tb_outlet] ([id_outlet], [nama], [alamat], [telp]) VALUES (N'OT-02     ', N'Bersih Laundry', N'Jl. Antasari No. 22', N'083763827482')
INSERT [dbo].[tb_outlet] ([id_outlet], [nama], [alamat], [telp]) VALUES (N'OT-03     ', N'Jamin Laundry', N'Jl. Kemayang No. 12', N'082683940283')
INSERT [dbo].[tb_outlet] ([id_outlet], [nama], [alamat], [telp]) VALUES (N'OT-04     ', N'Cahaya Laundry', N'Jl. Unik No. 75', N'086382639472')
INSERT [dbo].[tb_paket] ([id_paket], [id_outlet], [jenis], [nama_paket], [harga]) VALUES (N'PK-01     ', N'OT-04     ', N'Express', N'Cuci Cepat', 15000)
INSERT [dbo].[tb_paket] ([id_paket], [id_outlet], [jenis], [nama_paket], [harga]) VALUES (N'PK-02     ', N'OT-02     ', N'Sepatu', N'Cuci Sepatu', 15000)
INSERT [dbo].[tb_paket] ([id_paket], [id_outlet], [jenis], [nama_paket], [harga]) VALUES (N'PK-03     ', N'OT-02     ', N'Bisnis', N'Paket Bisnis', 25000)
INSERT [dbo].[tb_paket] ([id_paket], [id_outlet], [jenis], [nama_paket], [harga]) VALUES (N'PK-04     ', N'OT-01     ', N'Kiloan', N'Kiloan', 10000)
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-01     ', N'OT-03     ', N'INV-01', N'MB-01     ', N'14/02/2021', N'16/02/2021', N'14/02/2021', 0, 5, 1, N'Baru', N'Dibayar', N'USR-01    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-02     ', N'OT-04     ', N'INV-02', N'MB-01     ', N'14/02/2021', N'23/02/2021', N'14/02/2021', 100, 5, 1, N'Proses', N'Belum Dibayar', N'USR-03    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-03     ', N'OT-02     ', N'INV-03', N'MB-02     ', N'14/02/2021', N'22/02/2021', N'22/02/2021', 100, 2, 1, N'Selesai', N'Dibayar', N'USR-02    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-04     ', N'OT-03     ', N'INV-04', N'MB-05     ', N'14/02/2021', N'14/02/2021', N'14/02/2021', 0, 0, 1, N'Proses', N'Dibayar', N'USR-04    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-05     ', N'OT-02     ', N'INV-05', N'MB-03     ', N'15/02/2021', N'22/02/2021', N'15/02/2021', 1000, 2, 1, N'Baru', N'Dibayar', N'USR-02    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-06     ', N'OT-02     ', N'INV-06', N'MB-02     ', N'05/04/2021', N'12/04/2021', N'05/04/2021', 2000, 0, 1, N'Baru', N'Dibayar', N'USR-01    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-07     ', N'OT-01     ', N'INV-07', N'MB-01     ', N'06/04/2021', N'13/04/2021', N'06/04/2021', 1000, 0, 1, N'Baru', N'Dibayar', N'USR-01    ')
INSERT [dbo].[tb_transaksi] ([id_transaksi], [id_outlet], [kode_invoice], [id_member], [tgl], [batas_waktu], [tgl_bayar], [biaya_tambahan], [diskon], [pajak], [status], [dibayar], [id_user]) VALUES (N'TR-08     ', N'OT-01     ', N'INV-08', N'MB-01     ', N'06/04/2021', N'13/04/2021', N'06/04/2021', 1000, 0, 1, N'Baru', N'Dibayar', N'USR-04    ')
INSERT [dbo].[tb_user] ([id_user], [nama], [username], [password], [id_outlet], [role]) VALUES (N'USR-01    ', N'Bagoes', N'Username', N'dc647eb65e6711e155375218212b3964', N'OT-01     ', N'Admin')
INSERT [dbo].[tb_user] ([id_user], [nama], [username], [password], [id_outlet], [role]) VALUES (N'USR-02    ', N'Satria', N'Kasir', N'de28f8f7998f23ab4194b51a6029416f', N'OT-02     ', N'Kasir')
INSERT [dbo].[tb_user] ([id_user], [nama], [username], [password], [id_outlet], [role]) VALUES (N'USR-03    ', N'Wijaya', N'Owner', N'5be057accb25758101fa5eadbbd79503', N'OT-03     ', N'Owner')
INSERT [dbo].[tb_user] ([id_user], [nama], [username], [password], [id_outlet], [role]) VALUES (N'USR-04    ', N'Vania', N'Admin', N'0192023a7bbd73250516f069df18b500', N'OT-02     ', N'Admin')
INSERT [dbo].[tb_user] ([id_user], [nama], [username], [password], [id_outlet], [role]) VALUES (N'USR-05    ', N'Ferdi', N'Ferdi', N'0192023a7bbd73250516f069df18b500', N'OT-01     ', N'Admin')
ALTER TABLE [dbo].[tb_detail_transaksi]  WITH CHECK ADD  CONSTRAINT [FK_tb_detail_transaksi_tb_paket] FOREIGN KEY([id_paket])
REFERENCES [dbo].[tb_paket] ([id_paket])
GO
ALTER TABLE [dbo].[tb_detail_transaksi] CHECK CONSTRAINT [FK_tb_detail_transaksi_tb_paket]
GO
ALTER TABLE [dbo].[tb_detail_transaksi]  WITH CHECK ADD  CONSTRAINT [FK_tb_detail_transaksi_tb_transaksi] FOREIGN KEY([id_transaksi])
REFERENCES [dbo].[tb_transaksi] ([id_transaksi])
GO
ALTER TABLE [dbo].[tb_detail_transaksi] CHECK CONSTRAINT [FK_tb_detail_transaksi_tb_transaksi]
GO
ALTER TABLE [dbo].[tb_paket]  WITH CHECK ADD  CONSTRAINT [FK_tb_paket_tb_outlet] FOREIGN KEY([id_outlet])
REFERENCES [dbo].[tb_outlet] ([id_outlet])
GO
ALTER TABLE [dbo].[tb_paket] CHECK CONSTRAINT [FK_tb_paket_tb_outlet]
GO
ALTER TABLE [dbo].[tb_transaksi]  WITH CHECK ADD  CONSTRAINT [FK_tb_transaksi_tb_member] FOREIGN KEY([id_member])
REFERENCES [dbo].[tb_member] ([id_member])
GO
ALTER TABLE [dbo].[tb_transaksi] CHECK CONSTRAINT [FK_tb_transaksi_tb_member]
GO
ALTER TABLE [dbo].[tb_transaksi]  WITH CHECK ADD  CONSTRAINT [FK_tb_transaksi_tb_outlet] FOREIGN KEY([id_outlet])
REFERENCES [dbo].[tb_outlet] ([id_outlet])
GO
ALTER TABLE [dbo].[tb_transaksi] CHECK CONSTRAINT [FK_tb_transaksi_tb_outlet]
GO
ALTER TABLE [dbo].[tb_transaksi]  WITH CHECK ADD  CONSTRAINT [FK_tb_transaksi_tb_user] FOREIGN KEY([id_user])
REFERENCES [dbo].[tb_user] ([id_user])
GO
ALTER TABLE [dbo].[tb_transaksi] CHECK CONSTRAINT [FK_tb_transaksi_tb_user]
GO
ALTER TABLE [dbo].[tb_user]  WITH CHECK ADD  CONSTRAINT [FK_tb_user_tb_outlet] FOREIGN KEY([id_outlet])
REFERENCES [dbo].[tb_outlet] ([id_outlet])
GO
ALTER TABLE [dbo].[tb_user] CHECK CONSTRAINT [FK_tb_user_tb_outlet]
GO
USE [master]
GO
ALTER DATABASE [db_UKK_Bagoes] SET  READ_WRITE 
GO
