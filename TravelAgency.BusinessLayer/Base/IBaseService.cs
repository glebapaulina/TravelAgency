﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Repositories;

namespace TravelAgency.BusinessLayer.Base
{
    public interface IBaseService<TEntity, TViewModel>     
    {
        ObjectResult<TViewModel> Get(int id);
        IEnumerable<TViewModel> GetAll();
        void Add(TViewModel viewModel);
        void AddRange(IEnumerable<TViewModel> viewModels);
        ObjectResult<TViewModel> Remove(int entity);

    }
}