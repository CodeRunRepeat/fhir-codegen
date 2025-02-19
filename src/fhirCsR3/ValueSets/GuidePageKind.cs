// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The kind of an included page.
  /// </summary>
  public static class GuidePageKindCodes
  {
    /// <summary>
    /// This is a page that creates the listed resources as a dictionary.
    /// </summary>
    public static readonly Coding Dictionary = new Coding
    {
      Code = "dictionary",
      Display = "Dictionary",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a page that lists the resources of a given type, and also creates pages for all the listed types as other pages in the section.
    /// </summary>
    public static readonly Coding Directory = new Coding
    {
      Code = "directory",
      Display = "Directory",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a page that represents a human readable rendering of an example.
    /// </summary>
    public static readonly Coding Example = new Coding
    {
      Code = "example",
      Display = "Example",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a page showing where an included guide is injected.
    /// </summary>
    public static readonly Coding Include = new Coding
    {
      Code = "include",
      Display = "Include",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a page that represents a list of resources of one or more types.
    /// </summary>
    public static readonly Coding List = new Coding
    {
      Code = "list",
      Display = "List",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a page of content that is included in the implementation guide. It has no particular function.
    /// </summary>
    public static readonly Coding Page = new Coding
    {
      Code = "page",
      Display = "Page",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a page that represents a presented resource. This is typically used for generated conformance resource presentations.
    /// </summary>
    public static readonly Coding Resource = new Coding
    {
      Code = "resource",
      Display = "Resource",
      System = "http://hl7.org/fhir/guide-page-kind"
    };
    /// <summary>
    /// This is a generated page that contains the table of contents.
    /// </summary>
    public static readonly Coding TableOfContents = new Coding
    {
      Code = "toc",
      Display = "Table Of Contents",
      System = "http://hl7.org/fhir/guide-page-kind"
    };

    /// <summary>
    /// Literal for code: Dictionary
    /// </summary>
    public const string LiteralDictionary = "dictionary";

    /// <summary>
    /// Literal for code: GuidePageKindDictionary
    /// </summary>
    public const string LiteralGuidePageKindDictionary = "http://hl7.org/fhir/guide-page-kind#dictionary";

    /// <summary>
    /// Literal for code: Directory
    /// </summary>
    public const string LiteralDirectory = "directory";

    /// <summary>
    /// Literal for code: GuidePageKindDirectory
    /// </summary>
    public const string LiteralGuidePageKindDirectory = "http://hl7.org/fhir/guide-page-kind#directory";

    /// <summary>
    /// Literal for code: Example
    /// </summary>
    public const string LiteralExample = "example";

    /// <summary>
    /// Literal for code: GuidePageKindExample
    /// </summary>
    public const string LiteralGuidePageKindExample = "http://hl7.org/fhir/guide-page-kind#example";

    /// <summary>
    /// Literal for code: Include
    /// </summary>
    public const string LiteralInclude = "include";

    /// <summary>
    /// Literal for code: GuidePageKindInclude
    /// </summary>
    public const string LiteralGuidePageKindInclude = "http://hl7.org/fhir/guide-page-kind#include";

    /// <summary>
    /// Literal for code: List
    /// </summary>
    public const string LiteralList = "list";

    /// <summary>
    /// Literal for code: GuidePageKindList
    /// </summary>
    public const string LiteralGuidePageKindList = "http://hl7.org/fhir/guide-page-kind#list";

    /// <summary>
    /// Literal for code: Page
    /// </summary>
    public const string LiteralPage = "page";

    /// <summary>
    /// Literal for code: GuidePageKindPage
    /// </summary>
    public const string LiteralGuidePageKindPage = "http://hl7.org/fhir/guide-page-kind#page";

    /// <summary>
    /// Literal for code: Resource
    /// </summary>
    public const string LiteralResource = "resource";

    /// <summary>
    /// Literal for code: GuidePageKindResource
    /// </summary>
    public const string LiteralGuidePageKindResource = "http://hl7.org/fhir/guide-page-kind#resource";

    /// <summary>
    /// Literal for code: TableOfContents
    /// </summary>
    public const string LiteralTableOfContents = "toc";

    /// <summary>
    /// Literal for code: GuidePageKindTableOfContents
    /// </summary>
    public const string LiteralGuidePageKindTableOfContents = "http://hl7.org/fhir/guide-page-kind#toc";

    /// <summary>
    /// Dictionary for looking up GuidePageKind Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "dictionary", Dictionary }, 
      { "http://hl7.org/fhir/guide-page-kind#dictionary", Dictionary }, 
      { "directory", Directory }, 
      { "http://hl7.org/fhir/guide-page-kind#directory", Directory }, 
      { "example", Example }, 
      { "http://hl7.org/fhir/guide-page-kind#example", Example }, 
      { "include", Include }, 
      { "http://hl7.org/fhir/guide-page-kind#include", Include }, 
      { "list", List }, 
      { "http://hl7.org/fhir/guide-page-kind#list", List }, 
      { "page", Page }, 
      { "http://hl7.org/fhir/guide-page-kind#page", Page }, 
      { "resource", Resource }, 
      { "http://hl7.org/fhir/guide-page-kind#resource", Resource }, 
      { "toc", TableOfContents }, 
      { "http://hl7.org/fhir/guide-page-kind#toc", TableOfContents }, 
    };
  };
}
