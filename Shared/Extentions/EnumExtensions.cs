using System.ComponentModel;

namespace UnitedSystemsCooperativeWebsite.Shared.Extentions;

public static class EnumExtensions
{
    public static string ToDescriptionString<T>(this T val) where T : Enum
    {
        var attributes = (DescriptionAttribute[]) val.GetType()
            .GetField(val.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }
}