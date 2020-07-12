using System;

namespace Marfrig.Domain
{
    public class CompraGado
    {
        public int Id { get; set; }
        public DateTime DataEntrega { get; set; }
        public int PecuaristaId { get; set; }
        public Pecuarista Pecuarista { get; set; }
    }
}