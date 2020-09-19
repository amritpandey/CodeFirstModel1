using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace udemyCodeFirst.Models
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [Key]
        public int OrderItemID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}