using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.CommandProcessor.Command;
using TechEasy.Domain.Commands;
using TechEasy.Data.Repositories;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Domain.Handlers
{
    public class UserRegisterHandler : ICommandHandler<UserRegisterCommand>
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        public UserRegisterHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }
        public ICommandResult Execute(UserRegisterCommand command)
        {
            var user = new User
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Password = command.Password,
                RoleId = command.RoleId,
                DateCreated = DateTime.Now,
                LastLoginTime = DateTime.Now,
                Activated = command.Activated
            };
            userRepository.Add(user);
            unitOfWork.Commit();
            return new CommandResult(true);
        }
    }
}
