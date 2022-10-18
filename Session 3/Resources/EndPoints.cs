namespace Session3.Resources
{
    public class Endpoints
    {
        public const string baseURL = "https://petstore.swagger.io/v2";

        public static string GetPetById(long petID) => $"{baseURL}/pet/{petID}";

        public static string PostPet() => $"{baseURL}/pet";

        public static string DeletePetById(long petID) => $"{baseURL}/pet/{petID}";
    }
}