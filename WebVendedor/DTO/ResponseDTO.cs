namespace WebVendedor.DTO
{
    public class ResponseDTO
    {
        public int Codigo { get; set; }

        public string Mensagem { get; set; } = string.Empty;
        public object? Informacao { get; set; }
    }
}