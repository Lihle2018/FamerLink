using System.Numerics;

namespace Domain.Entities
{
    /// <summary>
    /// The Tag model is used to represent a category or label that can be associated with a product, vendor, or any other relevant entity in the FarmLink app. Tags are used to help users quickly find what they are looking for and to organize similar products or vendors together.
    ///For example, a vendor selling organic vegetables may use the tags "organic", "locally grown", and "sustainable farming" to describe their products.A user searching for organic produce could then filter their search results to only show products with the "organic" tag
    /// </summary>
    public sealed class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; set; }
        public List<VendorTag> VendorTags { get; set; }
    }

}
