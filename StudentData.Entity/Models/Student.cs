﻿using System;
using System.Collections.Generic;

namespace StudentData.Entity.Models;

public partial class Student
{
    public int? Id { get; set; }

    public string Name { get; set; } = null!;

    public string Class { get; set; } = null!;

    public int? MarkObtained { get; set; }
    public virtual ICollection<SheetMaster> SheetMasters { get; set; } = new List<SheetMaster>();
    public Guid StudentId { get; set; }
}
