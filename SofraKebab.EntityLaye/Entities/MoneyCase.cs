using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.EntityLayer.Entities
{
    public class MoneyCase
    {
        [Key]
        public int CaseID { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
