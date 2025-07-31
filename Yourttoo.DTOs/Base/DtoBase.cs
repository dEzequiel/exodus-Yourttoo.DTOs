using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Base
{
    /// <summary>
    /// Interfaz marcadora para identificar DTOs
    /// </summary>
    public interface IDto
    {
    }

    /// <summary>
    /// Clase base para DTOs con propiedades comunes
    /// </summary>
    public abstract class DtoBase : IDto
    {
        /// <summary>
        /// Identificador único del DTO
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Fecha y hora de creación
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
