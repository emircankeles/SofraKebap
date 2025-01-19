﻿using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.BusinessLayer.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
        int TTotalOrderCount();
        int TActiveOrders();
        decimal TLastOrderPrice();
        decimal TTodayGetMoney();
    }
}
