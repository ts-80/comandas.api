namespace Comandas.Api.Dtos
{
    public class MesaCreateRequest
    {
        public int NumeroMesa { get; set; }
        public SituacaoMesa? SituacaoMesa { get; set; }
    }
}
