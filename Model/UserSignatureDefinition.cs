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
    public partial class UserSignatureDefinition :  IEquatable<UserSignatureDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSignatureDefinition" /> class.
        /// </summary>
        /// <param name="SignatureFont">.</param>
        /// <param name="SignatureId">Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID..</param>
        /// <param name="SignatureInitials">.</param>
        /// <param name="SignatureName">Specifies the user signature name..</param>
        public UserSignatureDefinition(string SignatureFont = null, string SignatureId = null, string SignatureInitials = null, string SignatureName = null)
        {
            this.SignatureFont = SignatureFont;
            this.SignatureId = SignatureId;
            this.SignatureInitials = SignatureInitials;
            this.SignatureName = SignatureName;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureFont", EmitDefaultValue=false)]
        public string SignatureFont { get; set; }
        /// <summary>
        /// Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID.
        /// </summary>
        /// <value>Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID.</value>
        [DataMember(Name="signatureId", EmitDefaultValue=false)]
        public string SignatureId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureInitials", EmitDefaultValue=false)]
        public string SignatureInitials { get; set; }
        /// <summary>
        /// Specifies the user signature name.
        /// </summary>
        /// <value>Specifies the user signature name.</value>
        [DataMember(Name="signatureName", EmitDefaultValue=false)]
        public string SignatureName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSignatureDefinition {\n");
            sb.Append("  SignatureFont: ").Append(SignatureFont).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  SignatureInitials: ").Append(SignatureInitials).Append("\n");
            sb.Append("  SignatureName: ").Append(SignatureName).Append("\n");
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
            return this.Equals(obj as UserSignatureDefinition);
        }

        /// <summary>
        /// Returns true if UserSignatureDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSignatureDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSignatureDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignatureFont == other.SignatureFont ||
                    this.SignatureFont != null &&
                    this.SignatureFont.Equals(other.SignatureFont)
                ) && 
                (
                    this.SignatureId == other.SignatureId ||
                    this.SignatureId != null &&
                    this.SignatureId.Equals(other.SignatureId)
                ) && 
                (
                    this.SignatureInitials == other.SignatureInitials ||
                    this.SignatureInitials != null &&
                    this.SignatureInitials.Equals(other.SignatureInitials)
                ) && 
                (
                    this.SignatureName == other.SignatureName ||
                    this.SignatureName != null &&
                    this.SignatureName.Equals(other.SignatureName)
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
                if (this.SignatureFont != null)
                    hash = hash * 59 + this.SignatureFont.GetHashCode();
                if (this.SignatureId != null)
                    hash = hash * 59 + this.SignatureId.GetHashCode();
                if (this.SignatureInitials != null)
                    hash = hash * 59 + this.SignatureInitials.GetHashCode();
                if (this.SignatureName != null)
                    hash = hash * 59 + this.SignatureName.GetHashCode();
                return hash;
            }
        }
    }

}
