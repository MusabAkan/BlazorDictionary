using BlazorDictionary.Common.Models.Queries.Base;
using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Queries
{
    public class UserEntriesQuery : EntryQuery, IRequest<IEnumerable<EntryViewModel>>
    {
        private Guid? _userId;
        public Guid? UserId
        {
            get => _userId;
            set
            {
                if (Guid.TryParse(value.ToString(), out Guid id))
                    _userId = id;
                else
                    _userId = Guid.Empty;
            }
        }
        private int _skip = 0;
        public int Skip
        {
            get => _skip;
            set
            {
                if (int.TryParse(value.ToString(), out int skip))
                {
                    if (skip > 0)
                        _skip = skip;
                }
            }
        }
    }
}