using BlazorDictionary.Common.Enums;
namespace Common.Models.View
{
    public class EntryCommentsViewModel
    {
        public Guid Id { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public VoteType VoteType { get; set; }
        public bool IsFavorite { get; set; }
        public string? Username { get; set; }
        public string? UserImage { get; set; }
    }
}