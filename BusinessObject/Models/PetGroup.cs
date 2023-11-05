using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class PetGroup
{
    public string PetGroupId { get; set; } = null!;

    public string PetGroupName { get; set; } = null!;

    public string? GroupDescription { get; set; }

    public string? OriginalSource { get; set; }

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
