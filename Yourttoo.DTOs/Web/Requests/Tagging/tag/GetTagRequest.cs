using Yourttoo.DTOs.Base;
using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Web.Requests.Tagging
{
    /// <summary>
    /// Request to get a tag.
    /// </summary>
    public class GetTagRequest : RequestPayload
    {
        /// <summary>
        /// Id of the tag.
        /// </summary>
        [Required]
        public Guid Id { get; set; }
    }
}