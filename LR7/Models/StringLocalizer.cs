using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace LR7.Models
{
    public class StringLocalizer : IStringLocalizer
    {
        Dictionary<string, Dictionary<string, string>> resources;

        const string HEADER = "Header";
        const string TITLE = "Title";
        const string TITLE2 = "Title2";
        const string TITLE3 = "Title3";
        const string NAME = "Name";
        const string NAME2 = "Name2";
        const string NAME3 = "Name3";
        const string NAME4 = "Name4";
        const string CATEGORY = "Category";
        const string CATEGORY2 = "Category2";
        const string CATEGORY3 = "Category3";
        const string CATEGORY4 = "Category4";
        const string PRICE = "Price";
        const string PRICE2 = "Price2";
        const string PRICE3 = "Price3";
        const string PRICE4 = "Price4";


        public StringLocalizer()
        {
            Dictionary<string, string> enDict = new Dictionary<string, string>
            {
                {HEADER, "List of items and their prices" },
                {TITLE, "Name" },
                {TITLE2, "Category" },
                {TITLE3, "Price" },
                {NAME, "Black Jeans" },
                {NAME2, "Salmon" },
                {NAME3, "Xiaomi phone" },
                {NAME4, "Vine Muscat" },
                {CATEGORY,"Clothes"},
                {CATEGORY2,"Fish"},
                {CATEGORY3,"Technique"},
                {CATEGORY4,"Alcoholic drink"},
                {PRICE, "$18"},
                 {PRICE2, "$2"},
                 {PRICE3, "$178"},
                 {PRICE4, "$9"}

            };
          
            Dictionary<string, string> ukrDict = new Dictionary<string, string>
            {
                {HEADER, "Список товарів та їх ціни" },
                {TITLE, "Назва" },
                {TITLE2, "Категорія" },
                {TITLE3, "Ціна" },
                {NAME, "Чорні джинси" },
                {NAME2, "Лосось" },
                {NAME3, "телефон Xiaomi" },
                {NAME4, "Вино Muscat" },
                {CATEGORY,"Одяг"},
                {CATEGORY2,"Риба"},
                {CATEGORY3,"Техніка"},
                {CATEGORY4,"Алкогольний напій"},
                {PRICE, "504 грн"},
                 {PRICE2, "56 грн"},
                 {PRICE3, "5000 грн"},
                 {PRICE4, "252 грн"}
            };
  
            resources = new Dictionary<string, Dictionary<string, string>>
            {
                {"en", enDict },
                {"uk", ukrDict }
            };
        }
        // по ключу выбираем для текущей культуры нужный ресурс
        public LocalizedString this[string name]
        {
            get
            {
                var currentCulture = CultureInfo.CurrentUICulture;
                string val = "";
                if (resources.ContainsKey(currentCulture.Name))
                {
                    if (resources[currentCulture.Name].ContainsKey(name))
                    {
                        val = resources[currentCulture.Name][name];
                    }
                }
                return new LocalizedString(name, val);
            }
        }

        public LocalizedString this[string name, params object[] arguments] => throw new NotImplementedException();

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new NotImplementedException();
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            return this;
        }
    }


}
