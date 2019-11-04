﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface INewsDAL : IBaseDAL<News>
    {
        IQueryable<News> GetNewsByName(string newsName);
        IQueryable<News> GetNewsForIndex();
    }
}