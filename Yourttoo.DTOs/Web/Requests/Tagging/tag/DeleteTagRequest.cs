using Yourttoo.DTOs.Base;
using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Web.Requests.Tagging
{
    /// <summary>
    /// Request to delete a tag.
    /// </summary>
    public class DeleteTagRequest : RequestPayload
    {
        /// <summary>
        /// Id of the tag.
        /// </summary>
        [Required]
        public Guid Id { get; set; }
    }
    
}