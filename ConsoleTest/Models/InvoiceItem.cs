using System;
using System.Collections.Generic;

namespace ConsoleTest.Models;

public partial class InvoiceItem
{
    public long InvoiceLineId { get; set; }

    public long InvoiceId { get; set; }

    public long TrackId { get; set; }

    public byte[] UnitPrice { get; set; } = null!;

    public long Quantity { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Track Track { get; set; } = null!;
}
