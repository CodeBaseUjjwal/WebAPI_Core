using Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UsersRepository
{
	public class UsersRepository:Repository<Users>, IUsersRepository
	{
		public UsersRepository(DbContext context) : base(context)
		{
		}
	}
}
