using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class BnkFormatyNag
{
    public int BfnBfnid { get; set; }

    public string BfnNazwa { get; set; } = null!;

    public byte BfnStandardowy { get; set; }

    public byte? BfnCdc { get; set; }

    public string? BfnCdcadres { get; set; }

    public byte? BfnCdcwariant { get; set; }

    public byte BfnCdcrodzajCertyfikatow { get; set; }

    public byte? BfnXml { get; set; }

    public byte? BfnXmlRodzaj { get; set; }

    public byte BfnObslugaEksportu { get; set; }

    public byte BfnObslugaImportu { get; set; }

    public string? BfnSepDzies { get; set; }

    public string? BfnSepDziesSplitPay { get; set; }

    public string? BfnFormatDaty { get; set; }

    public byte? BfnUsunSpacje { get; set; }

    public byte? BfnOddzielajPola { get; set; }

    public string? BfnSepPol { get; set; }

    public string? BfnSepOpisuZb { get; set; }

    public string? BfnSepGrup { get; set; }

    public string? BfnOgrTekstu { get; set; }

    public string? BfnOgrTekstuEsc { get; set; }

    public string? BfnPodzPolaNaWiersze { get; set; }

    public string? BfnSepWierszy { get; set; }

    public string? BfnRozszerzeniePliku { get; set; }

    public short? BfnStronaKodowa { get; set; }

    public byte? BfnTylkoWielkieLitery { get; set; }

    public byte BfnNieaktywny { get; set; }

    public virtual ICollection<BnkFormatyElem> BnkFormatyElems { get; set; } = new List<BnkFormatyElem>();
}
