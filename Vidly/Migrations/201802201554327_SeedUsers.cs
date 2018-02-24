namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'483c853e-49e8-4879-b70a-11915ccc1a29', N'admin@vidly.com', 0, N'AD67WfqHGbZhUpdeYQjikWzn9k/8zSU8asuwZG4CFfC06MIjxp7rJX5kBs7IAx4DUw==', N'85bf9e6e-cba5-433d-a9f2-16ab401bc549', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9451977d-dbe9-46c5-8baf-e483a860dffb', N'guest@vidly.com', 0, N'AL8Zlcp5jsJcwbTIc2sSpB86CmW4tstWtJ4ynbXnYjRDW3Yj1YtuqV9kaC8/s+XWpw==', N'21591af1-b94d-4827-892f-9615feabbae1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be8839d6-1e4e-43b4-8272-0259da855eea', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'483c853e-49e8-4879-b70a-11915ccc1a29', N'be8839d6-1e4e-43b4-8272-0259da855eea')
         
");
        }
        
        public override void Down()
        {
        }
    }
}
