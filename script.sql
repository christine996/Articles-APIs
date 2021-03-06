USE [DB_USERS]
GO
/****** Object:  Table [Articles]    Script Date: 10/16/2020 7:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Articles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArticleName] [varchar](50) NULL,
	[ArticleCategory] [varchar](50) NULL,
	[ArticleContent] [varchar](max) NULL,
	[Comments] [varchar](max) NULL,
	[commentApproval] [bit] NULL,
	[Reason] [varchar](max) NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [Articles] ON 

INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (1, N'article 1', N'comedy', N'I haven’t thought about you, but I’m sure you’ve thought of me plenty between the scars I left on your psyche and my popular, unprofessional TikToks.I haven’t thought about you, but I’m sure you’ve thought of me plenty between the scars I left on your psyche and my popular, unprofessional TikToks.', N'i like this article', 1, NULL)
INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (2, N'article 2', N'comedy', N'“Is there a doctor on the plane? Specifically, someone with a PhD in Mathematics with a focus on algebraic geometry?”', N'dislike', 1, NULL)
INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (3, N'article 3', N'politics', N'“Is there a doctor on the plane? Specifically, someone with a PhD in Mathematics with a focus on algebraic geometry?”', NULL, NULL, N'comment')
INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (4, N'article 4', N'comedy', N'testing', NULL, NULL, NULL)
INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (5, N'article 5', N'comedy', N'“Is there a doctor on the plane? Specifically, someone with a PhD in Mathematics with a focus on algebraic geometry?”', NULL, NULL, NULL)
INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (6, N'article 6', N'sports', N'sports articles', NULL, NULL, NULL)
INSERT [Articles] ([Id], [ArticleName], [ArticleCategory], [ArticleContent], [Comments], [commentApproval], [Reason]) VALUES (7, N'article 7', N'politics', N'testing', N'i like this article', 1, NULL)
SET IDENTITY_INSERT [Articles] OFF
GO
