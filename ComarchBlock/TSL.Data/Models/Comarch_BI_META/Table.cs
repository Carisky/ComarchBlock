using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Table
{
    public int TblId { get; set; }

    public string TblTbtid { get; set; } = null!;

    public string? TblDstid { get; set; }

    public string? TblDitid { get; set; }

    public string? TblFmdid { get; set; }

    public string TblPrefix { get; set; } = null!;

    public string TblLogicalName { get; set; } = null!;

    public string TblTableName { get; set; } = null!;

    public bool? TblIsSourceTable { get; set; }

    public bool? TblIsMultiRow { get; set; }

    public bool? TblNeedsTranslationConfirmation { get; set; }

    public bool? TblIsAutoTranslated { get; set; }

    public int TblDisplayOrder { get; set; }

    public int? TblIdfieldId { get; set; }

    public int? TblGidfieldId { get; set; }

    public int? TblSrcgidfieldId { get; set; }

    public int? TblOrgIdfieldlId { get; set; }

    public int? TblCleanOrgIdfieldlId { get; set; }

    public int? TblParCleanOrgIdfieldId { get; set; }

    public int? TblParDirtyOrgIdfieldId { get; set; }

    public int? TblPargidfieldId { get; set; }

    public int? TblNameFieldId { get; set; }

    public int? TblDescriptionFieldId { get; set; }

    public int? TblDtdgidfieldId { get; set; }

    public int? TblTsinsertFieldId { get; set; }

    public int? TblTsupdateFieldId { get; set; }

    public int? TblInsertTransformationIdfieldId { get; set; }

    public int? TblInsertSubTransformationIdfieldId { get; set; }

    public int? TblUpdateTransformationIdfieldId { get; set; }

    public int? TblUpdateSubTransformationIdfieldId { get; set; }

    public int? TblRowVersionFieldId { get; set; }

    public int? TblTimeFromFieldId { get; set; }

    public int? TblTimeToFieldId { get; set; }

    public int? TblCheckSumKimball1FieldId { get; set; }

    public int? TblCheckSumKimball2FieldId { get; set; }

    public DateTime TblTsinsert { get; set; }

    public DateTime TblTsupdate { get; set; }

    public byte[] TblRowVersion { get; set; } = null!;

    public string? TblCustomProperty1 { get; set; }

    public string? TblCustomProperty2 { get; set; }

    public bool? TblAllowCorrections { get; set; }

    public string? TblDescription { get; set; }

    public string? TblOlapId { get; set; }

    public int TblWsSchemaId { get; set; }

    public bool TblUseSqlstatementAsTimeTo { get; set; }

    public string? TblSqlstatementToBeUsedAsTimeTo { get; set; }

    public string? ServerName { get; set; }

    public string? DatabaseName { get; set; }

    public int? TblDbsid { get; set; }

    public int? TblTgrid { get; set; }

    public string? TblDisplaySeparator { get; set; }

    public bool TblIsVisible { get; set; }

    public string? TblDataEditorTableName { get; set; }

    public bool TblIsUnEditable { get; set; }

    public bool? TblCreateBdt { get; set; }

    public bool? TblAttributesAsMeasures { get; set; }

    public int? TblValueFieldId { get; set; }

    public int? TblNumberFieldId { get; set; }

    public bool? TblUseSqlstatementAsTimeFrom { get; set; }

    public bool? TblCloseUnmappedHistoricalData { get; set; }

    public bool? TblCorrespondingResponseFileTable { get; set; }

    public string TblMigrationGuid { get; set; } = null!;

    public virtual ICollection<ApplicationUsersTable> ApplicationUsersTables { get; set; } = new List<ApplicationUsersTable>();

    public virtual ICollection<Correction> Corrections { get; set; } = new List<Correction>();

    public virtual ICollection<DynamicColumnNode> DynamicColumnNodes { get; set; } = new List<DynamicColumnNode>();

    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();

    public virtual ICollection<ForeignKeyDisplay> ForeignKeyDisplays { get; set; } = new List<ForeignKeyDisplay>();

    public virtual ICollection<Index> Indices { get; set; } = new List<Index>();

    public virtual ICollection<PrimaryKey> PrimaryKeys { get; set; } = new List<PrimaryKey>();

    public virtual ICollection<Relation> Relations { get; set; } = new List<Relation>();

    public virtual ICollection<StackColumnValue> StackColumnValues { get; set; } = new List<StackColumnValue>();

    public virtual ICollection<TableLink> TableLinks { get; set; } = new List<TableLink>();

    public virtual DatabaseSchema? TblDbs { get; set; }

    public virtual TableGroup? TblTgr { get; set; }

    public virtual WarehouseSchema TblWsSchema { get; set; } = null!;

    public virtual ICollection<ToolTipTable> ToolTipTables { get; set; } = new List<ToolTipTable>();
}
