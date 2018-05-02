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
    public partial class TemplateMatch :  IEquatable<TemplateMatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateMatch" /> class.
        /// </summary>
        /// <param name="DocumentEndPage">.</param>
        /// <param name="DocumentStartPage">.</param>
        /// <param name="MatchPercentage">.</param>
        public TemplateMatch(string DocumentEndPage = null, string DocumentStartPage = null, string MatchPercentage = null)
        {
            this.DocumentEndPage = DocumentEndPage;
            this.DocumentStartPage = DocumentStartPage;
            this.MatchPercentage = MatchPercentage;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentEndPage", EmitDefaultValue=false)]
        public string DocumentEndPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentStartPage", EmitDefaultValue=false)]
        public string DocumentStartPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="matchPercentage", EmitDefaultValue=false)]
        public string MatchPercentage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateMatch {\n");
            sb.Append("  DocumentEndPage: ").Append(DocumentEndPage).Append("\n");
            sb.Append("  DocumentStartPage: ").Append(DocumentStartPage).Append("\n");
            sb.Append("  MatchPercentage: ").Append(MatchPercentage).Append("\n");
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
            return this.Equals(obj as TemplateMatch);
        }

        /// <summary>
        /// Returns true if TemplateMatch instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateMatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateMatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentEndPage == other.DocumentEndPage ||
                    this.DocumentEndPage != null &&
                    this.DocumentEndPage.Equals(other.DocumentEndPage)
                ) && 
                (
                    this.DocumentStartPage == other.DocumentStartPage ||
                    this.DocumentStartPage != null &&
                    this.DocumentStartPage.Equals(other.DocumentStartPage)
                ) && 
                (
                    this.MatchPercentage == other.MatchPercentage ||
                    this.MatchPercentage != null &&
                    this.MatchPercentage.Equals(other.MatchPercentage)
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
                if (this.DocumentEndPage != null)
                    hash = hash * 59 + this.DocumentEndPage.GetHashCode();
                if (this.DocumentStartPage != null)
                    hash = hash * 59 + this.DocumentStartPage.GetHashCode();
                if (this.MatchPercentage != null)
                    hash = hash * 59 + this.MatchPercentage.GetHashCode();
                return hash;
            }
        }
    }

}
