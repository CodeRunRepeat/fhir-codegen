// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Codes specifying the state of the request. Describes the lifecycle of the nutrition order.
  /// </summary>
  public static class NutritionOrderStatusCodes
  {
    /// <summary>
    /// The request is 'actionable', but not all actions that are implied by it have occurred yet.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// The request has been withdrawn and is no longer actionable.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// All actions that are implied by the order have occurred and no continuation is planned (this will rarely be made explicit).
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// The request is in preliminary form prior to being sent.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// Actions implied by the request have been temporarily halted, but are expected to continue later. May also be called "suspended".
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On-Hold",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// The request has been planned.
    /// </summary>
    public static readonly Coding Planned = new Coding
    {
      Code = "planned",
      Display = "Planned",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// The request has been proposed.
    /// </summary>
    public static readonly Coding Proposed = new Coding
    {
      Code = "proposed",
      Display = "Proposed",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };
    /// <summary>
    /// The request has been placed.
    /// </summary>
    public static readonly Coding Requested = new Coding
    {
      Code = "requested",
      Display = "Requested",
      System = "http://hl7.org/fhir/nutrition-order-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: NutritionOrderStatusActive
    /// </summary>
    public const string LiteralNutritionOrderStatusActive = "http://hl7.org/fhir/nutrition-order-status#active";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: NutritionOrderStatusCancelled
    /// </summary>
    public const string LiteralNutritionOrderStatusCancelled = "http://hl7.org/fhir/nutrition-order-status#cancelled";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: NutritionOrderStatusCompleted
    /// </summary>
    public const string LiteralNutritionOrderStatusCompleted = "http://hl7.org/fhir/nutrition-order-status#completed";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: NutritionOrderStatusDraft
    /// </summary>
    public const string LiteralNutritionOrderStatusDraft = "http://hl7.org/fhir/nutrition-order-status#draft";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: NutritionOrderStatusOnHold
    /// </summary>
    public const string LiteralNutritionOrderStatusOnHold = "http://hl7.org/fhir/nutrition-order-status#on-hold";

    /// <summary>
    /// Literal for code: Planned
    /// </summary>
    public const string LiteralPlanned = "planned";

    /// <summary>
    /// Literal for code: NutritionOrderStatusPlanned
    /// </summary>
    public const string LiteralNutritionOrderStatusPlanned = "http://hl7.org/fhir/nutrition-order-status#planned";

    /// <summary>
    /// Literal for code: Proposed
    /// </summary>
    public const string LiteralProposed = "proposed";

    /// <summary>
    /// Literal for code: NutritionOrderStatusProposed
    /// </summary>
    public const string LiteralNutritionOrderStatusProposed = "http://hl7.org/fhir/nutrition-order-status#proposed";

    /// <summary>
    /// Literal for code: Requested
    /// </summary>
    public const string LiteralRequested = "requested";

    /// <summary>
    /// Literal for code: NutritionOrderStatusRequested
    /// </summary>
    public const string LiteralNutritionOrderStatusRequested = "http://hl7.org/fhir/nutrition-order-status#requested";

    /// <summary>
    /// Dictionary for looking up NutritionOrderStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/nutrition-order-status#active", Active }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/nutrition-order-status#cancelled", Cancelled }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/nutrition-order-status#completed", Completed }, 
      { "draft", Draft }, 
      { "http://hl7.org/fhir/nutrition-order-status#draft", Draft }, 
      { "on-hold", OnHold }, 
      { "http://hl7.org/fhir/nutrition-order-status#on-hold", OnHold }, 
      { "planned", Planned }, 
      { "http://hl7.org/fhir/nutrition-order-status#planned", Planned }, 
      { "proposed", Proposed }, 
      { "http://hl7.org/fhir/nutrition-order-status#proposed", Proposed }, 
      { "requested", Requested }, 
      { "http://hl7.org/fhir/nutrition-order-status#requested", Requested }, 
    };
  };
}
