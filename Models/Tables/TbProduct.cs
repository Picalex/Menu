using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Menu.Models.Tables
{
    public class TbProduct
    {
        [Key]//первычный ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long Id { get; set; }
        string ProductBindingName { get; set; }
        string SubMenuKey { get; set; }
        string IsStock { get; set; }
        string Articul { get; set; }
        long Cost { get; set; }
        string Description { get; set; }
        public virtual ICollection<TbSubMenu> TbSubMenus { get; set; }
        public TbProduct()
        {
            TbSubMenus = new List<TbSubMenu>();
        }

    }
}