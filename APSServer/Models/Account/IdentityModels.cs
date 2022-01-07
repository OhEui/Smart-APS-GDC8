using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace APSServer.Models
{
    // ApplicationUser 클래스에 더 많은 속성을 추가하여 사용자의 프로필 데이터를 추가할 수 있습니다. 자세한 내용은 https://go.microsoft.com/fwlink/?LinkID=317594를 참조하세요.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // authenticationType은 CookieAuthenticationOptions.AuthenticationType에 정의된 항목과 일치해야 합니다.
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // 여기에 사용자 지정 사용자 클레임 추가
            return userIdentity;
        }

        #region custom property
        // id(UserName), password, email,dept(role) 제외
        public string Name { get; set; }
        public int No { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
        #endregion
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        public ApplicationDbContext(string nameOrConnectionString) : base(nameOrConnectionString, false)
        {

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
         }
        public static ApplicationDbContext Create()
        {
            string nameOrConnectionString = "DefaultConnection";
            return new ApplicationDbContext(nameOrConnectionString);
        }
    }
}