USE [IDV-NET5]
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator], [File_link], [Language], [Picture_link]) VALUES (4, N'Silence', N'XVIIème siècle, deux prêtres jésuites se rendent au Japon pour retrouver leur mentor, le père Ferreira, disparu alors qu’il tentait de répandre les enseignements du catholicisme. Au terme d’un dangereux voyage, ils découvrent un pays où le christianisme est décrété illégal et ses fidèles persécutés. Ils devront mener dans la clandestinité cette quête périlleuse qui confrontera leur foi aux pires épreuves.', N'Andrew Garfield', 4, N'Martin Scorcese', N'http://www.allocine.fr/film/fichefilm_gen_cfilm=29943.html', N'french', N'1page-img6.jpg')

INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator], [File_link], [Language], [Picture_link]) VALUES (2, N'twilight chapitre 1', N'Isabella Swan, 17 ans, déménage à Forks, petite ville pluvieuse dans l''Etat de Washington, pour vivre avec son père. Elle s''attend à ce que sa nouvelle vie soit aussi ennuyeuse que la ville elle-même. Or, au lycée, elle est terriblement intriguée par le comportement d''une étrange fratrie, deux filles et trois garçons. Bella tombe follement amoureuse de l''un d''eux, Edward Cullen. Une relation sensuelle et dangereuse commence alors entre les deux jeunes gens : lorsque Isabella comprend que Edward est un vampire, il est déjà trop tard.', N'Kristen Stewart', 3, N'Catherine Hardwicke', N'http://www.allocine.fr/film/fichefilm_gen_cfilm=131377.html', N'french', N'1page-img4.jpg')

INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator], [File_link], [Language], [Picture_link]) VALUES (3, N'Toy Story 3', N'Check out Disney-Pixar''s official Toy Story site, watch the Toy Story 3 trailer, and meet new characters. Remember, no toy gets left behind!', N'Woody', 3, N'Buzz', N'http://www.allocine.fr/film/fichefilm_gen_cfilm=131377.html', N'french', N'1page-img2.jpg')

INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator], [File_link], [Language], [Picture_link]) VALUES (1, N'Prince of persia: Sand of time', N'A young fugitive prince and princess must stop a villain who unknowingly threatens to destroy the world with a special dagger.', N'Jake j''ai un nom a chier', 3, N'jfaitdesfilmdemerde', N'http://www.allocine.fr/film/fichefilm_gen_cfilm=131377.html', N'french', N'1page-img3.jpg')



SET IDENTITY_INSERT [dbo].[Movie] OFF
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([Id], [DateOfPost], [Text], [MovieId], [Username]) VALUES (4, CAST(N'2017-02-01 00:00:00.0000000' AS DateTime2), N'Quand le film à commencé, il y a eut silence dans la salle', 1, N'fraggy')
INSERT [dbo].[Comment] ([Id], [DateOfPost], [Text], [MovieId], [Username]) VALUES (6, CAST(N'2017-02-02 00:00:00.0000000' AS DateTime2), N'Messieurs nous avons le roi de la blague parmis nous !', 1, N'darkknight')
INSERT [dbo].[Comment] ([Id], [DateOfPost], [Text], [MovieId], [Username]) VALUES (7, CAST(N'2016-11-01 00:00:00.0000000' AS DateTime2), N'ce film m''a vraiment touché', 2, N'fraggy')
INSERT [dbo].[Comment] ([Id], [DateOfPost], [Text], [MovieId], [Username]) VALUES (8, CAST(N'2016-11-05 00:00:00.0000000' AS DateTime2), N'Moi aussi ce film m''a fait réaliser qu''il falait faire attention a comment tout ça évolue', 2, N'darkknight')
SET IDENTITY_INSERT [dbo].[Comment] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161212124646_init', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161213160816_init2', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161213162019_init3', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161213162113_init5', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161213162530_init6', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170126134411_fuckit2', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170126135621_fuckit4', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170127075248_myproject', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170202183626_migration2', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170209200410_newDb', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170209200658_newDatabase', N'1.0.0-rtm-21431')
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Email], [FirstName], [LastName], [UserName], [ConfirmPassword], [Password]) VALUES (1, N'mymail@mail.fr', N'anthony', N'ossent', N'fraggy', N'aaa', N'aaa')
INSERT [dbo].[User] ([Id], [Email], [FirstName], [LastName], [UserName], [ConfirmPassword], [Password]) VALUES (2, N'mymail@aol.com', N'addel', N'aloui', N'darkknight', N'aaa', N'aaa')
SET IDENTITY_INSERT [dbo].[User] OFF
