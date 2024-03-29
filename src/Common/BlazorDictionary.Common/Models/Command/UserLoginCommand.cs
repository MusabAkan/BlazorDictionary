
using BlazorDictionary.Common.Models.View;
using MediatR;

namespace BlazorDictionary.Common.Models.Command
{
    public class UserLoginCommand : IRequest<UserLoginViewModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserLoginCommand() { }
        public UserLoginCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}