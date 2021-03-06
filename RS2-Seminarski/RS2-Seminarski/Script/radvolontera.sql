USE [RadVolontera]

SET IDENTITY_INSERT [dbo].[Mjesec] ON 

INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (1, N'Januar')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (2, N'Februar')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (3, N'Mart')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (4, N'April')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (5, N'Maj')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (6, N'Juni')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (7, N'Juli')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (8, N'August')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (9, N'Septembar')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (10, N'Oktobar')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (11, N'Novembar')
INSERT [dbo].[Mjesec] ([ID], [Naziv]) VALUES (12, N'Decembar')
SET IDENTITY_INSERT [dbo].[Mjesec] OFF

SET IDENTITY_INSERT [dbo].[Grad] ON 

INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (1, N'Bugojno')
INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (2, N'Mostar')
INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (3, N'Sarajevo')
INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (4, N'Donji Vakuf')
INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (5, N'Konjic')
INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (6, N'Bihać')
INSERT [dbo].[Grad] ([ID], [Naziv]) VALUES (7, N'Banja Luka')
SET IDENTITY_INSERT [dbo].[Grad] OFF

SET IDENTITY_INSERT [dbo].[Spol] ON 

INSERT [dbo].[Spol] ([ID], [Naziv]) VALUES (1, N'Muski')
INSERT [dbo].[Spol] ([ID], [Naziv]) VALUES (2, N'Zenski')
SET IDENTITY_INSERT [dbo].[Spol] OFF

INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'080b023b-ad0a-4c32-8aae-fb0c589fece5', N'user@example.com', N'USER@EXAMPLE.COM', N'user@example.com', N'USER@EXAMPLE.COM', 0, N'AQAAAAEAACcQAAAAEEq0d1c8H6RFsx6+nAIgbEOdnG5HAwXqcBrtwvzRKxUh4HmM939pc7okbM54dBux/w==', N'KWVO5XFF2HN4WYZVIKGW37Z6WAIPSU32', N'a68950b6-cf70-4514-b6f3-3436ffde89ae', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'string', N'string', 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'0a80e34f-c779-4af4-8f96-a5597469078b', N'elma@hotmail.com', N'ELMA@HOTMAIL.COM', N'elma@hotmail.com', N'ELMA@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHRBJ/6qdjOc5Fc1Kjnn52oZLYc+xP/AVwRoMpN6lyg0NuyWDAlDlN1nZ7be6pEreQ==', N'Y7777KQYQHSQ2RAA2L7HSAKV4HO7BGWM', N'3398a4da-d3bd-4c7e-bd09-9bcefb4a7133', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'Elma', N'Hubljar', 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'690f2706-2155-4cf1-bb77-f02fe74cb02f', N'safkica@edu.fit.ba', N'SAFKICA@EDU.FIT.BA', N'safkica@edu.fit.ba', N'SAFKICA@EDU.FIT.BA', 0, N'AQAAAAEAACcQAAAAEGNbIPNM+k3ZSihcCDHbWPr+fKgkhOOSziHEQ0EtVJZK0VWKjEaI9Iup+RTn76NDMA==', N'UQF6NM7UM3THT2SYXJOYE2AXVVP2DYJS', N'18ff496d-b1c1-4a1f-a065-606cf3936bdd', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'safija', N'hubljar', 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'a870b9bd-e7f7-4e10-8879-e70f4e42aa2f', N'safija.hubljar@edu.fit.ba', N'SAFIJA.HUBLJAR@EDU.FIT.BA', N'safija.hubljar@edu.fit.ba', N'SAFIJA.HUBLJAR@EDU.FIT.BA', 0, N'AQAAAAEAACcQAAAAEJzg7vgVf8IURIMAVtaoUTKMmmyYPBEmU9ZCU4JsmrDb0+ie2Y+4FAYS9UlOPiEWAg==', N'IN4UIGIRHT5Z5OJDQA4W77WBUOC6KQFW', N'a28171d1-a6a2-42e0-903d-66402ef43e0a', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'Safija', N'Hubljar', 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'abd84f0e-e46c-4588-bf32-02eb5e15ff12', N'safija_hubljarr@hotmail.com', N'SAFIJA_HUBLJARR@HOTMAIL.COM', N'safija_hubljarr@hotmail.com', N'SAFIJA_HUBLJARR@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEErIh4KQIRtN8pXsXfQ0wqM9O2R4G2TMXwnHNxpjhsSPr/won6kpoSy/frBOK8ObDw==', N'CV75KQSIULPW476XUL3QNT2SWROQ2AAF', N'471d06ca-95da-4042-aa12-0a187d6a5249', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'sasa', N'dsad', 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'd36cb487-2fce-4fb2-bf0a-d33cad03010d', N'Lamija@hotmail.com', N'LAMIJA@HOTMAIL.COM', N'Lamija@hotmail.com', N'LAMIJA@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEK6Js/Cd9OkoW63FUFiQAJ9GQZSDlg4xuMvSJtuT9swCArYWcdz637FX/p+BcIAU+Q==', N'CHYSHXBFGBGSSKUDX3BPAIZPNNPX7LTH', N'cbf20074-2c46-4c7c-be44-989b9e5bc190', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'Lamija', N'Kulas', 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'd567239d-0400-4412-94bc-36e3badbaa59', N'amina@hotmail.com', N'AMINA@HOTMAIL.COM', N'amina@hotmail.com', N'AMINA@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOaASAVdW2SBPDqus+CpdetMgf/78Oqr4JMPAUlfUFU5PgkWHp6JQ38oM+9D8to1rg==', N'CBIHOMFUOGQEDSGGHRXHSQDMBZ4NFXRW', N'129acda6-974c-424d-b25f-09a45f490c49', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'Amina', N'Hubljar', 3, 2)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Ime], [Prezime], [GradID], [SpolID]) VALUES (N'e5fc2824-d832-4f51-9338-8b5943110014', N'safija_hubljar@hotmail.com', N'SAFIJA_HUBLJAR@HOTMAIL.COM', N'safija_hubljar@hotmail.com', N'SAFIJA_HUBLJAR@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEL5gsRSwUOwgYroYlhApxlKqzQKpdj1Qw+aaKsGsn4hpa7s65vLrwXmaR824ZSAmQg==', N'SHVE3DAXFJPS44OLYPZ6R6D5KFOUHFER', N'5374354b-9856-498e-a8fd-b18452240f84', NULL, 0, 0, NULL, 1, 0, N'Korisnik', N'Safija', N'Hubljar', 1, 1)

