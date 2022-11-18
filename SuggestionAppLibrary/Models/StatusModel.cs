namespace SuggestionAppLibrary.Models;

public class StatusModel
{
   [BsonId]//this is identifier
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string StatusName { get; set; }
   public string StatusDescription { get; set; }
}
