// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Defines organization behavior of a group.
  /// </summary>
  public static class ActionGroupingBehaviorCodes
  {
    /// <summary>
    /// A group with this behavior logically groups its sub-elements, and may be shown as a visual group to the end user, but it is not required to do so.
    /// </summary>
    public static readonly Coding LogicalGroup = new Coding
    {
      Code = "logical-group",
      Display = "Logical Group",
      System = "http://hl7.org/fhir/action-grouping-behavior"
    };
    /// <summary>
    /// A group of related alternative actions is a sentence group if the target referenced by the action is the same in all the actions and each action simply constitutes a different variation on how to specify the details for the target. For example, two actions that could be in a SentenceGroup are "aspirin, 500 mg, 2 times per day" and "aspirin, 300 mg, 3 times per day". In both cases, aspirin is the target referenced by the action, and the two actions represent different options for how aspirin might be ordered for the patient. Note that a SentenceGroup would almost always have an associated selection behavior of "AtMostOne", unless it's a required action, in which case, it would be "ExactlyOne".
    /// </summary>
    public static readonly Coding SentenceGroup = new Coding
    {
      Code = "sentence-group",
      Display = "Sentence Group",
      System = "http://hl7.org/fhir/action-grouping-behavior"
    };
    /// <summary>
    /// Any group marked with this behavior should be displayed as a visual group to the end user.
    /// </summary>
    public static readonly Coding VisualGroup = new Coding
    {
      Code = "visual-group",
      Display = "Visual Group",
      System = "http://hl7.org/fhir/action-grouping-behavior"
    };

    /// <summary>
    /// Literal for code: LogicalGroup
    /// </summary>
    public const string LiteralLogicalGroup = "logical-group";

    /// <summary>
    /// Literal for code: ActionGroupingBehaviorLogicalGroup
    /// </summary>
    public const string LiteralActionGroupingBehaviorLogicalGroup = "http://hl7.org/fhir/action-grouping-behavior#logical-group";

    /// <summary>
    /// Literal for code: SentenceGroup
    /// </summary>
    public const string LiteralSentenceGroup = "sentence-group";

    /// <summary>
    /// Literal for code: ActionGroupingBehaviorSentenceGroup
    /// </summary>
    public const string LiteralActionGroupingBehaviorSentenceGroup = "http://hl7.org/fhir/action-grouping-behavior#sentence-group";

    /// <summary>
    /// Literal for code: VisualGroup
    /// </summary>
    public const string LiteralVisualGroup = "visual-group";

    /// <summary>
    /// Literal for code: ActionGroupingBehaviorVisualGroup
    /// </summary>
    public const string LiteralActionGroupingBehaviorVisualGroup = "http://hl7.org/fhir/action-grouping-behavior#visual-group";

    /// <summary>
    /// Dictionary for looking up ActionGroupingBehavior Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "logical-group", LogicalGroup }, 
      { "http://hl7.org/fhir/action-grouping-behavior#logical-group", LogicalGroup }, 
      { "sentence-group", SentenceGroup }, 
      { "http://hl7.org/fhir/action-grouping-behavior#sentence-group", SentenceGroup }, 
      { "visual-group", VisualGroup }, 
      { "http://hl7.org/fhir/action-grouping-behavior#visual-group", VisualGroup }, 
    };
  };
}
