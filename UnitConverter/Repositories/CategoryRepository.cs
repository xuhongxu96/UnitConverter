using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Exceptions;
using Microsoft.UnitConverter.Models;
using System.Collections.Generic;

namespace Microsoft.UnitConverter.Repositories
{
    public class CategoryRepository
    {
        private readonly Dictionary<Category, CategoryProperties> _categories = new Dictionary<Category, CategoryProperties>();

        public CategoryRepository Clear()
        {
            _categories.Clear();
            return this;
        }

        public CategoryRepository Add(CategoryProperties category)
        {
            if (_categories.ContainsKey(category.Key))
            {
                throw new DuplicateCategoryException(category.Key.ToString());
            }

            _categories.Add(category.Key, category);
            return this;
        }

        public CategoryProperties this[Category category]
        {
            get => _categories[category];
            set => _categories[category] = value;
        }

        public CategoryProperties Get(Category category)
        {
            return _categories[category];
        }

        public static CategoryRepository Default { get; } = DefaultCategories.CreateRepository();
    }
}
