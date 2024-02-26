namespace JsonToCsvTool.Tests;

public class JsonWikiUsersTests
{
    [Fact]
    public void GivenUserListWhenreturnIdListShouldReturn()
    {
        // Given
        List<JsonWikiUser> wikiUsersList =
        [
            new()
            {
                Id = 1,
                Name = "Mario",
                ProviderKey = "Local",
            },
            new()
            {
                Id = 2,
                Name = "Luigi",
                ProviderKey = "Keycloak",
            },
        ];
        JsonWikiUsers wikiUsers = new()
        {
            List = wikiUsersList,
        };
        List<int> expected =[1,2];

        // When
        var actual = wikiUsers.IdList;

        //Should
        actual.Should().BeEquivalentTo(expected);
    }
}
