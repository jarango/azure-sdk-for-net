// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AssignmentOperations.
    /// </summary>
    public static partial class AssignmentOperationsExtensions
    {
            /// <summary>
            /// List operations for given blueprint assignment within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}'). For blueprint
            /// assignments management group scope is reserved for future use.
            /// </param>
            /// <param name='assignmentName'>
            /// Name of the blueprint assignment.
            /// </param>
            public static IPage<AssignmentOperation> List(this IAssignmentOperations operations, string scope, string assignmentName)
            {
                return operations.ListAsync(scope, assignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List operations for given blueprint assignment within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}'). For blueprint
            /// assignments management group scope is reserved for future use.
            /// </param>
            /// <param name='assignmentName'>
            /// Name of the blueprint assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AssignmentOperation>> ListAsync(this IAssignmentOperations operations, string scope, string assignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, assignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a blueprint assignment operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}'). For blueprint
            /// assignments management group scope is reserved for future use.
            /// </param>
            /// <param name='assignmentName'>
            /// Name of the blueprint assignment.
            /// </param>
            /// <param name='assignmentOperationName'>
            /// Name of the blueprint assignment operation.
            /// </param>
            public static AssignmentOperation Get(this IAssignmentOperations operations, string scope, string assignmentName, string assignmentOperationName)
            {
                return operations.GetAsync(scope, assignmentName, assignmentOperationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a blueprint assignment operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}'). For blueprint
            /// assignments management group scope is reserved for future use.
            /// </param>
            /// <param name='assignmentName'>
            /// Name of the blueprint assignment.
            /// </param>
            /// <param name='assignmentOperationName'>
            /// Name of the blueprint assignment operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssignmentOperation> GetAsync(this IAssignmentOperations operations, string scope, string assignmentName, string assignmentOperationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, assignmentName, assignmentOperationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List operations for given blueprint assignment within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AssignmentOperation> ListNext(this IAssignmentOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List operations for given blueprint assignment within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AssignmentOperation>> ListNextAsync(this IAssignmentOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}