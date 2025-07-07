using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymDokumentNumerZapOfert
{
    public int? DokNumerZapDataDo { get; set; }

    public int? DokNumerZapDataOd { get; set; }

    public string DokNumerZapDirtyOrgId { get; set; } = null!;

    public int DokNumerZapId { get; set; }

    public int? DokNumerZapKimball1CheckSum { get; set; }

    public int? DokNumerZapKimball2CheckSum { get; set; }

    public string DokNumerZapOrgId { get; set; } = null!;

    public string? DokNumerZapOrgParId { get; set; }

    public string? DokNumerZapParDirtyOrgId { get; set; }

    public int? DokNumerZapParId { get; set; }

    public int DokNumerZapRowId { get; set; }

    public byte[] DokNumerZapRowVersion { get; set; } = null!;

    public int? DokNumerZapSubTransformationId { get; set; }

    public DateTime DokNumerZapTsinsert { get; set; }

    public DateTime DokNumerZapTsupdate { get; set; }

    public int DokNumerZapZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? DokNumerZapCechaTransakcjiId { get; set; }

    public int? DokNumerZapDokSeriaId { get; set; }

    public int? DokNumerZapDokStatusId { get; set; }

    public int? DokNumerZapDokTypId { get; set; }

    public int? DokNumerZapKodFiaskaId { get; set; }

    public int? DokNumerZapOperatorId { get; set; }

    public int? DokNumerZapSposobDostawyId { get; set; }

    public string? DokNumerZapAktualneOrgId { get; set; }

    public string? DokNumerZapAktualneOrgParId { get; set; }

    public int? DokNumerZapAktywny { get; set; }

    public int? DokNumerZapDataDokumentu { get; set; }

    public string? DokNumerZapGrupowanie { get; set; }

    public string? DokNumerZapKosztUstalono { get; set; }

    public string? DokNumerZapNazwa { get; set; }

    public string? DokNumerZapOpis { get; set; }

    public string? DokNumerZapOrgAtrId { get; set; }

    public string? DokNumerZapOwnOpis { get; set; }

    public string? DokNumerZapPelnyNumer { get; set; }

    public int? DokNumerZapPoprzednikId { get; set; }

    public string? DokNumerZapSpiOrgId { get; set; }

    public int? DokNumerZapWymFirma { get; set; }

    public int? DokNumerZapWymTyp { get; set; }

    public int? FaktyDok { get; set; }

    /// <summary>
    /// Do ofert - 0 - przedawniona, 1 - aktualna
    /// </summary>
    public int? DokNumerZapCzyAktualny { get; set; }

    /// <summary>
    /// Stan - dotyczy zamówień oraz ofert
    /// </summary>
    public string? DokNumerZapStan { get; set; }

    public virtual WymCechaTransakcji? DokNumerZapCechaTransakcji { get; set; }

    public virtual WymDokumentSerium? DokNumerZapDokSeria { get; set; }

    public virtual WymDokumentStatus? DokNumerZapDokStatus { get; set; }

    public virtual WymDokumentTyp? DokNumerZapDokTyp { get; set; }

    public virtual WymKodFiaska? DokNumerZapKodFiaska { get; set; }

    public virtual WymOperator? DokNumerZapOperator { get; set; }

    public virtual WymSposobDostawy? DokNumerZapSposobDostawy { get; set; }

    public virtual WymZrodloDanych DokNumerZapZrodg { get; set; } = null!;

    public virtual ICollection<FktDokumenty> FktDokumenties { get; set; } = new List<FktDokumenty>();
}
