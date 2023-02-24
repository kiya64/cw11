using WebApplication3.Enum;
using WebApplication3.Models;

namespace WebApplication3.sample_data
{
    public class comList
    {
        public static List<Commodity> commodities = new List<Commodity>
        { new Commodity {Id=1,Name="A52s",Color="red",Brand=BrandEnum.samsung,Model=ModelEnum.Mobile,Number=5,Serial="awffQAW" },
             new Commodity {Id=2,Name="p4",Color="black",Brand=BrandEnum.ho,Model=ModelEnum.Mobile ,Number=6, Serial="awADW"},
              new Commodity {Id=3,Name="aqq",Color="blue",Brand=BrandEnum.lenovo,Model=ModelEnum.Mobile , Number=9,Serial="awQ45"},
               new Commodity {Id=4,Name="rrr",Color="red",Brand=BrandEnum.samsung,Model=ModelEnum.Mobile, Number=1,Serial="awQ122" },
                new Commodity {Id=1,Name="Tuf",Color="black",Brand=BrandEnum.Asus,Model=ModelEnum.Laptop, Number=6,Serial="aw184Q" },
                new Commodity {Id=1,Name="Rog",Color="black",Brand=BrandEnum.Asus,Model=ModelEnum.Laptop, Number=0,Serial="praaqw"}

        };
    }
}
