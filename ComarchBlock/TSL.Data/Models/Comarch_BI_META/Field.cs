using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Field
{
    public int FldId { get; set; }

    public int? FldTblid { get; set; }

    public string FldTbtid { get; set; } = null!;

    public string FldDatid { get; set; } = null!;

    public string? FldFfkid { get; set; }

    public string? FldDfkid { get; set; }

    public bool FldIsTranslationField { get; set; }

    public string? FldLogicalName { get; set; }

    public string FldName { get; set; } = null!;

    public bool FldUseAtSourceDerivedExpression { get; set; }

    public string? FldAtSourceDerivedExpression { get; set; }

    public bool FldUseAtDestinationDerivedExpression { get; set; }

    public string? FldAtDestinationDerivedExpression { get; set; }

    public string? FldSourceFieldName { get; set; }

    public string? FldSourceFieldExpression { get; set; }

    public bool? FldMergeWithSourceOrgId { get; set; }

    public int FldDisplayOrder { get; set; }

    public bool FldIsSourceField { get; set; }

    public bool FldIsReadOnly { get; set; }

    public bool FldIsVisible { get; set; }

    public bool FldIsIdentity { get; set; }

    public bool FldIsNullable { get; set; }

    public string? FldDefaultValue { get; set; }

    public int FldLength { get; set; }

    public int FldScale { get; set; }

    public DateTime FldTsinsert { get; set; }

    public DateTime FldTsupdate { get; set; }

    public byte[] FldRowVersion { get; set; } = null!;

    public bool? FldAllowCorrections { get; set; }

    public bool? FldIsCorrectionFilter { get; set; }

    public bool? FldIsCorrectionMapping { get; set; }

    public bool? FldIsCorrectionObligatory { get; set; }

    public string? FldDescription { get; set; }

    public string? FldOlapId { get; set; }

    public string? FldDataEditorFieldName { get; set; }

    public string FldMigrationGuid { get; set; } = null!;

    public string? FldCtkind { get; set; }

    public virtual ICollection<CorrectionFilter> CorrectionFilterCfiDflds { get; set; } = new List<CorrectionFilter>();

    public virtual ICollection<CorrectionFilter> CorrectionFilterCfiFlds { get; set; } = new List<CorrectionFilter>();

    public virtual ICollection<CorrectionMapping> CorrectionMappingCmaDflds { get; set; } = new List<CorrectionMapping>();

    public virtual ICollection<CorrectionMapping> CorrectionMappingCmaFlds { get; set; } = new List<CorrectionMapping>();

    public virtual ICollection<CorrectionMeasure> CorrectionMeasures { get; set; } = new List<CorrectionMeasure>();

    public virtual ICollection<CorrectionRule> CorrectionRules { get; set; } = new List<CorrectionRule>();

    public virtual ICollection<FieldLink> FieldLinkFllFlds { get; set; } = new List<FieldLink>();

    public virtual ICollection<FieldLink> FieldLinkFllRelationLookUpFields { get; set; } = new List<FieldLink>();

    public virtual ICollection<FieldSettingsForUser> FieldSettingsForUsers { get; set; } = new List<FieldSettingsForUser>();

    public virtual DataType FldDat { get; set; } = null!;

    public virtual DimensionFieldKind? FldDfk { get; set; }

    public virtual FactFieldKind? FldFfk { get; set; }

    public virtual Table? FldTbl { get; set; }

    public virtual TableType FldTbt { get; set; } = null!;

    public virtual ICollection<ForeignKeyDisplay> ForeignKeyDisplays { get; set; } = new List<ForeignKeyDisplay>();

    public virtual ICollection<IndexField> IndexFields { get; set; } = new List<IndexField>();

    public virtual ICollection<IndexIncludedField> IndexIncludedFields { get; set; } = new List<IndexIncludedField>();

    public virtual ICollection<PrimaryKeyField> PrimaryKeyFields { get; set; } = new List<PrimaryKeyField>();

    public virtual ICollection<Relation> RelationRelFirstFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelInputFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelMappingLookupFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelMappingRetrievedFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelOutputFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelRelatedFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelRelationDescriptionFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelRelationNameFields { get; set; } = new List<Relation>();

    public virtual ICollection<Relation> RelationRelRetrievedFields { get; set; } = new List<Relation>();

    public virtual ICollection<StackColumnValue> StackColumnValues { get; set; } = new List<StackColumnValue>();

    public virtual ICollection<TableLink> TableLinkTlnTranslationDescriptionFields { get; set; } = new List<TableLink>();

    public virtual ICollection<TableLink> TableLinkTlnTranslationField1Fields { get; set; } = new List<TableLink>();

    public virtual ICollection<TableLink> TableLinkTlnTranslationField2Fields { get; set; } = new List<TableLink>();

    public virtual ICollection<TableLink> TableLinkTlnTranslationField3Fields { get; set; } = new List<TableLink>();

    public virtual ICollection<ToolTipField> ToolTipFields { get; set; } = new List<ToolTipField>();
}
