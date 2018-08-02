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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class SqlManagementClientExtensions
    {
        /// <summary>
        /// Gets the status of an Azure Sql Database Failover Group Force
        /// Failover operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.ISqlManagementClient.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database Failover Group
        /// operation.
        /// </returns>
        public static FailoverGroupForceFailoverResponse GetFailoverGroupForceFailoverAllowDataLossOperationStatus(this ISqlManagementClient operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISqlManagementClient)s).GetFailoverGroupForceFailoverAllowDataLossOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Database Failover Group Force
        /// Failover operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.ISqlManagementClient.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database Failover Group
        /// operation.
        /// </returns>
        public static Task<FailoverGroupForceFailoverResponse> GetFailoverGroupForceFailoverAllowDataLossOperationStatusAsync(this ISqlManagementClient operations, string operationStatusLink)
        {
            return operations.GetFailoverGroupForceFailoverAllowDataLossOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
    }
}