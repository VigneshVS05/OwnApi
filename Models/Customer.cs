using System;
using System.Collections.Generic;

namespace ImageWebapi.Models;

public partial class Customer
{
    public int? Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? FavoriteWebsite { get; set; }
}
