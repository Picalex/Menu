using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Menu.Models.Tables
{
    public class TbSubMenu
    {
        [Key]//первычный ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long Id { get; set;}
        long SubMenuId { get; set; }
        string Order { get; set; }
        string ViewType { get; set; }
        string BindingName { get; set; }
        string Description { get; set; }
        string Info { get; set; }
        string IsPacketPaymentGroup { get; set; }
        string BackId { get; set; }
        public virtual ICollection<TbProduct> TbProducts { get; set; }//навигационное свойство ?
        public TbSubMenu()
        {
            TbProducts = new List<TbProduct>();
        }

    }
}