/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DocuSign.Core.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class TextCustomField :  IEquatable<TextCustomField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextCustomField" /> class.
        /// </summary>
        /// <param name="ConfigurationType">If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**..</param>
        /// <param name="ErrorDetails">.</param>
        /// <param name="FieldId">An ID used to specify a custom field..</param>
        /// <param name="Name">The name of the custom field..</param>
        /// <param name="Required">When set to **true**, the signer is required to fill out this tab.</param>
        /// <param name="Show">A boolean indicating if the value should be displayed.  If this value is set to **true**, the custom field is displayed at the top of the certificate of completion. If this value is left blank/ or set to **false**, then it does not appear in the certificate of completion. .</param>
        /// <param name="Value">The value of the custom field..</param>
        public TextCustomField(string ConfigurationType = null, ErrorDetails ErrorDetails = null, string FieldId = null, string Name = null, string Required = null, string Show = null, string Value = null)
        {
            this.ConfigurationType = ConfigurationType;
            this.ErrorDetails = ErrorDetails;
            this.FieldId = FieldId;
            this.Name = Name;
            this.Required = Required;
            this.Show = Show;
            this.Value = Value;
        }
        
        /// <summary>
        /// If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**.
        /// </summary>
        /// <value>If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**.</value>
        [DataMember(Name="configurationType", EmitDefaultValue=false)]
        public string ConfigurationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// An ID used to specify a custom field.
        /// </summary>
        /// <value>An ID used to specify a custom field.</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
        /// <summary>
        /// The name of the custom field.
        /// </summary>
        /// <value>The name of the custom field.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// When set to **true**, the signer is required to fill out this tab
        /// </summary>
        /// <value>When set to **true**, the signer is required to fill out this tab</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
        /// <summary>
        /// A boolean indicating if the value should be displayed.  If this value is set to **true**, the custom field is displayed at the top of the certificate of completion. If this value is left blank/ or set to **false**, then it does not appear in the certificate of completion. 
        /// </summary>
        /// <value>A boolean indicating if the value should be displayed.  If this value is set to **true**, the custom field is displayed at the top of the certificate of completion. If this value is left blank/ or set to **false**, then it does not appear in the certificate of completion. </value>
        [DataMember(Name="show", EmitDefaultValue=false)]
        public string Show { get; set; }
        /// <summary>
        /// The value of the custom field.
        /// </summary>
        /// <value>The value of the custom field.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextCustomField {\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Show: ").Append(Show).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TextCustomField);
        }

        /// <summary>
        /// Returns true if TextCustomField instances are equal
        /// </summary>
        /// <param name="other">Instance of TextCustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextCustomField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfigurationType == other.ConfigurationType ||
                    this.ConfigurationType != null &&
                    this.ConfigurationType.Equals(other.ConfigurationType)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Show == other.Show ||
                    this.Show != null &&
                    this.Show.Equals(other.Show)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ConfigurationType != null)
                    hash = hash * 59 + this.ConfigurationType.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Show != null)
                    hash = hash * 59 + this.Show.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
