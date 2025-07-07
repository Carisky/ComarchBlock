using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

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

    public byte? PrmBlokadaCeny { get; set; }

    public short? PrmOpeTypM { get; set; }

    public int? PrmOpeFirmaM { get; set; }

    public int? PrmOpeNumerM { get; set; }

    public short? PrmOpeLpM { get; set; }

    public byte? PrmPakietowa { get; set; }

    public byte? PrmRodzajPakietu { get; set; }

    public byte? PrmNajwyzszyProg { get; set; }

    public short? PrmOpeTypU { get; set; }

    public int? PrmOpeNumerU { get; set; }

    public short? PrmOpeTypP { get; set; }

    public int? PrmOpeNumerP { get; set; }

    public short? PrmOpeTypZ { get; set; }

    public int? PrmOpeNumerZ { get; set; }

    public int? PrmDataUtworzenia { get; set; }

    public int? PrmDataPotwierdzenia { get; set; }

    public int? PrmDataZamkniecia { get; set; }

    public int? PrmKolor { get; set; }

    public int? PrmKolorBg { get; set; }

    public short? PrmCyklCzestotliwosc { get; set; }

    public short? PrmCyklRodzaj { get; set; }

    public int? PrmCyklWystepowanie { get; set; }

    public short? PrmCyklDniOd { get; set; }

    public short? PrmCyklDniDo { get; set; }

    public byte? PrmZamknietaLista { get; set; }

    public byte? PrmLimitTyp { get; set; }

    public decimal? PrmLimitWartosc { get; set; }

    public byte? PrmGrupaTwrWazniejsza { get; set; }

    public byte? PrmProgTyp { get; set; }

    public decimal? PrmProgWartosc { get; set; }

    public int? PrmOkresTransakcjiOd { get; set; }

    public int? PrmOkresTransakcjiDo { get; set; }

    public string? PrmWarunekProgSql { get; set; }

    public int? PrmMaxIloscPakietow { get; set; }

    public byte? PrmLimitRodzaj { get; set; }

    public byte? PrmWymagajJm { get; set; }

    public string? PrmJmZ { get; set; }

    public string? PrmGuid { get; set; }

    public virtual ICollection<FrsPromocje> FrsPromocjes { get; set; } = new List<FrsPromocje>();

    public virtual ICollection<GratisyPromocje> GratisyPromocjes { get; set; } = new List<GratisyPromocje>();

    public virtual ICollection<KntPromocje> KntPromocjes { get; set; } = new List<KntPromocje>();

    public virtual ICollection<MagPromocje> MagPromocjes { get; set; } = new List<MagPromocje>();

    public virtual ICollection<OpePromocje> OpePromocjes { get; set; } = new List<OpePromocje>();

    public virtual ICollection<PltPromocje> PltPromocjes { get; set; } = new List<PltPromocje>();

    public virtual ICollection<ProgiPromocje> ProgiPromocjes { get; set; } = new List<ProgiPromocje>();

    public virtual ICollection<SpDpromocje> SpDpromocjes { get; set; } = new List<SpDpromocje>();

    public virtual ICollection<TwrPromocje> TwrPromocjes { get; set; } = new List<TwrPromocje>();

    public virtual ICollection<ZstPromocje> ZstPromocjes { get; set; } = new List<ZstPromocje>();
}
