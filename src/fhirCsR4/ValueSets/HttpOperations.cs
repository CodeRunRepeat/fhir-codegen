// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The allowable request method or HTTP operation codes.
  /// </summary>
  public static class HttpOperationsCodes
  {
    /// <summary>
    /// HTTP DELETE operation.
    /// </summary>
    public static readonly Coding DELETE = new Coding
    {
      Code = "delete",
      Display = "DELETE",
      System = "http://hl7.org/fhir/http-operations"
    };
    /// <summary>
    /// HTTP GET operation.
    /// </summary>
    public static readonly Coding GET = new Coding
    {
      Code = "get",
      Display = "GET",
      System = "http://hl7.org/fhir/http-operations"
    };
    /// <summary>
    /// HTTP HEAD operation.
    /// </summary>
    public static readonly Coding HEAD = new Coding
    {
      Code = "head",
      Display = "HEAD",
      System = "http://hl7.org/fhir/http-operations"
    };
    /// <summary>
    /// HTTP OPTIONS operation.
    /// </summary>
    public static readonly Coding OPTIONS = new Coding
    {
      Code = "options",
      Display = "OPTIONS",
      System = "http://hl7.org/fhir/http-operations"
    };
    /// <summary>
    /// HTTP PATCH operation.
    /// </summary>
    public static readonly Coding PATCH = new Coding
    {
      Code = "patch",
      Display = "PATCH",
      System = "http://hl7.org/fhir/http-operations"
    };
    /// <summary>
    /// HTTP POST operation.
    /// </summary>
    public static readonly Coding POST = new Coding
    {
      Code = "post",
      Display = "POST",
      System = "http://hl7.org/fhir/http-operations"
    };
    /// <summary>
    /// HTTP PUT operation.
    /// </summary>
    public static readonly Coding PUT = new Coding
    {
      Code = "put",
      Display = "PUT",
      System = "http://hl7.org/fhir/http-operations"
    };

    /// <summary>
    /// Literal for code: DELETE
    /// </summary>
    public const string LiteralDELETE = "delete";

    /// <summary>
    /// Literal for code: HttpOperationsDELETE
    /// </summary>
    public const string LiteralHttpOperationsDELETE = "http://hl7.org/fhir/http-operations#delete";

    /// <summary>
    /// Literal for code: GET
    /// </summary>
    public const string LiteralGET = "get";

    /// <summary>
    /// Literal for code: HttpOperationsGET
    /// </summary>
    public const string LiteralHttpOperationsGET = "http://hl7.org/fhir/http-operations#get";

    /// <summary>
    /// Literal for code: HEAD
    /// </summary>
    public const string LiteralHEAD = "head";

    /// <summary>
    /// Literal for code: HttpOperationsHEAD
    /// </summary>
    public const string LiteralHttpOperationsHEAD = "http://hl7.org/fhir/http-operations#head";

    /// <summary>
    /// Literal for code: OPTIONS
    /// </summary>
    public const string LiteralOPTIONS = "options";

    /// <summary>
    /// Literal for code: HttpOperationsOPTIONS
    /// </summary>
    public const string LiteralHttpOperationsOPTIONS = "http://hl7.org/fhir/http-operations#options";

    /// <summary>
    /// Literal for code: PATCH
    /// </summary>
    public const string LiteralPATCH = "patch";

    /// <summary>
    /// Literal for code: HttpOperationsPATCH
    /// </summary>
    public const string LiteralHttpOperationsPATCH = "http://hl7.org/fhir/http-operations#patch";

    /// <summary>
    /// Literal for code: POST
    /// </summary>
    public const string LiteralPOST = "post";

    /// <summary>
    /// Literal for code: HttpOperationsPOST
    /// </summary>
    public const string LiteralHttpOperationsPOST = "http://hl7.org/fhir/http-operations#post";

    /// <summary>
    /// Literal for code: PUT
    /// </summary>
    public const string LiteralPUT = "put";

    /// <summary>
    /// Literal for code: HttpOperationsPUT
    /// </summary>
    public const string LiteralHttpOperationsPUT = "http://hl7.org/fhir/http-operations#put";

    /// <summary>
    /// Dictionary for looking up HttpOperations Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "delete", DELETE }, 
      { "http://hl7.org/fhir/http-operations#delete", DELETE }, 
      { "get", GET }, 
      { "http://hl7.org/fhir/http-operations#get", GET }, 
      { "head", HEAD }, 
      { "http://hl7.org/fhir/http-operations#head", HEAD }, 
      { "options", OPTIONS }, 
      { "http://hl7.org/fhir/http-operations#options", OPTIONS }, 
      { "patch", PATCH }, 
      { "http://hl7.org/fhir/http-operations#patch", PATCH }, 
      { "post", POST }, 
      { "http://hl7.org/fhir/http-operations#post", POST }, 
      { "put", PUT }, 
      { "http://hl7.org/fhir/http-operations#put", PUT }, 
    };
  };
}
