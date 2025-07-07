using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Wymiary
{
    public int WmrId { get; set; }

    public int? WmrParId { get; set; }

    public int? WmrRootId { get; set; }

    public string? WmrNazwa { get; set; }

    public string? WmrOpis { get; set; }

    public byte? WmrTyp { get; set; }

    public string? WmrKonto { get; set; }

    public string? WmrWyrazenieSql { get; set; }

    public byte? WmrAktywny { get; set; }

    public string? WmrNazwaPoziomu { get; set; }

    public int? WmrMaxIlosc { get; set; }

    public byte? WmrKategoria { get; set; }

    public int? WmrAktywnyOd { get; set; }

    public int? WmrAktywnyDo { get; set; }

    public byte? WmrArchiwalny { get; set; }

    public byte? WmrObieg { get; set; }

    public byte? WmrEprac { get; set; }

    public virtual WymPowiazanium? WymPowiazanium { get; set; }

    public virtual ICollection<DokDefinicje> DoWs { get; set; } = new List<DokDefinicje>();
}
