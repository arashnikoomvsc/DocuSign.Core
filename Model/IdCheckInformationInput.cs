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
    /// A complex element that contains input information related to a recipient ID check. It can include the following information.  addressInformationInput: Used to set recipient address information and consists of:  * addressInformation: consists of six elements, with stree2 and zipPlus4 being optional. The elements are: street1, street2, city, state, zip, zipPlus4. The maximum length of each element is: street1/street2 &#x3D; 150 characters, city &#x3D; 50 characters, state &#x3D; 2 characters, and zip/zipPlus4 &#x3D; 20 characters. * displayLevelCode: Specifies the display level for the recipient. Values are: ReadOnly, Editable, or DoNotDisplay. * receiveInResponse: A Boolean element that specifies if the information needs to be returned in the response.  dobInformationInput: Used to set recipient date of birth information and consists of:  * dateOfBirth: Specifies the recipient&#39;s date, month and year of birth. * displayLevelCode: Specifies the display level for the recipient. Values are: ReadOnly, Editable, or DoNotDisplay. * receiveInResponse: A Boolean element that specifies if the information needs to be returned in the response.  ssn4InformationInput: Used to set the last four digits of the recipient&#39;s SSN information and consists of:  * ssn4: Specifies the last four digits of the recipient&#39;s SSN. * displayLevelCode: Specifies the display level for the recipient. Values are: ReadOnly, Editable, or DoNotDisplay. * receiveInResponse: A Boolean element that specifies if the information needs to be returned in the response.  ssn9InformationInput: Used to set the recipient&#39;s SSN information. Note that the ssn9 information can never be returned in the response. The ssn9 input consists of:  * ssn9: Specifies the recipient&#39;s SSN. * displayLevelCode: Specifies the display level for the recipient. Values are: ReadOnly, Editable, or DoNotDisplay.
    /// </summary>
    [DataContract]
    public partial class IdCheckInformationInput :  IEquatable<IdCheckInformationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdCheckInformationInput" /> class.
        /// </summary>
        /// <param name="AddressInformationInput">.</param>
        /// <param name="DobInformationInput">Complex type containing:  * dateOfBirth * displayLevelCode * receiveInResponse.</param>
        /// <param name="Ssn4InformationInput">.</param>
        /// <param name="Ssn9InformationInput">.</param>
        public IdCheckInformationInput(AddressInformationInput AddressInformationInput = null, DobInformationInput DobInformationInput = null, Ssn4InformationInput Ssn4InformationInput = null, Ssn9InformationInput Ssn9InformationInput = null)
        {
            this.AddressInformationInput = AddressInformationInput;
            this.DobInformationInput = DobInformationInput;
            this.Ssn4InformationInput = Ssn4InformationInput;
            this.Ssn9InformationInput = Ssn9InformationInput;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="addressInformationInput", EmitDefaultValue=false)]
        public AddressInformationInput AddressInformationInput { get; set; }
        /// <summary>
        /// Complex type containing:  * dateOfBirth * displayLevelCode * receiveInResponse
        /// </summary>
        /// <value>Complex type containing:  * dateOfBirth * displayLevelCode * receiveInResponse</value>
        [DataMember(Name="dobInformationInput", EmitDefaultValue=false)]
        public DobInformationInput DobInformationInput { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ssn4InformationInput", EmitDefaultValue=false)]
        public Ssn4InformationInput Ssn4InformationInput { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ssn9InformationInput", EmitDefaultValue=false)]
        public Ssn9InformationInput Ssn9InformationInput { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdCheckInformationInput {\n");
            sb.Append("  AddressInformationInput: ").Append(AddressInformationInput).Append("\n");
            sb.Append("  DobInformationInput: ").Append(DobInformationInput).Append("\n");
            sb.Append("  Ssn4InformationInput: ").Append(Ssn4InformationInput).Append("\n");
            sb.Append("  Ssn9InformationInput: ").Append(Ssn9InformationInput).Append("\n");
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
            return this.Equals(obj as IdCheckInformationInput);
        }

        /// <summary>
        /// Returns true if IdCheckInformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of IdCheckInformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdCheckInformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressInformationInput == other.AddressInformationInput ||
                    this.AddressInformationInput != null &&
                    this.AddressInformationInput.Equals(other.AddressInformationInput)
                ) && 
                (
                    this.DobInformationInput == other.DobInformationInput ||
                    this.DobInformationInput != null &&
                    this.DobInformationInput.Equals(other.DobInformationInput)
                ) && 
                (
                    this.Ssn4InformationInput == other.Ssn4InformationInput ||
                    this.Ssn4InformationInput != null &&
                    this.Ssn4InformationInput.Equals(other.Ssn4InformationInput)
                ) && 
                (
                    this.Ssn9InformationInput == other.Ssn9InformationInput ||
                    this.Ssn9InformationInput != null &&
                    this.Ssn9InformationInput.Equals(other.Ssn9InformationInput)
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
                if (this.AddressInformationInput != null)
                    hash = hash * 59 + this.AddressInformationInput.GetHashCode();
                if (this.DobInformationInput != null)
                    hash = hash * 59 + this.DobInformationInput.GetHashCode();
                if (this.Ssn4InformationInput != null)
                    hash = hash * 59 + this.Ssn4InformationInput.GetHashCode();
                if (this.Ssn9InformationInput != null)
                    hash = hash * 59 + this.Ssn9InformationInput.GetHashCode();
                return hash;
            }
        }
    }

}
