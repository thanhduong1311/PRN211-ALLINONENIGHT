using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class PetShopMember
{
    public string MemberId { get; set; } = null!;

    public string MemberPassword { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public int? MemberRole { get; set; }

    public virtual ICollection<MemberOrder> MemberOrders { get; set; } = new List<MemberOrder>();
}
