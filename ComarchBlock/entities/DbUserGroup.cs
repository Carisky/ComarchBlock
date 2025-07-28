using System.ComponentModel.DataAnnotations;

namespace ComarchBlock.entities
{
    public class DbUserGroup
    {
        [Key]
        public string UserName { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;
        public string WindowsUser { get; set; } = string.Empty;
    }
}
