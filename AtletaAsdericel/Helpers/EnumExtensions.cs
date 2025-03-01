using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AtletaAsdericel.Helpers
{
	public static class EnumExtensions
	{
		public static string GetDisplayName(this Enum enumValue)
		{
			var attribute = enumValue.GetType()
									 .GetMember(enumValue.ToString())[0]
									 .GetCustomAttribute<DisplayAttribute>();

			return attribute?.Name ?? enumValue.ToString();
		}
	}
}
