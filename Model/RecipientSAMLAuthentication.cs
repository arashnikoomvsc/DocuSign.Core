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
    /// Contains the name/value pair information for the SAML assertion attributes:  * name - The name of the SAML assertion attribute. * value - The value associated with the named SAML assertion attribute.   Your account must be set up to use SSO to use this.
    /// </summary>
    [DataContract]
    public partial class RecipientSAMLAuthentication :  IEquatable<RecipientSAMLAuthentication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientSAMLAuthentication" /> class.
        /// </summary>
        /// <param name="SamlAssertionAttributes">.</param>
        public RecipientSAMLAuthentication(List<SamlAssertionAttribute> SamlAssertionAttributes = null)
        {
            this.SamlAssertionAttributes = SamlAssertionAttributes;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="samlAssertionAttributes", EmitDefaultValue=false)]
        public List<SamlAssertionAttribute> SamlAssertionAttributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSAMLAuthentication {\n");
            sb.Append("  SamlAssertionAttributes: ").Append(SamlAssertionAttributes).Append("\n");
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
            return this.Equals(obj as RecipientSAMLAuthentication);
        }

        /// <summary>
        /// Returns true if RecipientSAMLAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSAMLAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSAMLAuthentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SamlAssertionAttributes == other.SamlAssertionAttributes ||
                    this.SamlAssertionAttributes != null &&
                    this.SamlAssertionAttributes.SequenceEqual(other.SamlAssertionAttributes)
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
                if (this.SamlAssertionAttributes != null)
                    hash = hash * 59 + this.SamlAssertionAttributes.GetHashCode();
                return hash;
            }
        }
    }

}
