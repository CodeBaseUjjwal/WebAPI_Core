using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected DbContext Context { get; }

		public Repository(DbContext context)
		{
			Context = context;
		}
		public void Delete(object Id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> GetAll()
		{
			return Context.Set<T>();
		}

		public T GetById(object Id)
		{
			return Context.Set<T>().Find(Id);
		}

		public void Insert(T data)
		{
			Context.Add(data);
			Save();
		}

		public void Save()
		{
			Context.SaveChanges();
		}

		public void Update(T data)
		{
			throw new NotImplementedException();
		}
	}
}
