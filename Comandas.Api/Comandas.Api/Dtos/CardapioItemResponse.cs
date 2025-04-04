namespace Comandas.Api.Dtos
{
    public class CardapioItemResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public bool PossuiPreparo { get; set; }
        public decimal Preco { get; set; }
    }
}
