﻿using System;
using System.Collections.Generic;

namespace ConsoleTest.Models;

public partial class Invoice
{
    public long InvoiceId { get; set; }

    public long CustomerId { get; set; }

    public byte[] InvoiceDate { get; set; } = null!;

    public string? BillingAddress { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingPostalCode { get; set; }

    public byte[] Total { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<InvoiceItem> InvoiceItems { get; } = new List<InvoiceItem>();
}
