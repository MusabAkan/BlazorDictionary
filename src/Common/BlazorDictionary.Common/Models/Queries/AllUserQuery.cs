using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Queries
{
    public class AllUserQuery : IRequest<List<UserViewModel>>
    {
        public Guid? Id { get; set; }
        public int Count { get; set; } = 100;
    }
}