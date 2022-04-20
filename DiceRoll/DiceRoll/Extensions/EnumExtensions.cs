using DiceRoll.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceRoll.Extensions
{
    public static class EnumExtensions
    {
        public static Dictionary<T, Option<T>> GetEnumDictionary<T>()
            where T : Enum
        {
            Dictionary<T,Option<T>> enumDictionary = new();
            foreach (var optionType in (T[])Enum.GetValues(typeof(T)))
                enumDictionary.Add(optionType, new Option<T>(optionType));
            return enumDictionary;
        }

        public static string GetDescription(this Enum genericEnum)
        {
            string description = null;
            var memberInfo = genericEnum.GetType().GetMember(genericEnum.ToString());
            if (memberInfo?.Any() ?? false)
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attribs?.Any() ?? false)
                {
                    description = ((System.ComponentModel.DescriptionAttribute)attribs.ElementAt(0)).Description;
                }
            }
            return description ?? genericEnum.ToString();
        }
    }
}
