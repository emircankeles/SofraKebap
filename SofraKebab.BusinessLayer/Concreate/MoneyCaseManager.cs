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
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDal _ımoneycasedal;

        public MoneyCaseManager(IMoneyCaseDal ımoneycasedal)
        {
            _ımoneycasedal = ımoneycasedal;
        }

        public void TAdd(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MoneyCase entity)
        {
            throw new NotImplementedException();
        }

        public MoneyCase TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MoneyCase> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _ımoneycasedal.TotalMoneyCaseAmount();
        }

        public void TUpdate(MoneyCase entity)
        {
            throw new NotImplementedException();
        }
    }
}
