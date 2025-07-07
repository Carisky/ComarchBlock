using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class MdSession
{
    public int MdsLoggedInDcdid { get; set; }

    public Guid? MdsAuthenticationToken { get; set; }

    public DateTime? MdsAuthenticationTokenExpirationDate { get; set; }

    public Guid MdsAuthorisationToken { get; set; }

    public DateTime? MdsAuthorisationTokenExpirationDate { get; set; }

    public DateTime? MdsLastActivityTime { get; set; }

    public Guid? MdsSguid { get; set; }
}
