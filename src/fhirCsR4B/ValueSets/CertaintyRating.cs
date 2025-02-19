// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The assessment of quality, confidence, or certainty.
  /// </summary>
  public static class CertaintyRatingCodes
  {
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to be absent.
    /// </summary>
    public static readonly Coding Absent = new Coding
    {
      Code = "absent",
      Display = "absent",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// reduce quality rating by 1.
    /// </summary>
    public static readonly Coding ReduceRating1 = new Coding
    {
      Code = "downcode1",
      Display = "reduce rating: -1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// reduce quality rating by 2.
    /// </summary>
    public static readonly Coding ReduceRating2 = new Coding
    {
      Code = "downcode2",
      Display = "reduce rating: -2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// reduce quality rating by 3.
    /// </summary>
    public static readonly Coding ReduceRating3 = new Coding
    {
      Code = "downcode3",
      Display = "reduce rating: -3",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// extremely serious concern.
    /// </summary>
    public static readonly Coding ExtremelySeriousConcern = new Coding
    {
      Code = "extremely-serious-concern",
      Display = "extremely serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// High quality evidence.
    /// </summary>
    public static readonly Coding HighQuality = new Coding
    {
      Code = "high",
      Display = "High quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// Low quality evidence.
    /// </summary>
    public static readonly Coding LowQuality = new Coding
    {
      Code = "low",
      Display = "Low quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// Moderate quality evidence.
    /// </summary>
    public static readonly Coding ModerateQuality = new Coding
    {
      Code = "moderate",
      Display = "Moderate quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// no change to quality rating.
    /// </summary>
    public static readonly Coding NoChangeToRating = new Coding
    {
      Code = "no-change",
      Display = "no change to rating",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// no serious concern.
    /// </summary>
    public static readonly Coding NoSeriousConcern = new Coding
    {
      Code = "no-concern",
      Display = "no serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to be present.
    /// </summary>
    public static readonly Coding Present = new Coding
    {
      Code = "present",
      Display = "present",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// serious concern.
    /// </summary>
    public static readonly Coding SeriousConcern = new Coding
    {
      Code = "serious-concern",
      Display = "serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// increase quality rating by 1.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus1 = new Coding
    {
      Code = "upcode1",
      Display = "increase rating: +1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// increase quality rating by 2.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus2 = new Coding
    {
      Code = "upcode2",
      Display = "increase rating: +2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// Very low quality evidence.
    /// </summary>
    public static readonly Coding VeryLowQuality = new Coding
    {
      Code = "very-low",
      Display = "Very low quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// very serious concern.
    /// </summary>
    public static readonly Coding VerySeriousConcern = new Coding
    {
      Code = "very-serious-concern",
      Display = "very serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };

    /// <summary>
    /// Literal for code: Absent
    /// </summary>
    public const string LiteralAbsent = "absent";

    /// <summary>
    /// Literal for code: CertaintyRatingAbsent
    /// </summary>
    public const string LiteralCertaintyRatingAbsent = "http://terminology.hl7.org/CodeSystem/certainty-rating#absent";

    /// <summary>
    /// Literal for code: ReduceRating1
    /// </summary>
    public const string LiteralReduceRating1 = "downcode1";

    /// <summary>
    /// Literal for code: CertaintyRatingReduceRating1
    /// </summary>
    public const string LiteralCertaintyRatingReduceRating1 = "http://terminology.hl7.org/CodeSystem/certainty-rating#downcode1";

    /// <summary>
    /// Literal for code: ReduceRating2
    /// </summary>
    public const string LiteralReduceRating2 = "downcode2";

    /// <summary>
    /// Literal for code: CertaintyRatingReduceRating2
    /// </summary>
    public const string LiteralCertaintyRatingReduceRating2 = "http://terminology.hl7.org/CodeSystem/certainty-rating#downcode2";

    /// <summary>
    /// Literal for code: ReduceRating3
    /// </summary>
    public const string LiteralReduceRating3 = "downcode3";

    /// <summary>
    /// Literal for code: CertaintyRatingReduceRating3
    /// </summary>
    public const string LiteralCertaintyRatingReduceRating3 = "http://terminology.hl7.org/CodeSystem/certainty-rating#downcode3";

    /// <summary>
    /// Literal for code: ExtremelySeriousConcern
    /// </summary>
    public const string LiteralExtremelySeriousConcern = "extremely-serious-concern";

    /// <summary>
    /// Literal for code: CertaintyRatingExtremelySeriousConcern
    /// </summary>
    public const string LiteralCertaintyRatingExtremelySeriousConcern = "http://terminology.hl7.org/CodeSystem/certainty-rating#extremely-serious-concern";

    /// <summary>
    /// Literal for code: HighQuality
    /// </summary>
    public const string LiteralHighQuality = "high";

    /// <summary>
    /// Literal for code: CertaintyRatingHighQuality
    /// </summary>
    public const string LiteralCertaintyRatingHighQuality = "http://terminology.hl7.org/CodeSystem/certainty-rating#high";

    /// <summary>
    /// Literal for code: LowQuality
    /// </summary>
    public const string LiteralLowQuality = "low";

    /// <summary>
    /// Literal for code: CertaintyRatingLowQuality
    /// </summary>
    public const string LiteralCertaintyRatingLowQuality = "http://terminology.hl7.org/CodeSystem/certainty-rating#low";

    /// <summary>
    /// Literal for code: ModerateQuality
    /// </summary>
    public const string LiteralModerateQuality = "moderate";

    /// <summary>
    /// Literal for code: CertaintyRatingModerateQuality
    /// </summary>
    public const string LiteralCertaintyRatingModerateQuality = "http://terminology.hl7.org/CodeSystem/certainty-rating#moderate";

    /// <summary>
    /// Literal for code: NoChangeToRating
    /// </summary>
    public const string LiteralNoChangeToRating = "no-change";

    /// <summary>
    /// Literal for code: CertaintyRatingNoChangeToRating
    /// </summary>
    public const string LiteralCertaintyRatingNoChangeToRating = "http://terminology.hl7.org/CodeSystem/certainty-rating#no-change";

    /// <summary>
    /// Literal for code: NoSeriousConcern
    /// </summary>
    public const string LiteralNoSeriousConcern = "no-concern";

    /// <summary>
    /// Literal for code: CertaintyRatingNoSeriousConcern
    /// </summary>
    public const string LiteralCertaintyRatingNoSeriousConcern = "http://terminology.hl7.org/CodeSystem/certainty-rating#no-concern";

    /// <summary>
    /// Literal for code: Present
    /// </summary>
    public const string LiteralPresent = "present";

    /// <summary>
    /// Literal for code: CertaintyRatingPresent
    /// </summary>
    public const string LiteralCertaintyRatingPresent = "http://terminology.hl7.org/CodeSystem/certainty-rating#present";

    /// <summary>
    /// Literal for code: SeriousConcern
    /// </summary>
    public const string LiteralSeriousConcern = "serious-concern";

    /// <summary>
    /// Literal for code: CertaintyRatingSeriousConcern
    /// </summary>
    public const string LiteralCertaintyRatingSeriousConcern = "http://terminology.hl7.org/CodeSystem/certainty-rating#serious-concern";

    /// <summary>
    /// Literal for code: IncreaseRatingPlus1
    /// </summary>
    public const string LiteralIncreaseRatingPlus1 = "upcode1";

    /// <summary>
    /// Literal for code: CertaintyRatingIncreaseRatingPlus1
    /// </summary>
    public const string LiteralCertaintyRatingIncreaseRatingPlus1 = "http://terminology.hl7.org/CodeSystem/certainty-rating#upcode1";

    /// <summary>
    /// Literal for code: IncreaseRatingPlus2
    /// </summary>
    public const string LiteralIncreaseRatingPlus2 = "upcode2";

    /// <summary>
    /// Literal for code: CertaintyRatingIncreaseRatingPlus2
    /// </summary>
    public const string LiteralCertaintyRatingIncreaseRatingPlus2 = "http://terminology.hl7.org/CodeSystem/certainty-rating#upcode2";

    /// <summary>
    /// Literal for code: VeryLowQuality
    /// </summary>
    public const string LiteralVeryLowQuality = "very-low";

    /// <summary>
    /// Literal for code: CertaintyRatingVeryLowQuality
    /// </summary>
    public const string LiteralCertaintyRatingVeryLowQuality = "http://terminology.hl7.org/CodeSystem/certainty-rating#very-low";

    /// <summary>
    /// Literal for code: VerySeriousConcern
    /// </summary>
    public const string LiteralVerySeriousConcern = "very-serious-concern";

    /// <summary>
    /// Literal for code: CertaintyRatingVerySeriousConcern
    /// </summary>
    public const string LiteralCertaintyRatingVerySeriousConcern = "http://terminology.hl7.org/CodeSystem/certainty-rating#very-serious-concern";

    /// <summary>
    /// Dictionary for looking up CertaintyRating Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "absent", Absent }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#absent", Absent }, 
      { "downcode1", ReduceRating1 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#downcode1", ReduceRating1 }, 
      { "downcode2", ReduceRating2 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#downcode2", ReduceRating2 }, 
      { "downcode3", ReduceRating3 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#downcode3", ReduceRating3 }, 
      { "extremely-serious-concern", ExtremelySeriousConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#extremely-serious-concern", ExtremelySeriousConcern }, 
      { "high", HighQuality }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#high", HighQuality }, 
      { "low", LowQuality }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#low", LowQuality }, 
      { "moderate", ModerateQuality }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#moderate", ModerateQuality }, 
      { "no-change", NoChangeToRating }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#no-change", NoChangeToRating }, 
      { "no-concern", NoSeriousConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#no-concern", NoSeriousConcern }, 
      { "present", Present }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#present", Present }, 
      { "serious-concern", SeriousConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#serious-concern", SeriousConcern }, 
      { "upcode1", IncreaseRatingPlus1 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#upcode1", IncreaseRatingPlus1 }, 
      { "upcode2", IncreaseRatingPlus2 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#upcode2", IncreaseRatingPlus2 }, 
      { "very-low", VeryLowQuality }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#very-low", VeryLowQuality }, 
      { "very-serious-concern", VerySeriousConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-rating#very-serious-concern", VerySeriousConcern }, 
    };
  };
}
