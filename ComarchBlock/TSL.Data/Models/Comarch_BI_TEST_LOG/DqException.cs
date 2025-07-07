using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class DqException
{
    public int DqeId { get; set; }

    public int DqeDqcode { get; set; }

    public string? DqeName1 { get; set; }

    public string? DqeValue1 { get; set; }

    public string? DqeOperator1 { get; set; }

    public string? DqeName2 { get; set; }

    public string? DqeValue2 { get; set; }

    public string? DqeOperator2 { get; set; }

    public int DqeDateFrom { get; set; }

    public int DqeDateTo { get; set; }

    public bool DqeIsActive { get; set; }
}
