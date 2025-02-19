// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A set of flags that defines how references are supported.
  /// </summary>
  public static class ReferenceHandlingPolicyCodes
  {
    /// <summary>
    /// The server enforces that references have integrity - e.g. it ensures that references can always be resolved. This is typically the case for clinical record systems, but often not the case for middleware/proxy systems.
    /// </summary>
    public static readonly Coding ReferenceIntegrityEnforced = new Coding
    {
      Code = "enforced",
      Display = "Reference Integrity Enforced",
      System = "http://hl7.org/fhir/reference-handling-policy"
    };
    /// <summary>
    /// The server supports and populates Literal references (i.e. using Reference.reference) where they are known (this code does not guarantee that all references are literal; see 'enforced').
    /// </summary>
    public static readonly Coding LiteralReferences = new Coding
    {
      Code = "literal",
      Display = "Literal References",
      System = "http://hl7.org/fhir/reference-handling-policy"
    };
    /// <summary>
    /// The server does not support references that point to other servers.
    /// </summary>
    public static readonly Coding LocalReferencesOnly = new Coding
    {
      Code = "local",
      Display = "Local References Only",
      System = "http://hl7.org/fhir/reference-handling-policy"
    };
    /// <summary>
    /// The server allows logical references (i.e. using Reference.identifier).
    /// </summary>
    public static readonly Coding LogicalReferences = new Coding
    {
      Code = "logical",
      Display = "Logical References",
      System = "http://hl7.org/fhir/reference-handling-policy"
    };
    /// <summary>
    /// The server will attempt to resolve logical references to literal references - i.e. converting Reference.identifier to Reference.reference (if resolution fails, the server may still accept resources; see logical).
    /// </summary>
    public static readonly Coding ResolvesReferences = new Coding
    {
      Code = "resolves",
      Display = "Resolves References",
      System = "http://hl7.org/fhir/reference-handling-policy"
    };

    /// <summary>
    /// Literal for code: ReferenceIntegrityEnforced
    /// </summary>
    public const string LiteralReferenceIntegrityEnforced = "enforced";

    /// <summary>
    /// Literal for code: ReferenceHandlingPolicyReferenceIntegrityEnforced
    /// </summary>
    public const string LiteralReferenceHandlingPolicyReferenceIntegrityEnforced = "http://hl7.org/fhir/reference-handling-policy#enforced";

    /// <summary>
    /// Literal for code: LiteralReferences
    /// </summary>
    public const string LiteralLiteralReferences = "literal";

    /// <summary>
    /// Literal for code: ReferenceHandlingPolicyLiteralReferences
    /// </summary>
    public const string LiteralReferenceHandlingPolicyLiteralReferences = "http://hl7.org/fhir/reference-handling-policy#literal";

    /// <summary>
    /// Literal for code: LocalReferencesOnly
    /// </summary>
    public const string LiteralLocalReferencesOnly = "local";

    /// <summary>
    /// Literal for code: ReferenceHandlingPolicyLocalReferencesOnly
    /// </summary>
    public const string LiteralReferenceHandlingPolicyLocalReferencesOnly = "http://hl7.org/fhir/reference-handling-policy#local";

    /// <summary>
    /// Literal for code: LogicalReferences
    /// </summary>
    public const string LiteralLogicalReferences = "logical";

    /// <summary>
    /// Literal for code: ReferenceHandlingPolicyLogicalReferences
    /// </summary>
    public const string LiteralReferenceHandlingPolicyLogicalReferences = "http://hl7.org/fhir/reference-handling-policy#logical";

    /// <summary>
    /// Literal for code: ResolvesReferences
    /// </summary>
    public const string LiteralResolvesReferences = "resolves";

    /// <summary>
    /// Literal for code: ReferenceHandlingPolicyResolvesReferences
    /// </summary>
    public const string LiteralReferenceHandlingPolicyResolvesReferences = "http://hl7.org/fhir/reference-handling-policy#resolves";

    /// <summary>
    /// Dictionary for looking up ReferenceHandlingPolicy Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "enforced", ReferenceIntegrityEnforced }, 
      { "http://hl7.org/fhir/reference-handling-policy#enforced", ReferenceIntegrityEnforced }, 
      { "literal", LiteralReferences }, 
      { "http://hl7.org/fhir/reference-handling-policy#literal", LiteralReferences }, 
      { "local", LocalReferencesOnly }, 
      { "http://hl7.org/fhir/reference-handling-policy#local", LocalReferencesOnly }, 
      { "logical", LogicalReferences }, 
      { "http://hl7.org/fhir/reference-handling-policy#logical", LogicalReferences }, 
      { "resolves", ResolvesReferences }, 
      { "http://hl7.org/fhir/reference-handling-policy#resolves", ResolvesReferences }, 
    };
  };
}