SET IDENTITY_INSERT [dbo].[TipSkole] ON 

INSERT [dbo].[TipSkole] ([ID], [Naziv]) VALUES (1, N'Srednja skola')
INSERT [dbo].[TipSkole] ([ID], [Naziv]) VALUES (2, N'Osnovna skola')
INSERT [dbo].[TipSkole] ([ID], [Naziv]) VALUES (3, N'Fakultet')
SET IDENTITY_INSERT [dbo].[TipSkole] OFF

SET IDENTITY_INSERT [dbo].[Skola] ON 

INSERT [dbo].[Skola] ([ID], [Naziv], [TipSkoleID]) VALUES (1, N'Srednja tehnicka skola Bugojno', 1)
INSERT [dbo].[Skola] ([ID], [Naziv], [TipSkoleID]) VALUES (2, N'Fakultet informacijskih tehnologija', 3)
INSERT [dbo].[Skola] ([ID], [Naziv], [TipSkoleID]) VALUES (4, N'Ekonomski Fakultet Sarajevo', 3)
INSERT [dbo].[Skola] ([ID], [Naziv], [TipSkoleID]) VALUES (5, N'Elektrotehnički Fakultet Sarajevo', 3)
INSERT [dbo].[Skola] ([ID], [Naziv], [TipSkoleID]) VALUES (6, N'Građevinski fakultet Mostar', 3)
INSERT [dbo].[Skola] ([ID], [Naziv], [TipSkoleID]) VALUES (7, N'Mašinski fakultet Mostar', 3)
SET IDENTITY_INSERT [dbo].[Skola] OFF

INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'080b023b-ad0a-4c32-8aae-fb0c589fece5', 1)
INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'0a80e34f-c779-4af4-8f96-a5597469078b', 1)
INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'abd84f0e-e46c-4588-bf32-02eb5e15ff12', 1)
INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'd36cb487-2fce-4fb2-bf0a-d33cad03010d', 1)
INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'e5fc2824-d832-4f51-9338-8b5943110014', 1)
INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'690f2706-2155-4cf1-bb77-f02fe74cb02f', 2)
INSERT [dbo].[Volonter] ([ID], [SkolaID]) VALUES (N'd567239d-0400-4412-94bc-36e3badbaa59', 6)

