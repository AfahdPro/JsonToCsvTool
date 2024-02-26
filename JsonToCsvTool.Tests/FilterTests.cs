using JsonToCsvTool.Application;

namespace JsonToCsvTool.Tests;

public class FilterTests
{
    private readonly Filter _sut  = new();

    [Fact]
    public void GivenPropertyWhenFilterByPropertyShouldReturn()
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
        List<JsonWikiUser> expectedWikiUsers =
        [
            new()
            {
                Id = 2,
                Name = "Luigi",
                ProviderKey = "Keycloak",
            },
        ];

        // When
        var actual = _sut.FilterOutByProviderKey(wikiUsers, "Local");

        //Should
        actual.Should().NotBeNull();
        actual.List.Should().BeEquivalentTo(expectedWikiUsers);
    }


    [Fact]
    public void GivenUserListWhenFilterByPropertyShouldReturn()
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
        List<JsonWikiUser> expectedWikiUsers =
        [
            new()
            {
                Id = 2,
                Name = "Luigi",
                ProviderKey = "Keycloak",
            },
        ];

        // When
        var actual = _sut.FilterOutByProviderKey(wikiUsers, "Local");

        //Should
        actual.Should().NotBeNull();
        actual.List.Should().BeEquivalentTo(expectedWikiUsers);
    }
}