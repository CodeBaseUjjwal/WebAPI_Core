using Data.EntityModels;
using System.Collections.Generic;

namespace Services.User
{
	public interface IUserService
	{
		/// <summary>
		/// Adding user details
		/// </summary>
		/// <param name="userDetails"></param>
		void AddUserDetails(Users userDetails);

		/// <summary>
		/// Get user details
		/// </summary>
		IEnumerable<Users> GetUserDetails();
	}
}
