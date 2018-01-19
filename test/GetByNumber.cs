using System.Net.Http;
using System.Threading.Tasks;
using api.Dto;
using Newtonsoft.Json;
using Xunit;

namespace test
{
    public class GetByNumber : ApiControllerTestBase
    {
        private readonly HttpClient client;

        public GetByNumber() => client = base.GetClient();

        [Theory]
        [InlineData("trivia")]
        public async Task ReturnsTextForTheNumber42(string controllerName)
        {
            var response = await client.GetAsync($"/api/{controllerName}/42");
            response.EnsureSuccessStatusCode();

            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TriviaResponse>(stringResponse);

            Assert.Equal(42, result.Number);
            Assert.NotEmpty(result.Text);
        }
    }
}