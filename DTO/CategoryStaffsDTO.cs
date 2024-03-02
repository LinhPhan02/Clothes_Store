using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryStaffsDTO
    {
        public string id { get; set; }
        public string type { get; set; }
        public CategoryStaffsDTO(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
    }
}
