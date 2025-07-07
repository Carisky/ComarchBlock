using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfOsdictionary
{
    public int DcdId { get; set; }

    public string DcdName1 { get; set; } = null!;

    public string? DcdName2 { get; set; }

    public string? DcdName3 { get; set; }

    public int? DcdType { get; set; }

    public bool DcdArchival { get; set; }

    public int? DcdDcpid { get; set; }

    public int? DcdNatSystemId { get; set; }

    public int? DcdSid { get; set; }

    public string? DcdLogin { get; set; }

    public string? DcdPassword { get; set; }

    public string? DcdMail { get; set; }

    public short DcdLoginMethod { get; set; }

    public short DcdRole { get; set; }

    public int? DcdNatTypeId { get; set; }

    public bool DcdDeleteDocument { get; set; }

    public bool DcdCanPrintPreview { get; set; }

    public bool DcdCanPrintOutboxBook { get; set; }

    public bool DcdCanExportListToSpreadsheet { get; set; }

    public byte DcdBackToListAfterPropagate { get; set; }

    public bool DcdStandardPrintout { get; set; }

    public bool DcdModificationOfDocumentNumber { get; set; }

    public bool DcdCreateDocumentFromScan { get; set; }

    public bool DcdAutoCreateDocuments { get; set; }

    public bool DcdUseOwnXllogin { get; set; }

    public int? DcdReplacementEmployeeId { get; set; }

    public DateOnly? DcdReplacementStartDate { get; set; }

    public DateOnly? DcdReplacementEndDate { get; set; }

    public bool DcdReplacementDateRestrictionsDisabled { get; set; }

    public bool DcdPositionRelatedWithDepartment { get; set; }

    public string? DcdErplogin { get; set; }

    public bool DcdCanCreateDashboards { get; set; }

    public byte DcdModulesPermission { get; set; }

    public int? DcdCompanyId { get; set; }

    public string? DcdSaldeoId { get; set; }

    public string? DcdSaldeoLogin { get; set; }

    public bool DcdCanConfirmContentTerms { get; set; }

    public bool DcdCanConfirmIntegrityAndAccountsTerms { get; set; }

    public bool DcdIsAnonymized { get; set; }

    public string? DcdAnonymizedDescription { get; set; }

    public DateTime? DcdAnonymizedStartDate { get; set; }

    public DateTime? DcdLastModificationDate { get; set; }

    public Guid? DcdUserLoginToken { get; set; }

    public bool DcdRunErpinTheBackground { get; set; }

    public string? DcdNatSystemId2 { get; set; }

    public bool DcdDefaultFullScreen { get; set; }

    public byte DcdForAllDocumentWorkflowsSetSections { get; set; }

    public bool DcdCanCreateRpaprograms { get; set; }

    public bool DcdMlstageSuggestions { get; set; }

    public DateTime? DcdMlstageSuggestionsLastCalculation { get; set; }

    public bool DcdMessageOnWorkflowDetailsClosing { get; set; }

    public string? DcdAdditionalName1 { get; set; }

    public string? DcdAdditionalName2 { get; set; }

    public string? DcdAdditionalName3 { get; set; }

    public string? DcdAdditionalName4 { get; set; }

    public string? DcdAdditionalName5 { get; set; }

    public string? DcdApiKey { get; set; }

    public string? DcdOptimaPraimportRowId { get; set; }

    public int? DcdAppid { get; set; }

    public byte DcdSelectedStartupPanelOption { get; set; }

    public string? Dcd2fasecretKey { get; set; }

    public byte DcdGeneralLogConfigSource { get; set; }

    public bool DcdIsGeneralLoggingEnabled { get; set; }

    public byte DcdRobotizationLogConfigSource { get; set; }

    public bool DcdIsRobotizationLoggingEnabled { get; set; }

    public virtual DfConfOsdictionary? DcdReplacementEmployee { get; set; }

    public virtual ICollection<DfApiKey> DfApiKeys { get; set; } = new List<DfApiKey>();

    public virtual ICollection<DfConfOstree> DfConfOstrees { get; set; } = new List<DfConfOstree>();

    public virtual ICollection<DfOneTimeToken> DfOneTimeTokens { get; set; } = new List<DfOneTimeToken>();

    public virtual ICollection<DfRefreshToken> DfRefreshTokens { get; set; } = new List<DfRefreshToken>();

    public virtual ICollection<DfWorkD> DfWorkDDwsDcdpeople { get; set; } = new List<DfWorkD>();

    public virtual ICollection<DfWorkD> DfWorkDDwsDcdreplacementPeople { get; set; } = new List<DfWorkD>();

    public virtual ICollection<DfWorkOsclosedDoc> DfWorkOsclosedDocs { get; set; } = new List<DfWorkOsclosedDoc>();

    public virtual ICollection<DfWorkOsworkDoc> DfWorkOsworkDocs { get; set; } = new List<DfWorkOsworkDoc>();

    public virtual ICollection<DfWork> DfWorks { get; set; } = new List<DfWork>();

    public virtual ICollection<DfConfOsdictionary> InverseDcdReplacementEmployee { get; set; } = new List<DfConfOsdictionary>();
}
