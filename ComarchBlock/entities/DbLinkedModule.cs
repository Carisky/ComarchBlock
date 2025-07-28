using System.ComponentModel.DataAnnotations;

namespace ComarchBlock.entities
{
    public class DbLinkedModule
    {
        [Key]
        public int Id { get; set; }
        public string ModuleKey { get; set; } = string.Empty;
        public string LinkedModule { get; set; } = string.Empty;
    }
}
