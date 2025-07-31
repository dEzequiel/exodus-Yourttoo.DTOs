using Yourttoo.DTOs.Base;
using Yourttoo.DTOs.Common;

namespace Yourttoo.DTOs.Web.DTOs.Tagging
{
    public class TagDto : DtoBase
    {
        public string Code { get; set; } = string.Empty;

        public List<IdiomaticText> Name { get; set; } = new();
        public List<IdiomaticText> Description { get; set; } = new();
        public List<IdiomaticText> Label { get; set; } = new();

        public string Slug { get; set; } = string.Empty;
        public string Status { get; set; } = "active";

        public List<TagCategoryDto> Categories { get; set; } = new();

        public string? Icon { get; set; }
    }
}
