using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBlock.dto
{
    public class SessionInfo
    {
        public int Spid { get; set; }
        public string UserName { get; set; }
        public string Module { get; set; }
        public long Start { get; set; }
    }
}
