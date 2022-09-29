using System.Net.Http.Json;

namespace DiabetesBlazorApp.Client.Services.GlucoseValuesSerice
{
    public class GlucoseValuesService : IGlucoseValuesService
    {

        public List<GlucoseValue> glucoseValues { get; set; } = new List<GlucoseValue>();
        private readonly HttpClient _http;

        public GlucoseValuesService(HttpClient http)
        {
            _http = http;
        }
        public async Task GetGlusoeValues()
        {
            var result = await _http.GetFromJsonAsync<List<GlucoseValue>>("api/values");
            if (result != null)
                glucoseValues = result;
        }
    }
}
