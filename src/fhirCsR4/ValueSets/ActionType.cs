// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of action to be performed.
  /// </summary>
  public static class ActionTypeCodes
  {
    /// <summary>
    /// The action is to create a new resource.
    /// </summary>
    public static readonly Coding Create = new Coding
    {
      Code = "create",
      Display = "Create",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
    /// <summary>
    /// The action is to fire a specific event.
    /// </summary>
    public static readonly Coding FireEvent = new Coding
    {
      Code = "fire-event",
      Display = "Fire Event",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
    /// <summary>
    /// The action is to remove an existing resource.
    /// </summary>
    public static readonly Coding Remove = new Coding
    {
      Code = "remove",
      Display = "Remove",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
    /// <summary>
    /// The action is to update an existing resource.
    /// </summary>
    public static readonly Coding Update = new Coding
    {
      Code = "update",
      Display = "Update",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };

    /// <summary>
    /// Literal for code: Create
    /// </summary>
    public const string LiteralCreate = "create";

    /// <summary>
    /// Literal for code: ActionTypeCreate
    /// </summary>
    public const string LiteralActionTypeCreate = "http://terminology.hl7.org/CodeSystem/action-type#create";

    /// <summary>
    /// Literal for code: FireEvent
    /// </summary>
    public const string LiteralFireEvent = "fire-event";

    /// <summary>
    /// Literal for code: ActionTypeFireEvent
    /// </summary>
    public const string LiteralActionTypeFireEvent = "http://terminology.hl7.org/CodeSystem/action-type#fire-event";

    /// <summary>
    /// Literal for code: Remove
    /// </summary>
    public const string LiteralRemove = "remove";

    /// <summary>
    /// Literal for code: ActionTypeRemove
    /// </summary>
    public const string LiteralActionTypeRemove = "http://terminology.hl7.org/CodeSystem/action-type#remove";

    /// <summary>
    /// Literal for code: Update
    /// </summary>
    public const string LiteralUpdate = "update";

    /// <summary>
    /// Literal for code: ActionTypeUpdate
    /// </summary>
    public const string LiteralActionTypeUpdate = "http://terminology.hl7.org/CodeSystem/action-type#update";

    /// <summary>
    /// Dictionary for looking up ActionType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "create", Create }, 
      { "http://terminology.hl7.org/CodeSystem/action-type#create", Create }, 
      { "fire-event", FireEvent }, 
      { "http://terminology.hl7.org/CodeSystem/action-type#fire-event", FireEvent }, 
      { "remove", Remove }, 
      { "http://terminology.hl7.org/CodeSystem/action-type#remove", Remove }, 
      { "update", Update }, 
      { "http://terminology.hl7.org/CodeSystem/action-type#update", Update }, 
    };
  };
}
