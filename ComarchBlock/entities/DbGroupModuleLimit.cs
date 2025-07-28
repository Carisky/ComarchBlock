using System.ComponentModel.DataAnnotations;

namespace ComarchBlock.entities
{
    public class DbGroupModuleLimit
    {
        [Key]
        public int Id { get; set; }
        public string GroupCode { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public int Hour { get; set; }
        public int MaxLicenses { get; set; }
    }
}
