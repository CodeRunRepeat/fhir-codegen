// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DataRequirementCodeFilter>))]
  public class DataRequirementCodeFilter : Element,  IFhirJsonSerializable {
    /// <summary>
    /// The codes for the code filter. If values are given, the filter will return only those data items for which the code-valued attribute specified by the path has a value that is one of the specified codes. If codes are specified in addition to a value set, the filter returns items matching a code in the value set or one of the specified codes.
    /// </summary>
    public List<Coding> Code { get; set; }
    /// <summary>
    /// The path attribute contains a [Simple FHIRPath Subset](fhirpath.html#simple) that allows path traversal, but not calculation.
    /// </summary>
    public string Path { get; set; }
    /// <summary>
    /// Extension container element for Path
    /// </summary>
    public Element _Path { get; set; }
    /// <summary>
    /// A token parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type code, Coding, or CodeableConcept.
    /// </summary>
    public string SearchParam { get; set; }
    /// <summary>
    /// Extension container element for SearchParam
    /// </summary>
    public Element _SearchParam { get; set; }
    /// <summary>
    /// The valueset for the code filter. The valueSet and code elements are additive. If valueSet is specified, the filter will return only those data items for which the value of the code-valued element specified in the path is a member of the specified valueset.
    /// </summary>
    public string ValueSet { get; set; }
    /// <summary>
    /// Extension container element for ValueSet
    /// </summary>
    public Element _ValueSet { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Path))
      {
        writer.WriteString("path", (string)Path!);
      }

      if (_Path != null)
      {
        writer.WritePropertyName("_path");
        _Path.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SearchParam))
      {
        writer.WriteString("searchParam", (string)SearchParam!);
      }

      if (_SearchParam != null)
      {
        writer.WritePropertyName("_searchParam");
        _SearchParam.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueSet))
      {
        writer.WriteString("valueSet", (string)ValueSet!);
      }

      if (_ValueSet != null)
      {
        writer.WritePropertyName("_valueSet");
        _ValueSet.SerializeJson(writer, options);
      }

      if ((Code != null) && (Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();

        foreach (Coding valCode in Code)
        {
          valCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Code = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Coding objCode = new fhirCsR5.Models.Coding();
            objCode.DeserializeJson(ref reader, options);
            Code.Add(objCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Code.Count == 0)
          {
            Code = null;
          }

          break;

        case "path":
          Path = reader.GetString();
          break;

        case "_path":
          _Path = new fhirCsR5.Models.Element();
          _Path.DeserializeJson(ref reader, options);
          break;

        case "searchParam":
          SearchParam = reader.GetString();
          break;

        case "_searchParam":
          _SearchParam = new fhirCsR5.Models.Element();
          _SearchParam.DeserializeJson(ref reader, options);
          break;

        case "valueSet":
          ValueSet = reader.GetString();
          break;

        case "_valueSet":
          _ValueSet = new fhirCsR5.Models.Element();
          _ValueSet.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DataRequirementDateFilter>))]
  public class DataRequirementDateFilter : Element,  IFhirJsonSerializable {
    /// <summary>
    /// The path attribute contains a [Simple FHIR Subset](fhirpath.html#simple) that allows path traversal, but not calculation.
    /// </summary>
    public string Path { get; set; }
    /// <summary>
    /// Extension container element for Path
    /// </summary>
    public Element _Path { get; set; }
    /// <summary>
    /// A date parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type date, dateTime, Period, Schedule, or Timing.
    /// </summary>
    public string SearchParam { get; set; }
    /// <summary>
    /// Extension container element for SearchParam
    /// </summary>
    public Element _SearchParam { get; set; }
    /// <summary>
    /// The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.
    /// </summary>
    public string ValueDateTime { get; set; }
    /// <summary>
    /// Extension container element for ValueDateTime
    /// </summary>
    public Element _ValueDateTime { get; set; }
    /// <summary>
    /// The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.
    /// </summary>
    public Period ValuePeriod { get; set; }
    /// <summary>
    /// The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.
    /// </summary>
    public Duration ValueDuration { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Path))
      {
        writer.WriteString("path", (string)Path!);
      }

      if (_Path != null)
      {
        writer.WritePropertyName("_path");
        _Path.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SearchParam))
      {
        writer.WriteString("searchParam", (string)SearchParam!);
      }

      if (_SearchParam != null)
      {
        writer.WritePropertyName("_searchParam");
        _SearchParam.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueDateTime))
      {
        writer.WriteString("valueDateTime", (string)ValueDateTime!);
      }

      if (_ValueDateTime != null)
      {
        writer.WritePropertyName("_valueDateTime");
        _ValueDateTime.SerializeJson(writer, options);
      }

      if (ValuePeriod != null)
      {
        writer.WritePropertyName("valuePeriod");
        ValuePeriod.SerializeJson(writer, options);
      }

      if (ValueDuration != null)
      {
        writer.WritePropertyName("valueDuration");
        ValueDuration.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          Path = reader.GetString();
          break;

        case "_path":
          _Path = new fhirCsR5.Models.Element();
          _Path.DeserializeJson(ref reader, options);
          break;

        case "searchParam":
          SearchParam = reader.GetString();
          break;

        case "_searchParam":
          _SearchParam = new fhirCsR5.Models.Element();
          _SearchParam.DeserializeJson(ref reader, options);
          break;

        case "valueDateTime":
          ValueDateTime = reader.GetString();
          break;

        case "_valueDateTime":
          _ValueDateTime = new fhirCsR5.Models.Element();
          _ValueDateTime.DeserializeJson(ref reader, options);
          break;

        case "valuePeriod":
          ValuePeriod = new fhirCsR5.Models.Period();
          ValuePeriod.DeserializeJson(ref reader, options);
          break;

        case "valueDuration":
          ValueDuration = new fhirCsR5.Models.Duration();
          ValueDuration.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// This element can be used in combination with the sort element to specify quota requirements such as "the most recent 5" or "the highest 5". When multiple sorts are specified, they are applied in the order they appear in the resource.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DataRequirementSort>))]
  public class DataRequirementSort : Element,  IFhirJsonSerializable {
    /// <summary>
    /// The direction of the sort, ascending or descending.
    /// </summary>
    public string Direction { get; set; }
    /// <summary>
    /// Extension container element for Direction
    /// </summary>
    public Element _Direction { get; set; }
    /// <summary>
    /// The attribute of the sort. The specified path must be resolvable from the type of the required data. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements. Note that the index must be an integer constant.
    /// </summary>
    public string Path { get; set; }
    /// <summary>
    /// Extension container element for Path
    /// </summary>
    public Element _Path { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Path))
      {
        writer.WriteString("path", (string)Path!);
      }

      if (_Path != null)
      {
        writer.WritePropertyName("_path");
        _Path.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Direction))
      {
        writer.WriteString("direction", (string)Direction!);
      }

      if (_Direction != null)
      {
        writer.WritePropertyName("_direction");
        _Direction.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "direction":
          Direction = reader.GetString();
          break;

        case "_direction":
          _Direction = new fhirCsR5.Models.Element();
          _Direction.DeserializeJson(ref reader, options);
          break;

        case "path":
          Path = reader.GetString();
          break;

        case "_path":
          _Path = new fhirCsR5.Models.Element();
          _Path.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the DataRequirement.sort.direction field
  /// </summary>
  public static class DataRequirementSortDirectionCodes {
    public const string ASCENDING = "ascending";
    public const string DESCENDING = "descending";
    public static HashSet<string> Values = new HashSet<string>() {
      "ascending",
      "descending",
    };
  }
  /// <summary>
  /// Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DataRequirement>))]
  public class DataRequirement : DataType,  IFhirJsonSerializable {
    /// <summary>
    /// Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.
    /// </summary>
    public List<DataRequirementCodeFilter> CodeFilter { get; set; }
    /// <summary>
    /// Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.
    /// </summary>
    public List<DataRequirementDateFilter> DateFilter { get; set; }
    /// <summary>
    /// This element can be used in combination with the sort element to specify quota requirements such as "the most recent 5" or "the highest 5".
    /// </summary>
    public uint? Limit { get; set; }
    /// <summary>
    /// Indicates that specific elements of the type are referenced by the knowledge module and must be supported by the consumer in order to obtain an effective evaluation. This does not mean that a value is required for this element, only that the consuming system must understand the element and be able to provide values for it if they are available. 
    /// The value of mustSupport SHALL be a FHIRPath resolveable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).
    /// </summary>
    public List<string> MustSupport { get; set; }
    /// <summary>
    /// Extension container element for MustSupport
    /// </summary>
    public List<Element> _MustSupport { get; set; }
    /// <summary>
    /// The profile of the required data, specified as the uri of the profile definition.
    /// </summary>
    public List<string> Profile { get; set; }
    /// <summary>
    /// Extension container element for Profile
    /// </summary>
    public List<Element> _Profile { get; set; }
    /// <summary>
    /// This element can be used in combination with the sort element to specify quota requirements such as "the most recent 5" or "the highest 5". When multiple sorts are specified, they are applied in the order they appear in the resource.
    /// </summary>
    public List<DataRequirementSort> Sort { get; set; }
    /// <summary>
    /// The subject of a data requirement is critical, as the data being specified is determined with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what data is available based on its relationship to the subject. In CQL, this corresponds to the context declaration.
    /// </summary>
    public CodeableConcept SubjectCodeableConcept { get; set; }
    /// <summary>
    /// The subject of a data requirement is critical, as the data being specified is determined with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what data is available based on its relationship to the subject. In CQL, this corresponds to the context declaration.
    /// </summary>
    public Reference SubjectReference { get; set; }
    /// <summary>
    /// The type of the required data, specified as the type name of a resource. For profiles, this value is set to the type of the base resource of the profile.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.DataType)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if ((Profile != null) && (Profile.Count != 0))
      {
        writer.WritePropertyName("profile");
        writer.WriteStartArray();

        foreach (string valProfile in Profile)
        {
          writer.WriteStringValue(valProfile);
        }

        writer.WriteEndArray();
      }

      if ((_Profile != null) && (_Profile.Count != 0))
      {
        writer.WritePropertyName("_profile");
        writer.WriteStartArray();

        foreach (Element val_Profile in _Profile)
        {
          val_Profile.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (SubjectCodeableConcept != null)
      {
        writer.WritePropertyName("subjectCodeableConcept");
        SubjectCodeableConcept.SerializeJson(writer, options);
      }

      if (SubjectReference != null)
      {
        writer.WritePropertyName("subjectReference");
        SubjectReference.SerializeJson(writer, options);
      }

      if ((MustSupport != null) && (MustSupport.Count != 0))
      {
        writer.WritePropertyName("mustSupport");
        writer.WriteStartArray();

        foreach (string valMustSupport in MustSupport)
        {
          writer.WriteStringValue(valMustSupport);
        }

        writer.WriteEndArray();
      }

      if ((_MustSupport != null) && (_MustSupport.Count != 0))
      {
        writer.WritePropertyName("_mustSupport");
        writer.WriteStartArray();

        foreach (Element val_MustSupport in _MustSupport)
        {
          val_MustSupport.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((CodeFilter != null) && (CodeFilter.Count != 0))
      {
        writer.WritePropertyName("codeFilter");
        writer.WriteStartArray();

        foreach (DataRequirementCodeFilter valCodeFilter in CodeFilter)
        {
          valCodeFilter.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((DateFilter != null) && (DateFilter.Count != 0))
      {
        writer.WritePropertyName("dateFilter");
        writer.WriteStartArray();

        foreach (DataRequirementDateFilter valDateFilter in DateFilter)
        {
          valDateFilter.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Limit != null)
      {
        writer.WriteNumber("limit", (uint)Limit!);
      }

      if ((Sort != null) && (Sort.Count != 0))
      {
        writer.WritePropertyName("sort");
        writer.WriteStartArray();

        foreach (DataRequirementSort valSort in Sort)
        {
          valSort.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "codeFilter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          CodeFilter = new List<DataRequirementCodeFilter>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.DataRequirementCodeFilter objCodeFilter = new fhirCsR5.Models.DataRequirementCodeFilter();
            objCodeFilter.DeserializeJson(ref reader, options);
            CodeFilter.Add(objCodeFilter);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (CodeFilter.Count == 0)
          {
            CodeFilter = null;
          }

          break;

        case "dateFilter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DateFilter = new List<DataRequirementDateFilter>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.DataRequirementDateFilter objDateFilter = new fhirCsR5.Models.DataRequirementDateFilter();
            objDateFilter.DeserializeJson(ref reader, options);
            DateFilter.Add(objDateFilter);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DateFilter.Count == 0)
          {
            DateFilter = null;
          }

          break;

        case "limit":
          Limit = reader.GetUInt32();
          break;

        case "mustSupport":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          MustSupport = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            MustSupport.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (MustSupport.Count == 0)
          {
            MustSupport = null;
          }

          break;

        case "_mustSupport":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _MustSupport = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_MustSupport = new fhirCsR5.Models.Element();
            obj_MustSupport.DeserializeJson(ref reader, options);
            _MustSupport.Add(obj_MustSupport);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_MustSupport.Count == 0)
          {
            _MustSupport = null;
          }

          break;

        case "profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Profile = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Profile.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Profile.Count == 0)
          {
            Profile = null;
          }

          break;

        case "_profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Profile = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_Profile = new fhirCsR5.Models.Element();
            obj_Profile.DeserializeJson(ref reader, options);
            _Profile.Add(obj_Profile);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Profile.Count == 0)
          {
            _Profile = null;
          }

          break;

        case "sort":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Sort = new List<DataRequirementSort>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.DataRequirementSort objSort = new fhirCsR5.Models.DataRequirementSort();
            objSort.DeserializeJson(ref reader, options);
            Sort.Add(objSort);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Sort.Count == 0)
          {
            Sort = null;
          }

          break;

        case "subjectCodeableConcept":
          SubjectCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          SubjectCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "subjectReference":
          SubjectReference = new fhirCsR5.Models.Reference();
          SubjectReference.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR5.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DataType)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
