// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Indicates the level of importance associated with reaching or sustaining a goal.
  /// </summary>
  public static class GoalPriorityCodes
  {
    /// <summary>
    /// Indicates that the goal is of considerable importance and should be a primary focus of care delivery.
    /// </summary>
    public static readonly Coding HighPriority = new Coding
    {
      Code = "high-priority",
      Display = "High Priority",
      System = "http://terminology.hl7.org/CodeSystem/goal-priority"
    };
    /// <summary>
    /// The goal is desirable but is not sufficiently important to devote significant resources to.  Achievement of the goal may be sought when incidental to achieving other goals.
    /// </summary>
    public static readonly Coding LowPriority = new Coding
    {
      Code = "low-priority",
      Display = "Low Priority",
      System = "http://terminology.hl7.org/CodeSystem/goal-priority"
    };
    /// <summary>
    /// Indicates that the goal has a reasonable degree of importance and that concrete action should be taken towards the goal.  Attainment is not as critical as high-priority goals.
    /// </summary>
    public static readonly Coding MediumPriority = new Coding
    {
      Code = "medium-priority",
      Display = "Medium Priority",
      System = "http://terminology.hl7.org/CodeSystem/goal-priority"
    };

    /// <summary>
    /// Literal for code: HighPriority
    /// </summary>
    public const string LiteralHighPriority = "high-priority";

    /// <summary>
    /// Literal for code: GoalPriorityHighPriority
    /// </summary>
    public const string LiteralGoalPriorityHighPriority = "http://terminology.hl7.org/CodeSystem/goal-priority#high-priority";

    /// <summary>
    /// Literal for code: LowPriority
    /// </summary>
    public const string LiteralLowPriority = "low-priority";

    /// <summary>
    /// Literal for code: GoalPriorityLowPriority
    /// </summary>
    public const string LiteralGoalPriorityLowPriority = "http://terminology.hl7.org/CodeSystem/goal-priority#low-priority";

    /// <summary>
    /// Literal for code: MediumPriority
    /// </summary>
    public const string LiteralMediumPriority = "medium-priority";

    /// <summary>
    /// Literal for code: GoalPriorityMediumPriority
    /// </summary>
    public const string LiteralGoalPriorityMediumPriority = "http://terminology.hl7.org/CodeSystem/goal-priority#medium-priority";

    /// <summary>
    /// Dictionary for looking up GoalPriority Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "high-priority", HighPriority }, 
      { "http://terminology.hl7.org/CodeSystem/goal-priority#high-priority", HighPriority }, 
      { "low-priority", LowPriority }, 
      { "http://terminology.hl7.org/CodeSystem/goal-priority#low-priority", LowPriority }, 
      { "medium-priority", MediumPriority }, 
      { "http://terminology.hl7.org/CodeSystem/goal-priority#medium-priority", MediumPriority }, 
    };
  };
}
