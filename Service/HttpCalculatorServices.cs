using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace VolumeWeb.Service
{
    public class HttpCalculatorServices: CalculatorService

    {
        private string _url= "http://localhost:5000";
        private HttpClient _httpClient;

        public HttpCalculatorServices( HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async  Task<VolumeResult> CalculateVolumeCylinderAsync(double height, double radius)
        {
            var response = await _httpClient.GetAsync($"{_url}/calculate/cylinder?height={height}&radius={radius}");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<VolumeResult>(json);
        }

        public async Task<VolumeResult> CalculateVolumeConeAsync(double height, double radius)
        {
            var response = await _httpClient.GetAsync($"{_url}/calculate/cone?height={height}&radius={radius}");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<VolumeResult>(json); 
        }

        public  async Task<List<VolumeResult>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync($"{_url}/calculate/results/");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<VolumeResult>>(json); 
        }
    }
}