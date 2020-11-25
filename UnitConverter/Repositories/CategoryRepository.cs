using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Exceptions;
using Microsoft.UnitConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Repositories
{
    public class CategoryRepository
    {
        private readonly Dictionary<Category, CategoryProperties> _categories = new Dictionary<Category, CategoryProperties>();

        public CategoryRepository Add(CategoryProperties category)
        {
            if (_categories.ContainsKey(category.Key))
            {
                throw new DuplicateCategoryException(category.Key.ToString());
            }

            _categories.Add(category.Key, category);
            return this;
        }

        public static CategoryRepository Default { get; } = DefaultCategories.CreateRepository();
    }
}
