/* 
 * Version 1
 *
 * This is version 1 document
 *
 * OpenAPI spec version: 0.0.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Elton.Phantom.Models.SwaggerDateConverter;

namespace Elton.Phantom.Models.Version1
{
    /// <summary>
    /// WeatherCurrent
    /// </summary>
    [DataContract]
    public partial class WeatherCurrent :  IEquatable<WeatherCurrent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherCurrent" /> class.
        /// </summary>
        /// <param name="Condition">天气状况.</param>
        /// <param name="Humidity">湿度.</param>
        /// <param name="Temperature">温度.</param>
        /// <param name="Pressure">气压.</param>
        /// <param name="Visibility">可见度.</param>
        /// <param name="Wind">风力.</param>
        /// <param name="SunRiseAt">日升时刻.</param>
        /// <param name="SunSetAt">日落时刻.</param>
        /// <param name="ObservedAt">该天气状态观察于.</param>
        /// <param name="StaleAt">该天气状态何时过期.</param>
        public WeatherCurrent(string Condition = default(string), float? Humidity = default(float?), float? Temperature = default(float?), float? Pressure = default(float?), float? Visibility = default(float?), int? Wind = default(int?), DateTime? SunRiseAt = default(DateTime?), DateTime? SunSetAt = default(DateTime?), DateTime? ObservedAt = default(DateTime?), DateTime? StaleAt = default(DateTime?))
        {
            this.Condition = Condition;
            this.Humidity = Humidity;
            this.Temperature = Temperature;
            this.Pressure = Pressure;
            this.Visibility = Visibility;
            this.Wind = Wind;
            this.SunRiseAt = SunRiseAt;
            this.SunSetAt = SunSetAt;
            this.ObservedAt = ObservedAt;
            this.StaleAt = StaleAt;
        }
        
        /// <summary>
        /// 天气状况
        /// </summary>
        /// <value>天气状况</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public string Condition { get; set; }

        /// <summary>
        /// 湿度
        /// </summary>
        /// <value>湿度</value>
        [DataMember(Name="humidity", EmitDefaultValue=false)]
        public float? Humidity { get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        /// <value>温度</value>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// 气压
        /// </summary>
        /// <value>气压</value>
        [DataMember(Name="pressure", EmitDefaultValue=false)]
        public float? Pressure { get; set; }

        /// <summary>
        /// 可见度
        /// </summary>
        /// <value>可见度</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public float? Visibility { get; set; }

        /// <summary>
        /// 风力
        /// </summary>
        /// <value>风力</value>
        [DataMember(Name="wind", EmitDefaultValue=false)]
        public int? Wind { get; set; }

        /// <summary>
        /// 日升时刻
        /// </summary>
        /// <value>日升时刻</value>
        [DataMember(Name="sun_rise_at", EmitDefaultValue=false)]
        public DateTime? SunRiseAt { get; set; }

        /// <summary>
        /// 日落时刻
        /// </summary>
        /// <value>日落时刻</value>
        [DataMember(Name="sun_set_at", EmitDefaultValue=false)]
        public DateTime? SunSetAt { get; set; }

        /// <summary>
        /// 该天气状态观察于
        /// </summary>
        /// <value>该天气状态观察于</value>
        [DataMember(Name="observed_at", EmitDefaultValue=false)]
        public DateTime? ObservedAt { get; set; }

        /// <summary>
        /// 该天气状态何时过期
        /// </summary>
        /// <value>该天气状态何时过期</value>
        [DataMember(Name="stale_at", EmitDefaultValue=false)]
        public DateTime? StaleAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherCurrent {\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Wind: ").Append(Wind).Append("\n");
            sb.Append("  SunRiseAt: ").Append(SunRiseAt).Append("\n");
            sb.Append("  SunSetAt: ").Append(SunSetAt).Append("\n");
            sb.Append("  ObservedAt: ").Append(ObservedAt).Append("\n");
            sb.Append("  StaleAt: ").Append(StaleAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WeatherCurrent);
        }

        /// <summary>
        /// Returns true if WeatherCurrent instances are equal
        /// </summary>
        /// <param name="input">Instance of WeatherCurrent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeatherCurrent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.Humidity == input.Humidity ||
                    (this.Humidity != null &&
                    this.Humidity.Equals(input.Humidity))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.Pressure == input.Pressure ||
                    (this.Pressure != null &&
                    this.Pressure.Equals(input.Pressure))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.Wind == input.Wind ||
                    (this.Wind != null &&
                    this.Wind.Equals(input.Wind))
                ) && 
                (
                    this.SunRiseAt == input.SunRiseAt ||
                    (this.SunRiseAt != null &&
                    this.SunRiseAt.Equals(input.SunRiseAt))
                ) && 
                (
                    this.SunSetAt == input.SunSetAt ||
                    (this.SunSetAt != null &&
                    this.SunSetAt.Equals(input.SunSetAt))
                ) && 
                (
                    this.ObservedAt == input.ObservedAt ||
                    (this.ObservedAt != null &&
                    this.ObservedAt.Equals(input.ObservedAt))
                ) && 
                (
                    this.StaleAt == input.StaleAt ||
                    (this.StaleAt != null &&
                    this.StaleAt.Equals(input.StaleAt))
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
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Humidity != null)
                    hashCode = hashCode * 59 + this.Humidity.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.Pressure != null)
                    hashCode = hashCode * 59 + this.Pressure.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Wind != null)
                    hashCode = hashCode * 59 + this.Wind.GetHashCode();
                if (this.SunRiseAt != null)
                    hashCode = hashCode * 59 + this.SunRiseAt.GetHashCode();
                if (this.SunSetAt != null)
                    hashCode = hashCode * 59 + this.SunSetAt.GetHashCode();
                if (this.ObservedAt != null)
                    hashCode = hashCode * 59 + this.ObservedAt.GetHashCode();
                if (this.StaleAt != null)
                    hashCode = hashCode * 59 + this.StaleAt.GetHashCode();
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
            yield break;
        }
    }

}