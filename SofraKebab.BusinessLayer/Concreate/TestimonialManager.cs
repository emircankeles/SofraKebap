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
	public class TestimonialManager : ITestimonialService
	{

		private readonly ITestimonialDal _ıtestimonialdal;

		public TestimonialManager(ITestimonialDal ıtestimonialdal)
		{
			_ıtestimonialdal = ıtestimonialdal;
		}

		public void TAdd(Testimonial entity)
		{
			_ıtestimonialdal.Add(entity);
		}

		public void TDelete(Testimonial entity)
		{
			_ıtestimonialdal.Delete(entity);
		}

		public Testimonial TGetByID(int id)
		{
			return _ıtestimonialdal.GetByID(id);
		}

		public List<Testimonial> TGetListAll()
		{
			return _ıtestimonialdal.GetListAll();
		}

		public void TUpdate(Testimonial entity)
		{
			_ıtestimonialdal.Update(entity);	
		}
	}
}
