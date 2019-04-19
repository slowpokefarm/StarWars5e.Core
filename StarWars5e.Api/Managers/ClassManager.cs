﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using StarWars5e.Api.Interfaces;
using StarWars5e.Models.Class;
using StarWars5e.Models.Enums;
using StarWars5e.Models.Search;
using Wolnik.Azure.TableStorage.Repository;

namespace StarWars5e.Api.Managers
{
    public class ClassManager : IClassManager
    {
        private readonly ITableStorage _tableStorage;

        public ClassManager(ITableStorage tableStorage)
        {
            _tableStorage = tableStorage;
        }

        public async Task<PagedSearchResult<Class>> SearchClasses(ClassSearch classSearch)
        {
            var filter = "";
            if (!string.IsNullOrEmpty(classSearch.Name))
            {
                filter = $"Name eq '{classSearch.Name}'";
            }
            if (classSearch.ContentType.HasValue && classSearch.ContentType != ContentType.None)
            {
                if (!string.IsNullOrEmpty(filter)) filter = $"{filter} and";
                filter = $"{filter} ContentType eq '{classSearch.ContentType.ToString()}'";
            }

            var query = new TableQuery<Class>().Where(filter);
            var classes = await _tableStorage.QueryAsync("classes", query);

            return new PagedSearchResult<Class>(classes.ToList(), classSearch.PageSize, classSearch.CurrentPage);
        }
    }
}
