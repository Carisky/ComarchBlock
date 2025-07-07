using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Stany
{
    public int DtsKksnumer { get; set; }

    public int DtsRokMiesiac { get; set; }

    public int DtsSpid { get; set; }

    public decimal? DtsObrotyDebet { get; set; }

    public decimal? DtsObrotyDebetBuf { get; set; }

    public decimal? DtsObrotyCredit { get; set; }

    public decimal? DtsObrotyCreditBuf { get; set; }

    public decimal? DtsObrotyNarDebet { get; set; }

    public decimal? DtsObrotyNarCredit { get; set; }

    public decimal? DtsObrotyNarDebetBuf { get; set; }

    public decimal? DtsObrotyNarCreditBuf { get; set; }
}
