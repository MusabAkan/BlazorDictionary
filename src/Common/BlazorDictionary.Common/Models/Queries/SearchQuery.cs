using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Queries
{
    public class SearchQuery : IRequest<SearchViewModel>
    {
        public string Value { get; set; }
        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                if (value == default)
                    _count = 12;
                else
                    _count = value;
            }
        }
    }
}