using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizAPIAjax.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        
        //public virtual Estudiante Estudiante { get; set; }
    }
}