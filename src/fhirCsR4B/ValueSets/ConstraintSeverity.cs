// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// SHALL applications comply with this constraint?
  /// </summary>
  public static class ConstraintSeverityCodes
  {
    /// <summary>
    /// If the constraint is violated, the resource is not conformant.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://hl7.org/fhir/constraint-severity"
    };
    /// <summary>
    /// If the constraint is violated, the resource is conformant, but it is not necessarily following best practice.
    /// </summary>
    public static readonly Coding Warning = new Coding
    {
      Code = "warning",
      Display = "Warning",
      System = "http://hl7.org/fhir/constraint-severity"
    };

    /// <summary>
    /// Literal for code: Error
    /// </summary>
    public const string LiteralError = "error";

    /// <summary>
    /// Literal for code: ConstraintSeverityError
    /// </summary>
    public const string LiteralConstraintSeverityError = "http://hl7.org/fhir/constraint-severity#error";

    /// <summary>
    /// Literal for code: Warning
    /// </summary>
    public const string LiteralWarning = "warning";

    /// <summary>
    /// Literal for code: ConstraintSeverityWarning
    /// </summary>
    public const string LiteralConstraintSeverityWarning = "http://hl7.org/fhir/constraint-severity#warning";

    /// <summary>
    /// Dictionary for looking up ConstraintSeverity Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "error", Error }, 
      { "http://hl7.org/fhir/constraint-severity#error", Error }, 
      { "warning", Warning }, 
      { "http://hl7.org/fhir/constraint-severity#warning", Warning }, 
    };
  };
}
