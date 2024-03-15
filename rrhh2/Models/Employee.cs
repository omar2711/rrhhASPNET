using System;
using System.Collections.Generic;

namespace rrhh2.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int PositionId { get; set; }

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Position Position { get; set; } = null!;
}
