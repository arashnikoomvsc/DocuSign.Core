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
    public partial class MemberGroupSharedItem :  IEquatable<MemberGroupSharedItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberGroupSharedItem" /> class.
        /// </summary>
        /// <param name="ErrorDetails">.</param>
        /// <param name="Group">.</param>
        /// <param name="Shared">When set to **true**, this custom tab is shared..</param>
        public MemberGroupSharedItem(ErrorDetails ErrorDetails = null, Group Group = null, string Shared = null)
        {
            this.ErrorDetails = ErrorDetails;
            this.Group = Group;
            this.Shared = Shared;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberGroupSharedItem {\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
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
            return this.Equals(obj as MemberGroupSharedItem);
        }

        /// <summary>
        /// Returns true if MemberGroupSharedItem instances are equal
        /// </summary>
        /// <param name="other">Instance of MemberGroupSharedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberGroupSharedItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
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
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                return hash;
            }
        }
    }

}
