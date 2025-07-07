using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfStampDictionary
{
    public int DcsCompanyId { get; set; }

    public string? DcsLine1 { get; set; }

    public string? DcsLine2 { get; set; }

    public string? DcsLine3 { get; set; }

    public int DcsLenLp { get; set; }

    public int DcsLenDocumentNummber { get; set; }

    public int DcsLenCustomerName { get; set; }

    public int DcsLenCustomerAdress { get; set; }

    public int DcsLenDeclaredValue { get; set; }

    public int DcsLenWeight { get; set; }

    public int DcsLenBroadcastNumber { get; set; }

    public int DcsLenComments { get; set; }

    public int DcsLenCharge { get; set; }

    public int DcsLenAmount { get; set; }
}
