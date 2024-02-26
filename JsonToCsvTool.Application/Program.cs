// See https://aka.ms/new-console-template for more information
using JsonToCsvTool.Application;
using JsonToCsvTool.Domain;
using System.Text.Json;

Console.WriteLine("Hello, World!");
// Load JSON file
string jsonFilePath = "data/wikiUserList.json"; // Change this to your JSON file path
string jsonString = File.ReadAllText(jsonFilePath);

// Deserialize JSON
JsonWikiUserSearchResults jsonObject = JsonSerializer.Deserialize<JsonWikiUserSearchResults>(jsonString);

// Filter JSON
JsonWikiUsers filteredItems = new Filter().FilterOutByProviderKey(jsonObject.Users, "Keycloack");

// Serialize filtered JSON
string filteredJsonString = JsonSerializer.Serialize(filteredItems);
Console.WriteLine(filteredJsonString);