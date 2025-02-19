// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate a type of insurance plan.
  /// </summary>
  public static class InsuranceplanTypeCodes
  {
    /// <summary>
    /// Dental
    /// </summary>
    public static readonly Coding Dental = new Coding
    {
      Code = "dental",
      Display = "Dental",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Drug
    /// </summary>
    public static readonly Coding Drug = new Coding
    {
      Code = "Drug",
      Display = "Drug",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Home Health
    /// </summary>
    public static readonly Coding HomeHealth = new Coding
    {
      Code = "home",
      Display = "Home Health",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Hospice
    /// </summary>
    public static readonly Coding Hospice = new Coding
    {
      Code = "hospice",
      Display = "Hospice",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Long Term Care
    /// </summary>
    public static readonly Coding LongTermCare = new Coding
    {
      Code = "long-term",
      Display = "Long Term Care",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Medical
    /// </summary>
    public static readonly Coding Medical = new Coding
    {
      Code = "medical",
      Display = "Medical",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Mental Health
    /// </summary>
    public static readonly Coding MentalHealth = new Coding
    {
      Code = "mental",
      Display = "Mental Health",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Short Term
    /// </summary>
    public static readonly Coding ShortTerm = new Coding
    {
      Code = "short-term",
      Display = "Short Term",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Substance Abuse
    /// </summary>
    public static readonly Coding SubstanceAbuse = new Coding
    {
      Code = "subst-ab",
      Display = "Substance Abuse",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };
    /// <summary>
    /// Vision
    /// </summary>
    public static readonly Coding Vision = new Coding
    {
      Code = "vision",
      Display = "Vision",
      System = "http://terminology.hl7.org/CodeSystem/insurance-plan-type"
    };

    /// <summary>
    /// Literal for code: Dental
    /// </summary>
    public const string LiteralDental = "dental";

    /// <summary>
    /// Literal for code: InsuranceplanTypeDental
    /// </summary>
    public const string LiteralInsuranceplanTypeDental = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#dental";

    /// <summary>
    /// Literal for code: Drug
    /// </summary>
    public const string LiteralDrug = "Drug";

    /// <summary>
    /// Literal for code: InsuranceplanTypeDrug
    /// </summary>
    public const string LiteralInsuranceplanTypeDrug = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#Drug";

    /// <summary>
    /// Literal for code: HomeHealth
    /// </summary>
    public const string LiteralHomeHealth = "home";

    /// <summary>
    /// Literal for code: InsuranceplanTypeHomeHealth
    /// </summary>
    public const string LiteralInsuranceplanTypeHomeHealth = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#home";

    /// <summary>
    /// Literal for code: Hospice
    /// </summary>
    public const string LiteralHospice = "hospice";

    /// <summary>
    /// Literal for code: InsuranceplanTypeHospice
    /// </summary>
    public const string LiteralInsuranceplanTypeHospice = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#hospice";

    /// <summary>
    /// Literal for code: LongTermCare
    /// </summary>
    public const string LiteralLongTermCare = "long-term";

    /// <summary>
    /// Literal for code: InsuranceplanTypeLongTermCare
    /// </summary>
    public const string LiteralInsuranceplanTypeLongTermCare = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#long-term";

    /// <summary>
    /// Literal for code: Medical
    /// </summary>
    public const string LiteralMedical = "medical";

    /// <summary>
    /// Literal for code: InsuranceplanTypeMedical
    /// </summary>
    public const string LiteralInsuranceplanTypeMedical = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#medical";

    /// <summary>
    /// Literal for code: MentalHealth
    /// </summary>
    public const string LiteralMentalHealth = "mental";

    /// <summary>
    /// Literal for code: InsuranceplanTypeMentalHealth
    /// </summary>
    public const string LiteralInsuranceplanTypeMentalHealth = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#mental";

    /// <summary>
    /// Literal for code: ShortTerm
    /// </summary>
    public const string LiteralShortTerm = "short-term";

    /// <summary>
    /// Literal for code: InsuranceplanTypeShortTerm
    /// </summary>
    public const string LiteralInsuranceplanTypeShortTerm = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#short-term";

    /// <summary>
    /// Literal for code: SubstanceAbuse
    /// </summary>
    public const string LiteralSubstanceAbuse = "subst-ab";

    /// <summary>
    /// Literal for code: InsuranceplanTypeSubstanceAbuse
    /// </summary>
    public const string LiteralInsuranceplanTypeSubstanceAbuse = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#subst-ab";

    /// <summary>
    /// Literal for code: Vision
    /// </summary>
    public const string LiteralVision = "vision";

    /// <summary>
    /// Literal for code: InsuranceplanTypeVision
    /// </summary>
    public const string LiteralInsuranceplanTypeVision = "http://terminology.hl7.org/CodeSystem/insurance-plan-type#vision";

    /// <summary>
    /// Dictionary for looking up InsuranceplanType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "dental", Dental }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#dental", Dental }, 
      { "Drug", Drug }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#Drug", Drug }, 
      { "home", HomeHealth }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#home", HomeHealth }, 
      { "hospice", Hospice }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#hospice", Hospice }, 
      { "long-term", LongTermCare }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#long-term", LongTermCare }, 
      { "medical", Medical }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#medical", Medical }, 
      { "mental", MentalHealth }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#mental", MentalHealth }, 
      { "short-term", ShortTerm }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#short-term", ShortTerm }, 
      { "subst-ab", SubstanceAbuse }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#subst-ab", SubstanceAbuse }, 
      { "vision", Vision }, 
      { "http://terminology.hl7.org/CodeSystem/insurance-plan-type#vision", Vision }, 
    };
  };
}
