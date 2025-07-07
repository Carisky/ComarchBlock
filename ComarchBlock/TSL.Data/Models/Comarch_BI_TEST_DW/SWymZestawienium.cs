using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class SWymZestawienium
{
    public int ZstId { get; set; }

    public int? ZstParId { get; set; }

    public int? ZstPoprzednikId { get; set; }

    public string? ZstOrgId { get; set; }

    public string? ZstOrgParId { get; set; }

    public string? ZstOrgAtrId { get; set; }

    public int? ZstWymTyp { get; set; }

    public int? ZstWymFirma { get; set; }

    public int? ZstAktywny { get; set; }

    public string? ZstAktualneOrgId { get; set; }

    public string? ZstAktualneOrgParId { get; set; }

    public int? ZstDataOd { get; set; }

    public int? ZstDataDo { get; set; }

    public int? ZstKimball1CheckSum { get; set; }

    public int? ZstKimball2CheckSum { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadDeleteId { get; set; }

    public string? ZstNazwa { get; set; }

    public int? ZstZnak { get; set; }

    public decimal? ZstPozycjaNr { get; set; }

    public string? ZstPozycjaChar { get; set; }

    public string? ZstDefinicja { get; set; }

    public int? ZstSyntetyka { get; set; }

    public int? ZstZknNumer { get; set; }

    public string? ZstZknNazwa { get; set; }

    public int? ZstIdKonta { get; set; }

    public string? ZstNumeracja { get; set; }

    public string? ZstSaldoDwustronnie { get; set; }

    public string? ZstLisc { get; set; }

    public int? ZstTypPozycji { get; set; }

    public string? ZstFunkcja { get; set; }

    public string? ZstPoziom { get; set; }

    public int? ZstPoziomNr { get; set; }

    public string? ZstPrezentacja { get; set; }

    public string? ZstZnakPozycji { get; set; }

    public decimal? ZstMnoznik { get; set; }
}
