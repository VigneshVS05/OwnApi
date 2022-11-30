using System;
using System.Collections.Generic;

namespace ImageWebapi.Models;

public partial class Book
{
    public int BId { get; set; }

    public string? BTitle { get; set; }

    public int? BAuthourid { get; set; }
}
