using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ElGuerre.Benchmarking
{
    public class JsonBuilder
    {
        public void Run()
        {
            // --- WRITER ---
            var dic = new Dictionary<string, object>();

            dic.Add("name", "Juanlu");
            dic.Add("age", 36);
            dic.Add("address", new Dictionary<string, object>
            {
                {
                    "street", new Dictionary<string, object>
                    {
                        { "name", "Angel Serradilla" },
                        { "number", "2" },
                    }
                },
                { "city", "Huelva" }
            });

            var jsonString = JsonConvert.SerializeObject(dic);
            // Console.WriteLine(jsonString);


            // --- READER ---

            var doc = JsonDocument.Parse(jsonString);
            var root = doc.RootElement;

            var json = JsonNode.Parse(jsonString);

            var name = json?["name"]!.ToString();
            var city = json?["address"]!["city"]!.ToString();
            var street = json?["address"]!["street"];
            street["new prop"] = 33;

            var number = Int32.Parse(json["address"]!["street"]!["number"]?.ToString());

            Console.WriteLine($"Now {name} is at {city} city at street {number}");
        }
    }
}
