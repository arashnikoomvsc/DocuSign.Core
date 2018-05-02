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
    /// Defines an billing payment response object.
    /// </summary>
    [DataContract]
    public partial class BillingPaymentResponse :  IEquatable<BillingPaymentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPaymentResponse" /> class.
        /// </summary>
        /// <param name="BillingPayments">Reserved: TBD.</param>
        public BillingPaymentResponse(List<BillingPayment> BillingPayments = null)
        {
            this.BillingPayments = BillingPayments;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPayments", EmitDefaultValue=false)]
        public List<BillingPayment> BillingPayments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPaymentResponse {\n");
            sb.Append("  BillingPayments: ").Append(BillingPayments).Append("\n");
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
            return this.Equals(obj as BillingPaymentResponse);
        }

        /// <summary>
        /// Returns true if BillingPaymentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPaymentResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingPayments == other.BillingPayments ||
                    this.BillingPayments != null &&
                    this.BillingPayments.SequenceEqual(other.BillingPayments)
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
                if (this.BillingPayments != null)
                    hash = hash * 59 + this.BillingPayments.GetHashCode();
                return hash;
            }
        }
    }

}
