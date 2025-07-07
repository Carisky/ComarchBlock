using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfCmdictionary
{
    public int CmdId { get; set; }

    public string CmdCompanyName { get; set; } = null!;

    public string? CmdDisplayName { get; set; }

    public string? CmdShortcut { get; set; }

    public int? CmdConnectionTypeErp { get; set; }

    public string? CmdConnectionStringErp { get; set; }

    public string? CmdLicenceKeyServerXl { get; set; }

    public string? CmdDatabase { get; set; }

    public string? CmdLogin { get; set; }

    public string? CmdPassword { get; set; }

    public int? CmdErpdepartmentId { get; set; }

    public string? CmdMigratorGetEmployeesQuery { get; set; }

    public string? CmdMigratorGetPositionsQuery { get; set; }

    public string? CmdMigratorGetGetDepartmentsQuery { get; set; }

    public string? CmdMigratorGetOrganizationStructureQuery { get; set; }

    public string? CmdDomainName { get; set; }

    public string? CmdDomainGroup { get; set; }

    public bool? CmdArchival { get; set; }

    public byte CmdErpSystem { get; set; }

    public string? CmdConnectionStringErpconf { get; set; }

    public int? CmdNatCompanyId { get; set; }

    public bool CmdUseDomain { get; set; }

    public string? CmdUrl { get; set; }

    public string? CmdRestService { get; set; }

    public string? CmdCertificateName { get; set; }

    public string? CmdOrganizationId { get; set; }

    public string? CmdOrganizationName { get; set; }

    public string? CmdConnectionStringErpencrypted { get; set; }

    public string? CmdConnectionStringErpconfEncrypted { get; set; }

    public string? CmdPasswordEncrypted { get; set; }

    public string? CmdNip { get; set; }

    public string? CmdKseFtoken { get; set; }

    public virtual ICollection<DfApiKey> DfApiKeys { get; set; } = new List<DfApiKey>();
}
