// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// No Description Provided
  /// </summary>
  public static class V3SubstanceAdminSubstitutionReasonCodes
  {
    /// <summary>
    /// Indicates that the decision to substitute or to not substitute was driven by a desire to maintain consistency with a pre-existing therapy.  I.e. The performer provided the same item/service as had been previously provided rather than providing exactly what was ordered, or rather than substituting with a lower-cost equivalent.
    /// </summary>
    public static readonly Coding ContinuingTherapy = new Coding
    {
      Code = "CT",
      Display = "continuing therapy",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// Indicates that the decision to substitute or to not substitute was driven by a policy expressed within the formulary.
    /// </summary>
    public static readonly Coding FormularyPolicy = new Coding
    {
      Code = "FP",
      Display = "formulary policy",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// In the case of 'substitution', indicates that the substitution occurred because the ordered item was not in stock.  In the case of 'no substitution', indicates that a cheaper equivalent was not substituted because it was not in stock.
    /// </summary>
    public static readonly Coding OutOfStock = new Coding
    {
      Code = "OS",
      Display = "out of stock",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// Indicates that the decision to substitute or to not substitute was driven by a jurisdictional regulatory requirement mandating or prohibiting substitution.
    /// </summary>
    public static readonly Coding RegulatoryRequirement = new Coding
    {
      Code = "RR",
      Display = "regulatory requirement",
      System = "http://hl7.org/fhir/v3/ActReason"
    };

    /// <summary>
    /// Literal for code: ContinuingTherapy
    /// </summary>
    public const string LiteralContinuingTherapy = "CT";

    /// <summary>
    /// Literal for code: V3ActReasonContinuingTherapy
    /// </summary>
    public const string LiteralV3ActReasonContinuingTherapy = "http://hl7.org/fhir/v3/ActReason#CT";

    /// <summary>
    /// Literal for code: FormularyPolicy
    /// </summary>
    public const string LiteralFormularyPolicy = "FP";

    /// <summary>
    /// Literal for code: V3ActReasonFormularyPolicy
    /// </summary>
    public const string LiteralV3ActReasonFormularyPolicy = "http://hl7.org/fhir/v3/ActReason#FP";

    /// <summary>
    /// Literal for code: OutOfStock
    /// </summary>
    public const string LiteralOutOfStock = "OS";

    /// <summary>
    /// Literal for code: V3ActReasonOutOfStock
    /// </summary>
    public const string LiteralV3ActReasonOutOfStock = "http://hl7.org/fhir/v3/ActReason#OS";

    /// <summary>
    /// Literal for code: RegulatoryRequirement
    /// </summary>
    public const string LiteralRegulatoryRequirement = "RR";

    /// <summary>
    /// Literal for code: V3ActReasonRegulatoryRequirement
    /// </summary>
    public const string LiteralV3ActReasonRegulatoryRequirement = "http://hl7.org/fhir/v3/ActReason#RR";

    /// <summary>
    /// Dictionary for looking up V3SubstanceAdminSubstitutionReason Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "CT", ContinuingTherapy }, 
      { "http://hl7.org/fhir/v3/ActReason#CT", ContinuingTherapy }, 
      { "FP", FormularyPolicy }, 
      { "http://hl7.org/fhir/v3/ActReason#FP", FormularyPolicy }, 
      { "OS", OutOfStock }, 
      { "http://hl7.org/fhir/v3/ActReason#OS", OutOfStock }, 
      { "RR", RegulatoryRequirement }, 
      { "http://hl7.org/fhir/v3/ActReason#RR", RegulatoryRequirement }, 
    };
  };
}
