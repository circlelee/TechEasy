using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.CommandProcessor.Command;
using TechEasy.Domain.Commands;
using TechEasy.Core.Common;
using TechEasy.Data.Repositories;

namespace TechEasy.Domain.Handlers
{
    public class UserRegisterValidateHandler : IValidationHandler<UserRegisterCommand>
    {
        private readonly IUserRepository userRepository;
        public UserRegisterValidateHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IEnumerable<ValidationResult> Validate(UserRegisterCommand command)
        {
            var user = userRepository.Get(m => m.Email == command.Email);
            if (user != null)
            {
                yield return new ValidationResult("EMail", "is exist");
            }
        }
    }
}
