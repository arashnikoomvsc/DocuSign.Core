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
    public partial class NotaryJournalMetaData :  IEquatable<NotaryJournalMetaData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotaryJournalMetaData" /> class.
        /// </summary>
        /// <param name="Comment">.</param>
        /// <param name="CredibleWitnesses">.</param>
        /// <param name="SignatureImage">.</param>
        /// <param name="SignerIdType">.</param>
        public NotaryJournalMetaData(string Comment = null, List<NotaryJournalCredibleWitness> CredibleWitnesses = null, string SignatureImage = null, string SignerIdType = null)
        {
            this.Comment = Comment;
            this.CredibleWitnesses = CredibleWitnesses;
            this.SignatureImage = SignatureImage;
            this.SignerIdType = SignerIdType;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="credibleWitnesses", EmitDefaultValue=false)]
        public List<NotaryJournalCredibleWitness> CredibleWitnesses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureImage", EmitDefaultValue=false)]
        public string SignatureImage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signerIdType", EmitDefaultValue=false)]
        public string SignerIdType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotaryJournalMetaData {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CredibleWitnesses: ").Append(CredibleWitnesses).Append("\n");
            sb.Append("  SignatureImage: ").Append(SignatureImage).Append("\n");
            sb.Append("  SignerIdType: ").Append(SignerIdType).Append("\n");
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
            return this.Equals(obj as NotaryJournalMetaData);
        }

        /// <summary>
        /// Returns true if NotaryJournalMetaData instances are equal
        /// </summary>
        /// <param name="other">Instance of NotaryJournalMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotaryJournalMetaData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.CredibleWitnesses == other.CredibleWitnesses ||
                    this.CredibleWitnesses != null &&
                    this.CredibleWitnesses.SequenceEqual(other.CredibleWitnesses)
                ) && 
                (
                    this.SignatureImage == other.SignatureImage ||
                    this.SignatureImage != null &&
                    this.SignatureImage.Equals(other.SignatureImage)
                ) && 
                (
                    this.SignerIdType == other.SignerIdType ||
                    this.SignerIdType != null &&
                    this.SignerIdType.Equals(other.SignerIdType)
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
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.CredibleWitnesses != null)
                    hash = hash * 59 + this.CredibleWitnesses.GetHashCode();
                if (this.SignatureImage != null)
                    hash = hash * 59 + this.SignatureImage.GetHashCode();
                if (this.SignerIdType != null)
                    hash = hash * 59 + this.SignerIdType.GetHashCode();
                return hash;
            }
        }
    }

}
