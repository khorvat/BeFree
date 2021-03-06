﻿using BeFree.Model.Common;
using BeFree.Repository.Common;
using BeFree.Service.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeFree.Service
{
    public class CategoryService : ICategoryService
    {
        protected ICategoryRepository Repository { get; private set; }

        public CategoryService(ICategoryRepository repository)
        {
            Repository = repository;
        }

        public Task<IEnumerable<ICategory>> GetAsync()
        {
            return Repository.GetAsync();
        }

        public Task<ICategory> GetAsync(Guid id)
        {
            return Repository.GetAsync(id);
        }

        public Task<int> AddAsync(ICategory category)
        {
            return Repository.AddAsync(category);
        }
    }
}
