using System.ComponentModel.DataAnnotations;

namespace ComarchBlock.entities
{
    public class DbModuleLimit
    {
        [Key]
        public string Module { get; set; } = string.Empty;
        public int MaxLicenses { get; set; }
    }
}
