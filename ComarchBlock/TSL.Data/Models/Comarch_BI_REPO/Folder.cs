using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Folder
{
    public int FolId { get; set; }

    public int? FolParentId { get; set; }

    public string? FolName { get; set; }

    public DateTime FolCreatedOn { get; set; }

    public int FolOwnerId { get; set; }

    public DateTime? FolModifiedOn { get; set; }

    public string FolType { get; set; } = null!;

    public int FolCompanyId { get; set; }

    public virtual Company FolCompany { get; set; } = null!;

    public virtual Folder? FolParent { get; set; }

    public virtual ICollection<Folder> InverseFolParent { get; set; } = new List<Folder>();

    public virtual ICollection<Link> Links { get; set; } = new List<Link>();

    public virtual ICollection<RightsFoldersGroup> RightsFoldersGroups { get; set; } = new List<RightsFoldersGroup>();

    public virtual ICollection<RightsFoldersUser> RightsFoldersUsers { get; set; } = new List<RightsFoldersUser>();
}
