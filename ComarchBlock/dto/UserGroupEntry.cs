using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBlock.dto
{
    public class UserGroupEntry
    {
        public required string Group { get; set; }
        public required string WindowsUser { get; set; }
    }
}
