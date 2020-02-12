using System;
using System.Collections.Generic;

namespace RF.Models
{
    public partial class TypeDetail
    {
        public int TypeId { get; set; }
        public int? TypeCode { get; set; }
        public string TypeName { get; set; }
        public string DetailName { get; set; }
    }
}
