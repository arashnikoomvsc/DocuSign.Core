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
    /// Contains address input information.
    /// </summary>
    [DataContract]
    public partial class AddressInformationInput :  IEquatable<AddressInformationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressInformationInput" /> class.
        /// </summary>
        /// <param name="AddressInformation">A complex type that contains the following information for the new account (all string content): address1, address2, city, country, fax, phone, postalCode and state.  ###### Note: If country is US (United States) then State codes are validated for US States.  Otherwise, State is treated as a non-validated string and serves the purpose of entering a state/province/region. The maximum characters for the strings are:  * address1, address2, city, country and state: 100 characters * postalCode, phone, and fax: 20 characters .</param>
        /// <param name="DisplayLevelCode">Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay.</param>
        /// <param name="ReceiveInResponse">When set to **true**, the information needs to be returned in the response..</param>
        public AddressInformationInput(AddressInformation AddressInformation = null, string DisplayLevelCode = null, string ReceiveInResponse = null)
        {
            this.AddressInformation = AddressInformation;
            this.DisplayLevelCode = DisplayLevelCode;
            this.ReceiveInResponse = ReceiveInResponse;
        }
        
        /// <summary>
        /// A complex type that contains the following information for the new account (all string content): address1, address2, city, country, fax, phone, postalCode and state.  ###### Note: If country is US (United States) then State codes are validated for US States.  Otherwise, State is treated as a non-validated string and serves the purpose of entering a state/province/region. The maximum characters for the strings are:  * address1, address2, city, country and state: 100 characters * postalCode, phone, and fax: 20 characters 
        /// </summary>
        /// <value>A complex type that contains the following information for the new account (all string content): address1, address2, city, country, fax, phone, postalCode and state.  ###### Note: If country is US (United States) then State codes are validated for US States.  Otherwise, State is treated as a non-validated string and serves the purpose of entering a state/province/region. The maximum characters for the strings are:  * address1, address2, city, country and state: 100 characters * postalCode, phone, and fax: 20 characters </value>
        [DataMember(Name="addressInformation", EmitDefaultValue=false)]
        public AddressInformation AddressInformation { get; set; }
        /// <summary>
        /// Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay
        /// </summary>
        /// <value>Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay</value>
        [DataMember(Name="displayLevelCode", EmitDefaultValue=false)]
        public string DisplayLevelCode { get; set; }
        /// <summary>
        /// When set to **true**, the information needs to be returned in the response.
        /// </summary>
        /// <value>When set to **true**, the information needs to be returned in the response.</value>
        [DataMember(Name="receiveInResponse", EmitDefaultValue=false)]
        public string ReceiveInResponse { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressInformationInput {\n");
            sb.Append("  AddressInformation: ").Append(AddressInformation).Append("\n");
            sb.Append("  DisplayLevelCode: ").Append(DisplayLevelCode).Append("\n");
            sb.Append("  ReceiveInResponse: ").Append(ReceiveInResponse).Append("\n");
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
            return this.Equals(obj as AddressInformationInput);
        }

        /// <summary>
        /// Returns true if AddressInformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressInformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressInformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressInformation == other.AddressInformation ||
                    this.AddressInformation != null &&
                    this.AddressInformation.Equals(other.AddressInformation)
                ) && 
                (
                    this.DisplayLevelCode == other.DisplayLevelCode ||
                    this.DisplayLevelCode != null &&
                    this.DisplayLevelCode.Equals(other.DisplayLevelCode)
                ) && 
                (
                    this.ReceiveInResponse == other.ReceiveInResponse ||
                    this.ReceiveInResponse != null &&
                    this.ReceiveInResponse.Equals(other.ReceiveInResponse)
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
                if (this.AddressInformation != null)
                    hash = hash * 59 + this.AddressInformation.GetHashCode();
                if (this.DisplayLevelCode != null)
                    hash = hash * 59 + this.DisplayLevelCode.GetHashCode();
                if (this.ReceiveInResponse != null)
                    hash = hash * 59 + this.ReceiveInResponse.GetHashCode();
                return hash;
            }
        }
    }

}
