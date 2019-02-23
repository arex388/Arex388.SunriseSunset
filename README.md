# Arex388.SunriseSunset

Sunrise-Sunset.org API Implementation in C#

To use, create an instance of `SunriseSunsetClient`, passing it an instance of `HttpClient`. No API key is required. The original API documentation is [here][0]. For more information, please visit [arex388.com][1].

Available as a NuGet package [here][2].

    var sunriseSunset = new SunriseSunset(
        httpClient
    );

**Get**

    var result = await sunriseSunset.GetAsync(38.9072, -77.0369);

[0]:https://sunrise-sunset.org/api
[1]:https://arex388.com
[2]:https://www.nuget.org/packages/Arex388.SunriseSunset