using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ESklepAdresyNadawczeRelacje
{
    public int EsanEsanid { get; set; }

    public int EsanSanoptimaId { get; set; }

    public int EsanSaneSklepId { get; set; }

    public int EsanESklepId { get; set; }

    public DateTime EsanTs { get; set; }

    public virtual SenditAdresyNadawcze EsanSanoptima { get; set; } = null!;
}
