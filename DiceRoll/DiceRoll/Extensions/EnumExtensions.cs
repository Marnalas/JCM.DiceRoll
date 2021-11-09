using DiceRoll.DataModels;
using System;
using System.Collections.Generic;

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
    }
}
