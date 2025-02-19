// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The verification status to support or decline the clinical status of the allergy or intolerance.
  /// </summary>
  public static class AllergyintoleranceVerificationCodes
  {
    /// <summary>
    /// Confirmed
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// Entered in Error
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// Presumed
    /// </summary>
    public static readonly Coding Presumed = new Coding
    {
      Code = "presumed",
      Display = "Presumed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// Refuted
    /// </summary>
    public static readonly Coding Refuted = new Coding
    {
      Code = "refuted",
      Display = "Refuted",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// Unconfirmed
    /// </summary>
    public static readonly Coding Unconfirmed = new Coding
    {
      Code = "unconfirmed",
      Display = "Unconfirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };

    /// <summary>
    /// Literal for code: Confirmed
    /// </summary>
    public const string LiteralConfirmed = "confirmed";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationConfirmed
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationConfirmed = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#confirmed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationEnteredInError
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationEnteredInError = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#entered-in-error";

    /// <summary>
    /// Literal for code: Presumed
    /// </summary>
    public const string LiteralPresumed = "presumed";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationPresumed
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationPresumed = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#presumed";

    /// <summary>
    /// Literal for code: Refuted
    /// </summary>
    public const string LiteralRefuted = "refuted";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationRefuted
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationRefuted = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#refuted";

    /// <summary>
    /// Literal for code: Unconfirmed
    /// </summary>
    public const string LiteralUnconfirmed = "unconfirmed";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationUnconfirmed
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationUnconfirmed = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#unconfirmed";

    /// <summary>
    /// Dictionary for looking up AllergyintoleranceVerification Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "confirmed", Confirmed }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#confirmed", Confirmed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#entered-in-error", EnteredInError }, 
      { "presumed", Presumed }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#presumed", Presumed }, 
      { "refuted", Refuted }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#refuted", Refuted }, 
      { "unconfirmed", Unconfirmed }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#unconfirmed", Unconfirmed }, 
    };
  };
}
