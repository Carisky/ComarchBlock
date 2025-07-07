using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymDokumentNumer
{
    public int DokNumerId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? DokNumerRowId { get; set; }

    public string? Gid { get; set; }

    public string? DokNumerDokumentObcy { get; set; }

    public string? DokNumerStan { get; set; }

    public int? DokNumerCzyAktualny { get; set; }

    public int? FaktyDok { get; set; }

    public int? DokNumerWymTyp { get; set; }

    public int? DokNumerWymFirma { get; set; }

    public string? DokNumerSpiOrgId { get; set; }

    public int? DokNumerPoprzednikId { get; set; }

    public string? DokNumerPelnyNumer { get; set; }

    public string? DokNumerOwnOpis { get; set; }

    public string? DokNumerOrgAtrId { get; set; }

    public string? DokNumerOpis { get; set; }

    public string? DokNumerNazwa { get; set; }

    public string? DokNumerKosztUstalono { get; set; }

    public string? DokNumerGrupowanie { get; set; }

    public int? DokNumerDataDokumentu { get; set; }

    public int? DokNumerAktywny { get; set; }

    public string? DokNumerAktualneOrgParId { get; set; }

    public string? DokNumerAktualneOrgId { get; set; }

    public int? DokNumerSposobDostawyId { get; set; }

    public int? DokNumerOperatorId { get; set; }

    public int? DokNumerKodFiaskaId { get; set; }

    public int? DokNumerDokTypId { get; set; }

    public int? DokNumerDokStatusId { get; set; }

    public int? DokNumerDokSeriaId { get; set; }

    public int? DokNumerCechaTransakcjiId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int DokNumerZrodgid { get; set; }

    public DateTime DokNumerTsupdate { get; set; }

    public DateTime DokNumerTsinsert { get; set; }

    public int? DokNumerSubTransformationId { get; set; }

    public byte[] DokNumerRowVersion { get; set; } = null!;

    public int? DokNumerParId { get; set; }

    public string? DokNumerParDirtyOrgId { get; set; }

    public string? DokNumerOrgParId { get; set; }

    public string DokNumerOrgId { get; set; } = null!;

    public int? DokNumerKimball2CheckSum { get; set; }

    public int? DokNumerKimball1CheckSum { get; set; }

    public string DokNumerDirtyOrgId { get; set; } = null!;

    public int? DokNumerDataOd { get; set; }

    public int? DokNumerDataDo { get; set; }

    public string? DokNumerOpisNaglowka { get; set; }

    public int? DokNumerDokStatusRozliczeniaId { get; set; }

    public string? DokNumerMpp { get; set; }

    public string? DokNumerRejestrVat { get; set; }

    public string? DokNumerProceduryJpk { get; set; }

    public string? DokNumerPrzyczynaZw { get; set; }

    public string? DokNumerZwolnioneDoProd { get; set; }

    public string? DokNumerNumerListu { get; set; }

    public string? DokNumerStanPrzesylki { get; set; }

    public string? DokNumerKurier { get; set; }

    public string? DokNumerNumerSformatowany { get; set; }

    public string? DokNumerPozycje { get; set; }

    public string? DokNumerFisk { get; set; }

    public string? DokNumerTransakcja { get; set; }

    public string? DokNumerNumerSad { get; set; }

    public string? DokNumerKseFwyslany { get; set; }

    public string? DokNumerKseFodebrany { get; set; }
}
