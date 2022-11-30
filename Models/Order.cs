using System;
using System.Collections.Generic;

namespace ImageWebapi.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public string? OrderDate { get; set; }
}
