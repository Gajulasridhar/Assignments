using System;
using System.Collections.Generic;

namespace HandsOnEFDB.Entities;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string? EmpFname { get; set; }

    public string? EmpLname { get; set; }

    public string? DeptNo { get; set; }

    public virtual Department? DeptNoNavigation { get; set; }
}
