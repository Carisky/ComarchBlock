using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class VFktPlatnosciRozrachunki
{
    public long RzrId { get; set; }

    public string RzrOrgId { get; set; } = null!;

    public string RzrDirtyOrgId { get; set; } = null!;

    public string? RzrDescription { get; set; }

    public int RzrUpdateTransformationId { get; set; }

    public int? RzrUpdateSubTransformationId { get; set; }

    public int RzrInsertTransformationId { get; set; }

    public int? RzrInsertSubTransformationId { get; set; }

    public DateTime RzrTsinsert { get; set; }

    public DateTime RzrTsupdate { get; set; }

    public int RzrZrodgid { get; set; }

    public int RzrCzdid { get; set; }

    public int? RzrCzmid { get; set; }

    public int? RzrBudzetId { get; set; }

    public int? RzrDokNumerId { get; set; }

    public int? RzrSpiNumerId { get; set; }

    public int? RzrFirmaId { get; set; }

    public int? RzrFormPlatId { get; set; }

    public int? RzrKntId { get; set; }

    public int? RzrPlatId { get; set; }

    public int? RzrOpiekunId { get; set; }

    public int? RzrPerspektywaId { get; set; }

    public int? RzrProdId { get; set; }

    public int? RzrWalutaId { get; set; }

    public decimal? RzrMprzelicznikWaluty { get; set; }

    public decimal? RzrMnaleznoscWaluta { get; set; }

    public decimal? RzrMzobowiazanieWaluta { get; set; }

    public decimal? RzrMnaleznosc { get; set; }

    public decimal? RzrMzobowiazanie { get; set; }

    public int? RzrRejonId { get; set; }

    public int RzrKndId { get; set; }

    public int? RzrCzdterminPlatId { get; set; }

    public int? RzrWymTyp { get; set; }

    public int? RzrKierunek { get; set; }

    public int? RzrTypKwoty { get; set; }

    public string? RzrOrgAtrId { get; set; }

    public string? RzrOrgWymId { get; set; }

    public string? RzrWymObjGidLp { get; set; }

    public int? RzrAkwId { get; set; }

    public int RzrRejestryId { get; set; }

    public int RzrAlokacjaId { get; set; }

    public int RzrDataWystawieniaId { get; set; }

    public int RzrStrFrmId { get; set; }

    public int RzrProjektId { get; set; }

    public int? WsadInsertId { get; set; }

    public int RzrLokId { get; set; }

    public string? RzrOrgAtrNagId { get; set; }

    public int? RzrStrPrwId { get; set; }

    public int RzrWnogid { get; set; }

    public int RzrDlggid { get; set; }

    public int RzrDokPlaId { get; set; }

    public int RzrPrlvid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr0267Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int? Atr0299Id { get; set; }

    public int? Atr02101Id { get; set; }

    public decimal? RzrMnaleznoscBez0 { get; set; }

    public decimal? RzrMzobowiazanieBez0 { get; set; }
}
