using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ComarchBlock.entities
{
    [Keyless]
    public class DbGroupModuleLimit
    {
        public string GroupCode { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public int Hour { get; set; }
        public int MaxLicenses { get; set; }
    }
}
