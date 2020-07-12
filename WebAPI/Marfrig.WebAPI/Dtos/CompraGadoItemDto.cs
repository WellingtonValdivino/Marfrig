using Marfrig.Domain;

namespace Marfrig.WebAPI.Dtos
{
    public class CompraGadoItemDto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }        
        public CompraGado CompraGado { get; set; }    
        public Animal Animal { get; set; }
    }
}