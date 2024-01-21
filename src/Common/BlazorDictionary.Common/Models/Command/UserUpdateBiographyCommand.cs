using MediatR;

namespace BlazorDictionary.Common.Models.Command
{
    public class UserUpdateBiographyCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public string? Biography { get; set; }
    }
}