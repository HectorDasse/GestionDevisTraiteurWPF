using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Manager
{
	public interface IActionManager<T>
	{

		Task saveChanges();

		Task Delete(int id);

		Task getById(int id);

		Task<T> Update(int id, EntityDto entityDto);

		Task<T> Add(EntityDto entityDto);

		List<T> getAll();

	}
}
