namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c256c866-2da3-4923-81e0-4318cef4c784', N'admin@vidly.com', 0, N'ACBojhGNqZAmq6MfH0p28Kh2WmiFTv14itaemESZ5KI9PdkJkotD20RGPYiP707Kyw==', N'2dc165ac-a897-4f57-a905-3f6b6fe0cebc', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c89afde3-786f-4d0b-92b4-364478ac8ba9', N'gust@vidly.com', 0, N'AP9MVVPzuaPVccCCX8ahZcTJ+sfJM5MvzDgy/PPhrRJdfRb0vJXHRBvKYV+eSAVkWQ==', N'5f5c95c2-77db-4560-913a-b0700df299da', NULL, 0, 0, NULL, 1, 0, N'gust@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e8bb5b72-3556-44bc-85de-b348fc5a122e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c256c866-2da3-4923-81e0-4318cef4c784', N'e8bb5b72-3556-44bc-85de-b348fc5a122e')


");
        }
        
        public override void Down()
        {
        }
    }
}
