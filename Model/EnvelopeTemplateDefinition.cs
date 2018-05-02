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
    /// A complex element containing the following information:  templateId: Unique identifier of the template. If this is not provided, DocuSign will generate a value.   name: Name of the template. Maximum length: 100 characters.  shared: When set to **true**, the template is shared with the Everyone group in the account. If false, the template is only shared with the Administrator group.  password: Password, if the template is locked.  description: Description of the template. Maximum Length: 500 characters.  pageCount: Number of document pages in the template.  folderName: The name of the folder the template is located in.  folderId: The ID for the folder.  owner: The userName, email, userId, userType, and userStatus for the template owner.
    /// </summary>
    [DataContract]
    public partial class EnvelopeTemplateDefinition :  IEquatable<EnvelopeTemplateDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeTemplateDefinition" /> class.
        /// </summary>
        /// <param name="Description">A sender-defined description of the line item. .</param>
        /// <param name="FolderId">The ID for the folder..</param>
        /// <param name="FolderName"> The name of the folder in which the template is located..</param>
        /// <param name="FolderUri">The URI of the folder..</param>
        /// <param name="LastModified">Utc date and time the comment was last updated (can only be done by creator.).</param>
        /// <param name="LastModifiedBy">.</param>
        /// <param name="Name">.</param>
        /// <param name="NewPassword">The user&#39;s new password..</param>
        /// <param name="Owner">The userName, email, userId, userType, and userStatus for the template owner..</param>
        /// <param name="PageCount">An integer value specifying the number of document pages in the template. Omit this property if not submitting a page count..</param>
        /// <param name="ParentFolderUri">.</param>
        /// <param name="Password">.</param>
        /// <param name="Shared">When set to **true**, this custom tab is shared..</param>
        /// <param name="TemplateId">The unique identifier of the template. If this is not provided, DocuSign will generate a value. .</param>
        /// <param name="Uri">.</param>
        public EnvelopeTemplateDefinition(string Description = null, string FolderId = null, string FolderName = null, string FolderUri = null, string LastModified = null, UserInfo LastModifiedBy = null, string Name = null, string NewPassword = null, UserInfo Owner = null, int? PageCount = null, string ParentFolderUri = null, string Password = null, string Shared = null, string TemplateId = null, string Uri = null)
        {
            this.Description = Description;
            this.FolderId = FolderId;
            this.FolderName = FolderName;
            this.FolderUri = FolderUri;
            this.LastModified = LastModified;
            this.LastModifiedBy = LastModifiedBy;
            this.Name = Name;
            this.NewPassword = NewPassword;
            this.Owner = Owner;
            this.PageCount = PageCount;
            this.ParentFolderUri = ParentFolderUri;
            this.Password = Password;
            this.Shared = Shared;
            this.TemplateId = TemplateId;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// A sender-defined description of the line item. 
        /// </summary>
        /// <value>A sender-defined description of the line item. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The ID for the folder.
        /// </summary>
        /// <value>The ID for the folder.</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }
        /// <summary>
        ///  The name of the folder in which the template is located.
        /// </summary>
        /// <value> The name of the folder in which the template is located.</value>
        [DataMember(Name="folderName", EmitDefaultValue=false)]
        public string FolderName { get; set; }
        /// <summary>
        /// The URI of the folder.
        /// </summary>
        /// <value>The URI of the folder.</value>
        [DataMember(Name="folderUri", EmitDefaultValue=false)]
        public string FolderUri { get; set; }
        /// <summary>
        /// Utc date and time the comment was last updated (can only be done by creator.)
        /// </summary>
        /// <value>Utc date and time the comment was last updated (can only be done by creator.)</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public UserInfo LastModifiedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The user&#39;s new password.
        /// </summary>
        /// <value>The user&#39;s new password.</value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }
        /// <summary>
        /// The userName, email, userId, userType, and userStatus for the template owner.
        /// </summary>
        /// <value>The userName, email, userId, userType, and userStatus for the template owner.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserInfo Owner { get; set; }
        /// <summary>
        /// An integer value specifying the number of document pages in the template. Omit this property if not submitting a page count.
        /// </summary>
        /// <value>An integer value specifying the number of document pages in the template. Omit this property if not submitting a page count.</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="parentFolderUri", EmitDefaultValue=false)]
        public string ParentFolderUri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value. 
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value. </value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeTemplateDefinition {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
            sb.Append("  FolderUri: ").Append(FolderUri).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  ParentFolderUri: ").Append(ParentFolderUri).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as EnvelopeTemplateDefinition);
        }

        /// <summary>
        /// Returns true if EnvelopeTemplateDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeTemplateDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeTemplateDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.FolderName == other.FolderName ||
                    this.FolderName != null &&
                    this.FolderName.Equals(other.FolderName)
                ) && 
                (
                    this.FolderUri == other.FolderUri ||
                    this.FolderUri != null &&
                    this.FolderUri.Equals(other.FolderUri)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.LastModifiedBy == other.LastModifiedBy ||
                    this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(other.LastModifiedBy)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.ParentFolderUri == other.ParentFolderUri ||
                    this.ParentFolderUri != null &&
                    this.ParentFolderUri.Equals(other.ParentFolderUri)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.FolderName != null)
                    hash = hash * 59 + this.FolderName.GetHashCode();
                if (this.FolderUri != null)
                    hash = hash * 59 + this.FolderUri.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hash = hash * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.ParentFolderUri != null)
                    hash = hash * 59 + this.ParentFolderUri.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }
    }

}
