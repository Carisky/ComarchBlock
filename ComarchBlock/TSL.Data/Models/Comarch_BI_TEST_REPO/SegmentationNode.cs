using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SegmentationNode
{
    public int SnId { get; set; }

    public int? SnParentId { get; set; }

    public string SnName { get; set; } = null!;

    public int SnType { get; set; }

    public int SnCompanyId { get; set; }

    public DateTime? SnModifiedOn { get; set; }

    public DateTime SnCreatedOn { get; set; }

    public virtual ICollection<SegmentationNode> InverseSnParent { get; set; } = new List<SegmentationNode>();

    public virtual ICollection<SegmentationFtpConnection> SegmentationFtpConnections { get; set; } = new List<SegmentationFtpConnection>();

    public virtual SegmentationNode? SnParent { get; set; }
}
