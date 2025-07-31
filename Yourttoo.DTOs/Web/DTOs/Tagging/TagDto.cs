using System.ComponentModel.DataAnnotations;
using Yourttoo.DTOs.Base;
using Yourttoo.DTOs.Common;

namespace Yourttoo.DTOs.Web.DTOs.Tagging
{
    /// <summary>
    /// Represents a tag.
    /// </summary>
    public class TagDto : DtoBase
    {
        /// <summary>
        /// Unique code of the tag.
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "The code can only contain letters, numbers, hyphens, and underscores")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Name of the tag in different languages.
        /// </summary>
        [Required]
        [MinLength(1, ErrorMessage = "You must provide at least one name")]
        public List<IdiomaticText> Name { get; set; } = new();

        /// <summary>
        /// Description of the tag in different languages.
        /// </summary>
        public List<IdiomaticText> Description { get; set; } = new();

        /// <summary>
        /// Label of the tag in different languages.
        /// </summary>
        [Required]
        [MinLength(1, ErrorMessage = "You must provide at least one label")]
        public List<IdiomaticText> Label { get; set; } = new();

        /// <summary>
        /// Slug of the tag.
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "The slug can only contain letters, numbers, hyphens, and underscores")]
        public string Slug { get; set; } = string.Empty;

        /// <summary>
        /// Status of the tag.
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "The status can only contain letters, numbers, hyphens, and underscores")]
        public string Status { get; set; } = "active";

        /// <summary>
        /// Icon of the tag.
        /// </summary>
        /// <remarks>
        /// The icon is a icon's library code.
        /// </remarks>
        /// <example>
        /// "fa-solid fa-star"
        /// </example>  
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "The icon can only contain letters, numbers, hyphens, and underscores")]
        public string? Icon { get; set; }

        /// <summary>
        /// Categories of the tag.
        /// </summary>
        public List<TagCategoryDto> Categories { get; set; } = new();

    }
}
