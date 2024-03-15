using System;
using System.Collections.Generic;

namespace rrhh2.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
