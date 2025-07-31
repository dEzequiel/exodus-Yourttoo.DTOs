using Yourttoo.DTOs.Base;
using Yourttoo.DTOs.Common;
using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Web.DTOs.Tagging
{
    /// <summary>
    /// Represents a tag category.
    /// </summary>
    public class TagCategoryDto : DtoBase
    {
        /// <summary>
        /// Unique code of the category
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "The code can only contain letters, numbers, hyphens, and underscores")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Category names in different languages
        /// </summary>
        [Required]
        [MinLength(1, ErrorMessage = "You must provide at least one name")]
        public List<IdiomaticText> Name { get; set; } = new();

        /// <summary>
        /// Category descriptions in different languages
        /// </summary>
        public List<IdiomaticText> Description { get; set; } = new();
        
        /// <summary>
        /// Indicates if the category can be used as a filter
        /// </summary>
        public bool Filter { get; set; } = false;

        /// <summary>
        /// Category creation date
        /// </summary>
        [Required]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Category last update date
        /// </summary>
        [Required]
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Tags associated with this category
        /// </summary>
        public List<TagDto> Tags { get; set; } = new();
    }
}
