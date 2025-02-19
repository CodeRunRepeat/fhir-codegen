// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// ActConsentDirective codes are used to specify the type of Consent Directive to which a Consent Directive Act conforms.
  /// </summary>
  public static class V3ActConsentDirectiveCodes
  {
    /// <summary>
    /// ActConsentDirective
    /// </summary>
    public static readonly Coding ActConsentDirective = new Coding
    {
      Code = "_ActConsentDirective",
      Display = "ActConsentDirective",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// emergency only
    /// </summary>
    public static readonly Coding EmergencyOnly = new Coding
    {
      Code = "EMRGONLY",
      Display = "emergency only",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// grantor choice
    /// </summary>
    public static readonly Coding GrantorChoice = new Coding
    {
      Code = "GRANTORCHOICE",
      Display = "grantor choice",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// implied consent
    /// </summary>
    public static readonly Coding ImpliedConsent = new Coding
    {
      Code = "IMPLIED",
      Display = "implied consent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// implied consent with opportunity to dissent
    /// </summary>
    public static readonly Coding ImpliedConsentWithOpportunityToDissent = new Coding
    {
      Code = "IMPLIEDD",
      Display = "implied consent with opportunity to dissent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// no consent
    /// </summary>
    public static readonly Coding NoConsent = new Coding
    {
      Code = "NOCONSENT",
      Display = "no consent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// notice of privacy practices
    /// </summary>
    public static readonly Coding NoticeOfPrivacyPractices = new Coding
    {
      Code = "NOPP",
      Display = "notice of privacy practices",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// opt-in
    /// </summary>
    public static readonly Coding OptIn = new Coding
    {
      Code = "OPTIN",
      Display = "opt-in",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// opt-in with restrictions
    /// </summary>
    public static readonly Coding OptInWithRestrictions = new Coding
    {
      Code = "OPTINR",
      Display = "opt-in with restrictions",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// op-out
    /// </summary>
    public static readonly Coding OpOut = new Coding
    {
      Code = "OPTOUT",
      Display = "op-out",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// opt-out with exceptions
    /// </summary>
    public static readonly Coding OptOutWithExceptions = new Coding
    {
      Code = "OPTOUTE",
      Display = "opt-out with exceptions",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };

    /// <summary>
    /// Literal for code: ActConsentDirective
    /// </summary>
    public const string LiteralActConsentDirective = "_ActConsentDirective";

    /// <summary>
    /// Literal for code: V3ActCodeActConsentDirective
    /// </summary>
    public const string LiteralV3ActCodeActConsentDirective = "http://terminology.hl7.org/CodeSystem/v3-ActCode#_ActConsentDirective";

    /// <summary>
    /// Literal for code: EmergencyOnly
    /// </summary>
    public const string LiteralEmergencyOnly = "EMRGONLY";

    /// <summary>
    /// Literal for code: V3ActCodeEmergencyOnly
    /// </summary>
    public const string LiteralV3ActCodeEmergencyOnly = "http://terminology.hl7.org/CodeSystem/v3-ActCode#EMRGONLY";

    /// <summary>
    /// Literal for code: GrantorChoice
    /// </summary>
    public const string LiteralGrantorChoice = "GRANTORCHOICE";

    /// <summary>
    /// Literal for code: V3ActCodeGrantorChoice
    /// </summary>
    public const string LiteralV3ActCodeGrantorChoice = "http://terminology.hl7.org/CodeSystem/v3-ActCode#GRANTORCHOICE";

    /// <summary>
    /// Literal for code: ImpliedConsent
    /// </summary>
    public const string LiteralImpliedConsent = "IMPLIED";

    /// <summary>
    /// Literal for code: V3ActCodeImpliedConsent
    /// </summary>
    public const string LiteralV3ActCodeImpliedConsent = "http://terminology.hl7.org/CodeSystem/v3-ActCode#IMPLIED";

    /// <summary>
    /// Literal for code: ImpliedConsentWithOpportunityToDissent
    /// </summary>
    public const string LiteralImpliedConsentWithOpportunityToDissent = "IMPLIEDD";

    /// <summary>
    /// Literal for code: V3ActCodeImpliedConsentWithOpportunityToDissent
    /// </summary>
    public const string LiteralV3ActCodeImpliedConsentWithOpportunityToDissent = "http://terminology.hl7.org/CodeSystem/v3-ActCode#IMPLIEDD";

    /// <summary>
    /// Literal for code: NoConsent
    /// </summary>
    public const string LiteralNoConsent = "NOCONSENT";

    /// <summary>
    /// Literal for code: V3ActCodeNoConsent
    /// </summary>
    public const string LiteralV3ActCodeNoConsent = "http://terminology.hl7.org/CodeSystem/v3-ActCode#NOCONSENT";

    /// <summary>
    /// Literal for code: NoticeOfPrivacyPractices
    /// </summary>
    public const string LiteralNoticeOfPrivacyPractices = "NOPP";

    /// <summary>
    /// Literal for code: V3ActCodeNoticeOfPrivacyPractices
    /// </summary>
    public const string LiteralV3ActCodeNoticeOfPrivacyPractices = "http://terminology.hl7.org/CodeSystem/v3-ActCode#NOPP";

    /// <summary>
    /// Literal for code: OptIn
    /// </summary>
    public const string LiteralOptIn = "OPTIN";

    /// <summary>
    /// Literal for code: V3ActCodeOptIn
    /// </summary>
    public const string LiteralV3ActCodeOptIn = "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTIN";

    /// <summary>
    /// Literal for code: OptInWithRestrictions
    /// </summary>
    public const string LiteralOptInWithRestrictions = "OPTINR";

    /// <summary>
    /// Literal for code: V3ActCodeOptInWithRestrictions
    /// </summary>
    public const string LiteralV3ActCodeOptInWithRestrictions = "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTINR";

    /// <summary>
    /// Literal for code: OpOut
    /// </summary>
    public const string LiteralOpOut = "OPTOUT";

    /// <summary>
    /// Literal for code: V3ActCodeOpOut
    /// </summary>
    public const string LiteralV3ActCodeOpOut = "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTOUT";

    /// <summary>
    /// Literal for code: OptOutWithExceptions
    /// </summary>
    public const string LiteralOptOutWithExceptions = "OPTOUTE";

    /// <summary>
    /// Literal for code: V3ActCodeOptOutWithExceptions
    /// </summary>
    public const string LiteralV3ActCodeOptOutWithExceptions = "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTOUTE";

    /// <summary>
    /// Dictionary for looking up V3ActConsentDirective Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "_ActConsentDirective", ActConsentDirective }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#_ActConsentDirective", ActConsentDirective }, 
      { "EMRGONLY", EmergencyOnly }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#EMRGONLY", EmergencyOnly }, 
      { "GRANTORCHOICE", GrantorChoice }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#GRANTORCHOICE", GrantorChoice }, 
      { "IMPLIED", ImpliedConsent }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#IMPLIED", ImpliedConsent }, 
      { "IMPLIEDD", ImpliedConsentWithOpportunityToDissent }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#IMPLIEDD", ImpliedConsentWithOpportunityToDissent }, 
      { "NOCONSENT", NoConsent }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#NOCONSENT", NoConsent }, 
      { "NOPP", NoticeOfPrivacyPractices }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#NOPP", NoticeOfPrivacyPractices }, 
      { "OPTIN", OptIn }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTIN", OptIn }, 
      { "OPTINR", OptInWithRestrictions }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTINR", OptInWithRestrictions }, 
      { "OPTOUT", OpOut }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTOUT", OpOut }, 
      { "OPTOUTE", OptOutWithExceptions }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#OPTOUTE", OptOutWithExceptions }, 
    };
  };
}
