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

namespace TravelAgency.BusinessLayer.Base
{
    public class BaseService<TEntity, TViewModel> : IBaseService<TEntity, TViewModel> where TEntity : class 
    {
        public IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }   

        public IEnumerable<TViewModel> GetAll()
        {        
            return Mapper.Map<IEnumerable<TViewModel>>(_repository.GetAll());
        }

        public ObjectResult<TViewModel> Get(int id)
        {
            var result = _repository.Get(id);
            if (result == null)
                return new ObjectResult<TViewModel>();
            return new ObjectResult<TViewModel>(Mapper.Map<TViewModel>(result));

        }
          
        public void Add(TViewModel viewModel)
        {
            _repository.Add(Mapper.Map<TEntity>(viewModel));
        }

        public void AddRange(IEnumerable<TViewModel> viewModels)
        {
            _repository.AddRange(Mapper.Map<IEnumerable<TEntity>>(viewModels));
        }

        public ObjectResult<TViewModel> Remove(int id)
        {
            var result = _repository.Get(id);
            if(result == null)
                return new ObjectResult<TViewModel>();
            _repository.Remove(result);
          
            return new ObjectResult<TViewModel>(Mapper.Map<TViewModel>(result));
        }

      
    }



}
