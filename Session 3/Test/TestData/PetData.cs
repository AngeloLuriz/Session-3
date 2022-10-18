using Session3.DataModels;

namespace Session3.Tests
{
    class PetData
    {
        public static PetModel demoPet()
        {

            List<Tags> tags = new List<Tags>();
            tags.Add(new Tags()
            {
                Id = 1001,
                Name = "SampleTag"
            });

            return new PetModel
            {
                Id = 2,
                Name = "Updated Name",
                PhotoUrls = new List<string> { "Photo_String" },
                Tags = tags,
                Status = "available"
            };
        }
    }
}