/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.1
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// No mass opaque material representing a layer within an opaque construction.  Used when only the thermal resistance (R value) of the material is known.
    /// </summary>
    [DataContract]
    public partial class EnergyMaterialNoMass :  IEquatable<EnergyMaterialNoMass>, IValidatableObject
    {
        /// <summary>
        /// Defines Roughness
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoughnessEnum
        {
            /// <summary>
            /// Enum VeryRough for value: VeryRough
            /// </summary>
            [EnumMember(Value = "VeryRough")]
            VeryRough = 1,

            /// <summary>
            /// Enum Rough for value: Rough
            /// </summary>
            [EnumMember(Value = "Rough")]
            Rough = 2,

            /// <summary>
            /// Enum MediumRough for value: MediumRough
            /// </summary>
            [EnumMember(Value = "MediumRough")]
            MediumRough = 3,

            /// <summary>
            /// Enum MediumSmooth for value: MediumSmooth
            /// </summary>
            [EnumMember(Value = "MediumSmooth")]
            MediumSmooth = 4,

            /// <summary>
            /// Enum Smooth for value: Smooth
            /// </summary>
            [EnumMember(Value = "Smooth")]
            Smooth = 5,

            /// <summary>
            /// Enum VerySmooth for value: VerySmooth
            /// </summary>
            [EnumMember(Value = "VerySmooth")]
            VerySmooth = 6

        }

        /// <summary>
        /// Gets or Sets Roughness
        /// </summary>
        [DataMember(Name="roughness", EmitDefaultValue=false)]
        public RoughnessEnum? Roughness { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyMaterialNoMass" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyMaterialNoMass() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyMaterialNoMass" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="rValue">The thermal resistance (R-value) of the material layer [m2-K/W]. (required).</param>
        /// <param name="type">type (default to &quot;EnergyMaterialNoMass&quot;).</param>
        /// <param name="roughness">roughness (default to RoughnessEnum.MediumRough).</param>
        /// <param name="thermalAbsorptance">Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9. (default to 0.9).</param>
        /// <param name="solarAbsorptance">Fraction of incident solar radiation absorbed by the material. Default value is 0.7. (default to 0.7).</param>
        /// <param name="visibleAbsorptance">Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7. (default to 0.7).</param>
        public EnergyMaterialNoMass(string name, double rValue, string type = "EnergyMaterialNoMass", RoughnessEnum? roughness = RoughnessEnum.MediumRough, double thermalAbsorptance = 0.9, double solarAbsorptance = 0.7, double visibleAbsorptance = 0.7)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EnergyMaterialNoMass and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "rValue" is required (not null)
            if (rValue == null)
            {
                throw new InvalidDataException("rValue is a required property for EnergyMaterialNoMass and cannot be null");
            }
            else
            {
                this.RValue = rValue;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "EnergyMaterialNoMass";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "roughness" provided
            if (roughness == null)
            {
                this.Roughness = RoughnessEnum.MediumRough;
            }
            else
            {
                this.Roughness = roughness;
            }
            // use default value if no "thermalAbsorptance" provided
            if (thermalAbsorptance == null)
            {
                this.ThermalAbsorptance = 0.9;
            }
            else
            {
                this.ThermalAbsorptance = thermalAbsorptance;
            }
            // use default value if no "solarAbsorptance" provided
            if (solarAbsorptance == null)
            {
                this.SolarAbsorptance = 0.7;
            }
            else
            {
                this.SolarAbsorptance = solarAbsorptance;
            }
            // use default value if no "visibleAbsorptance" provided
            if (visibleAbsorptance == null)
            {
                this.VisibleAbsorptance = 0.7;
            }
            else
            {
                this.VisibleAbsorptance = visibleAbsorptance;
            }
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The thermal resistance (R-value) of the material layer [m2-K/W].
        /// </summary>
        /// <value>The thermal resistance (R-value) of the material layer [m2-K/W].</value>
        [DataMember(Name="r_value", EmitDefaultValue=false)]
        [JsonProperty("r_value")]
        public double RValue { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }


        /// <summary>
        /// Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.
        /// </summary>
        /// <value>Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.</value>
        [DataMember(Name="thermal_absorptance", EmitDefaultValue=false)]
        [JsonProperty("thermal_absorptance")]
        public double ThermalAbsorptance { get; set; }

        /// <summary>
        /// Fraction of incident solar radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident solar radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="solar_absorptance", EmitDefaultValue=false)]
        [JsonProperty("solar_absorptance")]
        public double SolarAbsorptance { get; set; }

        /// <summary>
        /// Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="visible_absorptance", EmitDefaultValue=false)]
        [JsonProperty("visible_absorptance")]
        public double VisibleAbsorptance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyMaterialNoMass {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RValue: ").Append(RValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Roughness: ").Append(Roughness).Append("\n");
            sb.Append("  ThermalAbsorptance: ").Append(ThermalAbsorptance).Append("\n");
            sb.Append("  SolarAbsorptance: ").Append(SolarAbsorptance).Append("\n");
            sb.Append("  VisibleAbsorptance: ").Append(VisibleAbsorptance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EnergyMaterialNoMass object</returns>
        public static EnergyMaterialNoMass FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyMaterialNoMass>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyMaterialNoMass);
        }

        /// <summary>
        /// Returns true if EnergyMaterialNoMass instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyMaterialNoMass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyMaterialNoMass input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RValue == input.RValue ||
                    (this.RValue != null &&
                    this.RValue.Equals(input.RValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Roughness == input.Roughness ||
                    (this.Roughness != null &&
                    this.Roughness.Equals(input.Roughness))
                ) && 
                (
                    this.ThermalAbsorptance == input.ThermalAbsorptance ||
                    (this.ThermalAbsorptance != null &&
                    this.ThermalAbsorptance.Equals(input.ThermalAbsorptance))
                ) && 
                (
                    this.SolarAbsorptance == input.SolarAbsorptance ||
                    (this.SolarAbsorptance != null &&
                    this.SolarAbsorptance.Equals(input.SolarAbsorptance))
                ) && 
                (
                    this.VisibleAbsorptance == input.VisibleAbsorptance ||
                    (this.VisibleAbsorptance != null &&
                    this.VisibleAbsorptance.Equals(input.VisibleAbsorptance))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RValue != null)
                    hashCode = hashCode * 59 + this.RValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Roughness != null)
                    hashCode = hashCode * 59 + this.Roughness.GetHashCode();
                if (this.ThermalAbsorptance != null)
                    hashCode = hashCode * 59 + this.ThermalAbsorptance.GetHashCode();
                if (this.SolarAbsorptance != null)
                    hashCode = hashCode * 59 + this.SolarAbsorptance.GetHashCode();
                if (this.VisibleAbsorptance != null)
                    hashCode = hashCode * 59 + this.VisibleAbsorptance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // RValue (double) minimum
            if(this.RValue < (double)0.001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RValue, must be a value greater than or equal to 0.001.", new [] { "RValue" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyMaterialNoMass$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ThermalAbsorptance (double) maximum
            if(this.ThermalAbsorptance > (double)0.99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThermalAbsorptance, must be a value less than or equal to 0.99999.", new [] { "ThermalAbsorptance" });
            }

            // SolarAbsorptance (double) maximum
            if(this.SolarAbsorptance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value less than or equal to 1.", new [] { "SolarAbsorptance" });
            }

            // SolarAbsorptance (double) minimum
            if(this.SolarAbsorptance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value greater than or equal to 0.", new [] { "SolarAbsorptance" });
            }

            // VisibleAbsorptance (double) maximum
            if(this.VisibleAbsorptance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value less than or equal to 1.", new [] { "VisibleAbsorptance" });
            }

            // VisibleAbsorptance (double) minimum
            if(this.VisibleAbsorptance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value greater than or equal to 0.", new [] { "VisibleAbsorptance" });
            }

            yield break;
        }
    }

}
