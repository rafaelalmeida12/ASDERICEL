using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.Reflection;

namespace AtletaAsdericel.Helpers
{
    public static class EnumHelper
    {
        public static IEnumerable<SelectListItem> GetEnumSelectList<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                       .Cast<TEnum>()
                       .Select(e => new SelectListItem
                       {
                           Value = e.ToString(),
                           Text = GetEnumDescription(e)
                       });
        }

        private static string GetEnumDescription<TEnum>(TEnum enumValue) where TEnum : Enum
        {
            FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute == null ? enumValue.ToString() : attribute.Description;
        }
    }
}
