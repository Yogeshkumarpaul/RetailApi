using System;
using System.Collections.Generic;

namespace RF.Models
{
    public partial class Accounts
    {
        public long AccountId { get; set; }
        public string CompanyName { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string AddLine3 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string TinNo { get; set; }
        public string WebSite { get; set; }
        public bool? IsSupplier { get; set; }
        public bool? IsManufacturer { get; set; }
        public bool? IsCustomer { get; set; }
    }
}
