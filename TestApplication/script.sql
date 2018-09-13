IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Enrolments] (
    [Id] int NOT NULL IDENTITY,
    [DateCreated] datetime2 NOT NULL,
    [DateUpdated] datetime2 NOT NULL,
    [Status] int NOT NULL,
    CONSTRAINT [PK_Enrolments] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180912193525_InitialCreate', N'2.1.3-rtm-32065');

GO

ALTER TABLE [Enrolments] ADD [SupplyAddressId] int NULL;

GO

CREATE TABLE [Addresses] (
    [Id] int NOT NULL IDENTITY,
    [DateCreated] datetime2 NOT NULL,
    [DateUpdated] datetime2 NOT NULL,
    [HouseNumber] nvarchar(max) NULL,
    [HouseName] nvarchar(max) NULL,
    [StreetName] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [Postcode] nvarchar(max) NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Enrolments_SupplyAddressId] ON [Enrolments] ([SupplyAddressId]);

GO

ALTER TABLE [Enrolments] ADD CONSTRAINT [FK_Enrolments_Addresses_SupplyAddressId] FOREIGN KEY ([SupplyAddressId]) REFERENCES [Addresses] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180912204634_AddingAddressTable', N'2.1.3-rtm-32065');

GO

