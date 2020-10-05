CREATE TABLE [dbo].[Blogs](
    [BlogId] INT IDENTITY (1,1) NOT NULL,
    [Name] NVARCHAR (200) NULL,
    [URL] NVARCHAR (200) NULL,
    CONSTRAINT [Pk_dbo.Blogs] Primary Key Clustered ([BlogId] ASC)
);

CREATE TABLE [dbo].[Posts] (
    [PostId] INT IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (200) NULL,
    [Content] NTEXT NULL,
    [BlogId] INT NOT NULL,
    CONSTRAINT [PK_dbo.Posts] PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_dbo.Posts_dbo.Blogs_BlogId] FOREIGN KEY ([BlogId]) REFERENCES [dbo].[Blogs] ([BlogId]) ON DELETE CASCADE
);