using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DaSite.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //personal data
        public string Gender { get; set; }
        public string Ethnicity { get; set; }        
        public string Height { get; set; }
        public string Hair { get; set; }
        
        //seeking
        public string Seeking { get; set; }
        public bool Toption { get; set; }
        public bool Tseeking { get; set; }
        public string Bio { get; set; }

        //location
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public DateTime BirthDate { get; set; }

        public string ProfilePic { get; set; }
    
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
            {
                // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Add custom user claims here
                return userIdentity;
            }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        { }

        public DbSet<Photos> Photos { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }


    public class Photos
    {
        [Key]
        public int Key { get; set; }

        [ForeignKey("Email")]
        public string EmailId { get; set; }
        public virtual ApplicationUser Email { get; set; }

        public string PathId { get; set; }
    }

}