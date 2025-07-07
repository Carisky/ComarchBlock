using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class BankiFormKryt
{
    public int BfkId { get; set; }

    public int? BfkBankDefId { get; set; }

    public byte? BfkOperatorLog { get; set; }

    public byte? BfkOperator { get; set; }

    public byte? BfkTypOperacji { get; set; }

    public string? BfkKodOperacji { get; set; }
}
