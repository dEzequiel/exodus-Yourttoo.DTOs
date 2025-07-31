using Yourttoo.DTOs.Base;
using Yourttoo.DTOs.Common;

namespace Yourttoo.DTOs.Web.Requests.Tagging
{
    public class CreateTagCategoryRequest : RequestPayload
    {
        public string Code { get; set; }
        public List<IdiomaticText> Name { get; set; } = new();
        public List<IdiomaticText> Description { get; set; } = new();
        public bool Filter { get; set; }
    }
}
