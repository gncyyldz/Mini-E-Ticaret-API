namespace ETicaretAPI.Application.RequestParameters
{
    public record Pagination
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