SET IDENTITY_INSERT [dbo].[Uplata] ON 

INSERT [dbo].[Uplata] ([Id], [Iznos], [Napomena], [VolonterID], [MjesecID]) VALUES (2, 250, N'nn', N'e5fc2824-d832-4f51-9338-8b5943110014', 5)
INSERT [dbo].[Uplata] ([Id], [Iznos], [Napomena], [VolonterID], [MjesecID]) VALUES (3, 100, N'kk', N'0a80e34f-c779-4af4-8f96-a5597469078b', 1)
INSERT [dbo].[Uplata] ([Id], [Iznos], [Napomena], [VolonterID], [MjesecID]) VALUES (4, 100, N'kk', N'd36cb487-2fce-4fb2-bf0a-d33cad03010d', 1)
INSERT [dbo].[Uplata] ([Id], [Iznos], [Napomena], [VolonterID], [MjesecID]) VALUES (5, 100, N'kk', N'e5fc2824-d832-4f51-9338-8b5943110014', 2)
INSERT [dbo].[Uplata] ([Id], [Iznos], [Napomena], [VolonterID], [MjesecID]) VALUES (6, 100, N'mm', N'abd84f0e-e46c-4588-bf32-02eb5e15ff12', 9)
INSERT [dbo].[Uplata] ([Id], [Iznos], [Napomena], [VolonterID], [MjesecID]) VALUES (7, 150, N'mm', N'abd84f0e-e46c-4588-bf32-02eb5e15ff12', 2)
SET IDENTITY_INSERT [dbo].[Uplata] OFF

SET IDENTITY_INSERT [dbo].[Stanje] ON 

INSERT [dbo].[Stanje] ([ID], [Naziv]) VALUES (1, N'Poslana')
INSERT [dbo].[Stanje] ([ID], [Naziv]) VALUES (2, N'Vraćena')
INSERT [dbo].[Stanje] ([ID], [Naziv]) VALUES (3, N'Odobrena')
SET IDENTITY_INSERT [dbo].[Stanje] OFF

INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'ADMIN', N'')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'Volonter', N'VOLONTER', N'')

INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'080b023b-ad0a-4c32-8aae-fb0c589fece5', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a80e34f-c779-4af4-8f96-a5597469078b', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'690f2706-2155-4cf1-bb77-f02fe74cb02f', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'abd84f0e-e46c-4588-bf32-02eb5e15ff12', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd36cb487-2fce-4fb2-bf0a-d33cad03010d', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd567239d-0400-4412-94bc-36e3badbaa59', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5fc2824-d832-4f51-9338-8b5943110014', N'2')

INSERT [dbo].[Admin] ([ID]) VALUES (N'a870b9bd-e7f7-4e10-8879-e70f4e42aa2f')

SET IDENTITY_INSERT [dbo].[Sekcija] ON 

INSERT [dbo].[Sekcija] ([Id], [Naziv]) VALUES (1, N'Studenti')
INSERT [dbo].[Sekcija] ([Id], [Naziv]) VALUES (2, N'Srednjoškolci')
INSERT [dbo].[Sekcija] ([Id], [Naziv]) VALUES (3, N'Osnovci')
SET IDENTITY_INSERT [dbo].[Sekcija] OFF

SET IDENTITY_INSERT [dbo].[KorisniLink] ON 

INSERT [dbo].[KorisniLink] ([Id], [Naziv], [Link], [AdminID]) VALUES (1, N'sport', N'hehe', N'a870b9bd-e7f7-4e10-8879-e70f4e42aa2f')
INSERT [dbo].[KorisniLink] ([Id], [Naziv], [Link], [AdminID]) VALUES (2, N'Kurs programiranja', N'fitba.com', N'a870b9bd-e7f7-4e10-8879-e70f4e42aa2f')
INSERT [dbo].[KorisniLink] ([Id], [Naziv], [Link], [AdminID]) VALUES (3, N'jshajksa', N'sjdbsajkbca', N'a870b9bd-e7f7-4e10-8879-e70f4e42aa2f')
INSERT [dbo].[KorisniLink] ([Id], [Naziv], [Link], [AdminID]) VALUES (4, N'bjbjk', N'ghvjk', N'a870b9bd-e7f7-4e10-8879-e70f4e42aa2f')
SET IDENTITY_INSERT [dbo].[KorisniLink] OFF

