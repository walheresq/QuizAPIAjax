using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizAPIAjax.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //public virtual ICollection<Curso> Cursos { get; set; }
    }
}