
namespace AutoGo.Service.Models
{
    using System.Collections.Generic;

    public class Role : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    } 
}
