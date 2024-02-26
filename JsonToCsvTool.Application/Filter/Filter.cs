using JsonToCsvTool.Domain;

namespace JsonToCsvTool.Application;

public class Filter
{
    public JsonWikiUsers FilterByProviderKey(JsonWikiUsers usersToFilter, string providerKeyValue)
    {
        List<JsonWikiUser> filteredUsers = [];
        foreach (JsonWikiUser user in usersToFilter.List)
        {
            if (user.ProviderKey == providerKeyValue)
                filteredUsers.Add(user);
        }

        return new() { List = filteredUsers };
    }
}