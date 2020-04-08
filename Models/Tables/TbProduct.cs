using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Menu.Models.Tables
{
    public class TbProduct
    {
        long id { get; set; }
        string ProductBindingName { get; set; }
        string SubMenuKey { get; set; }
        string IsStock { get; set; }
        string Articul { get; set; }
        long Cost { get; set; }
        string Description { get; set; }


    }
}