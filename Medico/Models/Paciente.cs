using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del paciente es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Primer apellido del paciente es requerido")]
        public string PrimerAPellido { get; set; }


        public string? SegundoAPellido { get; set; }

        [Required(ErrorMessage = "La {0} del paciente es requerido")]
        [MinLength(18,ErrorMessage ="LA {0} debe de tener {1} caracteres")]
        [MaxLength(18,ErrorMessage ="LA {0} debe de tener {1} caracteres")]

        public string Curp { get; set; }


        [Required(ErrorMessage = "El tipo de sangre del paciente es requerido.")]
        public string TipoSangre { get; set; }

        public string? Observaciones { get; set; }
    }
}
