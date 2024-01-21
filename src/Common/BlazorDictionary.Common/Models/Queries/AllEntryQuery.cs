using BlazorDictionary.Common.Models.Queries.Base;
using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Queries
{
    public class AllEntryQuery : EntryQuery, IRequest<List<AllEntryViewModel>>
    {

    }
}