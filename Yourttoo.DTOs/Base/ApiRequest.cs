using System.ComponentModel.DataAnnotations;

namespace Yourttoo.DTOs.Base
{
    /// <summary>
    /// Clase que representa la llamada del frontend al API Gateway
    /// </summary>
    /// <typeparam name="TPayload">Tipo del payload del request</typeparam>
    public class ApiRequest<TPayload> where TPayload : RequestPayload
    {
        /// <summary>
        /// Ruta del endpoint
        /// </summary>
        [Required]
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// Método HTTP (GET, POST, PUT, DELETE, etc.)
        /// </summary>
        [Required]
        public string Method { get; set; } = string.Empty;

        /// <summary>
        /// Payload del request
        /// </summary>
        public TPayload? Payload { get; set; }

        /// <summary>
        /// Headers adicionales del request
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Parámetros de query string
        /// </summary>
        public Dictionary<string, string> QueryParameters { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Valida el request completo
        /// </summary>
        /// <returns>True si el request es válido, false en caso contrario</returns>
        public virtual bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Path) || string.IsNullOrWhiteSpace(Method))
                return false;


            return true;
        }
    }
}
