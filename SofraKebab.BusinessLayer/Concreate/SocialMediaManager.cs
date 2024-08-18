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
	public class SocialMediaManager : ISocialmediaService
	{
		private readonly ISocialmediaDal _ısocialmediadal;

		public SocialMediaManager(ISocialmediaDal ısocialmediadal)
		{
			_ısocialmediadal = ısocialmediadal;
		}

		public void TAdd(SocialMedia entity)
		{
			_ısocialmediadal.Add(entity);
		}

		public void TDelete(SocialMedia entity)
		{
			_ısocialmediadal.Delete(entity);
		}

		public SocialMedia TGetByID(int id)
		{
			return _ısocialmediadal.GetByID(id);
		}

		public List<SocialMedia> TGetListAll()
		{
			return _ısocialmediadal.GetListAll();
		}

		public void TUpdate(SocialMedia entity)
		{
			_ısocialmediadal.Update(entity);
		}
	}
}
