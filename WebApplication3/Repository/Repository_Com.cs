using WebApplication3.Models;
using WebApplication3.sample_data;

namespace WebApplication3.Repository
{
    public class Repository_Com
    {
        public void AddCom(Commodity commodity)
        {
            if (Exist(commodity.Serial))
            {
                var N_co = comList.commodities.FirstOrDefault(x => x.Serial == commodity.Serial);
                N_co.Number += commodity.Number;

            }

            else
            {

                commodity.Id = sample_data.comList.commodities.Last().Id + 1;
                comList.commodities.Add(commodity);

            }
        }
        public bool Exist(string sr)
        {
            return comList.commodities.Any(x => x.Serial == sr);


        }
        public void DelCom(int id)
        {

            var com = comList.commodities.FirstOrDefault(x => x.Id == id);
            if (com.Number <= 1)
            {
                comList.commodities.Remove(com);
            }
            else
            {
                com.Number--;
            }

        }
        public void UpCom(Commodity commodity)
        {
            var com = comList.commodities.FirstOrDefault(x => x.Id ==commodity.Id);
            com.Name = commodity.Name;
            com.Number = commodity.Number;
            com.Color = commodity.Color;
            com.Brand = commodity.Brand;
            com.Model = commodity.Model;




        }
        public Commodity Get_id(int id) {
            var ProductEntity = sample_data.comList.commodities.FirstOrDefault(x => x.Id == id);
            return ProductEntity;
        }
    }
}

