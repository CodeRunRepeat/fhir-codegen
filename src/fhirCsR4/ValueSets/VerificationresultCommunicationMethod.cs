// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Attested information may be validated by process that are manual or automated. For automated processes it may accomplished by the system of record reaching out through another system's API or information may be sent to the system of record. This value set defines a set of codes to describing the process, the how, a resource or data element is validated.
  /// </summary>
  public static class VerificationresultCommunicationMethodCodes
  {
    /// <summary>
    /// The information is submitted/retrieved manually (e.g. by phone, fax, paper-based)
    /// </summary>
    public static readonly Coding Manual = new Coding
    {
      Code = "manual",
      Display = "Manual",
      System = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method"
    };
    /// <summary>
    /// The information is submitted/retrieved via a portal
    /// </summary>
    public static readonly Coding Portal = new Coding
    {
      Code = "portal",
      Display = "Portal",
      System = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method"
    };
    /// <summary>
    /// The information is retrieved (i.e. pulled) from a source (e.g. over an API)
    /// </summary>
    public static readonly Coding Pull = new Coding
    {
      Code = "pull",
      Display = "Pull",
      System = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method"
    };
    /// <summary>
    /// The information is sent (i.e. pushed) from a source (e.g. over an API, asynchronously, secure messaging)
    /// </summary>
    public static readonly Coding Push = new Coding
    {
      Code = "push",
      Display = "Push",
      System = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method"
    };

    /// <summary>
    /// Literal for code: Manual
    /// </summary>
    public const string LiteralManual = "manual";

    /// <summary>
    /// Literal for code: VerificationresultCommunicationMethodManual
    /// </summary>
    public const string LiteralVerificationresultCommunicationMethodManual = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#manual";

    /// <summary>
    /// Literal for code: Portal
    /// </summary>
    public const string LiteralPortal = "portal";

    /// <summary>
    /// Literal for code: VerificationresultCommunicationMethodPortal
    /// </summary>
    public const string LiteralVerificationresultCommunicationMethodPortal = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#portal";

    /// <summary>
    /// Literal for code: Pull
    /// </summary>
    public const string LiteralPull = "pull";

    /// <summary>
    /// Literal for code: VerificationresultCommunicationMethodPull
    /// </summary>
    public const string LiteralVerificationresultCommunicationMethodPull = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#pull";

    /// <summary>
    /// Literal for code: Push
    /// </summary>
    public const string LiteralPush = "push";

    /// <summary>
    /// Literal for code: VerificationresultCommunicationMethodPush
    /// </summary>
    public const string LiteralVerificationresultCommunicationMethodPush = "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#push";

    /// <summary>
    /// Dictionary for looking up VerificationresultCommunicationMethod Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "manual", Manual }, 
      { "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#manual", Manual }, 
      { "portal", Portal }, 
      { "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#portal", Portal }, 
      { "pull", Pull }, 
      { "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#pull", Pull }, 
      { "push", Push }, 
      { "http://terminology.hl7.org/CodeSystem/verificationresult-communication-method#push", Push }, 
    };
  };
}
