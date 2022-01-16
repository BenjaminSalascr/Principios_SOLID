using Dependency_Inversion_Principle.Models;
using System.Text.Json;

namespace Dependency_Inversion_Principle.Services
{
    public class InfoByRequest : IInfo
    {
        private string _url;
        public InfoByRequest(string url)
        {
            _url = url;
        }

        public async Task<IEnumerable<JsonData>> GetInfoAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(_url); //solicitud get
            //async hasta el momento solo soporta stream por tanto se convierte a stream y después se des-serializa
            //Un stream es una abstracción de una secuencia de bytes, como un archivo, una entrada/salida a un dispositivo o un socket
            var stream = await response.Content.ReadAsStreamAsync();
            List<JsonData> result = await JsonSerializer.DeserializeAsync<List<JsonData>>(stream);
            return result;
        }
    }
}
