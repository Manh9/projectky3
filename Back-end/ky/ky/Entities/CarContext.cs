using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;
namespace ky.Entities
{
   
    public partial class CarContext : DbContext
    {
        public CarContext()
        {
        }

        public object Users { get; internal set; }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Otp> Otps { get; set; }

        public bool IsVerified { get; set; }
    }
}
