using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Movie_Store.Models.Data
{
    [Table("tblOrderDetails")]
    public class OrderDetailsDTO
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public virtual OrderDetailsDTO Orders { get; set; }

        [ForeignKey("UserId")]
        public virtual OrderDetailsDTO Users { get; set; }

        [ForeignKey("ProductId")]
        public virtual OrderDetailsDTO Products { get; set; }
    }
}