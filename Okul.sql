USE [Okul]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 8.12.2022 19:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[DersID] [int] IDENTITY(1,1) NOT NULL,
	[DersAdi] [nvarchar](30) NOT NULL,
	[DersKredisi] [int] NOT NULL,
	[OkulYonetimID] [int] NOT NULL,
 CONSTRAINT [PK_Ders] PRIMARY KEY CLUSTERED 
(
	[DersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 8.12.2022 19:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciAdiSoyadi] [nvarchar](30) NOT NULL,
	[OgrenciNo] [int] NULL,
	[OgrenciDogumTarihi] [date] NOT NULL,
	[OgrenciKayitTarihi] [date] NOT NULL,
	[OgrenciBolumu] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDers]    Script Date: 8.12.2022 19:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DersID] [int] NOT NULL,
	[OgrenciID] [int] NOT NULL,
 CONSTRAINT [PK_OgrenciDers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OkulYonetim]    Script Date: 8.12.2022 19:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OkulYonetim](
	[OkulYonetimID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](30) NOT NULL,
	[Gorevi] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_OkulYonetim] PRIMARY KEY CLUSTERED 
(
	[OkulYonetimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ders] ON 

INSERT [dbo].[Ders] ([DersID], [DersAdi], [DersKredisi], [OkulYonetimID]) VALUES (1, N'Görsel Programlama', 3, 7)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [DersKredisi], [OkulYonetimID]) VALUES (2, N'Elektronik', 2, 11)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [DersKredisi], [OkulYonetimID]) VALUES (3, N'Deniz ve Liman İşletmeciliği', 1, 10)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [DersKredisi], [OkulYonetimID]) VALUES (4, N'Web Programlama', 3, 8)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [DersKredisi], [OkulYonetimID]) VALUES (5, N'Kontrol Sistemleri', 3, 9)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [DersKredisi], [OkulYonetimID]) VALUES (8, N'Bilgi Güvenliği', 2, 11)
SET IDENTITY_INSERT [dbo].[Ders] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (1, N'Fevzi Uzun', 2000, CAST(N'2000-06-25' AS Date), CAST(N'2020-10-01' AS Date), N'Mekatronik')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (2, N'Aslı Kaya', 2549, CAST(N'2001-02-15' AS Date), CAST(N'2021-08-12' AS Date), N'Bilgisayar Programcılığı')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (3, N'Kerem Can Pamuk', 2078, CAST(N'1999-05-17' AS Date), CAST(N'2018-06-05' AS Date), N'Yazılım Mühendisliği')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (4, N'Ceren Yıldız', 560, CAST(N'1997-09-29' AS Date), CAST(N'2016-08-02' AS Date), N'Bilgisayar Mühendisliği')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (5, N'Umut Tavşan', 440, CAST(N'2000-11-05' AS Date), CAST(N'2020-05-14' AS Date), N'Gemi Makine')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (6, N'Ayhan Kınık', 98400, CAST(N'1995-01-17' AS Date), CAST(N'2015-06-26' AS Date), N'Aşçılık')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (7, N'Yahya Kınık', 650, CAST(N'1995-03-02' AS Date), CAST(N'2016-04-13' AS Date), N'Aşçılık')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (9, N'Sema Türk', 750, CAST(N'1999-12-14' AS Date), CAST(N'2022-10-22' AS Date), N'Marina ve Yat İşletmeciliği')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (12, N'Batuhan Eren Bingöl', 9756, CAST(N'2002-08-14' AS Date), CAST(N'2021-09-01' AS Date), N'Bilgisayar Programcılığı')
INSERT [dbo].[Ogrenci] ([OgrenciID], [OgrenciAdiSoyadi], [OgrenciNo], [OgrenciDogumTarihi], [OgrenciKayitTarihi], [OgrenciBolumu]) VALUES (13, N'Ahmet Çakar', 78896, CAST(N'1999-01-12' AS Date), CAST(N'2017-11-05' AS Date), N'Yazılım Mühendisliği')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciDers] ON 

INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (1, 2, 5)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (2, 3, 4)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (3, 3, 2)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (4, 5, 1)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (5, 1, 3)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (9, 8, 5)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (14, 2, 13)
INSERT [dbo].[OgrenciDers] ([ID], [DersID], [OgrenciID]) VALUES (16, 1, 3)
SET IDENTITY_INSERT [dbo].[OgrenciDers] OFF
GO
SET IDENTITY_INSERT [dbo].[OkulYonetim] ON 

INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (1, N'Nafiz Arıca', N'Rektör')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (2, N'Elif Özen Cansoy', N'Dekan')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (3, N'Emel Sarvan', N'Dekan')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (4, N'Sevgi Endoğan', N'Memur')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (5, N'Togahan Ayan', N'Bölüm Başkanı')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (6, N'Funda Yercan', N'Bölüm Başkanı')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (7, N'Pelin Erdem', N'Öğretim Görevlisi')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (8, N'Emrah Sarıçiçek', N'Öğretim Görevlisi')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (9, N'Azime Çetinkaya', N'Öğretim Görevlisi')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (10, N'Sezai Işık', N'Öğretim Görevlisi')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (11, N'Azime Çetinkaya', N'İdari İşler')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (12, N'Gökhan Ekinci', N'Öğrenci İşleri')
INSERT [dbo].[OkulYonetim] ([OkulYonetimID], [AdSoyad], [Gorevi]) VALUES (13, N'Muhammet Akman', N'Öğretim Görevlisi')
SET IDENTITY_INSERT [dbo].[OkulYonetim] OFF
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_OkulYonetim] FOREIGN KEY([OkulYonetimID])
REFERENCES [dbo].[OkulYonetim] ([OkulYonetimID])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_OkulYonetim]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDers_Ders] FOREIGN KEY([DersID])
REFERENCES [dbo].[Ders] ([DersID])
GO
ALTER TABLE [dbo].[OgrenciDers] CHECK CONSTRAINT [FK_OgrenciDers_Ders]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDers_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[OgrenciDers] CHECK CONSTRAINT [FK_OgrenciDers_Ogrenci]
GO
