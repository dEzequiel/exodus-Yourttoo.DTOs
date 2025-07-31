using Yourttoo.DTOs.Base;
using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Web.Requests.Tagging
{
    /// <summary>
    /// Request to get a tag category.
    /// </summary>
    public class GetTagCategoryRequest : RequestPayload
    {
        /// <summary>
        /// Id of the category.
        /// </summary>
        [Required]
        public Guid Id { get; set; }
        
    }
}