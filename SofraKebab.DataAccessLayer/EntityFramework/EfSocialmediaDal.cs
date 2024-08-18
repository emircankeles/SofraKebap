using SofraKebab.DataAccessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;
using SofraKebab.DataAccessLayer.Repositories;
using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.DataAccessLayer.EntityFramework
{
	public class EfSocialmediaDal : GenericRepository<SocialMedia>, ISocialmediaDal
	{
		public EfSocialmediaDal(SofraKebabContext context) : base(context)
		{
		}
	}
}
