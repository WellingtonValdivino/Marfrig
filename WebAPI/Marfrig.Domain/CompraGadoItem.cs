namespace Marfrig.Domain
{
    public class CompraGadoItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int CompraGadoId { get; set; }
        public CompraGado CompraGado { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}