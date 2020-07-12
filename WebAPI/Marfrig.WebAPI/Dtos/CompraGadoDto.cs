using System;
using Marfrig.Domain;

namespace Marfrig.WebAPI.Dtos
{
    public class CompraGadoDto
    {
        public int Id { get; set; }
        public DateTime DataEntrega { get; set; }        
        public Pecuarista Pecuarista { get; set; }
    }
}