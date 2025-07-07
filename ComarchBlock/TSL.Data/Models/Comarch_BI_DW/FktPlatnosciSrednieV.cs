using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPlatnosciSrednieV
{
    public int? PlsBudzetId { get; set; }

    public int? PlsOrgWymId { get; set; }

    public int? PlsTypKwoty { get; set; }

    public int? PlsKierunek { get; set; }

    public int? PlsWymObjGidLp { get; set; }

    public int? PlsWymTyp { get; set; }

    public string PlsProjektId { get; set; } = null!;

    public string PlsStrFrmId { get; set; } = null!;

    public string PlsLokId { get; set; } = null!;

    public int PlsAlokacjaId { get; set; }

    public int? PlsDokNumerId { get; set; }

    public int? PlsFirmaId { get; set; }

    public int? PlsKntId { get; set; }

    public int PlsKndId { get; set; }

    public int? PlsPlatId { get; set; }

    public int? PlsWalutaId { get; set; }

    public int PlsZrodgid { get; set; }

    public string? PlsOrgAtrId { get; set; }

    public int PlsCleanOrgId { get; set; }

    public int? PlsFormPlatId { get; set; }

    public int? PlsProdId { get; set; }

    public int? PlsOpiekunId { get; set; }

    public int? PlsAkwId { get; set; }

    public int? PlsCzdterminPlatId { get; set; }

    public int? PlsRejonId { get; set; }

    public int? PlsSpiNumerId { get; set; }

    public int? PlsCzmid { get; set; }

    public decimal? PlsMsrStanNaleznosci { get; set; }

    public decimal? PlsMsrStanZobowiazan { get; set; }

    public int? PlsMiloscDniWMiesiacu { get; set; }

    public decimal? PlsMsumaStanuNaleznosci { get; set; }

    public decimal? PlsMsunaStanuZobowiazan { get; set; }
}
