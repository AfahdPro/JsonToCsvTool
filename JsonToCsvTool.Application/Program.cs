// See https://aka.ms/new-console-template for more information
using JsonToCsvTool.Application;
using JsonToCsvTool.Domain;
using System.Text.Json;

Console.WriteLine("List Of keycloak Ids");
// Load JSON file
string jsonFilePath = "../../../data/response.json"; // Change this to your JSON file path
string jsonString = File.ReadAllText(jsonFilePath);
JsonSerializerOptions options = new()
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};
// Deserialize JSON
JsonWikiUserSearchResults wikiUserSearchResults = JsonSerializer.Deserialize<JsonWikiUserSearchResults>(jsonString, options);

// Filter JSON
JsonWikiUsers filteredUsers = new Filter().FilterByProviderKey(wikiUserSearchResults.Users, "a7787426-5050-4348-96ba-a45b635b6f0f");

// Serialize filtered JSON
string filteredUserIdListString = JsonSerializer.Serialize<JsonWikiUserSearchResults>(new() { Users = filteredUsers }, options);
Console.WriteLine(filteredUserIdListString);