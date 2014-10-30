// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management.Models
{
    /// <summary>
    /// The List Management Certificates operation response.
    /// </summary>
    public partial class ManagementCertificateListResponse : OperationResponse, IEnumerable<ManagementCertificateListResponse.SubscriptionCertificate>
    {
        private IList<ManagementCertificateListResponse.SubscriptionCertificate> _subscriptionCertificates;
        
        /// <summary>
        /// Optional. The management certificates that are valid for your
        /// subscription.
        /// </summary>
        public IList<ManagementCertificateListResponse.SubscriptionCertificate> SubscriptionCertificates
        {
            get { return this._subscriptionCertificates; }
            set { this._subscriptionCertificates = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ManagementCertificateListResponse
        /// class.
        /// </summary>
        public ManagementCertificateListResponse()
        {
            this.SubscriptionCertificates = new LazyList<ManagementCertificateListResponse.SubscriptionCertificate>();
        }
        
        /// <summary>
        /// Gets the sequence of SubscriptionCertificates.
        /// </summary>
        public IEnumerator<ManagementCertificateListResponse.SubscriptionCertificate> GetEnumerator()
        {
            return this.SubscriptionCertificates.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of SubscriptionCertificates.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// A management certificate that is valid for your subscription.
        /// </summary>
        public partial class SubscriptionCertificate
        {
            private DateTime _created;
            
            /// <summary>
            /// Optional. The time that the management certificate was created,
            /// in UTC.
            /// </summary>
            public DateTime Created
            {
                get { return this._created; }
                set { this._created = value; }
            }
            
            private byte[] _data;
            
            /// <summary>
            /// Optional. A base-64 representation of the data contained in the
            /// management certificate, in cer format.
            /// </summary>
            public byte[] Data
            {
                get { return this._data; }
                set { this._data = value; }
            }
            
            private byte[] _publicKey;
            
            /// <summary>
            /// Optional. A base-64 representation of the management
            /// certificate public key.
            /// </summary>
            public byte[] PublicKey
            {
                get { return this._publicKey; }
                set { this._publicKey = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. The X509 certificate thumbprint property of the
            /// management certificate. This thumbprint uniquely identifies
            /// the certificate.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the SubscriptionCertificate class.
            /// </summary>
            public SubscriptionCertificate()
            {
            }
        }
    }
}
