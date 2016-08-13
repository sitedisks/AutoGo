
namespace AutoGo.Service.Models
{
    using System.Collections.Generic;

    public class Team : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
