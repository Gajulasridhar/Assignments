using System;
using System.Collections.Generic;

namespace HandsOnEFDB.Entities;

public partial class WorksOn
{
    public int? EmpNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? Job { get; set; }

    public DateOnly? EnterDate { get; set; }

    public virtual Employee? EmpNoNavigation { get; set; }

    public virtual Project? ProjectNoNavigation { get; set; }
}
