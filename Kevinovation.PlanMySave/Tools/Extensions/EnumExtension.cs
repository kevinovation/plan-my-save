using Kevinovation.PlanMySave.Tools;
using System;
using System.Collections.Generic;

namespace PlanMySave.Tools.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// Is used to list all the values inside an enum
        /// </summary>
        /// <typeparam name="T">An enumeration</typeparam>
        /// <returns>aAll the values of this enum</returns>
        public static IEnumerable<EnumValue> GetValues<T>()
        {
            List<EnumValue> values = new List<EnumValue>();
            foreach (var itemType in Enum.GetValues(typeof(T)))
            {
                //For each value of this enumeration, add a new EnumValue instance
                values.Add(new EnumValue()
                {
                    Name = Enum.GetName(typeof(T), itemType),
                    Value = (int)itemType
                });
            }
            return values;
        }
    }
}