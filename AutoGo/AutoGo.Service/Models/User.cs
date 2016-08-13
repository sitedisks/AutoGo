
namespace AutoGo.Service.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User : BaseModel<int>
    {
        public string Password { get; set; }
        public string email { get; set; }

        [Required, StringLength(100)]
        public override string Name { get; set; }

        public int? TeamId { get; set; }
        public int RoleId { get; set; }

        public virtual Team Team { get; set; }
        public virtual Role Role { get; set; }
    }
}
