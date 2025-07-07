using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class RetroKarty
{
    public int RtKId { get; set; }

    public string? RtKNazwa { get; set; }

    public byte? RtKTyp { get; set; }

    public int? RtKDataOd { get; set; }

    public int? RtKDataDo { get; set; }

    public byte? RtKTypDaty { get; set; }

    public byte? RtKStan { get; set; }

    public int? RtKOpeUnumer { get; set; }

    public int? RtKDataUtworzenia { get; set; }

    public int? RtKOpeMnumer { get; set; }

    public int? RtKCzasModyfikacji { get; set; }

    public byte? RtKOkresyRozliczeniowe { get; set; }

    public int? RtKOkresIlosc { get; set; }

    public byte? RtKOkresTyp { get; set; }

    public int? RtKAktywny { get; set; }

    public byte? RtKTypProgu { get; set; }

    public byte? RtKPodstawaRabatu { get; set; }

    public int? RtKTypKalkulacji { get; set; }

    public string? RtKOpis { get; set; }

    public string? RtKSql { get; set; }

    public int? RtKTypId { get; set; }

    public short? RtKRodzajCeny { get; set; }

    public byte? RtKWymaganaZaplata { get; set; }

    public byte? RtKTypTerminu { get; set; }

    public virtual ICollection<RetroKontrahenci> RetroKontrahencis { get; set; } = new List<RetroKontrahenci>();

    public virtual ICollection<RetroMagazyny> RetroMagazynies { get; set; } = new List<RetroMagazyny>();

    public virtual ICollection<RetroOdbiorcy> RetroOdbiorcies { get; set; } = new List<RetroOdbiorcy>();

    public virtual ICollection<RetroPlt> RetroPlts { get; set; } = new List<RetroPlt>();

    public virtual ICollection<RetroProgi> RetroProgis { get; set; } = new List<RetroProgi>();

    public virtual ICollection<RetroSpD> RetroSpDs { get; set; } = new List<RetroSpD>();

    public virtual ICollection<RetroTowary> RetroTowaries { get; set; } = new List<RetroTowary>();

    public virtual ICollection<FrmStruktura> RtFFrs { get; set; } = new List<FrmStruktura>();
}
