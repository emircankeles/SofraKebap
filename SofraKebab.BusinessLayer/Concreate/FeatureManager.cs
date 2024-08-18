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
	public class FeatureManager : IFeatureService
	{
		private readonly IFeatureDal _ıfeaturedal;

		public FeatureManager(IFeatureDal ıfeaturedal)
		{
			_ıfeaturedal = ıfeaturedal;
		}

		public void TAdd(Feature entity)
		{
			_ıfeaturedal.Add(entity);
		}

		public void TDelete(Feature entity)
		{
			_ıfeaturedal.Delete(entity);
		}

		public Feature TGetByID(int id)
		{
			return _ıfeaturedal.GetByID(id);
		}

		public List<Feature> TGetListAll()
		{
			return _ıfeaturedal.GetListAll();
		}

		public void TUpdate(Feature entity)
		{
			_ıfeaturedal.Update(entity);	
		}
	}
}
