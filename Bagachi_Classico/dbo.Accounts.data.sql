SET IDENTITY_INSERT [dbo].[Accounts] ON
INSERT INTO [dbo].[Accounts] ([Id], [Username], [Password], [Email], [CreatedAt], [Bio], [IsActive], [HighScore], [Win], [Lose]) VALUES (1, N'admin', N'admin123', N'lhiexhian@gmail.com', N'2025-12-14 01:46:22', N'hi sir lor and sir bill
-------
edit 3', 0, 9999, 1000, 1005)
INSERT INTO [dbo].[Accounts] ([Id], [Username], [Password], [Email], [CreatedAt], [Bio], [IsActive], [HighScore], [Win], [Lose]) VALUES (2, N'lee-shann', N'aixiah', NULL, N'2025-12-14 10:38:35', NULL, 0, 9999, 999, 999)
INSERT INTO [dbo].[Accounts] ([Id], [Username], [Password], [Email], [CreatedAt], [Bio], [IsActive], [HighScore], [Win], [Lose]) VALUES (4, N'lee', N'shann1', N'cubecape.1@gmail.com', N'2025-12-15 11:02:27', N'editttt', 1, 250, 1, 1)

UPDATE [dbo].[Accounts] SET [IsActive] = 0 WHERE [Id] = 4

SET IDENTITY_INSERT [dbo].[Accounts] OFF
