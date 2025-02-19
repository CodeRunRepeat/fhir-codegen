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
  /// The starting materials - monomer(s) used in the synthesis of the polymer.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymerMonomerSetStartingMaterial>))]
  public class SubstancePolymerMonomerSetStartingMaterial : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A percentage.
    /// </summary>
    public Quantity Amount { get; set; }
    /// <summary>
    /// Substance high level category, e.g. chemical substance.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// The type of substance for this starting material.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Used to specify whether the attribute described is a defining element for the unique identification of the polymer.
    /// </summary>
    public bool? IsDefining { get; set; }
    /// <summary>
    /// Extension container element for IsDefining
    /// </summary>
    public Element _IsDefining { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
      }

      if (IsDefining != null)
      {
        writer.WriteBoolean("isDefining", (bool)IsDefining!);
      }

      if (_IsDefining != null)
      {
        writer.WritePropertyName("_isDefining");
        _IsDefining.SerializeJson(writer, options);
      }

      if (Amount != null)
      {
        writer.WritePropertyName("amount");
        Amount.SerializeJson(writer, options);
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
        case "amount":
          Amount = new fhirCsR5.Models.Quantity();
          Amount.DeserializeJson(ref reader, options);
          break;

        case "category":
          Category = new fhirCsR5.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR5.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "isDefining":
          IsDefining = reader.GetBoolean();
          break;

        case "_isDefining":
          _IsDefining = new fhirCsR5.Models.Element();
          _IsDefining.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Todo.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymerMonomerSet>))]
  public class SubstancePolymerMonomerSet : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Captures the type of ratio to the entire polymer, e.g. Monomer/Polymer ratio, SRU/Polymer Ratio.
    /// </summary>
    public CodeableConcept RatioType { get; set; }
    /// <summary>
    /// The starting materials - monomer(s) used in the synthesis of the polymer.
    /// </summary>
    public List<SubstancePolymerMonomerSetStartingMaterial> StartingMaterial { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (RatioType != null)
      {
        writer.WritePropertyName("ratioType");
        RatioType.SerializeJson(writer, options);
      }

      if ((StartingMaterial != null) && (StartingMaterial.Count != 0))
      {
        writer.WritePropertyName("startingMaterial");
        writer.WriteStartArray();

        foreach (SubstancePolymerMonomerSetStartingMaterial valStartingMaterial in StartingMaterial)
        {
          valStartingMaterial.SerializeJson(writer, options, true);
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
        case "ratioType":
          RatioType = new fhirCsR5.Models.CodeableConcept();
          RatioType.DeserializeJson(ref reader, options);
          break;

        case "startingMaterial":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          StartingMaterial = new List<SubstancePolymerMonomerSetStartingMaterial>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstancePolymerMonomerSetStartingMaterial objStartingMaterial = new fhirCsR5.Models.SubstancePolymerMonomerSetStartingMaterial();
            objStartingMaterial.DeserializeJson(ref reader, options);
            StartingMaterial.Add(objStartingMaterial);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (StartingMaterial.Count == 0)
          {
            StartingMaterial = null;
          }

          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Applies to homopolymer and block co-polymers where the degree of polymerisation within a block can be described.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>))]
  public class SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// An average amount of polymerisation.
    /// </summary>
    public int? Average { get; set; }
    /// <summary>
    /// Extension container element for Average
    /// </summary>
    public Element _Average { get; set; }
    /// <summary>
    /// A high expected limit of the amount.
    /// </summary>
    public int? High { get; set; }
    /// <summary>
    /// Extension container element for High
    /// </summary>
    public Element _High { get; set; }
    /// <summary>
    /// A low expected limit of the amount.
    /// </summary>
    public int? Low { get; set; }
    /// <summary>
    /// Extension container element for Low
    /// </summary>
    public Element _Low { get; set; }
    /// <summary>
    /// The type of the degree of polymerisation shall be described, e.g. SRU/Polymer Ratio.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Average != null)
      {
        writer.WriteNumber("average", (int)Average!);
      }

      if (_Average != null)
      {
        writer.WritePropertyName("_average");
        _Average.SerializeJson(writer, options);
      }

      if (Low != null)
      {
        writer.WriteNumber("low", (int)Low!);
      }

      if (_Low != null)
      {
        writer.WritePropertyName("_low");
        _Low.SerializeJson(writer, options);
      }

      if (High != null)
      {
        writer.WriteNumber("high", (int)High!);
      }

      if (_High != null)
      {
        writer.WritePropertyName("_high");
        _High.SerializeJson(writer, options);
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
        case "average":
          Average = reader.GetInt32();
          break;

        case "_average":
          _Average = new fhirCsR5.Models.Element();
          _Average.DeserializeJson(ref reader, options);
          break;

        case "high":
          High = reader.GetInt32();
          break;

        case "_high":
          _High = new fhirCsR5.Models.Element();
          _High.DeserializeJson(ref reader, options);
          break;

        case "low":
          Low = reader.GetInt32();
          break;

        case "_low":
          _Low = new fhirCsR5.Models.Element();
          _Low.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A graphical structure for this SRU.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>))]
  public class SubstancePolymerRepeatRepeatUnitStructuralRepresentation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// An attached file with the structural representation.
    /// </summary>
    public Attachment Attachment { get; set; }
    /// <summary>
    /// The format of the representation e.g. InChI, SMILES, MOLFILE, CDX, SDF, PDB, mmCIF.
    /// </summary>
    public CodeableConcept Format { get; set; }
    /// <summary>
    /// The structural representation as text string in a standard format e.g. InChI, SMILES, MOLFILE, CDX, SDF, PDB, mmCIF.
    /// </summary>
    public string Representation { get; set; }
    /// <summary>
    /// Extension container element for Representation
    /// </summary>
    public Element _Representation { get; set; }
    /// <summary>
    /// The type of structure (e.g. Full, Partial, Representative).
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Representation))
      {
        writer.WriteString("representation", (string)Representation!);
      }

      if (_Representation != null)
      {
        writer.WritePropertyName("_representation");
        _Representation.SerializeJson(writer, options);
      }

      if (Format != null)
      {
        writer.WritePropertyName("format");
        Format.SerializeJson(writer, options);
      }

      if (Attachment != null)
      {
        writer.WritePropertyName("attachment");
        Attachment.SerializeJson(writer, options);
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
        case "attachment":
          Attachment = new fhirCsR5.Models.Attachment();
          Attachment.DeserializeJson(ref reader, options);
          break;

        case "format":
          Format = new fhirCsR5.Models.CodeableConcept();
          Format.DeserializeJson(ref reader, options);
          break;

        case "representation":
          Representation = reader.GetString();
          break;

        case "_representation":
          _Representation = new fhirCsR5.Models.Element();
          _Representation.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// An SRU - Structural Repeat Unit.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymerRepeatRepeatUnit>))]
  public class SubstancePolymerRepeatRepeatUnit : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Number of repeats of this unit.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// Extension container element for Amount
    /// </summary>
    public Element _Amount { get; set; }
    /// <summary>
    /// Applies to homopolymer and block co-polymers where the degree of polymerisation within a block can be described.
    /// </summary>
    public List<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation> DegreeOfPolymerisation { get; set; }
    /// <summary>
    /// The orientation of the polymerisation, e.g. head-tail, head-head, random.
    /// </summary>
    public CodeableConcept Orientation { get; set; }
    /// <summary>
    /// A graphical structure for this SRU.
    /// </summary>
    public List<SubstancePolymerRepeatRepeatUnitStructuralRepresentation> StructuralRepresentation { get; set; }
    /// <summary>
    /// Structural repeat units are essential elements for defining polymers.
    /// </summary>
    public string Unit { get; set; }
    /// <summary>
    /// Extension container element for Unit
    /// </summary>
    public Element _Unit { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Unit))
      {
        writer.WriteString("unit", (string)Unit!);
      }

      if (_Unit != null)
      {
        writer.WritePropertyName("_unit");
        _Unit.SerializeJson(writer, options);
      }

      if (Orientation != null)
      {
        writer.WritePropertyName("orientation");
        Orientation.SerializeJson(writer, options);
      }

      if (Amount != null)
      {
        writer.WriteNumber("amount", (int)Amount!);
      }

      if (_Amount != null)
      {
        writer.WritePropertyName("_amount");
        _Amount.SerializeJson(writer, options);
      }

      if ((DegreeOfPolymerisation != null) && (DegreeOfPolymerisation.Count != 0))
      {
        writer.WritePropertyName("degreeOfPolymerisation");
        writer.WriteStartArray();

        foreach (SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation valDegreeOfPolymerisation in DegreeOfPolymerisation)
        {
          valDegreeOfPolymerisation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((StructuralRepresentation != null) && (StructuralRepresentation.Count != 0))
      {
        writer.WritePropertyName("structuralRepresentation");
        writer.WriteStartArray();

        foreach (SubstancePolymerRepeatRepeatUnitStructuralRepresentation valStructuralRepresentation in StructuralRepresentation)
        {
          valStructuralRepresentation.SerializeJson(writer, options, true);
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
        case "amount":
          Amount = reader.GetInt32();
          break;

        case "_amount":
          _Amount = new fhirCsR5.Models.Element();
          _Amount.DeserializeJson(ref reader, options);
          break;

        case "degreeOfPolymerisation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DegreeOfPolymerisation = new List<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation objDegreeOfPolymerisation = new fhirCsR5.Models.SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation();
            objDegreeOfPolymerisation.DeserializeJson(ref reader, options);
            DegreeOfPolymerisation.Add(objDegreeOfPolymerisation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DegreeOfPolymerisation.Count == 0)
          {
            DegreeOfPolymerisation = null;
          }

          break;

        case "orientation":
          Orientation = new fhirCsR5.Models.CodeableConcept();
          Orientation.DeserializeJson(ref reader, options);
          break;

        case "structuralRepresentation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          StructuralRepresentation = new List<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstancePolymerRepeatRepeatUnitStructuralRepresentation objStructuralRepresentation = new fhirCsR5.Models.SubstancePolymerRepeatRepeatUnitStructuralRepresentation();
            objStructuralRepresentation.DeserializeJson(ref reader, options);
            StructuralRepresentation.Add(objStructuralRepresentation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (StructuralRepresentation.Count == 0)
          {
            StructuralRepresentation = null;
          }

          break;

        case "unit":
          Unit = reader.GetString();
          break;

        case "_unit":
          _Unit = new fhirCsR5.Models.Element();
          _Unit.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Specifies and quantifies the repeated units and their configuration.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymerRepeat>))]
  public class SubstancePolymerRepeat : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A representation of an (average) molecular formula from a polymer.
    /// </summary>
    public string AverageMolecularFormula { get; set; }
    /// <summary>
    /// Extension container element for AverageMolecularFormula
    /// </summary>
    public Element _AverageMolecularFormula { get; set; }
    /// <summary>
    /// An SRU - Structural Repeat Unit.
    /// </summary>
    public List<SubstancePolymerRepeatRepeatUnit> RepeatUnit { get; set; }
    /// <summary>
    /// How the quantitative amount of Structural Repeat Units is captured (e.g. Exact, Numeric, Average).
    /// </summary>
    public CodeableConcept RepeatUnitAmountType { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(AverageMolecularFormula))
      {
        writer.WriteString("averageMolecularFormula", (string)AverageMolecularFormula!);
      }

      if (_AverageMolecularFormula != null)
      {
        writer.WritePropertyName("_averageMolecularFormula");
        _AverageMolecularFormula.SerializeJson(writer, options);
      }

      if (RepeatUnitAmountType != null)
      {
        writer.WritePropertyName("repeatUnitAmountType");
        RepeatUnitAmountType.SerializeJson(writer, options);
      }

      if ((RepeatUnit != null) && (RepeatUnit.Count != 0))
      {
        writer.WritePropertyName("repeatUnit");
        writer.WriteStartArray();

        foreach (SubstancePolymerRepeatRepeatUnit valRepeatUnit in RepeatUnit)
        {
          valRepeatUnit.SerializeJson(writer, options, true);
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
        case "averageMolecularFormula":
          AverageMolecularFormula = reader.GetString();
          break;

        case "_averageMolecularFormula":
          _AverageMolecularFormula = new fhirCsR5.Models.Element();
          _AverageMolecularFormula.DeserializeJson(ref reader, options);
          break;

        case "repeatUnit":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RepeatUnit = new List<SubstancePolymerRepeatRepeatUnit>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstancePolymerRepeatRepeatUnit objRepeatUnit = new fhirCsR5.Models.SubstancePolymerRepeatRepeatUnit();
            objRepeatUnit.DeserializeJson(ref reader, options);
            RepeatUnit.Add(objRepeatUnit);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RepeatUnit.Count == 0)
          {
            RepeatUnit = null;
          }

          break;

        case "repeatUnitAmountType":
          RepeatUnitAmountType = new fhirCsR5.Models.CodeableConcept();
          RepeatUnitAmountType.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Properties of a substance specific to it being a polymer.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstancePolymer>))]
  public class SubstancePolymer : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "SubstancePolymer";
    /// <summary>
    /// Overall type of the polymer.
    /// </summary>
    public CodeableConcept Class { get; set; }
    /// <summary>
    /// Descrtibes the copolymer sequence type (polymer connectivity).
    /// </summary>
    public List<CodeableConcept> CopolymerConnectivity { get; set; }
    /// <summary>
    /// Polymer geometry, e.g. linear, branched, cross-linked, network or dendritic.
    /// </summary>
    public CodeableConcept Geometry { get; set; }
    /// <summary>
    /// A business idenfier for this polymer, but typically this is handled by a SubstanceDefinition identifier.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// Todo - this is intended to connect to a repeating full modification structure, also used by Protein and Nucleic Acid . String is just a placeholder.
    /// </summary>
    public string Modification { get; set; }
    /// <summary>
    /// Extension container element for Modification
    /// </summary>
    public Element _Modification { get; set; }
    /// <summary>
    /// Todo.
    /// </summary>
    public List<SubstancePolymerMonomerSet> MonomerSet { get; set; }
    /// <summary>
    /// Specifies and quantifies the repeated units and their configuration.
    /// </summary>
    public List<SubstancePolymerRepeat> Repeat { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (Class != null)
      {
        writer.WritePropertyName("class");
        Class.SerializeJson(writer, options);
      }

      if (Geometry != null)
      {
        writer.WritePropertyName("geometry");
        Geometry.SerializeJson(writer, options);
      }

      if ((CopolymerConnectivity != null) && (CopolymerConnectivity.Count != 0))
      {
        writer.WritePropertyName("copolymerConnectivity");
        writer.WriteStartArray();

        foreach (CodeableConcept valCopolymerConnectivity in CopolymerConnectivity)
        {
          valCopolymerConnectivity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Modification))
      {
        writer.WriteString("modification", (string)Modification!);
      }

      if (_Modification != null)
      {
        writer.WritePropertyName("_modification");
        _Modification.SerializeJson(writer, options);
      }

      if ((MonomerSet != null) && (MonomerSet.Count != 0))
      {
        writer.WritePropertyName("monomerSet");
        writer.WriteStartArray();

        foreach (SubstancePolymerMonomerSet valMonomerSet in MonomerSet)
        {
          valMonomerSet.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Repeat != null) && (Repeat.Count != 0))
      {
        writer.WritePropertyName("repeat");
        writer.WriteStartArray();

        foreach (SubstancePolymerRepeat valRepeat in Repeat)
        {
          valRepeat.SerializeJson(writer, options, true);
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
        case "class":
          Class = new fhirCsR5.Models.CodeableConcept();
          Class.DeserializeJson(ref reader, options);
          break;

        case "copolymerConnectivity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          CopolymerConnectivity = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objCopolymerConnectivity = new fhirCsR5.Models.CodeableConcept();
            objCopolymerConnectivity.DeserializeJson(ref reader, options);
            CopolymerConnectivity.Add(objCopolymerConnectivity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (CopolymerConnectivity.Count == 0)
          {
            CopolymerConnectivity = null;
          }

          break;

        case "geometry":
          Geometry = new fhirCsR5.Models.CodeableConcept();
          Geometry.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR5.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "modification":
          Modification = reader.GetString();
          break;

        case "_modification":
          _Modification = new fhirCsR5.Models.Element();
          _Modification.DeserializeJson(ref reader, options);
          break;

        case "monomerSet":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          MonomerSet = new List<SubstancePolymerMonomerSet>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstancePolymerMonomerSet objMonomerSet = new fhirCsR5.Models.SubstancePolymerMonomerSet();
            objMonomerSet.DeserializeJson(ref reader, options);
            MonomerSet.Add(objMonomerSet);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (MonomerSet.Count == 0)
          {
            MonomerSet = null;
          }

          break;

        case "repeat":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Repeat = new List<SubstancePolymerRepeat>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstancePolymerRepeat objRepeat = new fhirCsR5.Models.SubstancePolymerRepeat();
            objRepeat.DeserializeJson(ref reader, options);
            Repeat.Add(objRepeat);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Repeat.Count == 0)
          {
            Repeat = null;
          }

          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
