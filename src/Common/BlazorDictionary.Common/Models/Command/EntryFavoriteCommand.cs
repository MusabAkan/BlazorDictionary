using MediatR;

namespace BlazorDictionary.Common.Models.Command
{
    public class EntryFavoriteCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public Guid EntryId { get; set; }
        public EntryFavoriteCommand(Guid userId, Guid entryId)
        {
            UserId = userId;
            EntryId = entryId;
        }
    }
}