// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The criteria by which a question is enabled.
  /// </summary>
  public static class QuestionnaireEnableOperatorCodes
  {
    /// <summary>
    /// True if whether at least no answer has a value that is equal to the enableWhen answer.
    /// </summary>
    public static readonly Coding NotEquals = new Coding
    {
      Code = "!=",
      Display = "Not Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if whether at least no answer has a value that is less than the enableWhen answer.
    /// </summary>
    public static readonly Coding LessThan = new Coding
    {
      Code = "<",
      Display = "Less Than",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if whether at least no answer has a value that is less or equal to the enableWhen answer.
    /// </summary>
    public static readonly Coding LessOrEquals = new Coding
    {
      Code = "<=",
      Display = "Less or Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if whether at least one answer has a value that is equal to the enableWhen answer.
    /// </summary>
    public static readonly new Coding Equals = new Coding
    {
      Code = "=",
      Display = "Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if whether at least no answer has a value that is greater than the enableWhen answer.
    /// </summary>
    public static readonly Coding GreaterThan = new Coding
    {
      Code = ">",
      Display = "Greater Than",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if whether at least no answer has a value that is greater or equal to the enableWhen answer.
    /// </summary>
    public static readonly Coding GreaterOrEquals = new Coding
    {
      Code = ">=",
      Display = "Greater or Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if whether an answer exists is equal to the enableWhen answer (which must be a boolean).
    /// </summary>
    public static readonly Coding Exists = new Coding
    {
      Code = "exists",
      Display = "Exists",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };

    /// <summary>
    /// Literal for code: NotEquals
    /// </summary>
    public const string LiteralNotEquals = "!=";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorNotEquals
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorNotEquals = "http://hl7.org/fhir/questionnaire-enable-operator#!=";

    /// <summary>
    /// Literal for code: LessThan
    /// </summary>
    public const string LiteralLessThan = "<";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorLessThan
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorLessThan = "http://hl7.org/fhir/questionnaire-enable-operator#<";

    /// <summary>
    /// Literal for code: LessOrEquals
    /// </summary>
    public const string LiteralLessOrEquals = "<=";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorLessOrEquals
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorLessOrEquals = "http://hl7.org/fhir/questionnaire-enable-operator#<=";

    /// <summary>
    /// Literal for code: Equals
    /// </summary>
    public const string LiteralEquals = "=";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorEquals
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorEquals = "http://hl7.org/fhir/questionnaire-enable-operator#=";

    /// <summary>
    /// Literal for code: GreaterThan
    /// </summary>
    public const string LiteralGreaterThan = ">";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorGreaterThan
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorGreaterThan = "http://hl7.org/fhir/questionnaire-enable-operator#>";

    /// <summary>
    /// Literal for code: GreaterOrEquals
    /// </summary>
    public const string LiteralGreaterOrEquals = ">=";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorGreaterOrEquals
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorGreaterOrEquals = "http://hl7.org/fhir/questionnaire-enable-operator#>=";

    /// <summary>
    /// Literal for code: Exists
    /// </summary>
    public const string LiteralExists = "exists";

    /// <summary>
    /// Literal for code: QuestionnaireEnableOperatorExists
    /// </summary>
    public const string LiteralQuestionnaireEnableOperatorExists = "http://hl7.org/fhir/questionnaire-enable-operator#exists";

    /// <summary>
    /// Dictionary for looking up QuestionnaireEnableOperator Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "!=", NotEquals }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#!=", NotEquals }, 
      { "<", LessThan }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#<", LessThan }, 
      { "<=", LessOrEquals }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#<=", LessOrEquals }, 
      { "=", Equals }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#=", Equals }, 
      { ">", GreaterThan }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#>", GreaterThan }, 
      { ">=", GreaterOrEquals }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#>=", GreaterOrEquals }, 
      { "exists", Exists }, 
      { "http://hl7.org/fhir/questionnaire-enable-operator#exists", Exists }, 
    };
  };
}
