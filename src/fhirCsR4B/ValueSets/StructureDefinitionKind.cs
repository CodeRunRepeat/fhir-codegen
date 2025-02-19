// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Defines the type of structure that a definition is describing.
  /// </summary>
  public static class StructureDefinitionKindCodes
  {
    /// <summary>
    /// A  complex structure that defines a set of data elements that is suitable for use in 'resources'. The base specification defines a number of complex types, and other specifications can define additional types. These structures do not have a maintained identity.
    /// </summary>
    public static readonly Coding ComplexDataType = new Coding
    {
      Code = "complex-type",
      Display = "Complex Data Type",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
    /// <summary>
    /// A pattern or a template that is not intended to be a real resource or complex type.
    /// </summary>
    public static readonly Coding Logical = new Coding
    {
      Code = "logical",
      Display = "Logical",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
    /// <summary>
    /// A primitive type that has a value and an extension. These can be used throughout complex datatype, Resource and extension definitions. Only the base specification can define primitive types.
    /// </summary>
    public static readonly Coding PrimitiveDataType = new Coding
    {
      Code = "primitive-type",
      Display = "Primitive Data Type",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
    /// <summary>
    /// A 'resource' - a directed acyclic graph of elements that aggregrates other types into an identifiable entity. The base FHIR resources are defined by the FHIR specification itself but other 'resources' can be defined in additional specifications (though these will not be recognised as 'resources' by the FHIR specification (i.e. they do not get end-points etc, or act as the targets of references in FHIR defined resources - though other specificatiosn can treat them this way).
    /// </summary>
    public static readonly Coding Resource = new Coding
    {
      Code = "resource",
      Display = "Resource",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };

    /// <summary>
    /// Literal for code: ComplexDataType
    /// </summary>
    public const string LiteralComplexDataType = "complex-type";

    /// <summary>
    /// Literal for code: StructureDefinitionKindComplexDataType
    /// </summary>
    public const string LiteralStructureDefinitionKindComplexDataType = "http://hl7.org/fhir/structure-definition-kind#complex-type";

    /// <summary>
    /// Literal for code: Logical
    /// </summary>
    public const string LiteralLogical = "logical";

    /// <summary>
    /// Literal for code: StructureDefinitionKindLogical
    /// </summary>
    public const string LiteralStructureDefinitionKindLogical = "http://hl7.org/fhir/structure-definition-kind#logical";

    /// <summary>
    /// Literal for code: PrimitiveDataType
    /// </summary>
    public const string LiteralPrimitiveDataType = "primitive-type";

    /// <summary>
    /// Literal for code: StructureDefinitionKindPrimitiveDataType
    /// </summary>
    public const string LiteralStructureDefinitionKindPrimitiveDataType = "http://hl7.org/fhir/structure-definition-kind#primitive-type";

    /// <summary>
    /// Literal for code: Resource
    /// </summary>
    public const string LiteralResource = "resource";

    /// <summary>
    /// Literal for code: StructureDefinitionKindResource
    /// </summary>
    public const string LiteralStructureDefinitionKindResource = "http://hl7.org/fhir/structure-definition-kind#resource";

    /// <summary>
    /// Dictionary for looking up StructureDefinitionKind Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "complex-type", ComplexDataType }, 
      { "http://hl7.org/fhir/structure-definition-kind#complex-type", ComplexDataType }, 
      { "logical", Logical }, 
      { "http://hl7.org/fhir/structure-definition-kind#logical", Logical }, 
      { "primitive-type", PrimitiveDataType }, 
      { "http://hl7.org/fhir/structure-definition-kind#primitive-type", PrimitiveDataType }, 
      { "resource", Resource }, 
      { "http://hl7.org/fhir/structure-definition-kind#resource", Resource }, 
    };
  };
}
