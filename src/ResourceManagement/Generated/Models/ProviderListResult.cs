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
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// List of resource providers.
    /// </summary>
    public partial class ProviderListResult : OperationResponse
    {
        private string _nextLink;
        
        /// <summary>
        /// Optional. Gets or sets the URL to get the next set of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<Provider> _providers;
        
        /// <summary>
        /// Optional. Gets or sets the list of resource providers.
        /// </summary>
        public IList<Provider> Providers
        {
            get { return this._providers; }
            set { this._providers = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProviderListResult class.
        /// </summary>
        public ProviderListResult()
        {
            this.Providers = new LazyList<Provider>();
        }
    }
}
