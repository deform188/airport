using Airports.Aplication.CustomException;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airports.Aplication.AirportApi
{
    public class AirportApiClient : IAirportApiClient
    {
        private readonly HttpClient _httpClient;

        public AirportApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<T> GetEntities<T>(string contentType, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(contentType);

            var responseContent = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new AirportNotFoundException("Airport api error: " + responseContent);
            }

            return JsonConvert.DeserializeObject<T>(responseContent);
        }
    }
}
