using UnitConverter.Models;
using UnitConverter.Repositories;

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
