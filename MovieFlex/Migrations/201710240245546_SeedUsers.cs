namespace MovieFlex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0699b419-06ec-4b17-ae05-98f19f5b2c49', N'admin@movieflex.com', 0, N'AMlBynR003VzJKfrv1SA+PCM2ctUYIgEfbrqiseYgJ4ZOnEXPe5n+ypUv9vJu5Harw==', N'be3ae5c7-a234-4ea3-8894-5984e240a2d6', NULL, 0, 0, NULL, 1, 0, N'admin@movieflex.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2fea0779-5907-4efc-9ae5-44acb6bce21f', N'guest@movieflex.com', 0, N'AORwWOEK3/8GEF8c/ACD+o+G12gt5b3esOrVU+znFHusLvVFC/gLkIbwY1uFGBibCw==', N'47d03479-8d20-44f2-a0de-193ae263ee2f', NULL, 0, 0, NULL, 1, 0, N'guest@movieflex.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'70ca1e28-d071-4d6b-898b-6a034c314484', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0699b419-06ec-4b17-ae05-98f19f5b2c49', N'70ca1e28-d071-4d6b-898b-6a034c314484')


");
        }
        
        public override void Down()
        {
        }
    }
}
