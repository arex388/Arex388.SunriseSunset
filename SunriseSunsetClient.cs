using System;
using System.Net.Http;
using System.Threading.Tasks;
using Arex388.SunriseSunset.Models;
using Newtonsoft.Json;

namespace Arex388.SunriseSunset {
	public sealed class SunriseSunsetClient {
		private HttpClient Client { get; }

		public SunriseSunsetClient(
			HttpClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		public async Task<Response> GetAsync(
			decimal latitude,
			decimal longitude) => await GetAsync(new Request {
				Latitude = latitude,
				Longitude = longitude
			});

		public async Task<Response> GetAsync(
			decimal latitude,
			decimal longitude,
			DateTime dateOn) => await GetAsync(new Request {
				DateOn = dateOn,
				Latitude = latitude,
				Longitude = longitude
			});

		public async Task<Response> GetAsync(
			Request request) {
			if (request is null) {
				return null;
			}

			var response = await GetResponseAsync(request);

			return JsonConvert.DeserializeObject<Response>(response);
		}

		private async Task<string> GetResponseAsync(
			Request request) {
			try {
				var response = await Client.GetAsync(request.Endpoint);

				return await response.Content.ReadAsStringAsync();
			} catch (HttpRequestException) {
				return null;
			}
		}
	}
}