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
    /// A line item describes details about an individual line item in a payment request.  
    /// </summary>
    [DataContract]
    public partial class PaymentLineItem :  IEquatable<PaymentLineItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLineItem" /> class.
        /// </summary>
        /// <param name="AmountReference">This is a the &#x60;tabLabel&#x60; that specifies the amount paid for the line items.  .</param>
        /// <param name="Description">A sender-defined description of the line item. .</param>
        /// <param name="ItemCode">This is the sender-defined SKU, inventory number, or other item code for the line item. .</param>
        /// <param name="Name">This is a sender-defined product name, service name, or other designation for the line item. .</param>
        public PaymentLineItem(string AmountReference = null, string Description = null, string ItemCode = null, string Name = null)
        {
            this.AmountReference = AmountReference;
            this.Description = Description;
            this.ItemCode = ItemCode;
            this.Name = Name;
        }
        
        /// <summary>
        /// This is a the &#x60;tabLabel&#x60; that specifies the amount paid for the line items.  
        /// </summary>
        /// <value>This is a the &#x60;tabLabel&#x60; that specifies the amount paid for the line items.  </value>
        [DataMember(Name="amountReference", EmitDefaultValue=false)]
        public string AmountReference { get; set; }
        /// <summary>
        /// A sender-defined description of the line item. 
        /// </summary>
        /// <value>A sender-defined description of the line item. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// This is the sender-defined SKU, inventory number, or other item code for the line item. 
        /// </summary>
        /// <value>This is the sender-defined SKU, inventory number, or other item code for the line item. </value>
        [DataMember(Name="itemCode", EmitDefaultValue=false)]
        public string ItemCode { get; set; }
        /// <summary>
        /// This is a sender-defined product name, service name, or other designation for the line item. 
        /// </summary>
        /// <value>This is a sender-defined product name, service name, or other designation for the line item. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLineItem {\n");
            sb.Append("  AmountReference: ").Append(AmountReference).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as PaymentLineItem);
        }

        /// <summary>
        /// Returns true if PaymentLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLineItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountReference == other.AmountReference ||
                    this.AmountReference != null &&
                    this.AmountReference.Equals(other.AmountReference)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ItemCode == other.ItemCode ||
                    this.ItemCode != null &&
                    this.ItemCode.Equals(other.ItemCode)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.AmountReference != null)
                    hash = hash * 59 + this.AmountReference.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.ItemCode != null)
                    hash = hash * 59 + this.ItemCode.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }
    }

}
