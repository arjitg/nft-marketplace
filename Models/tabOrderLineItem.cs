﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestReverseEngineer.Models
{
    [Table("tabOrderLineItem")]
    public partial class tabOrderLineItem
    {
        [Key]
        public int OrderItemID { get; set; }
        public int? OrderName { get; set; }
        public int? ItemName { get; set; }
        public double? ItemPrice { get; set; }
        public double? ItemTax { get; set; }

        [ForeignKey("ItemName")]
        [InverseProperty("tabOrderLineItems")]
        public virtual tabItem ItemNameNavigation { get; set; }
        [ForeignKey("OrderName")]
        [InverseProperty("tabOrderLineItems")]
        public virtual tabOrder OrderNameNavigation { get; set; }
    }
}