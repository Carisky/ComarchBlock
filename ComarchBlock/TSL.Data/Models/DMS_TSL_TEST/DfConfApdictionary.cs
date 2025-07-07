using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfApdictionary
{
    public int ApdId { get; set; }

    public string ApdName { get; set; } = null!;

    public int ApdDfhid { get; set; }

    public string ApdConnectionString { get; set; } = null!;

    public string? ApdSqliterator { get; set; }

    public string? ApdScanFolderPath { get; set; }

    public byte? ApdTrackingDatabaseType { get; set; }

    public bool ApdArchival { get; set; }

    public byte ApdSaldeoMode { get; set; }

    public string? ApdSaldeoId { get; set; }

    public string? ApdSaldeoUrl { get; set; }

    public string? ApdSaldeoToken { get; set; }

    public string? ApdSaldeoUser { get; set; }

    public bool ApdRemoveFromListAndMailbox { get; set; }

    public bool ApdRemoveFromMailboxAfterGenerating { get; set; }

    public string? ApdMailboxHost { get; set; }

    public int? ApdMailboxPort { get; set; }

    public byte ApdMailboxSecureConnectionType { get; set; }

    public string? ApdMailboxUser { get; set; }

    public string? ApdMailboxPassword { get; set; }

    public bool ApdUseSaldeoApiConfigurationPoint { get; set; }

    public int? ApdSaldeoApiConfigurationPointId { get; set; }

    public bool ApdShowMailSubject { get; set; }

    public bool ApdShowMailSender { get; set; }

    public bool ApdShowMailDate { get; set; }

    public bool ApdCopyOnlyGraphicAttachmentsToDisk { get; set; }

    public string? ApdInsertCommand { get; set; }

    public byte? ApdOcrDocumentType { get; set; }

    public byte? ApdOcrDocumentCountry { get; set; }

    public string? ApdAttachmentControlName { get; set; }

    public byte? ApdOcrDocumentBarcode { get; set; }

    public byte? ApdOcrLinkPagesByContent { get; set; }

    public string? ApdOcrDefaultPaymentType { get; set; }

    public string? ApdOcrPagesToRecognize { get; set; }

    public bool ApdDisableOcrFilesArchiving { get; set; }

    public string? ApdMailboxAccessToken { get; set; }

    public string? ApdMailboxRefreshToken { get; set; }

    public byte ApdMailboxAuthenticationMethod { get; set; }

    public string? ApdMailboxOauthProviderName { get; set; }

    public string? ApdRepositoryDocumentTypeId { get; set; }

    public string? ApdRepositoryLocationId { get; set; }

    public bool ApdTextSearchInRepositoryModule { get; set; }

    public int ApdConnectionType { get; set; }

    public int? ApdCompanyId { get; set; }

    public virtual ICollection<DfConfApcontrol> DfConfApcontrols { get; set; } = new List<DfConfApcontrol>();
}
