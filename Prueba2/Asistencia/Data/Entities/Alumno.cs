namespace Asistencia.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Alumno
    {
        public int id { set; get; }
        public int Nombre { set; get; }
        [Display(Name = "Cedula de identidad")]
        public int CI { set; get; }
        [Display(Name = "Foto")]
        public string ImageURL { set; get; }
        [Display(Name = "Dirrecion")]
        public string Direccion { set; get; }
        [Display(Name = "Telefono")]
        public string Fono { set; get; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNaci { set; get; }
        [Display(Name = "Curso")]
        public string Curso { set; get; }
    }
}
