using Newtonsoft.Json;
using System.Text;
using TravelApp.MVC.Models;

namespace TravelApp.MVC.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseUrl = configuration["ApiSettings:BaseUrl"] ?? "https://localhost:7000/api";
        }

        // Métodos para Ciudades
        public async Task<List<Ciudad>> GetCiudadesAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/ciudades");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Ciudad>>(json) ?? new List<Ciudad>();
            }
            return new List<Ciudad>();
        }

        public async Task<Ciudad?> GetCiudadAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/ciudades/{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Ciudad>(json);
            }
            return null;
        }

        // Métodos para Pasajes
        public async Task<List<Pasaje>> GetPasajesAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/pasajes");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Pasaje>>(json) ?? new List<Pasaje>();
            }
            return new List<Pasaje>();
        }

        public async Task<Pasaje?> GetPasajeAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/pasajes/{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Pasaje>(json);
            }
            return null;
        }

        public async Task<bool> CreatePasajeAsync(Pasaje pasaje)
        {
            var json = JsonConvert.SerializeObject(pasaje);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await _httpClient.PostAsync($"{_baseUrl}/pasajes", content);
            return response.IsSuccessStatusCode;
        }

        // Métodos para Paquetes
        public async Task<List<Paquete>> GetPaquetesAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/paquetes");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Paquete>>(json) ?? new List<Paquete>();
            }
            return new List<Paquete>();
        }

        public async Task<Paquete?> GetPaqueteAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/paquetes/{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Paquete>(json);
            }
            return null;
        }

        public async Task<bool> CreatePaqueteAsync(Paquete paquete)
        {
            var json = JsonConvert.SerializeObject(paquete);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await _httpClient.PostAsync($"{_baseUrl}/paquetes", content);
            return response.IsSuccessStatusCode;
        }
    }
}