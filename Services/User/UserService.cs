using Data.EntityModels;
using Repository.UsersRepository;
using System.Collections.Generic;

namespace Services.User
{
	public class UserService : IUserService
	{
		public IUsersRepository _usersRepository;

		public UserService(IUsersRepository usersRepository)
		{
			_usersRepository = usersRepository;
		}

		public void AddUserDetails(Users userDetails)
		{
			_usersRepository.Insert(userDetails);
		}

		public IEnumerable<Users> GetUserDetails()
		{
			return _usersRepository.GetAll();
		}
	}
}
