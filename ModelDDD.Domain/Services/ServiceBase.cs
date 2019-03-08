﻿using ModelDDD.Domain.Interfaces.Repositories;
using ModelDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private IProdutoRepository produtoRepository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public ServiceBase(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
