using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktDodatkoweKosztyZakupu
{
    public int KdzRejonid { get; set; }

    public int KdzKntId { get; set; }

    public int KdzAlokacjaId { get; set; }

    public int KdzKndId { get; set; }

    public int KdzDokNumerId { get; set; }

    public int KdzDokZrnumerId { get; set; }

    public int KdzDokKnumerId { get; set; }

    public int KdzCzdwystawieniaId { get; set; }

    public int KdzKndStazId { get; set; }

    public int KdzPerspektywaId { get; set; }

    public int KdzFirmaId { get; set; }

    public int KdzKntStazId { get; set; }

    public int KdzCzdzakupuId { get; set; }

    public int KdzCzdprzyjeciaId { get; set; }

    public int KdzBudzetId { get; set; }

    public int KdzProjektId { get; set; }

    public int KdzLokId { get; set; }

    public int KdzStrFrmId { get; set; }

    public int KdzWalutaId { get; set; }

    public int KdzProdStazId { get; set; }

    public int KdzJmId { get; set; }

    public int KdzZapId { get; set; }

    public int KdzMagId { get; set; }

    public int KdzRkdid { get; set; }

    public int KdzDstId { get; set; }

    public int KdzPracownikId { get; set; }

    public int KdzPrmid { get; set; }

    public int KdzCechyId { get; set; }

    public int KdzProdId { get; set; }

    public int KdzPlatId { get; set; }

    public int KdzId { get; set; }

    public int KdzCzdid { get; set; }

    public int KdzZrodgid { get; set; }

    public string KdzOrgId { get; set; } = null!;

    public string KdzDirtyOrgId { get; set; } = null!;

    public string? KdzOpis { get; set; }

    public DateTime KdzTsinsert { get; set; }

    public DateTime KdzTsupdate { get; set; }

    public int KdzUpdateSubTransformationId { get; set; }

    public int? KdzUpdateTransformationId { get; set; }

    public int KdzInsertSubTransformationId { get; set; }

    public int? KdzInsertTransformationId { get; set; }

    public int? KdzKierunek { get; set; }

    public int? KdzTypKwoty { get; set; }

    public string? KdzOrgWymId { get; set; }

    public int? KdzPozycjaId { get; set; }

    public int? KdzSubPozycjaId { get; set; }

    public string? KdzOrgAtrId { get; set; }

    public decimal? KdzMkosztDodatkowy { get; set; }

    public decimal? KdzMiloscJpom { get; set; }

    public decimal? KdzMilosc { get; set; }

    public decimal? KdzMpunkty { get; set; }

    public int? KdzStrPrwId { get; set; }
}
