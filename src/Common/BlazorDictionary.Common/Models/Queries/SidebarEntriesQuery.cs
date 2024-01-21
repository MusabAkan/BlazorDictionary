using BlazorDictionary.Common.Models.Queries.Base;
using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Queries
{
    public class SidebarEntriesQuery : MainSideEntriesQuery, IRequest<List<SidebarViewModel>>
    {
    }
}