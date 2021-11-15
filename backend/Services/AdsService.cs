using System.IO;
using System.Threading.Tasks;

namespace backend.Services
{

    public class AdsService : IAdsService
    {

        public AdResponse GetAds()
        {
            string currentPath = Directory.GetCurrentDirectory();

            currentPath = currentPath + "\\response.json";

            string jsonMe = System.IO.File.ReadAllText(@currentPath);
            
             AdResponse result = Newtonsoft.Json.JsonConvert.DeserializeObject<AdResponse>(jsonMe);

            return result; 
        }

    }

}