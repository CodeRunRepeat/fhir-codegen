// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes Status codes.
  /// </summary>
  public static class FmStatusCodes
  {
    /// <summary>
    /// The instance is currently in-force.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/fm-status"
    };
    /// <summary>
    /// The instance is withdrawn, rescinded or reversed.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/fm-status"
    };
    /// <summary>
    /// A new instance the contents of which is not complete.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/fm-status"
    };
    /// <summary>
    /// The instance was entered in error.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/fm-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: FmStatusActive
    /// </summary>
    public const string LiteralFmStatusActive = "http://hl7.org/fhir/fm-status#active";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: FmStatusCancelled
    /// </summary>
    public const string LiteralFmStatusCancelled = "http://hl7.org/fhir/fm-status#cancelled";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: FmStatusDraft
    /// </summary>
    public const string LiteralFmStatusDraft = "http://hl7.org/fhir/fm-status#draft";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: FmStatusEnteredInError
    /// </summary>
    public const string LiteralFmStatusEnteredInError = "http://hl7.org/fhir/fm-status#entered-in-error";

    /// <summary>
    /// Dictionary for looking up FmStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/fm-status#active", Active }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/fm-status#cancelled", Cancelled }, 
      { "draft", Draft }, 
      { "http://hl7.org/fhir/fm-status#draft", Draft }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/fm-status#entered-in-error", EnteredInError }, 
    };
  };
}
