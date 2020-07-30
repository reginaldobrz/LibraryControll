using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Shared.Repositories.Interface
{
	public interface IRepository<TEntity> : IDisposable where TEntity : class
	{
		void Add(TEntity t);
		void Delete(TEntity entity);
		void Delete(object key);
		void Save();
		Task<int> SaveAsync();
		Task SaveAsync(TEntity t);
		void Update(TEntity t);
		Task<TEntity> UpdateAsyn(TEntity t, object key);
	}
}
