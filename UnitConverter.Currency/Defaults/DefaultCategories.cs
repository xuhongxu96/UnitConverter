using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Currency.Defaults
{
    public static class DefaultCategories
    {
        public static readonly Category Currency = new Category(nameof(Currency));

        public static CategoryRepository AddCurrencyCategory(this CategoryRepository categoryRepository)
        {
            return categoryRepository.Add(new CategoryProperties(Currency));
        }
    }
}
