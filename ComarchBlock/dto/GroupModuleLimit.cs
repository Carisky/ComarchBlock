using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBlock.dto
{
    public class GroupModuleLimit
    {
        public string GroupCode { get; set; }
        public string Module { get; set; }
        public int Hour { get; set; }
        public int MaxLicenses { get; set; }
    }
}
