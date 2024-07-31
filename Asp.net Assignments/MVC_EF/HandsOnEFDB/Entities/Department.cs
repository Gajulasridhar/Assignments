using System;
using System.Collections.Generic;

namespace HandsOnEFDB.Entities;

public partial class Department
{
    public string DeptNo { get; set; } = null!;

    public string? DeptName { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
