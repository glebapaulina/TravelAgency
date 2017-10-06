using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Repositories;

namespace TravelAgency.BusinessLayer.Base
{
    public class BaseService<TEntity, TViewModel> : IBaseService<TEntity, TViewModel> where TEntity : class 
    {
        public IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }   

        public ObjectResult<IEnumerable<TViewModel>> GetAll()
        {           
            return new ObjectResult<IEnumerable<TViewModel>>( Mapper.Map<IEnumerable<TViewModel>>(_repository.GetAll()));
        }

        public ObjectResult<TViewModel> Get(int id)
        {
            var result = _repository.Get(id);
            return result == null ? new ObjectResult<TViewModel>() : new ObjectResult<TViewModel>(Mapper.Map<TViewModel>(result));
        }
          
        public ObjectResult<TViewModel> Add(TViewModel viewModel)
        {
            var result = Mapper.Map<TEntity>(viewModel);
            if (_repository.Add(result) == 1)
                return new ObjectResult<TViewModel>(Mapper.Map<TViewModel>(result));
            return new ObjectResult<TViewModel>();
        }

        public ObjectResult<IEnumerable<TViewModel>> AddRange(IEnumerable<TViewModel> viewModels)
        {
            var result = Mapper.Map<IEnumerable<TEntity>>(viewModels);
            if(_repository.AddRange(result) == 1)
                return new ObjectResult<IEnumerable<TViewModel>>(viewModels);
            return new ObjectResult<IEnumerable<TViewModel>>();
        }

        public ObjectResult<TViewModel> Remove(int id)
        {
            var result = _repository.Get(id);
            if (_repository.Remove(result)==1)
                return new ObjectResult<TViewModel>(Mapper.Map<TViewModel>(result));
            return new ObjectResult<TViewModel>();
        }

      
    }



}
