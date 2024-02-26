namespace JsonToCsvTool.Domain;

public class JsonWikiUsers
{
    public IEnumerable<JsonWikiUser> List { get; set; } = Enumerable.Empty<JsonWikiUser>();

    public IEnumerable<int> IdList { get => List.Select(x => x.Id); }
}