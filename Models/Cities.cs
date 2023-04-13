using System.Diagnostics;
using RestSharp;

namespace CityApp.Models
{
    public class Cities
    {
        static RestClient _client;

        public Cities()
        {
            _client = new RestClient("https://wft-geo-db.p.rapidapi.com/v1/geo/");
        }

        public async Task<Constants> GetCityData(string query)
        {
            Constants cityData = null;

            var request = new RestRequest("cities");
            request.AddHeader("X-RapidAPI-Key", XRapidAPIProperties.XRapidAPIKey);
            request.AddHeader("X-RapidAPI-Host", XRapidAPIProperties.XRapidAPIHost);
            request.AddParameter("namePrefix", query);


            try
            {
                var response = await _client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    //cityData = JsonConvert.DeserializeObject<Constants>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return cityData;
        }

    }
}
