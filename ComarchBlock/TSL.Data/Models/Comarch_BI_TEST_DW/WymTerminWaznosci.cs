using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymTerminWaznosci
{
    public int? SubWsadInsertId { get; set; }

    public int? TerminDataDo { get; set; }

    public int? TerminDataOd { get; set; }

    public string TerminDirtyOrgId { get; set; } = null!;

    public int TerminId { get; set; }

    public int? TerminKimball1CheckSum { get; set; }

    public int? TerminKimball2CheckSum { get; set; }

    public string TerminOrgId { get; set; } = null!;

    public string? TerminParDirtyOrgId { get; set; }

    public int? TerminParId { get; set; }

    public int TerminRowId { get; set; }

    public byte[] TerminRowVersion { get; set; } = null!;

    public int? TerminSubTransformationId { get; set; }

    public DateTime TerminTsinsert { get; set; }

    public DateTime TerminTsupdate { get; set; }

    public int TerminZrodgid { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? TerminTypId { get; set; }

    public string? TerminAktualneOrgId { get; set; }

    public string? TerminAktualneOrgParId { get; set; }

    public int? TerminAktywny { get; set; }

    public int? TerminDo { get; set; }

    public string? TerminNazwa { get; set; }

    public int? TerminOd { get; set; }

    public string? TerminOpis { get; set; }

    public string? TerminOrgAtrId { get; set; }

    public string? TerminOrgParId { get; set; }

    public int? TerminPoprzednikId { get; set; }

    public string TerminTypOrgId { get; set; } = null!;

    public int? TerminWymFirma { get; set; }

    public int? TerminWymTyp { get; set; }

    public int? WsadDeleteId { get; set; }

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual WymTerminWaznosciTyp? TerminTyp { get; set; }

    public virtual WymZrodloDanych TerminZrodg { get; set; } = null!;
}
