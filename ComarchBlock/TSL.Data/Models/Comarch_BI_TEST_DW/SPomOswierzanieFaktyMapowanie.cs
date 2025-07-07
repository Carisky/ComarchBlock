using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class SPomOswierzanieFaktyMapowanie
{
    public int OdswId { get; set; }

    public int OdswEprmid { get; set; }

    public int OdswTblid { get; set; }

    public int OdswTlnid { get; set; }

    public int OdswArea { get; set; }

    public int OdswType { get; set; }

    public string OdswTableName { get; set; } = null!;

    public int OdswEpsid { get; set; }

    public string OdswEprmName { get; set; } = null!;

    public int OdswEpvValue { get; set; }

    public int OdswEpvValueAfter { get; set; }
}
