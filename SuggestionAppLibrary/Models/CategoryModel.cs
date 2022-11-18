namespace SuggestionAppLibrary.Models;

public class CategoryModel
{
   [BsonId]//this is identifier
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string CategoryName { get; set; }
   public string CategoryDescription { get; set; }
}
