using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Day1_Homework
{
    public class CollectionService
    {
        /// <summary>
        /// 幾筆一組的加總物件集合內的某屬性值
        /// </summary>
        /// <typeparam name="T">物件型別</typeparam>
        /// <param name="collection">物件集合</param>
        /// <param name="propertyName">屬性名稱</param>
        /// <param name="groupCount">幾筆一組</param>
        /// <returns>物件集合內某屬性的每組屬性值加總</returns>
        public List<int> SumPropertyValueByGroupCount<T>(IEnumerable<T> collection, string propertyName, int groupCount)
        {
            if (collection == null) throw new ArgumentNullException("collection", "物件集合參數值不得為Null");
            if (string.IsNullOrEmpty(propertyName)) throw new ArgumentNullException("propertyName", "屬性名稱參數值不得為空字串或Null");
            if (groupCount < 1) throw new ArgumentException("groupCount", "幾筆一組的參數值必須大於0");

            List<int> result = new List<int>();

            for (int index = 0; index < collection.Count(); index += groupCount)
            {
                result.Add(this.SumPropertyValue(collection.Skip(index).Take(groupCount), propertyName));
            }

            return result;
        }

        /// <summary>
        /// 加總物件集合內的某屬性值
        /// </summary>
        /// <typeparam name="T">物件型別</typeparam>
        /// <param name="collection">物件集合</param>
        /// <param name="propertyName">屬性名稱</param>
        /// <returns>屬性值的加總</returns>
        private int SumPropertyValue<T>(IEnumerable<T> collection, string propertyName)
        {
            int result = 0;

            Type type = typeof(T);
            PropertyInfo propertyInfo = type.GetProperty(propertyName);

            if (this.CheckPropertyTypeIsInt(propertyInfo))
            {
                result = collection.Where(item => item != null)
                                   .Select(item => Convert.ToInt32(propertyInfo.GetValue(item)))
                                   .Sum();
            }

            return result;
        }

        /// <summary>
        /// 檢查屬性型別是否為Int
        /// </summary>
        /// <param name="propertyInfo">屬性資訊</param>
        /// <returns>是否為Int</returns>
        private bool CheckPropertyTypeIsInt(PropertyInfo propertyInfo)
        {
            return propertyInfo != null
                && propertyInfo.PropertyType == typeof(int);
        }
    }
}
