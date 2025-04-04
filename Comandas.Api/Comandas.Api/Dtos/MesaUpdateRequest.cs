namespace Comandas.Api.Dtos
{
    public class MesaUpdateRequest
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public SituacaoMesa? SituacaoMesa { get; set; }
    }
}
