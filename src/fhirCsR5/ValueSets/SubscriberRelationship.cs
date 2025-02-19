// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes codes for the relationship between the Subscriber and the Beneficiary (insured/covered party/patient).
  /// </summary>
  public static class SubscriberRelationshipCodes
  {
    /// <summary>
    /// Child
    /// </summary>
    public static readonly Coding Child = new Coding
    {
      Code = "child",
      Display = "Child",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };
    /// <summary>
    /// Common Law Spouse
    /// </summary>
    public static readonly Coding CommonLawSpouse = new Coding
    {
      Code = "common",
      Display = "Common Law Spouse",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };
    /// <summary>
    /// Injured Party
    /// </summary>
    public static readonly Coding InjuredParty = new Coding
    {
      Code = "injured",
      Display = "Injured Party",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };
    /// <summary>
    /// Other
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };
    /// <summary>
    /// Parent
    /// </summary>
    public static readonly Coding Parent = new Coding
    {
      Code = "parent",
      Display = "Parent",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };
    /// <summary>
    /// Self
    /// </summary>
    public static readonly Coding Self = new Coding
    {
      Code = "self",
      Display = "Self",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };
    /// <summary>
    /// Spouse
    /// </summary>
    public static readonly Coding Spouse = new Coding
    {
      Code = "spouse",
      Display = "Spouse",
      System = "http://terminology.hl7.org/CodeSystem/subscriber-relationship"
    };

    /// <summary>
    /// Literal for code: Child
    /// </summary>
    public const string LiteralChild = "child";

    /// <summary>
    /// Literal for code: SubscriberRelationshipChild
    /// </summary>
    public const string LiteralSubscriberRelationshipChild = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#child";

    /// <summary>
    /// Literal for code: CommonLawSpouse
    /// </summary>
    public const string LiteralCommonLawSpouse = "common";

    /// <summary>
    /// Literal for code: SubscriberRelationshipCommonLawSpouse
    /// </summary>
    public const string LiteralSubscriberRelationshipCommonLawSpouse = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#common";

    /// <summary>
    /// Literal for code: InjuredParty
    /// </summary>
    public const string LiteralInjuredParty = "injured";

    /// <summary>
    /// Literal for code: SubscriberRelationshipInjuredParty
    /// </summary>
    public const string LiteralSubscriberRelationshipInjuredParty = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#injured";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: SubscriberRelationshipOther
    /// </summary>
    public const string LiteralSubscriberRelationshipOther = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#other";

    /// <summary>
    /// Literal for code: Parent
    /// </summary>
    public const string LiteralParent = "parent";

    /// <summary>
    /// Literal for code: SubscriberRelationshipParent
    /// </summary>
    public const string LiteralSubscriberRelationshipParent = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#parent";

    /// <summary>
    /// Literal for code: Self
    /// </summary>
    public const string LiteralSelf = "self";

    /// <summary>
    /// Literal for code: SubscriberRelationshipSelf
    /// </summary>
    public const string LiteralSubscriberRelationshipSelf = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#self";

    /// <summary>
    /// Literal for code: Spouse
    /// </summary>
    public const string LiteralSpouse = "spouse";

    /// <summary>
    /// Literal for code: SubscriberRelationshipSpouse
    /// </summary>
    public const string LiteralSubscriberRelationshipSpouse = "http://terminology.hl7.org/CodeSystem/subscriber-relationship#spouse";

    /// <summary>
    /// Dictionary for looking up SubscriberRelationship Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "child", Child }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#child", Child }, 
      { "common", CommonLawSpouse }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#common", CommonLawSpouse }, 
      { "injured", InjuredParty }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#injured", InjuredParty }, 
      { "other", Other }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#other", Other }, 
      { "parent", Parent }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#parent", Parent }, 
      { "self", Self }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#self", Self }, 
      { "spouse", Spouse }, 
      { "http://terminology.hl7.org/CodeSystem/subscriber-relationship#spouse", Spouse }, 
    };
  };
}
