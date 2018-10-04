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
    /// A tab that allows the recipient to select a yes/no (on/off) option. 
    /// </summary>
    [DataContract]
    public partial class Checkbox :  IEquatable<Checkbox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Checkbox" /> class.
        /// </summary>
        /// <param name="AnchorCaseSensitive">Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt;.</param>
        /// <param name="AnchorHorizontalAlignment">Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt; .</param>
        /// <param name="AnchorIgnoreIfNotPresent">When set to **true**, this tab is ignored if anchorString is not found in the document..</param>
        /// <param name="AnchorMatchWholeWord">Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt; .</param>
        /// <param name="AnchorString">Specifies the anchor string..</param>
        /// <param name="AnchorUnits">Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches..</param>
        /// <param name="AnchorXOffset">Specifies the X axis location of the tab, in achorUnits, relative to the anchorString..</param>
        /// <param name="AnchorYOffset">Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString..</param>
        /// <param name="ConditionalParentLabel">For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility..</param>
        /// <param name="ConditionalParentValue">For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active. .</param>
        /// <param name="CustomTabId">The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties..</param>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="ErrorDetails">.</param>
        /// <param name="Locked">When set to **true**, the signer cannot change the data of the custom tab..</param>
        /// <param name="MergeField">.</param>
        /// <param name="Name">Specifies the tool tip text for the tab..</param>
        /// <param name="PageNumber">Specifies the page number on which the tab is located. Must be 1 for [supplemental documents][supdocs].  [supdocs]: /esign/guide/appendix/glossary.html#supplemental-documents .</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="Required">This property does not apply to &#x60;checkbox&#x60; tabs. Check boxes are always optional..</param>
        /// <param name="RequireInitialOnSharedChange">Optional element for field markup. When set to **true**, the signer is required to initial when they modify a shared field..</param>
        /// <param name="Selected">When set to **true**, the checkbox is selected..</param>
        /// <param name="Shared">When set to **true**, this custom tab is shared..</param>
        /// <param name="Status">Tab status &lt;!- - todo - -&gt; .</param>
        /// <param name="TabId">The unique identifier for the tab..</param>
        /// <param name="TabLabel">The label string associated with the tab. The string may be the empty string. If no value is provided, the tab type is used as the value.  Maximum of 500 characters. .</param>
        /// <param name="TabOrder">A positive integer that sets the order the tab is navigated to during signing.  Tabs on a page are navigated to in ascending order, starting with the lowest number and moving to the highest. If two or more tabs have the same &#x60;tabOrder&#x60; value, the normal auto-navigation setting behavior for the envelope is used..</param>
        /// <param name="TemplateLocked">When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. .</param>
        /// <param name="TemplateRequired">When set to **true**, the sender may not remove the recipient. Used only when working with template recipients..</param>
        /// <param name="XPosition">This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. Required. May be zero. .</param>
        /// <param name="YPosition">This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position..</param>
        public Checkbox(string AnchorCaseSensitive = null, string AnchorHorizontalAlignment = null, string AnchorIgnoreIfNotPresent = null, string AnchorMatchWholeWord = null, string AnchorString = null, string AnchorUnits = null, string AnchorXOffset = null, string AnchorYOffset = null, string ConditionalParentLabel = null, string ConditionalParentValue = null, string CustomTabId = null, string DocumentId = null, ErrorDetails ErrorDetails = null, string Locked = null, MergeField MergeField = null, string Name = null, string PageNumber = null, string RecipientId = null, string Required = null, string RequireInitialOnSharedChange = null, string Selected = null, string Shared = null, string Status = null, string TabId = null, string TabLabel = null, string TabOrder = null, string TemplateLocked = null, string TemplateRequired = null, string XPosition = null, string YPosition = null)
        {
            this.AnchorCaseSensitive = AnchorCaseSensitive;
            this.AnchorHorizontalAlignment = AnchorHorizontalAlignment;
            this.AnchorIgnoreIfNotPresent = AnchorIgnoreIfNotPresent;
            this.AnchorMatchWholeWord = AnchorMatchWholeWord;
            this.AnchorString = AnchorString;
            this.AnchorUnits = AnchorUnits;
            this.AnchorXOffset = AnchorXOffset;
            this.AnchorYOffset = AnchorYOffset;
            this.ConditionalParentLabel = ConditionalParentLabel;
            this.ConditionalParentValue = ConditionalParentValue;
            this.CustomTabId = CustomTabId;
            this.DocumentId = DocumentId;
            this.ErrorDetails = ErrorDetails;
            this.Locked = Locked;
            this.MergeField = MergeField;
            this.Name = Name;
            this.PageNumber = PageNumber;
            this.RecipientId = RecipientId;
            this.Required = Required;
            this.RequireInitialOnSharedChange = RequireInitialOnSharedChange;
            this.Selected = Selected;
            this.Shared = Shared;
            this.Status = Status;
            this.TabId = TabId;
            this.TabLabel = TabLabel;
            this.TabOrder = TabOrder;
            this.TemplateLocked = TemplateLocked;
            this.TemplateRequired = TemplateRequired;
            this.XPosition = XPosition;
            this.YPosition = YPosition;
        }
        
        /// <summary>
        /// Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt;
        /// </summary>
        /// <value>Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt;</value>
        [DataMember(Name="anchorCaseSensitive", EmitDefaultValue=false)]
        public string AnchorCaseSensitive { get; set; }
        /// <summary>
        /// Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt; 
        /// </summary>
        /// <value>Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt; </value>
        [DataMember(Name="anchorHorizontalAlignment", EmitDefaultValue=false)]
        public string AnchorHorizontalAlignment { get; set; }
        /// <summary>
        /// When set to **true**, this tab is ignored if anchorString is not found in the document.
        /// </summary>
        /// <value>When set to **true**, this tab is ignored if anchorString is not found in the document.</value>
        [DataMember(Name="anchorIgnoreIfNotPresent", EmitDefaultValue=false)]
        public string AnchorIgnoreIfNotPresent { get; set; }
        /// <summary>
        /// Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt; 
        /// </summary>
        /// <value>Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt; </value>
        [DataMember(Name="anchorMatchWholeWord", EmitDefaultValue=false)]
        public string AnchorMatchWholeWord { get; set; }
        /// <summary>
        /// Specifies the anchor string.
        /// </summary>
        /// <value>Specifies the anchor string.</value>
        [DataMember(Name="anchorString", EmitDefaultValue=false)]
        public string AnchorString { get; set; }
        /// <summary>
        /// Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.
        /// </summary>
        /// <value>Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.</value>
        [DataMember(Name="anchorUnits", EmitDefaultValue=false)]
        public string AnchorUnits { get; set; }
        /// <summary>
        /// Specifies the X axis location of the tab, in achorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the X axis location of the tab, in achorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorXOffset", EmitDefaultValue=false)]
        public string AnchorXOffset { get; set; }
        /// <summary>
        /// Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorYOffset", EmitDefaultValue=false)]
        public string AnchorYOffset { get; set; }
        /// <summary>
        /// For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility.
        /// </summary>
        /// <value>For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility.</value>
        [DataMember(Name="conditionalParentLabel", EmitDefaultValue=false)]
        public string ConditionalParentLabel { get; set; }
        /// <summary>
        /// For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active. 
        /// </summary>
        /// <value>For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active. </value>
        [DataMember(Name="conditionalParentValue", EmitDefaultValue=false)]
        public string ConditionalParentValue { get; set; }
        /// <summary>
        /// The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.
        /// </summary>
        /// <value>The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.</value>
        [DataMember(Name="customTabId", EmitDefaultValue=false)]
        public string CustomTabId { get; set; }
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// When set to **true**, the signer cannot change the data of the custom tab.
        /// </summary>
        /// <value>When set to **true**, the signer cannot change the data of the custom tab.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="mergeField", EmitDefaultValue=false)]
        public MergeField MergeField { get; set; }
        /// <summary>
        /// Specifies the tool tip text for the tab.
        /// </summary>
        /// <value>Specifies the tool tip text for the tab.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Specifies the page number on which the tab is located. Must be 1 for [supplemental documents][supdocs].  [supdocs]: /esign/guide/appendix/glossary.html#supplemental-documents 
        /// </summary>
        /// <value>Specifies the page number on which the tab is located. Must be 1 for [supplemental documents][supdocs].  [supdocs]: /esign/guide/appendix/glossary.html#supplemental-documents </value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public string PageNumber { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// This property does not apply to &#x60;checkbox&#x60; tabs. Check boxes are always optional.
        /// </summary>
        /// <value>This property does not apply to &#x60;checkbox&#x60; tabs. Check boxes are always optional.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
        /// <summary>
        /// Optional element for field markup. When set to **true**, the signer is required to initial when they modify a shared field.
        /// </summary>
        /// <value>Optional element for field markup. When set to **true**, the signer is required to initial when they modify a shared field.</value>
        [DataMember(Name="requireInitialOnSharedChange", EmitDefaultValue=false)]
        public string RequireInitialOnSharedChange { get; set; }
        /// <summary>
        /// When set to **true**, the checkbox is selected.
        /// </summary>
        /// <value>When set to **true**, the checkbox is selected.</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public string Selected { get; set; }
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
        /// <summary>
        /// Tab status &lt;!- - todo - -&gt; 
        /// </summary>
        /// <value>Tab status &lt;!- - todo - -&gt; </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// The unique identifier for the tab.
        /// </summary>
        /// <value>The unique identifier for the tab.</value>
        [DataMember(Name="tabId", EmitDefaultValue=false)]
        public string TabId { get; set; }
        /// <summary>
        /// The label string associated with the tab. The string may be the empty string. If no value is provided, the tab type is used as the value.  Maximum of 500 characters. 
        /// </summary>
        /// <value>The label string associated with the tab. The string may be the empty string. If no value is provided, the tab type is used as the value.  Maximum of 500 characters. </value>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }
        /// <summary>
        /// A positive integer that sets the order the tab is navigated to during signing.  Tabs on a page are navigated to in ascending order, starting with the lowest number and moving to the highest. If two or more tabs have the same &#x60;tabOrder&#x60; value, the normal auto-navigation setting behavior for the envelope is used.
        /// </summary>
        /// <value>A positive integer that sets the order the tab is navigated to during signing.  Tabs on a page are navigated to in ascending order, starting with the lowest number and moving to the highest. If two or more tabs have the same &#x60;tabOrder&#x60; value, the normal auto-navigation setting behavior for the envelope is used.</value>
        [DataMember(Name="tabOrder", EmitDefaultValue=false)]
        public string TabOrder { get; set; }
        /// <summary>
        /// When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. 
        /// </summary>
        /// <value>When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. </value>
        [DataMember(Name="templateLocked", EmitDefaultValue=false)]
        public string TemplateLocked { get; set; }
        /// <summary>
        /// When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.
        /// </summary>
        /// <value>When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.</value>
        [DataMember(Name="templateRequired", EmitDefaultValue=false)]
        public string TemplateRequired { get; set; }
        /// <summary>
        /// This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. Required. May be zero. 
        /// </summary>
        /// <value>This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. Required. May be zero. </value>
        [DataMember(Name="xPosition", EmitDefaultValue=false)]
        public string XPosition { get; set; }
        /// <summary>
        /// This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.
        /// </summary>
        /// <value>This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.</value>
        [DataMember(Name="yPosition", EmitDefaultValue=false)]
        public string YPosition { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Checkbox {\n");
            sb.Append("  AnchorCaseSensitive: ").Append(AnchorCaseSensitive).Append("\n");
            sb.Append("  AnchorHorizontalAlignment: ").Append(AnchorHorizontalAlignment).Append("\n");
            sb.Append("  AnchorIgnoreIfNotPresent: ").Append(AnchorIgnoreIfNotPresent).Append("\n");
            sb.Append("  AnchorMatchWholeWord: ").Append(AnchorMatchWholeWord).Append("\n");
            sb.Append("  AnchorString: ").Append(AnchorString).Append("\n");
            sb.Append("  AnchorUnits: ").Append(AnchorUnits).Append("\n");
            sb.Append("  AnchorXOffset: ").Append(AnchorXOffset).Append("\n");
            sb.Append("  AnchorYOffset: ").Append(AnchorYOffset).Append("\n");
            sb.Append("  ConditionalParentLabel: ").Append(ConditionalParentLabel).Append("\n");
            sb.Append("  ConditionalParentValue: ").Append(ConditionalParentValue).Append("\n");
            sb.Append("  CustomTabId: ").Append(CustomTabId).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  MergeField: ").Append(MergeField).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  RequireInitialOnSharedChange: ").Append(RequireInitialOnSharedChange).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TabId: ").Append(TabId).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
            sb.Append("  TabOrder: ").Append(TabOrder).Append("\n");
            sb.Append("  TemplateLocked: ").Append(TemplateLocked).Append("\n");
            sb.Append("  TemplateRequired: ").Append(TemplateRequired).Append("\n");
            sb.Append("  XPosition: ").Append(XPosition).Append("\n");
            sb.Append("  YPosition: ").Append(YPosition).Append("\n");
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
            return this.Equals(obj as Checkbox);
        }

        /// <summary>
        /// Returns true if Checkbox instances are equal
        /// </summary>
        /// <param name="other">Instance of Checkbox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Checkbox other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnchorCaseSensitive == other.AnchorCaseSensitive ||
                    this.AnchorCaseSensitive != null &&
                    this.AnchorCaseSensitive.Equals(other.AnchorCaseSensitive)
                ) && 
                (
                    this.AnchorHorizontalAlignment == other.AnchorHorizontalAlignment ||
                    this.AnchorHorizontalAlignment != null &&
                    this.AnchorHorizontalAlignment.Equals(other.AnchorHorizontalAlignment)
                ) && 
                (
                    this.AnchorIgnoreIfNotPresent == other.AnchorIgnoreIfNotPresent ||
                    this.AnchorIgnoreIfNotPresent != null &&
                    this.AnchorIgnoreIfNotPresent.Equals(other.AnchorIgnoreIfNotPresent)
                ) && 
                (
                    this.AnchorMatchWholeWord == other.AnchorMatchWholeWord ||
                    this.AnchorMatchWholeWord != null &&
                    this.AnchorMatchWholeWord.Equals(other.AnchorMatchWholeWord)
                ) && 
                (
                    this.AnchorString == other.AnchorString ||
                    this.AnchorString != null &&
                    this.AnchorString.Equals(other.AnchorString)
                ) && 
                (
                    this.AnchorUnits == other.AnchorUnits ||
                    this.AnchorUnits != null &&
                    this.AnchorUnits.Equals(other.AnchorUnits)
                ) && 
                (
                    this.AnchorXOffset == other.AnchorXOffset ||
                    this.AnchorXOffset != null &&
                    this.AnchorXOffset.Equals(other.AnchorXOffset)
                ) && 
                (
                    this.AnchorYOffset == other.AnchorYOffset ||
                    this.AnchorYOffset != null &&
                    this.AnchorYOffset.Equals(other.AnchorYOffset)
                ) && 
                (
                    this.ConditionalParentLabel == other.ConditionalParentLabel ||
                    this.ConditionalParentLabel != null &&
                    this.ConditionalParentLabel.Equals(other.ConditionalParentLabel)
                ) && 
                (
                    this.ConditionalParentValue == other.ConditionalParentValue ||
                    this.ConditionalParentValue != null &&
                    this.ConditionalParentValue.Equals(other.ConditionalParentValue)
                ) && 
                (
                    this.CustomTabId == other.CustomTabId ||
                    this.CustomTabId != null &&
                    this.CustomTabId.Equals(other.CustomTabId)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.MergeField == other.MergeField ||
                    this.MergeField != null &&
                    this.MergeField.Equals(other.MergeField)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.RequireInitialOnSharedChange == other.RequireInitialOnSharedChange ||
                    this.RequireInitialOnSharedChange != null &&
                    this.RequireInitialOnSharedChange.Equals(other.RequireInitialOnSharedChange)
                ) && 
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TabId == other.TabId ||
                    this.TabId != null &&
                    this.TabId.Equals(other.TabId)
                ) && 
                (
                    this.TabLabel == other.TabLabel ||
                    this.TabLabel != null &&
                    this.TabLabel.Equals(other.TabLabel)
                ) && 
                (
                    this.TabOrder == other.TabOrder ||
                    this.TabOrder != null &&
                    this.TabOrder.Equals(other.TabOrder)
                ) && 
                (
                    this.TemplateLocked == other.TemplateLocked ||
                    this.TemplateLocked != null &&
                    this.TemplateLocked.Equals(other.TemplateLocked)
                ) && 
                (
                    this.TemplateRequired == other.TemplateRequired ||
                    this.TemplateRequired != null &&
                    this.TemplateRequired.Equals(other.TemplateRequired)
                ) && 
                (
                    this.XPosition == other.XPosition ||
                    this.XPosition != null &&
                    this.XPosition.Equals(other.XPosition)
                ) && 
                (
                    this.YPosition == other.YPosition ||
                    this.YPosition != null &&
                    this.YPosition.Equals(other.YPosition)
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
                if (this.AnchorCaseSensitive != null)
                    hash = hash * 59 + this.AnchorCaseSensitive.GetHashCode();
                if (this.AnchorHorizontalAlignment != null)
                    hash = hash * 59 + this.AnchorHorizontalAlignment.GetHashCode();
                if (this.AnchorIgnoreIfNotPresent != null)
                    hash = hash * 59 + this.AnchorIgnoreIfNotPresent.GetHashCode();
                if (this.AnchorMatchWholeWord != null)
                    hash = hash * 59 + this.AnchorMatchWholeWord.GetHashCode();
                if (this.AnchorString != null)
                    hash = hash * 59 + this.AnchorString.GetHashCode();
                if (this.AnchorUnits != null)
                    hash = hash * 59 + this.AnchorUnits.GetHashCode();
                if (this.AnchorXOffset != null)
                    hash = hash * 59 + this.AnchorXOffset.GetHashCode();
                if (this.AnchorYOffset != null)
                    hash = hash * 59 + this.AnchorYOffset.GetHashCode();
                if (this.ConditionalParentLabel != null)
                    hash = hash * 59 + this.ConditionalParentLabel.GetHashCode();
                if (this.ConditionalParentValue != null)
                    hash = hash * 59 + this.ConditionalParentValue.GetHashCode();
                if (this.CustomTabId != null)
                    hash = hash * 59 + this.CustomTabId.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                if (this.MergeField != null)
                    hash = hash * 59 + this.MergeField.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.RequireInitialOnSharedChange != null)
                    hash = hash * 59 + this.RequireInitialOnSharedChange.GetHashCode();
                if (this.Selected != null)
                    hash = hash * 59 + this.Selected.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TabId != null)
                    hash = hash * 59 + this.TabId.GetHashCode();
                if (this.TabLabel != null)
                    hash = hash * 59 + this.TabLabel.GetHashCode();
                if (this.TabOrder != null)
                    hash = hash * 59 + this.TabOrder.GetHashCode();
                if (this.TemplateLocked != null)
                    hash = hash * 59 + this.TemplateLocked.GetHashCode();
                if (this.TemplateRequired != null)
                    hash = hash * 59 + this.TemplateRequired.GetHashCode();
                if (this.XPosition != null)
                    hash = hash * 59 + this.XPosition.GetHashCode();
                if (this.YPosition != null)
                    hash = hash * 59 + this.YPosition.GetHashCode();
                return hash;
            }
        }
    }

}
