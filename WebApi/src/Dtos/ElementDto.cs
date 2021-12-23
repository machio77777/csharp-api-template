namespace WebApi.src.Dtos
{
    public class ElementDto
    {
        // 部材名称
        public string ElementName { get; set; } = "";

        // 種別
        public string Type { get; set; } = "";

        // 体積
        public double Volume { get; set; }

        // 面積
        public double Area { get; set; }
    }
}