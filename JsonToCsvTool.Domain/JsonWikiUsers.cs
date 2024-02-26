namespace JsonToCsvTool.Domain;

public class JsonWikiUsers
{
    public IEnumerable<JsonWikiUser> List { get; set; } = Enumerable.Empty<JsonWikiUser>();
}