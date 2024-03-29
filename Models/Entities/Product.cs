using System;
using System.Collections.Generic;

namespace LAB7.Models.Entities;

public partial class Product
{
    public string ProductCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int OnHandQuantity { get; set; }

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; } = new List<InvoiceLineItem>();
}
