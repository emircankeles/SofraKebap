using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Abstract;
using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.BusinessLayer.Concreate
{
	public class ContactManager : IContactService
	{
		private readonly IContactDal _ıcontactdal;

		public ContactManager(IContactDal ıcontactdal)
		{
			_ıcontactdal = ıcontactdal;
		}

		public void TAdd(Contact entity)
		{
			_ıcontactdal.Add(entity);
		}

		public void TDelete(Contact entity)
		{
			_ıcontactdal.Delete(entity);
		}

		public Contact TGetByID(int id)
		{
			return _ıcontactdal.GetByID(id);
		}

		public List<Contact> TGetListAll()
		{
			return _ıcontactdal.GetListAll();
		}

		public void TUpdate(Contact entity)
		{
			_ıcontactdal.Update(entity);
		}
	}
}
