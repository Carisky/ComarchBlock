using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Relation
{
    public int RelId { get; set; }

    public int? RelFirstFieldId { get; set; }

    public int RelInputFieldId { get; set; }

    public int RelOutputFieldId { get; set; }

    public int? RelNextId { get; set; }

    public int? RelRelationNameFieldId { get; set; }

    public int? RelRelationDescriptionFieldId { get; set; }

    public int? RelRelatedFieldId { get; set; }

    public int? RelRetrievedFieldId { get; set; }

    public bool RelCreateDatabaseConstraint { get; set; }

    public DateTime RelTsinsert { get; set; }

    public DateTime RelTsupdate { get; set; }

    public byte[] RelRowVersion { get; set; } = null!;

    public int? RelBetweenFirstFieldId { get; set; }

    public int? RelBetweenSecondFieldId { get; set; }

    public bool RelUseBetweenCondition { get; set; }

    public bool RelUseAdvancedLookup { get; set; }

    public string? RelClauseWhere { get; set; }

    public string? RelClauseOrderBy { get; set; }

    public bool? RelUseMappingLookup { get; set; }

    public int? RelMappingLookupTableId { get; set; }

    public int? RelMappingLookupFieldId { get; set; }

    public int? RelMappingRetrievedFieldId { get; set; }

    public bool RelCreateOnDw { get; set; }

    public virtual ICollection<Relation> InverseRelNext { get; set; } = new List<Relation>();

    public virtual Field? RelFirstField { get; set; }

    public virtual Field RelInputField { get; set; } = null!;

    public virtual Field? RelMappingLookupField { get; set; }

    public virtual Table? RelMappingLookupTable { get; set; }

    public virtual Field? RelMappingRetrievedField { get; set; }

    public virtual Relation? RelNext { get; set; }

    public virtual Field RelOutputField { get; set; } = null!;

    public virtual Field? RelRelatedField { get; set; }

    public virtual Field? RelRelationDescriptionField { get; set; }

    public virtual Field? RelRelationNameField { get; set; }

    public virtual Field? RelRetrievedField { get; set; }
}
