using MediatR;

namespace BlazorDictionary.Common.Models.Command
{
    public class UserUpdateImageCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public string? Image { get; set; }
    }
}