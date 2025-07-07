using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalStanowiska
{
    public int DstaDstaId { get; set; }

    public string DstaNazwa { get; set; } = null!;

    public string DstaOpis { get; set; } = null!;

    public byte DstaTyp { get; set; }

    public byte DstaGenerujWz { get; set; }

    public byte DstaTypNettoBrutto { get; set; }

    public int DstaTwGgidnumer { get; set; }

    public int DstaDdfIdPa { get; set; }

    public int DstaDdfIdPakor { get; set; }

    public int DstaDdfIdFs { get; set; }

    public int DstaDdfIdFskor { get; set; }

    public int DstaDdfIdMm { get; set; }

    public int DstaDdfIdRo { get; set; }

    public int DstaDdfIdKp { get; set; }

    public int DstaDdfIdKw { get; set; }

    public int DstaDdfIdPka { get; set; }

    public int DstaDdfIdCrm { get; set; }

    public int DstaDdfIdWz { get; set; }

    public int DstaDdfIdPf { get; set; }

    public int DstaBraId { get; set; }

    public string DstaSeria { get; set; } = null!;

    public int DstaMagId { get; set; }

    public string? DstaKntGrupa { get; set; }

    public int DstaMagIdZwrotny { get; set; }

    public int DstaTwCnumer { get; set; }

    public byte DstaNieaktywne { get; set; }

    public DateTime DstaTsSynchro { get; set; }

    public DateTime DstaTsSynchroTwr { get; set; }

    public DateTime DstaTsSynchroKnt { get; set; }

    public DateTime DstaTsSynchroTraNag { get; set; }

    public DateTime DstaTsSynchroZapisKb { get; set; }

    public DateTime DstaTsSynchroImportKnt { get; set; }

    public DateTime DstaTsSynchroOpak { get; set; }

    public DateTime DstaTsSynchroKntPotw { get; set; }

    public DateTime DstaTsSynchroTwrPotw { get; set; }

    public DateTime DstaTsSynchroPotw { get; set; }

    public DateTime DstaTsSynchroGrup { get; set; }

    public DateTime DstaTsSynchroGrupPotw { get; set; }

    public byte DstaEdycjaKnt { get; set; }

    public byte DstaKntOpiekun { get; set; }

    public byte DstaPobieranieSkladnikowFsuslugaZlozona { get; set; }

    public virtual ICollection<DetalCeny> DetalCenies { get; set; } = new List<DetalCeny>();

    public virtual ICollection<DetalOperator> DetalOperators { get; set; } = new List<DetalOperator>();
}
