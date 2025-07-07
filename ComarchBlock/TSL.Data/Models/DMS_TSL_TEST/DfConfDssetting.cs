using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfDssetting
{
    public int DstDshid { get; set; }

    public bool DstCanPrintOutboxBook { get; set; }

    public int? DstMappedControlForContractor { get; set; }

    public int? DstMappedControlForRecipientAddress { get; set; }

    public int? DstMappedControlForDeclaredValue { get; set; }

    public int? DstMappedControlForWeight { get; set; }

    public int? DstMappedControlForShipmentNumber { get; set; }

    public int? DstMappedControlForComments { get; set; }

    public int? DstMappedControlForShipmentFee { get; set; }

    public int? DstMappedControlForShipmentValue { get; set; }

    public bool DstWorkWithMobile { get; set; }

    public int? DstMappedControlForParameter1 { get; set; }

    public int? DstMappedControlForParameter2 { get; set; }

    public int? DstCompanyId { get; set; }

    public bool? DstWorkflowCardVisibilityFromPropagationMoment { get; set; }

    public string? DstOwnData { get; set; }

    public bool DstIsAutoSaveOnDocumentCreationEnabled { get; set; }

    public bool DstUseCurrentCompany { get; set; }

    public int DstParameter1 { get; set; }

    public int DstParameter2 { get; set; }

    public int DstParameter3 { get; set; }

    public int DstParameter4 { get; set; }

    public int DstParameter5 { get; set; }

    public bool DstShowLabelForParameter1 { get; set; }

    public bool DstShowLabelForParameter2 { get; set; }

    public bool DstShowLabelForParameter3 { get; set; }

    public bool DstShowLabelForParameter4 { get; set; }

    public bool DstShowLabelForParameter5 { get; set; }

    public virtual DfConfDshead DstDsh { get; set; } = null!;
}
