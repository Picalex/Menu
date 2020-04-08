using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Menu.Models.Tables
{
    public class TbSubMenu
    {
        long Id { get; set;}
        long SubMenuId { get; set; }
        string Order { get; set; }
        string ViewType { get; set; }
        string BindingName { get; set; }
        string Description { get; set; }
        string Info { get; set; }
        string IsPacketPaymentGroup { get; set; }
        string BackId { get; set; }

    }
}