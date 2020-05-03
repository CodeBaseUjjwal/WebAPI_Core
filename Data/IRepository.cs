using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
	public interface IRepository<T> where T: class
	{
		IEnumerable<T> GetAll();
		T GetById(object Id);
		void Insert(T data);
		void Update(T data);
		void Delete(object Id);
		void Save();
	}
}
