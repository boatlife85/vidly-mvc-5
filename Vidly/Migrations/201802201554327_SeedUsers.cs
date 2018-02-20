namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d2f65e0-b380-4195-9658-e57d3b84c5df', N'admin@vidly.com', 0, N'ALtryglEHcuKfT0pG8RdmZHgkxq5bSzPWQQmaos3WA8bVHUwN7ZW4KKLSqU966zAzQ==', N'c639e642-72ce-4904-8916-df8a3992a887', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'67e7a4b0-5a77-4c35-b5cb-5312e9440d53', N'guest@vidly.com', 0, N'AGc7B5km3dEnhfycY39l1/Xu0D7ye4rhZatMOhWnZNgrg3eJhRlwDsCnwBgJ9gAvsQ==', N'893afa93-9396-415e-a554-ac170d2a48fb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fffb4440-60e1-4b6b-9bc2-0e9e4d95226c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d2f65e0-b380-4195-9658-e57d3b84c5df', N'fffb4440-60e1-4b6b-9bc2-0e9e4d95226c')
         
");
        }
        
        public override void Down()
        {
        }
    }
}
