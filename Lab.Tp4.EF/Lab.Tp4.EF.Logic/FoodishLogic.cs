using Lab.Tp4.EF.Entities.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp4.EF.Logic
{
    public class FoodishLogic
    {
        public async Task<Foodish> GetAll()
        {
            try
            {
                var httpClient = new HttpClient();
                var json = await httpClient.GetStringAsync("https://foodish-api.herokuapp.com/api/");
                Foodish foodish = JsonConvert.DeserializeObject<Foodish>(json);
                return foodish;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
