using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class WdrKopieElektroniczne
{
    public int WdKeWdKeid { get; set; }

    public int? WdKeCallProcId { get; set; }

    public string? WdKeCallProcName { get; set; }

    public int? WdKeProcId { get; set; }

    public string? WdKeProcName { get; set; }

    public int? WdKeObjType { get; set; }

    public int? WdKeObjSubType { get; set; }

    public int? WdKeObjId { get; set; }

    public string? WdKeObjName { get; set; }

    public string? WdKeObjDescription { get; set; }

    public DateTime? WdKeObjDate { get; set; }

    public int? WdKeObjSubjectType { get; set; }

    public int? WdKeObjSubjectId { get; set; }

    public int? WdKeObjModOpeId { get; set; }

    public int? WdKePrnId { get; set; }

    public string WdKePrnName { get; set; } = null!;

    public string WdKePrnFileName { get; set; } = null!;

    public DateTime WdKePrnDate { get; set; }

    public int WdKePrnOpeId { get; set; }

    public string WdKePrnOpeNazwisko { get; set; } = null!;

    public byte[]? WdKePrnContent { get; set; }

    public int WdKePrnContentLen { get; set; }

    public int? WdKeFlaga { get; set; }

    public int WdKeEPracownik { get; set; }

    public DateTime? WdKeEPracownikDate { get; set; }

    public byte WdKeBipoint { get; set; }

    public long? WdKeIbardId { get; set; }

    public string? WdKeIBardSciezka { get; set; }

    public string? WdKeIBardLink { get; set; }

    public string? WdKeUdostepnilLoginSso { get; set; }

    public string? WdKeDostepnyDlaLoginSso { get; set; }
}
