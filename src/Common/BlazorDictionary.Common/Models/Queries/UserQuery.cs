using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Queries
{
    public class UserQuery : IRequest<UserViewModel>
    {
        private Guid _userId;
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
        public string? Username { get; set; }
    }
}