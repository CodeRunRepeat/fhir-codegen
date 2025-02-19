// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// To describe the reason for the variant citation, such as version number or subpart specification.
  /// </summary>
  public static class CitedArtifactPartTypeCodes
  {
    /// <summary>
    /// Used to distinguish an individual article within an article set where the article set is a base citation.
    /// </summary>
    public static readonly Coding PartOfAnArticleSet = new Coding
    {
      Code = "article-set",
      Display = "Part of an article set",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific figure or figures of an article or artifact.
    /// </summary>
    public static readonly Coding Figures = new Coding
    {
      Code = "figures",
      Display = "figures",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific line or lines of an article or artifact.
    /// </summary>
    public static readonly Coding Lines = new Coding
    {
      Code = "lines",
      Display = "lines",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific page or pages of an article or artifact.
    /// </summary>
    public static readonly Coding Pages = new Coding
    {
      Code = "pages",
      Display = "pages",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific paragraph or paragraphs of an article or artifact.
    /// </summary>
    public static readonly Coding Paragraphs = new Coding
    {
      Code = "paragraphs",
      Display = "paragraphs",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific section or sections of an article or artifact.
    /// </summary>
    public static readonly Coding Sections = new Coding
    {
      Code = "sections",
      Display = "sections",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Used to denote a supplementary file, appendix, or additional part that is not a subpart of the primary article.
    /// </summary>
    public static readonly Coding SupplementOrAppendix = new Coding
    {
      Code = "supplement",
      Display = "Supplement or Appendix",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Used to denote a subpart within a supplementary file or appendix.
    /// </summary>
    public static readonly Coding SupplementOrAppendixSubpart = new Coding
    {
      Code = "supplement-subpart",
      Display = "Supplement or Appendix Subpart",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };
    /// <summary>
    /// Denotes specific table or tables of an article or artifact.
    /// </summary>
    public static readonly Coding Tables = new Coding
    {
      Code = "tables",
      Display = "tables",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type"
    };

    /// <summary>
    /// Literal for code: PartOfAnArticleSet
    /// </summary>
    public const string LiteralPartOfAnArticleSet = "article-set";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypePartOfAnArticleSet
    /// </summary>
    public const string LiteralCitedArtifactPartTypePartOfAnArticleSet = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#article-set";

    /// <summary>
    /// Literal for code: Figures
    /// </summary>
    public const string LiteralFigures = "figures";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeFigures
    /// </summary>
    public const string LiteralCitedArtifactPartTypeFigures = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#figures";

    /// <summary>
    /// Literal for code: Lines
    /// </summary>
    public const string LiteralLines = "lines";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeLines
    /// </summary>
    public const string LiteralCitedArtifactPartTypeLines = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#lines";

    /// <summary>
    /// Literal for code: Pages
    /// </summary>
    public const string LiteralPages = "pages";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypePages
    /// </summary>
    public const string LiteralCitedArtifactPartTypePages = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#pages";

    /// <summary>
    /// Literal for code: Paragraphs
    /// </summary>
    public const string LiteralParagraphs = "paragraphs";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeParagraphs
    /// </summary>
    public const string LiteralCitedArtifactPartTypeParagraphs = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#paragraphs";

    /// <summary>
    /// Literal for code: Sections
    /// </summary>
    public const string LiteralSections = "sections";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeSections
    /// </summary>
    public const string LiteralCitedArtifactPartTypeSections = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#sections";

    /// <summary>
    /// Literal for code: SupplementOrAppendix
    /// </summary>
    public const string LiteralSupplementOrAppendix = "supplement";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeSupplementOrAppendix
    /// </summary>
    public const string LiteralCitedArtifactPartTypeSupplementOrAppendix = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#supplement";

    /// <summary>
    /// Literal for code: SupplementOrAppendixSubpart
    /// </summary>
    public const string LiteralSupplementOrAppendixSubpart = "supplement-subpart";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeSupplementOrAppendixSubpart
    /// </summary>
    public const string LiteralCitedArtifactPartTypeSupplementOrAppendixSubpart = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#supplement-subpart";

    /// <summary>
    /// Literal for code: Tables
    /// </summary>
    public const string LiteralTables = "tables";

    /// <summary>
    /// Literal for code: CitedArtifactPartTypeTables
    /// </summary>
    public const string LiteralCitedArtifactPartTypeTables = "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#tables";

    /// <summary>
    /// Dictionary for looking up CitedArtifactPartType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "article-set", PartOfAnArticleSet }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#article-set", PartOfAnArticleSet }, 
      { "figures", Figures }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#figures", Figures }, 
      { "lines", Lines }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#lines", Lines }, 
      { "pages", Pages }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#pages", Pages }, 
      { "paragraphs", Paragraphs }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#paragraphs", Paragraphs }, 
      { "sections", Sections }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#sections", Sections }, 
      { "supplement", SupplementOrAppendix }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#supplement", SupplementOrAppendix }, 
      { "supplement-subpart", SupplementOrAppendixSubpart }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#supplement-subpart", SupplementOrAppendixSubpart }, 
      { "tables", Tables }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-part-type#tables", Tables }, 
    };
  };
}
