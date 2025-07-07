using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class ESklepKntRelacje
{
    public int EskEskid { get; set; }

    public int EskKntOptimaId { get; set; }

    public int EskKnteSklepId { get; set; }

    public int EskESklepId { get; set; }
}
