// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSPartnerManagedResourceProperties
    {

        /// <summary>
        /// Gets the partner managed resource id.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the partner managed ILB resource id
        /// </summary>
        public string InternalLoadBalancerId { get; private set; }

        /// <summary>
        /// Gets the partner managed SLB resource id
        /// </summary>
        public string StandardLoadBalancerId { get; private set; }
    }
}
