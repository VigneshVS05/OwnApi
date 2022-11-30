using System;
using System.Collections.Generic;

namespace ImageWebapi.Models;

public partial class Imagesss
{
    public int ImageId { get; set; }

    public string? ImageAttributes { get; set; }

    public string? Categories { get; set; }

    public string? ImageUrl { get; set; }
}
