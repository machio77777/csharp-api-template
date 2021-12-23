namespace WebApi.src.Models
{
    public class Element
    {
        // 部材名称
        public string ElementName { get; set; } = "";

        // 種別
        public string Type { get; set; } = "";

        // 体積
        public double Volume { get; set; }

        // 面積
        public double Area { get; set; }

        // 種別の上書き
        public void OverrideType() 
        {
            if (Volume == 0) Type = "";
        }
    }
}