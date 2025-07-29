using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ComarchBlock.entities
{
    [Keyless]
    public class DbLinkedModule
    {
        public string ModuleKey { get; set; } = string.Empty;
        public string LinkedModule { get; set; } = string.Empty;
    }
}
