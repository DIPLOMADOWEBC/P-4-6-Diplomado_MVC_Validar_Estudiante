using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P_4_5_Diplomado_MVC_Validar_Estudiante.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [MinLength(3,ErrorMessage ="El nombre del estudiante debe tener al menos 3 carateres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MinLength(3, ErrorMessage = "El apellido del estudiante debe tener al menos 2 carateres")]
        public string Apellidos { get; set; }

        [Range(14,65, ErrorMessage ="La edad del estudiante debe estar entre 14 y 65")]
        public int Edad { get; set;  }

        [EmailAddress(ErrorMessage ="debe ingresar un email válido")]
        public string Email { get; set; }

        [RegularExpression("[MmFf]", ErrorMessage ="Solo puede ingresar una M=Masculino o F=Feminino")]
        public string Genero { get; set; }

        [RegularExpression("[CcSsUuDd]", ErrorMessage ="Solo puede ingresar una C=Casado, S=Soltero, U=Union Libre o D=Divorciado")]
        public string EstadoCivil { get; set; }
    }
}