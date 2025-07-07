using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PrmKarty
{
    public int PrmId { get; set; }

    public string? PrmAkronim { get; set; }

    public int? PrmDataOd { get; set; }

    public int? PrmDataDo { get; set; }

    public int? PrmTyp { get; set; }

    public int? PrmPriorytet { get; set; }

    public int? PrmStan { get; set; }

    public int? PrmAktywna { get; set; }

    public short? PrmSposobStosowania { get; set; }

    public short? PrmPominPozostale { get; set; }

    public string? PrmUwagi { get; set; }

    public short? PrmDokument { get; set; }

    public int? PrmLastMod { get; set; }

    public int? PrmPriorytetLp { get; set; }

    public int? PrmCykliczna { get; set; }

    public virtual ICollection<FrsPromocje> FrsPromocjes { get; set; } = new List<FrsPromocje>();

    public virtual ICollection<KntPromocje> KntPromocjes { get; set; } = new List<KntPromocje>();

    public virtual ICollection<PltPromocje> PltPromocjes { get; set; } = new List<PltPromocje>();

    public virtual ICollection<TwrPromocje> TwrPromocjes { get; set; } = new List<TwrPromocje>();
}
