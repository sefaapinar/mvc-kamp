﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.concrete;

namespace DataAccess.EntityFramework
{
    public class EFCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        
    }
}
