﻿using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Abstract;
using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.BusinessLayer.Concreate
{
    public class MenuTableManager:IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void TAdd(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public MenuTable TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MenuTable> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
