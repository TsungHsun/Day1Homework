using System;

namespace Day1_Homework.Entity
{
    /// <summary>
    /// 商品資料
    /// </summary>
    [Serializable]
    public class Product
    {
        /// <summary>
        /// 商品編號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 成本
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// 收益
        /// </summary>
        public int Revenue { get; set; }
        /// <summary>
        /// 售價
        /// </summary>
        public int SellPrice { get; set; }
    }
}
