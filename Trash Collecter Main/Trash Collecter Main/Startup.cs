using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Trash_Collecter_Main.Models;

[assembly: OwinStartupAttribute(typeof(Trash_Collecter_Main.Startup))]
namespace Trash_Collecter_Main
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //CreateRoles();
        }
        //private void CreateRoles()
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    string[] roleNames = { "Customer", "Employee" };
        //    IdentityResult roleResult;
            
        //    if (!RoleManager.RoleExists("Customer"))
        //    {
        //        roleResult = RoleManager.Create(new IdentityRole("Customer"));
        //    }
        //    else if (!RoleManager.RoleExists("Employee"))
        //    {
        //        roleResult = RoleManager.Create(new IdentityRole("Employee"));
        //    }

        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        //}
    }
}
