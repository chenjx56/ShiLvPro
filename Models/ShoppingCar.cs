//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCar
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int GoodsID { get; set; }
        public int GoodsNum { get; set; }
        public decimal RMBPrice { get; set; }
        public int CreditPrice { get; set; }
        public System.DateTime AddTime { get; set; }
        public decimal RMBSumPrice { get; set; }
        public int CreditSumPrice { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual Users Users { get; set; }
    }
}