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
using Microsoft.Azure.Management.Insights.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// Represents the configuration for ETW providers by category.
    /// </summary>
    public partial class EtwProviders
    {
        private IList<EtwProvider> _eventSourceProviders;
        
        /// <summary>
        /// Optional. Configures collection of ETW events from EventSource
        /// providers.
        /// </summary>
        public IList<EtwProvider> EventSourceProviders
        {
            get { return this._eventSourceProviders; }
            set { this._eventSourceProviders = value; }
        }
        
        private IList<EtwProvider> _manifestProviders;
        
        /// <summary>
        /// Optional. Configures collection of ETW events from ETW Manifest
        /// providers.
        /// </summary>
        public IList<EtwProvider> ManifestProviders
        {
            get { return this._manifestProviders; }
            set { this._manifestProviders = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EtwProviders class.
        /// </summary>
        public EtwProviders()
        {
            this.EventSourceProviders = new LazyList<EtwProvider>();
            this.ManifestProviders = new LazyList<EtwProvider>();
        }
    }
}
