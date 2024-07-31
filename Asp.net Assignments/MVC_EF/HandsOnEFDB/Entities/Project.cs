using System;
using System.Collections.Generic;

namespace HandsOnEFDB.Entities;

public partial class Project
{
    public string ProjectNo { get; set; } = null!;

    public string? ProjectNameabk { get; set; }

    public int? Budget { get; set; }
}
