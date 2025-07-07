using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OrganizacjePp
{
    public int OrgPpOrgPpid { get; set; }

    public string OrgPpNumerKrs { get; set; } = null!;

    public string? OrgPpNazwa { get; set; }

    public string? OrgPpMiejscowosc { get; set; }
}
