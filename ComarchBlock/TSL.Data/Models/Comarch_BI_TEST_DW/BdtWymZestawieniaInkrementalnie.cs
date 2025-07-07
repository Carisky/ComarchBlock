using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymZestawieniaInkrementalnie
{
    public int ZstiId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ZstiRowId { get; set; }

    public string? ZstiZnakPozycji { get; set; }

    public int? ZstiZnak { get; set; }

    public int? ZstiZknNumer { get; set; }

    public string? ZstiZknNazwa { get; set; }

    public int? ZstiWymTyp { get; set; }

    public int? ZstiWymFirma { get; set; }

    public int? ZstiTypPozycji { get; set; }

    public int? ZstiSyntetyka { get; set; }

    public string? ZstiSaldoDwustronnie { get; set; }

    public string? ZstiPrezentacja { get; set; }

    public decimal? ZstiPozycjaNr { get; set; }

    public string? ZstiPozycjaChar { get; set; }

    public int? ZstiPoziomNr { get; set; }

    public string? ZstiPoziom { get; set; }

    public int? ZstiPoprzednikId { get; set; }

    public string? ZstiOrgAtrId { get; set; }

    public string? ZstiOpis { get; set; }

    public string? ZstiNumeracja { get; set; }

    public string? ZstiNazwa { get; set; }

    public decimal ZstiMnoznik { get; set; }

    public string? ZstiLisc { get; set; }

    public int? ZstiIdKonta { get; set; }

    public string? ZstiFunkcja { get; set; }

    public string? ZstiDefinicja { get; set; }

    public int? ZstiAktywny { get; set; }

    public string? ZstiAktualneOrgParId { get; set; }

    public string? ZstiAktualneOrgId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int ZstiZrodgid { get; set; }

    public DateTime ZstiTsupdate { get; set; }

    public DateTime ZstiTsinsert { get; set; }

    public int? ZstiSubTransformationId { get; set; }

    public byte[] ZstiRowVersion { get; set; } = null!;

    public int? ZstiParId { get; set; }

    public string? ZstiParDirtyOrgId { get; set; }

    public string? ZstiOrgParId { get; set; }

    public string ZstiOrgId { get; set; } = null!;

    public int? ZstiKimball2CheckSum { get; set; }

    public int? ZstiKimball1CheckSum { get; set; }

    public string ZstiDirtyOrgId { get; set; } = null!;

    public int? ZstiDataOd { get; set; }

    public int? ZstiDataDo { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? SubWsadInsertId { get; set; }
}
