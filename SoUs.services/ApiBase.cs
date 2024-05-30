using SoUs.Entities;
using System.Net.Http.Json;

namespace SoUs.services
{
    public abstract class ApiBase
    {
        protected Uri baseUri;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;
            
        }

        protected ApiBase(string Uri) : this(new Uri(Uri))
        {

        }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            // byg en uri for at sikre at vi har en gyldig uri
            Uri uri = new("");
            //kalder api
      
            using HttpClient client = new();
            var response = await client.GetAsync(uri);
            //returnerer resultatet
            return response;
        }


    }
    public class  SoUsService : ApiBase, ISoUsService
    {
        public SoUsService(Uri baseUri) : base(baseUri) { }
        public SoUsService(string baseUri) : base(baseUri){ }

        public async Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee)
        {

            string url = "";

            var response =  await GetHttpAsync(url);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Assignment>();
            List<Assignment> assignments = await result.ToListAsync();

            return assignments;
           

            /// call the api

        }
    }
    public interface ISoUsService
    {
       Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee);

    }
}
