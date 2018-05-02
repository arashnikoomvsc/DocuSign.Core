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
    /// A complex element consisting of:   * lastSentDateTime - the date and time the user last sent an envelope.  * lastSignedDateTime - the date and time the user last signed an envelope. * sentCount - the number of envelopes the user has sent. * signedCount - the number of envelopes the user has signed.
    /// </summary>
    [DataContract]
    public partial class UsageHistory :  IEquatable<UsageHistory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageHistory" /> class.
        /// </summary>
        /// <param name="LastSentDateTime">The date and time the user last sent an envelope. .</param>
        /// <param name="LastSignedDateTime">The date and time the user last signed an envelope..</param>
        /// <param name="SentCount">The number of envelopes the user has sent. .</param>
        /// <param name="SignedCount">The number of envelopes the user has signed. .</param>
        public UsageHistory(string LastSentDateTime = null, string LastSignedDateTime = null, int? SentCount = null, int? SignedCount = null)
        {
            this.LastSentDateTime = LastSentDateTime;
            this.LastSignedDateTime = LastSignedDateTime;
            this.SentCount = SentCount;
            this.SignedCount = SignedCount;
        }
        
        /// <summary>
        /// The date and time the user last sent an envelope. 
        /// </summary>
        /// <value>The date and time the user last sent an envelope. </value>
        [DataMember(Name="lastSentDateTime", EmitDefaultValue=false)]
        public string LastSentDateTime { get; set; }
        /// <summary>
        /// The date and time the user last signed an envelope.
        /// </summary>
        /// <value>The date and time the user last signed an envelope.</value>
        [DataMember(Name="lastSignedDateTime", EmitDefaultValue=false)]
        public string LastSignedDateTime { get; set; }
        /// <summary>
        /// The number of envelopes the user has sent. 
        /// </summary>
        /// <value>The number of envelopes the user has sent. </value>
        [DataMember(Name="sentCount", EmitDefaultValue=false)]
        public int? SentCount { get; set; }
        /// <summary>
        /// The number of envelopes the user has signed. 
        /// </summary>
        /// <value>The number of envelopes the user has signed. </value>
        [DataMember(Name="signedCount", EmitDefaultValue=false)]
        public int? SignedCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageHistory {\n");
            sb.Append("  LastSentDateTime: ").Append(LastSentDateTime).Append("\n");
            sb.Append("  LastSignedDateTime: ").Append(LastSignedDateTime).Append("\n");
            sb.Append("  SentCount: ").Append(SentCount).Append("\n");
            sb.Append("  SignedCount: ").Append(SignedCount).Append("\n");
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
            return this.Equals(obj as UsageHistory);
        }

        /// <summary>
        /// Returns true if UsageHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of UsageHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageHistory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastSentDateTime == other.LastSentDateTime ||
                    this.LastSentDateTime != null &&
                    this.LastSentDateTime.Equals(other.LastSentDateTime)
                ) && 
                (
                    this.LastSignedDateTime == other.LastSignedDateTime ||
                    this.LastSignedDateTime != null &&
                    this.LastSignedDateTime.Equals(other.LastSignedDateTime)
                ) && 
                (
                    this.SentCount == other.SentCount ||
                    this.SentCount != null &&
                    this.SentCount.Equals(other.SentCount)
                ) && 
                (
                    this.SignedCount == other.SignedCount ||
                    this.SignedCount != null &&
                    this.SignedCount.Equals(other.SignedCount)
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
                if (this.LastSentDateTime != null)
                    hash = hash * 59 + this.LastSentDateTime.GetHashCode();
                if (this.LastSignedDateTime != null)
                    hash = hash * 59 + this.LastSignedDateTime.GetHashCode();
                if (this.SentCount != null)
                    hash = hash * 59 + this.SentCount.GetHashCode();
                if (this.SignedCount != null)
                    hash = hash * 59 + this.SignedCount.GetHashCode();
                return hash;
            }
        }
    }

}