using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class User
{
    public int Id { get; set; }

    public string AccountName { get; set; } = null!;

    public int RowVer { get; set; }

    public string? DisplayName { get; set; }

    public string Domain { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public bool IsMatrixCreator { get; set; }

    public bool IsUser { get; set; }
}
