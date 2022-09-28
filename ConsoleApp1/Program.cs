using ConsoleApp1;
using Newtonsoft.Json;

var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://edamam-recipe-search.p.rapidapi.com/search?q=chicken"),
    Headers =
    {
        { "X-RapidAPI-Key", "" }, //PUT YOUR API KEY FROM RAPIDAPIHERE
        { "X-RapidAPI-Host", "edamam-recipe-search.p.rapidapi.com" },
    },
};

var body = "";
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    body = await response.Content.ReadAsStringAsync();
}

if (!string.IsNullOrEmpty(body))
{
    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(body);
    foreach(var Hit in myDeserializedClass.Hits)
    {
        Console.WriteLine(Hit.Recipe.Label);
    }
}
