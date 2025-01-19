﻿using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.DataAccessLayer.Abstract
{
    public interface IMoneyCaseDal :IGenericDal<MoneyCase>
    {
        decimal TotalMoney();
    }
}
