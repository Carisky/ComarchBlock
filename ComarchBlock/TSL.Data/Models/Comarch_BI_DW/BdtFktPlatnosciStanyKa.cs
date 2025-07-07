using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktPlatnosciStanyKa
{
    public int StkId { get; set; }

    public int StkLokId { get; set; }

    public int? StkTypKwoty { get; set; }

    public int? StkWymTyp { get; set; }

    public string? StkWymObjGidLp { get; set; }

    public string? StkOrgWymId { get; set; }

    public string? StkOrgAtrId { get; set; }

    public int StkStrFrmId { get; set; }

    public int StkProjektId { get; set; }

    public int StkAlokacjaId { get; set; }

    public decimal? StkStanRaportWaluta { get; set; }

    public decimal? StkStanRaport { get; set; }

    public decimal? StkStanRejestrWaluta { get; set; }

    public decimal? StkStanRejestr { get; set; }

    public decimal? StkMzobowiazanieWaluta { get; set; }

    public decimal? StkMzobowiazanie { get; set; }

    public decimal? StkMnaleznoscWaluta { get; set; }

    public decimal? StkMnaleznosc { get; set; }

    public decimal? StkKierunek { get; set; }

    public DateTime StkTsupdate { get; set; }

    public DateTime StkTsinsert { get; set; }

    public int? StkInsertSubTransformationId { get; set; }

    public int StkInsertTransformationId { get; set; }

    public int? StkUpdateSubTransformationId { get; set; }

    public int StkUpdateTransformationId { get; set; }

    public string? StkOpis { get; set; }

    public string StkDirtyOrgId { get; set; } = null!;

    public string StkCleanOrgId { get; set; } = null!;

    public int StkCzdid { get; set; }

    public int StkZrodgid { get; set; }

    public int StkFormPlatId { get; set; }

    public int StkWalutaId { get; set; }

    public int StkRejonid { get; set; }

    public int StkDataOtwarciaId { get; set; }

    public int StkDataZamknieciaId { get; set; }

    public int StkKndId { get; set; }

    public int StkDokNumerId { get; set; }

    public int StkCzdtid { get; set; }

    public int StkBudzetId { get; set; }

    public int StkKntId { get; set; }

    public int StkFirmaId { get; set; }

    public int StkPerspektywaId { get; set; }

    public int StkDlggid { get; set; }

    public int StkWnogid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int StkRejestrId { get; set; }
}
