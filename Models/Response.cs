using Arex388.SunriseSunset.Models;
using Newtonsoft.Json;

namespace Arex388.SunriseSunset {
	public sealed class Response {
		[JsonProperty("results")]
		public Result Result { get; set; }

		public string Status { get; set; }
	}
}
