// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// The manufactured item as contained in the packaged medicinal product.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<MedicinalProductManufactured>))]
  public class MedicinalProductManufactured : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "MedicinalProductManufactured";
    /// <summary>
    /// Ingredient.
    /// </summary>
    public List<Reference> Ingredient { get; set; }
    /// <summary>
    /// Dose form as manufactured and before any transformation into the pharmaceutical product.
    /// </summary>
    public CodeableConcept ManufacturedDoseForm { get; set; }
    /// <summary>
    /// Manufacturer of the item (Note that this should be named "manufacturer" but it currently causes technical issues).
    /// </summary>
    public List<Reference> Manufacturer { get; set; }
    /// <summary>
    /// Other codeable characteristics.
    /// </summary>
    public List<CodeableConcept> OtherCharacteristics { get; set; }
    /// <summary>
    /// Dimensions, color etc.
    /// </summary>
    public ProdCharacteristic PhysicalCharacteristics { get; set; }
    /// <summary>
    /// The quantity or "count number" of the manufactured item.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// The “real world” units in which the quantity of the manufactured item is described.
    /// </summary>
    public CodeableConcept UnitOfPresentation { get; set; }
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


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (ManufacturedDoseForm != null)
      {
        writer.WritePropertyName("manufacturedDoseForm");
        ManufacturedDoseForm.SerializeJson(writer, options);
      }

      if (UnitOfPresentation != null)
      {
        writer.WritePropertyName("unitOfPresentation");
        UnitOfPresentation.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if ((Manufacturer != null) && (Manufacturer.Count != 0))
      {
        writer.WritePropertyName("manufacturer");
        writer.WriteStartArray();

        foreach (Reference valManufacturer in Manufacturer)
        {
          valManufacturer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Ingredient != null) && (Ingredient.Count != 0))
      {
        writer.WritePropertyName("ingredient");
        writer.WriteStartArray();

        foreach (Reference valIngredient in Ingredient)
        {
          valIngredient.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (PhysicalCharacteristics != null)
      {
        writer.WritePropertyName("physicalCharacteristics");
        PhysicalCharacteristics.SerializeJson(writer, options);
      }

      if ((OtherCharacteristics != null) && (OtherCharacteristics.Count != 0))
      {
        writer.WritePropertyName("otherCharacteristics");
        writer.WriteStartArray();

        foreach (CodeableConcept valOtherCharacteristics in OtherCharacteristics)
        {
          valOtherCharacteristics.SerializeJson(writer, options, true);
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
        case "ingredient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Ingredient = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objIngredient = new fhirCsR4.Models.Reference();
            objIngredient.DeserializeJson(ref reader, options);
            Ingredient.Add(objIngredient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Ingredient.Count == 0)
          {
            Ingredient = null;
          }

          break;

        case "manufacturedDoseForm":
          ManufacturedDoseForm = new fhirCsR4.Models.CodeableConcept();
          ManufacturedDoseForm.DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manufacturer = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objManufacturer = new fhirCsR4.Models.Reference();
            objManufacturer.DeserializeJson(ref reader, options);
            Manufacturer.Add(objManufacturer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manufacturer.Count == 0)
          {
            Manufacturer = null;
          }

          break;

        case "otherCharacteristics":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          OtherCharacteristics = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objOtherCharacteristics = new fhirCsR4.Models.CodeableConcept();
            objOtherCharacteristics.DeserializeJson(ref reader, options);
            OtherCharacteristics.Add(objOtherCharacteristics);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (OtherCharacteristics.Count == 0)
          {
            OtherCharacteristics = null;
          }

          break;

        case "physicalCharacteristics":
          PhysicalCharacteristics = new fhirCsR4.Models.ProdCharacteristic();
          PhysicalCharacteristics.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR4.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "unitOfPresentation":
          UnitOfPresentation = new fhirCsR4.Models.CodeableConcept();
          UnitOfPresentation.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
