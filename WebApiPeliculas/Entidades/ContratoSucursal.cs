using System.ComponentModel.DataAnnotations;

namespace WebApiPractica1.Entidades
{
    public class ContratoSucursal
    {
        [Key]
        public int Id { get; set; }
        [Required]


        public int CodigoSucursal { get; set; }
        public int CodigoTurista { get; set; }
    }
}
