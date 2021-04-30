using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Repository
{
	public interface IRepository<U>
	{
		U Context { get; }

		IQueryable<T> readOne<T>() where T : class;
		IQueryable<T> readAll<T>() where T : class;

		void Create<T>(T tobject) where T : class;
		void Update<T>(T tobject) where T : class;
		void Delete<T>(T tobject) where T : class;
	}
}
