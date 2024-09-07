using EFCore.DAL.Enums;

namespace EFCore.DAL.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int MaxClassSize { get; set; }
        public Language ClassLanguage { get; set; } 
    }
}
