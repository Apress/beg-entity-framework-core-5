using System.ComponentModel.DataAnnotations;

namespace EFCore5WebApp.Core.Entities
{
    public enum LookUpType
    {
        State = 0,
        Country = 1
    }

    public class LookUp
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public LookUpType LookUpType { get; set; }
    }
}
