using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Project.FGStore.Data;

public class ASPIdentityContext : IdentityDbContext<IdentityUser>
{


    public ASPIdentityContext(DbContextOptions<ASPIdentityContext> options)
        : base(options)
    {
    }

    public override DbSet<IdentityUser> Users { get => base.Users; set => base.Users = value; }
    public override DbSet<IdentityUserClaim<string>> UserClaims { get => base.UserClaims; set => base.UserClaims = value; }
    public override DbSet<IdentityUserLogin<string>> UserLogins { get => base.UserLogins; set => base.UserLogins = value; }
    public override DbSet<IdentityUserToken<string>> UserTokens { get => base.UserTokens; set => base.UserTokens = value; }
    public override DbSet<IdentityUserRole<string>> UserRoles { get => base.UserRoles; set => base.UserRoles = value; }
    public override DbSet<IdentityRole> Roles { get => base.Roles; set => base.Roles = value; }
    public override DbSet<IdentityRoleClaim<string>> RoleClaims { get => base.RoleClaims; set => base.RoleClaims = value; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
