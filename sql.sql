USE [Personel_Takip]
GO
/****** Object:  Table [dbo].[Departmanlar]    Script Date: 12.01.2023 02:46:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departmanlar](
	[DepartmanID] [int] IDENTITY(1,1) NOT NULL,
	[Departman] [varchar](100) NULL,
	[Aciklama] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[izinHareketleri]    Script Date: 12.01.2023 02:46:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[izinHareketleri](
	[izinHareketID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelID] [int] NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[izinTurID] [int] NOT NULL,
	[izinBaslangic] [date] NOT NULL,
	[izinBitis] [date] NOT NULL,
	[islem] [varchar](500) NOT NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [date] NOT NULL,
	[Saat] [datetime] NOT NULL,
 CONSTRAINT [PK_izinHareketleri] PRIMARY KEY CLUSTERED 
(
	[izinHareketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[izinTurleri]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[izinTurleri](
	[izinTurID] [int] IDENTITY(1,1) NOT NULL,
	[izinTuru] [varchar](150) NOT NULL,
 CONSTRAINT [PK_izinTurleri] PRIMARY KEY CLUSTERED 
(
	[izinTurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](150) NULL,
	[Sifre] [varchar](150) NULL,
	[AdiSoyadi] [varchar](750) NULL,
	[Soru] [varchar](750) NULL,
	[Cevap] [varchar](850) NULL,
	[Tarih] [date] NULL,
	[Aciklama] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MesaiHareketleri]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MesaiHareketleri](
	[MesaiHareketID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[MesaiID] [int] NOT NULL,
	[Islem] [varchar](500) NOT NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [date] NOT NULL,
 CONSTRAINT [PK_MesaiHareketleri] PRIMARY KEY CLUSTERED 
(
	[MesaiHareketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesailer]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesailer](
	[MesaiID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[BaslangicSaati] [varchar](50) NOT NULL,
	[BitisSaati] [varchar](50) NOT NULL,
	[MesaiSaatUcreti] [decimal](18, 2) NOT NULL,
	[Tutar] [decimal](18, 2) NOT NULL,
	[Donem] [varchar](50) NOT NULL,
	[OdemeDurumu] [varchar](50) NULL,
	[Aciklama] [varchar](500) NOT NULL,
	[Tarih] [date] NOT NULL,
 CONSTRAINT [PK_Mesailer] PRIMARY KEY CLUSTERED 
(
	[MesaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personelislemleri]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personelislemleri](
	[PersonelislemID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[islem] [varchar](500) NOT NULL,
	[Aciklama] [varbinary](850) NOT NULL,
	[Tarih] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](100) NOT NULL,
	[Soyadi] [varchar](100) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Adres] [varchar](500) NOT NULL,
	[Email] [varchar](500) NOT NULL,
	[DepartmanID] [int] NOT NULL,
	[Durumu] [varchar](500) NULL,
	[Maasi] [decimal](18, 2) NOT NULL,
	[GirisTarihi] [date] NOT NULL,
	[CikisTarihi] [date] NULL,
	[Aciklama] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrimHareketleri]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrimHareketleri](
	[PrimhareketID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[PrimID] [int] NOT NULL,
	[Islem] [varchar](500) NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Primler]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Primler](
	[PrimID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[Donem] [varchar](250) NOT NULL,
	[PrimTutari] [decimal](18, 2) NOT NULL,
	[OdemeDurumu] [varchar](250) NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YapilanZamlar]    Script Date: 12.01.2023 02:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YapilanZamlar](
	[ZamID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[Donem] [varchar](150) NOT NULL,
	[Personeller] [varchar](750) NOT NULL,
	[Yuzde] [decimal](18, 2) NULL,
	[Fiyat] [decimal](18, 2) NULL,
	[Aciklama] [varchar](500) NULL,
	[Tarih] [date] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Mesailer] ADD  CONSTRAINT [DF_Mesailer_OdemeDurumu]  DEFAULT ('Ödenmedi') FOR [OdemeDurumu]
GO
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [DF_Personeller_Durumu]  DEFAULT ('Aktif') FOR [Durumu]
GO
ALTER TABLE [dbo].[Primler] ADD  CONSTRAINT [DF_Primler_OdemeDurumu]  DEFAULT ('Ödenmedi') FOR [OdemeDurumu]
GO
