using WebApplication3.Enum;

namespace WebApplication3.Models
{
    public class Commodity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Color { get; set; }
        public BrandEnum Brand { get; set; }
        public ModelEnum Model { get; set; }
        public int? Number { get; set; }
        public string Serial { get; set; }
    }
}
