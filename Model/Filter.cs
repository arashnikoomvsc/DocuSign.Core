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
    public partial class Filter :  IEquatable<Filter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="ActionRequired">Action required..</param>
        /// <param name="Expires">.</param>
        /// <param name="FolderIds">.</param>
        /// <param name="FromDateTime">.</param>
        /// <param name="IsTemplate">.</param>
        /// <param name="Order">An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order .</param>
        /// <param name="OrderBy">.</param>
        /// <param name="SearchTarget">.</param>
        /// <param name="SearchText">.</param>
        /// <param name="Status">Filter status..</param>
        /// <param name="ToDateTime">Latest date to filter..</param>
        public Filter(string ActionRequired = null, string Expires = null, string FolderIds = null, string FromDateTime = null, string IsTemplate = null, string Order = null, string OrderBy = null, string SearchTarget = null, string SearchText = null, string Status = null, string ToDateTime = null)
        {
            this.ActionRequired = ActionRequired;
            this.Expires = Expires;
            this.FolderIds = FolderIds;
            this.FromDateTime = FromDateTime;
            this.IsTemplate = IsTemplate;
            this.Order = Order;
            this.OrderBy = OrderBy;
            this.SearchTarget = SearchTarget;
            this.SearchText = SearchText;
            this.Status = Status;
            this.ToDateTime = ToDateTime;
        }
        
        /// <summary>
        /// Action required.
        /// </summary>
        /// <value>Action required.</value>
        [DataMember(Name="actionRequired", EmitDefaultValue=false)]
        public string ActionRequired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public string Expires { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="folderIds", EmitDefaultValue=false)]
        public string FolderIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fromDateTime", EmitDefaultValue=false)]
        public string FromDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isTemplate", EmitDefaultValue=false)]
        public string IsTemplate { get; set; }
        /// <summary>
        /// An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order 
        /// </summary>
        /// <value>An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order </value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public string OrderBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="searchTarget", EmitDefaultValue=false)]
        public string SearchTarget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="searchText", EmitDefaultValue=false)]
        public string SearchText { get; set; }
        /// <summary>
        /// Filter status.
        /// </summary>
        /// <value>Filter status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Latest date to filter.
        /// </summary>
        /// <value>Latest date to filter.</value>
        [DataMember(Name="toDateTime", EmitDefaultValue=false)]
        public string ToDateTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  ActionRequired: ").Append(ActionRequired).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FromDateTime: ").Append(FromDateTime).Append("\n");
            sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  SearchTarget: ").Append(SearchTarget).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ToDateTime: ").Append(ToDateTime).Append("\n");
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
            return this.Equals(obj as Filter);
        }

        /// <summary>
        /// Returns true if Filter instances are equal
        /// </summary>
        /// <param name="other">Instance of Filter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActionRequired == other.ActionRequired ||
                    this.ActionRequired != null &&
                    this.ActionRequired.Equals(other.ActionRequired)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) && 
                (
                    this.FolderIds == other.FolderIds ||
                    this.FolderIds != null &&
                    this.FolderIds.Equals(other.FolderIds)
                ) && 
                (
                    this.FromDateTime == other.FromDateTime ||
                    this.FromDateTime != null &&
                    this.FromDateTime.Equals(other.FromDateTime)
                ) && 
                (
                    this.IsTemplate == other.IsTemplate ||
                    this.IsTemplate != null &&
                    this.IsTemplate.Equals(other.IsTemplate)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.OrderBy == other.OrderBy ||
                    this.OrderBy != null &&
                    this.OrderBy.Equals(other.OrderBy)
                ) && 
                (
                    this.SearchTarget == other.SearchTarget ||
                    this.SearchTarget != null &&
                    this.SearchTarget.Equals(other.SearchTarget)
                ) && 
                (
                    this.SearchText == other.SearchText ||
                    this.SearchText != null &&
                    this.SearchText.Equals(other.SearchText)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ToDateTime == other.ToDateTime ||
                    this.ToDateTime != null &&
                    this.ToDateTime.Equals(other.ToDateTime)
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
                if (this.ActionRequired != null)
                    hash = hash * 59 + this.ActionRequired.GetHashCode();
                if (this.Expires != null)
                    hash = hash * 59 + this.Expires.GetHashCode();
                if (this.FolderIds != null)
                    hash = hash * 59 + this.FolderIds.GetHashCode();
                if (this.FromDateTime != null)
                    hash = hash * 59 + this.FromDateTime.GetHashCode();
                if (this.IsTemplate != null)
                    hash = hash * 59 + this.IsTemplate.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.OrderBy != null)
                    hash = hash * 59 + this.OrderBy.GetHashCode();
                if (this.SearchTarget != null)
                    hash = hash * 59 + this.SearchTarget.GetHashCode();
                if (this.SearchText != null)
                    hash = hash * 59 + this.SearchText.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ToDateTime != null)
                    hash = hash * 59 + this.ToDateTime.GetHashCode();
                return hash;
            }
        }
    }

}
