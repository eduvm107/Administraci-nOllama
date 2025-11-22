using System.ComponentModel.DataAnnotations;

namespace ChatbotTCS.AdminAPI.Models
{
    /// <summary>
    /// Modelo para la solicitud de login
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Email del usuario
        /// </summary>
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get; set; } = string.Empty;
    }

    /// <summary>
    /// Modelo para la respuesta de login exitoso
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// Mensaje de respuesta
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Token de autenticación (opcional para futuras implementaciones)
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// Información del usuario autenticado
        /// </summary>
        public UsuarioInfo Usuario { get; set; } = new UsuarioInfo();
    }

    /// <summary>
    /// Información básica del usuario para respuestas
    /// </summary>
    public class UsuarioInfo
    {
        /// <summary>
        /// ID del usuario
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Nombre completo del usuario
        /// </summary>
        public string NombreCompleto { get; set; } = string.Empty;

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Departamento del usuario
        /// </summary>
        public string Departamento { get; set; } = string.Empty;

        /// <summary>
        /// Puesto del usuario
        /// </summary>
        public string Puesto { get; set; } = string.Empty;

        /// <summary>
        /// Estado activo del usuario
        /// </summary>
        public bool Activo { get; set; }

        /// <summary>
        /// Estado de verificación del usuario
        /// </summary>
        public bool Verificado { get; set; }

        /// <summary>
        /// Estado del onboarding
        /// </summary>
        public string EstadoOnboarding { get; set; } = string.Empty;

        /// <summary>
        /// Progreso del onboarding
        /// </summary>
        public int ProgresoOnboarding { get; set; }

        /// <summary>
        /// Rol del usuario
        /// </summary>
        public string Rol { get; set; } = string.Empty;
    }
}