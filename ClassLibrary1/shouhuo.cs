//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class shouhuo
    {
        public shouhuo()
        {
            this.tuihuos = new HashSet<tuihuo>();
        }
    
        public string no { get; set; }
        public string sno { get; set; }
        public int snum { get; set; }
        public decimal price { get; set; }
        public string outdate { get; set; }
        public string sperson { get; set; }
        public decimal sum1 { get; set; }
    
        public virtual shangpin shangpin { get; set; }
        public virtual ICollection<tuihuo> tuihuos { get; set; }
    }
}
