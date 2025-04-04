namespace Comandas.Api.Dtos
{
    public class MesaResponse
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public SituacaoMesa? SituacaoMesa { get; set; }
    }
}
