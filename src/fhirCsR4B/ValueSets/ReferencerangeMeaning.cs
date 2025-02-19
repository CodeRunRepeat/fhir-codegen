// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that can be used to indicate the meaning/use of a reference range for a particular target population.
  /// </summary>
  public static class ReferencerangeMeaningCodes
  {
    /// <summary>
    /// Endocrine related states that change the expected value.
    /// </summary>
    public static readonly Coding Endocrine = new Coding
    {
      Code = "endocrine",
      Display = "Endocrine",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual during the follicular stage of the cycle.
    /// </summary>
    public static readonly Coding FollicularStage = new Coding
    {
      Code = "follicular",
      Display = "Follicular Stage",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual during the luteal stage of the cycle.
    /// </summary>
    public static readonly Coding Luteal = new Coding
    {
      Code = "luteal",
      Display = "Luteal",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual during the midcycle stage of the cycle.
    /// </summary>
    public static readonly Coding MidCycle = new Coding
    {
      Code = "midcycle",
      Display = "MidCycle",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// Values expected for a normal member of the relevant control population being measured. Typically each results producer such as a laboratory has specific normal ranges and they are usually defined as within two standard deviations from the mean and account for 95.45% of this population.
    /// </summary>
    public static readonly Coding NormalRange = new Coding
    {
      Code = "normal",
      Display = "Normal Range",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The optimal range for best therapeutic outcomes for a specimen taken immediately after administration.
    /// </summary>
    public static readonly Coding PostTherapeuticDesiredLevel = new Coding
    {
      Code = "post",
      Display = "Post Therapeutic Desired Level",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual post-menopause.
    /// </summary>
    public static readonly Coding PostMenopause = new Coding
    {
      Code = "postmenopausal",
      Display = "Post-Menopause",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The optimal range for best therapeutic outcomes for a specimen taken immediately before administration.
    /// </summary>
    public static readonly Coding PreTherapeuticDesiredLevel = new Coding
    {
      Code = "pre",
      Display = "Pre Therapeutic Desired Level",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual prior to puberty.
    /// </summary>
    public static readonly Coding PrePuberty = new Coding
    {
      Code = "pre-puberty",
      Display = "Pre-Puberty",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The range that is recommended by a relevant professional body.
    /// </summary>
    public static readonly Coding RecommendedRange = new Coding
    {
      Code = "recommended",
      Display = "Recommended Range",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The optimal range for best therapeutic outcomes.
    /// </summary>
    public static readonly Coding TherapeuticDesiredLevel = new Coding
    {
      Code = "therapeutic",
      Display = "Therapeutic Desired Level",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The range at which treatment would/should be considered.
    /// </summary>
    public static readonly Coding TreatmentRange = new Coding
    {
      Code = "treatment",
      Display = "Treatment Range",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// General types of reference range.
    /// </summary>
    public static readonly Coding Type = new Coding
    {
      Code = "type",
      Display = "Type",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };

    /// <summary>
    /// Literal for code: Endocrine
    /// </summary>
    public const string LiteralEndocrine = "endocrine";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningEndocrine
    /// </summary>
    public const string LiteralReferencerangeMeaningEndocrine = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#endocrine";

    /// <summary>
    /// Literal for code: FollicularStage
    /// </summary>
    public const string LiteralFollicularStage = "follicular";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningFollicularStage
    /// </summary>
    public const string LiteralReferencerangeMeaningFollicularStage = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#follicular";

    /// <summary>
    /// Literal for code: Luteal
    /// </summary>
    public const string LiteralLuteal = "luteal";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningLuteal
    /// </summary>
    public const string LiteralReferencerangeMeaningLuteal = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#luteal";

    /// <summary>
    /// Literal for code: MidCycle
    /// </summary>
    public const string LiteralMidCycle = "midcycle";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningMidCycle
    /// </summary>
    public const string LiteralReferencerangeMeaningMidCycle = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#midcycle";

    /// <summary>
    /// Literal for code: NormalRange
    /// </summary>
    public const string LiteralNormalRange = "normal";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningNormalRange
    /// </summary>
    public const string LiteralReferencerangeMeaningNormalRange = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#normal";

    /// <summary>
    /// Literal for code: PostTherapeuticDesiredLevel
    /// </summary>
    public const string LiteralPostTherapeuticDesiredLevel = "post";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningPostTherapeuticDesiredLevel
    /// </summary>
    public const string LiteralReferencerangeMeaningPostTherapeuticDesiredLevel = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#post";

    /// <summary>
    /// Literal for code: PostMenopause
    /// </summary>
    public const string LiteralPostMenopause = "postmenopausal";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningPostMenopause
    /// </summary>
    public const string LiteralReferencerangeMeaningPostMenopause = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#postmenopausal";

    /// <summary>
    /// Literal for code: PreTherapeuticDesiredLevel
    /// </summary>
    public const string LiteralPreTherapeuticDesiredLevel = "pre";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningPreTherapeuticDesiredLevel
    /// </summary>
    public const string LiteralReferencerangeMeaningPreTherapeuticDesiredLevel = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#pre";

    /// <summary>
    /// Literal for code: PrePuberty
    /// </summary>
    public const string LiteralPrePuberty = "pre-puberty";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningPrePuberty
    /// </summary>
    public const string LiteralReferencerangeMeaningPrePuberty = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#pre-puberty";

    /// <summary>
    /// Literal for code: RecommendedRange
    /// </summary>
    public const string LiteralRecommendedRange = "recommended";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningRecommendedRange
    /// </summary>
    public const string LiteralReferencerangeMeaningRecommendedRange = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#recommended";

    /// <summary>
    /// Literal for code: TherapeuticDesiredLevel
    /// </summary>
    public const string LiteralTherapeuticDesiredLevel = "therapeutic";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningTherapeuticDesiredLevel
    /// </summary>
    public const string LiteralReferencerangeMeaningTherapeuticDesiredLevel = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#therapeutic";

    /// <summary>
    /// Literal for code: TreatmentRange
    /// </summary>
    public const string LiteralTreatmentRange = "treatment";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningTreatmentRange
    /// </summary>
    public const string LiteralReferencerangeMeaningTreatmentRange = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#treatment";

    /// <summary>
    /// Literal for code: Type
    /// </summary>
    public const string LiteralType = "type";

    /// <summary>
    /// Literal for code: ReferencerangeMeaningType
    /// </summary>
    public const string LiteralReferencerangeMeaningType = "http://terminology.hl7.org/CodeSystem/referencerange-meaning#type";

    /// <summary>
    /// Dictionary for looking up ReferencerangeMeaning Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "endocrine", Endocrine }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#endocrine", Endocrine }, 
      { "follicular", FollicularStage }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#follicular", FollicularStage }, 
      { "luteal", Luteal }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#luteal", Luteal }, 
      { "midcycle", MidCycle }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#midcycle", MidCycle }, 
      { "normal", NormalRange }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#normal", NormalRange }, 
      { "post", PostTherapeuticDesiredLevel }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#post", PostTherapeuticDesiredLevel }, 
      { "postmenopausal", PostMenopause }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#postmenopausal", PostMenopause }, 
      { "pre", PreTherapeuticDesiredLevel }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#pre", PreTherapeuticDesiredLevel }, 
      { "pre-puberty", PrePuberty }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#pre-puberty", PrePuberty }, 
      { "recommended", RecommendedRange }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#recommended", RecommendedRange }, 
      { "therapeutic", TherapeuticDesiredLevel }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#therapeutic", TherapeuticDesiredLevel }, 
      { "treatment", TreatmentRange }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#treatment", TreatmentRange }, 
      { "type", Type }, 
      { "http://terminology.hl7.org/CodeSystem/referencerange-meaning#type", Type }, 
    };
  };
}
