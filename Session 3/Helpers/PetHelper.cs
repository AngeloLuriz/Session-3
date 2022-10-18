using RestSharp;
using System.Threading.Tasks;
using Session3.DataModels;
using Session3.Resources;
using Session3.Tests;
using System.Net;

namespace Session3.Helpers
{
    class PetHelper
    {
  
        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = PetData.demoPet();
            var postRequest = new RestRequest(Endpoints.PostPet());

            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}