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
	public class DiscountManager : IDiscountService
	{
		private readonly IDiscountDal _ıdiscountdal;

		public DiscountManager(IDiscountDal ıdiscountdal)
		{
			_ıdiscountdal = ıdiscountdal;
		}

		public void TAdd(Discount entity)
		{
			_ıdiscountdal.Add(entity);
		}

		public void TDelete(Discount entity)
		{
			_ıdiscountdal.Delete(entity);
		}

		public Discount TGetByID(int id)
		{
			return _ıdiscountdal.GetByID(id);
		}

		public List<Discount> TGetListAll()
		{
			return _ıdiscountdal.GetListAll();
		}

		public void TUpdate(Discount entity)
		{
			_ıdiscountdal.Update(entity);
		}
	}
}
