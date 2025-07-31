using Yourttoo.DTOs.Base;
using Yourttoo.DTOs.Common;

namespace Yourttoo.DTOs.Web.DTOs.Tagging
{
    public class TagCategoryDto : DtoBase
    {
        public string Code { get; set; } = string.Empty;
        public List<IdiomaticText> Name { get; set; } = new();
        public List<IdiomaticText> Description { get; set; } = new();
        public bool Filter { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set;}

        public List<IdiomaticText> Tags { get; set; } = new();
    }
}
