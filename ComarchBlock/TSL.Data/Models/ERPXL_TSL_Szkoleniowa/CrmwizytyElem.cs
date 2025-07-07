using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class CrmwizytyElem
{
    public short CweGidTyp { get; set; }

    public int? CweGidFirma { get; set; }

    public int CweGidNumer { get; set; }

    public short CweGidLp { get; set; }

    public string? CweKod { get; set; }

    public string? CweNazwa { get; set; }

    public short? CwePozycja { get; set; }

    public byte? CweWymagany { get; set; }

    public byte? CweWykonano { get; set; }

    public int? CwePowodNiewykonaniaId { get; set; }

    public string? CwePowodNiewykonania { get; set; }

    public string? CweOpis { get; set; }

    public string? CweOpisWykonania { get; set; }

    public int? CweRodzajId { get; set; }

    public int? CweDataUtworzenia { get; set; }

    public int? CweCzasModyfikacji { get; set; }

    public int? CweCzasModyfikacjiC { get; set; }

    public int? CweCzasArchiwizacji { get; set; }

    public int? CweOpeNumerU { get; set; }

    public int? CweOpeNumerM { get; set; }

    public int? CweOpeNumerA { get; set; }

    public string? CweUrl { get; set; }

    public byte? CwePrzypisz { get; set; }

    public int? CwePrzypiszPrzed { get; set; }

    public int? CwePrzypiszPo { get; set; }

    public byte? CweOddzialowy { get; set; }

    public virtual ICollection<CrmwizytyDokTwr> CrmwizytyDokTwrs { get; set; } = new List<CrmwizytyDokTwr>();

    public virtual ICollection<CrmwizytyElemDok> CrmwizytyElemDoks { get; set; } = new List<CrmwizytyElemDok>();

    public virtual ICollection<CrmwizytyElemObiekty> CrmwizytyElemObiekties { get; set; } = new List<CrmwizytyElemObiekty>();
}
