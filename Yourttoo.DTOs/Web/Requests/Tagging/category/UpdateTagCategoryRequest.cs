using Yourttoo.DTOs.Base;
using Yourttoo.DTOs.Common;
using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Web.Requests.Tagging
{
    /// <summary>
    /// Request to update a tag category.
    /// </summary>
    public class UpdateTagCategoryRequest : RequestPayload
    {
        /// <summary>
        /// Id of the category.
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Unique code of the category.
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "The code can only contain letters, numbers, hyphens, and underscores")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Names of the category in different languages.
        /// </summary>
        [Required]  
        [MinLength(1, ErrorMessage = "You must provide at least one name")]
        public List<IdiomaticText> Name { get; set; } = new();

        /// <summary>
        /// Descriptions of the category in different languages.
        /// </summary>
        public List<IdiomaticText> Description { get; set; } = new();
        
        /// </summary>
        public bool Filter { get; set; } = false;
    }
}