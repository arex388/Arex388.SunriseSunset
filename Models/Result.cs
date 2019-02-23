using System;
using Newtonsoft.Json;

namespace Arex388.SunriseSunset {
	public sealed class Result {
		[JsonProperty("astronomical_twilight_begin")]
		public DateTime AstronomicalTwilightStartsAtUtc { get; set; }

		[JsonProperty("astronomical_twilight_end")]
		public DateTime AstronomicalTwilightEndsAtUtc { get; set; }

		[JsonProperty("civil_twilight_begin")]
		public DateTime CivilTwilightStartsAtUtc { get; set; }

		[JsonProperty("civil_twilight_end")]
		public DateTime CivilTwilightEndsAtUtc { get; set; }

		[JsonProperty("day_length")]
		public int DayLengthInSeconds { get; set; }

		public int DayLengthInMinutes => DayLengthInSeconds / 60;

		public decimal DayLengthInHours => Math.Round(DayLengthInMinutes / 60M, 2);

		[JsonProperty("nautical_twilight_begin")]
		public DateTime NauticalTwilightStartsAtUtc { get; set; }

		[JsonProperty("nautical_twilight_end")]
		public DateTime NauticalTwilightEndsAtUtc { get; set; }

		[JsonProperty("solar_noon")]
		public DateTime SolarNoonAtUtc { get; set; }

		[JsonProperty("sunrise")]
		public DateTime SunriseAtUtc { get; set; }

		[JsonProperty("sunset")]
		public DateTime SunsetAtUtc { get; set; }
	}
}