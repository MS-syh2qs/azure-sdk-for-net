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
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Vm object.
    /// </summary>
    public partial class VirtualMachine : ProtectionEntity
    {
        private string _replicationProviderSettings;
        
        /// <summary>
        /// Required. Virtual machine settings related to Replication provider
        /// </summary>
        public string ReplicationProviderSettings
        {
            get { return this._replicationProviderSettings; }
            set { this._replicationProviderSettings = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachine class.
        /// </summary>
        public VirtualMachine()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachine class with
        /// required arguments.
        /// </summary>
        public VirtualMachine(string replicationProviderSettings, ProtectionEntityProperties properties, string location)
            : this()
        {
            if (replicationProviderSettings == null)
            {
                throw new ArgumentNullException("replicationProviderSettings");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.ReplicationProviderSettings = replicationProviderSettings;
            this.Properties = properties;
            this.Location = location;
        }
    }
}
