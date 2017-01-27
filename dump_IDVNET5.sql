USE [IDV-NET5]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Email], [Firstname], [Lastname], [Username]) VALUES (1, N'anto@anto.com', N'anto', N'ossent', N'toto')
INSERT [dbo].[User] ([Id], [Email], [Firstname], [Lastname], [Username]) VALUES (2, N'addel@addel.com', N'addel', N'aloui', N'tata')
INSERT [dbo].[User] ([Id], [Email], [Firstname], [Lastname], [Username]) VALUES (3, N'keny@keny.com', N'keny', N'wua', N'titi')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[Version] ON 

INSERT [dbo].[Version] ([Id], [Download_link], [Edition], [Language], [Quality], [created_at]) VALUES (1, N'http//:www.test.com', N'director''s cut', N'fr', N'1080p', CAST(0x07E0995767A8623C0B AS DateTime2))
INSERT [dbo].[Version] ([Id], [Download_link], [Edition], [Language], [Quality], [created_at]) VALUES (2, N'http//:www.test2.com', N'normal', N'eng', N'720', CAST(0x07E0995767A8623C0B AS DateTime2))
INSERT [dbo].[Version] ([Id], [Download_link], [Edition], [Language], [Quality], [created_at]) VALUES (3, N'http//:www.test3.com', N'director''s cut', N'es', N'R5', CAST(0x07E0995767A8623C0B AS DateTime2))
SET IDENTITY_INSERT [dbo].[Version] OFF
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([Id], [DateOfPost], [Text], [UserId], [VersionId]) VALUES (1, N'janv 26 2017  8:07PM', N'fuck you', 1, 1)
SET IDENTITY_INSERT [dbo].[Comment] OFF
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator]) VALUES (1, N'The Shawshank Redemption', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', N'Tim Robbins, Morgan Freeman, Bob Gunton', 10, N'Frank Darabont')
INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator]) VALUES (2, N'The Godfather', N'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', N'Marlon Brando, Al Pacino, James Caan', 9, N'Francis Ford Coppola')
INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator]) VALUES (3, N'The Dark Knight', N'When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.', N' Christian Bale, Heath Ledger, Aaron Eckhart ', 10, N'Christopher Nolan')
INSERT [dbo].[Movie] ([Id], [Title], [Description], [Actor_principal], [Rating], [Realisator]) VALUES (4, N'Pulp Fiction', N'The lives of two mob hit men, a boxer, a gangster''s wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', N'John Travolta, Uma Thurman, Samuel L. Jackson', 10, N'Quentin Tarantino')
SET IDENTITY_INSERT [dbo].[Movie] OFF
SET IDENTITY_INSERT [dbo].[Asso_movie_version] ON 

INSERT [dbo].[Asso_movie_version] ([Id], [MoviesId], [VersionId]) VALUES (1, 2, 1)
INSERT [dbo].[Asso_movie_version] ([Id], [MoviesId], [VersionId]) VALUES (2, 2, 3)
INSERT [dbo].[Asso_movie_version] ([Id], [MoviesId], [VersionId]) VALUES (3, 1, 2)
SET IDENTITY_INSERT [dbo].[Asso_movie_version] OFF
