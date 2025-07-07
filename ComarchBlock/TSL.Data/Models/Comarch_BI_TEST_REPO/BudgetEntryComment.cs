using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class BudgetEntryComment
{
    public int CommentId { get; set; }

    public int BudgetEntryId { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDate { get; set; }

    public string? CommentText { get; set; }

    public byte[]? History { get; set; }
}
