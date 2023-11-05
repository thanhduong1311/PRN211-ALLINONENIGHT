using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class MemberOrder
{
    public int Id { get; set; }

    public int? Quantity { get; set; }

    public int? TotalPrice { get; set; }

    public string MemberId { get; set; } = null!;

    public int PetId { get; set; }

    public virtual PetShopMember Member { get; set; } = null!;

    public virtual Pet Pet { get; set; } = null!;
}
