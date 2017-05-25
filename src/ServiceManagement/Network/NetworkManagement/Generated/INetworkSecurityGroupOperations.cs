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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network
{
    /// <summary>
    /// The Network Management API includes operations for managing the Network
    /// Security Groups for your subscription.
    /// </summary>
    public partial interface INetworkSecurityGroupOperations
    {
        /// <summary>
        /// Abort resservedIP migration api validates and aborts the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> AbortMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a Network Security Group to a network interface.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Network Security Group to a network
        /// interface operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> AddToNetworkInterfaceAsync(string serviceName, string deploymentName, string roleName, string networkInterfaceName, NetworkSecurityGroupAddAssociationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a Network Security Group to a Role.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Network Security Group to Role
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> AddToRoleAsync(string serviceName, string deploymentName, string roleName, NetworkSecurityGroupAddAssociationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a Network Security Group to a subnet.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Network Security Group to subnet
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> AddToSubnetAsync(string virtualNetworkName, string subnetName, NetworkSecurityGroupAddAssociationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Abort resservedIP migration api validates and aborts the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginAbortMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a Network Security Group to a network interface.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Network Security Group to a network
        /// interface operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginAddingToNetworkInterfaceAsync(string serviceName, string deploymentName, string roleName, string networkInterfaceName, NetworkSecurityGroupAddAssociationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a Network Security Group to a Role.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Network Security Group to Role
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginAddingToRoleAsync(string serviceName, string deploymentName, string roleName, NetworkSecurityGroupAddAssociationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a Network Security Group to a subnet.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Network Security Group to subnet
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginAddingToSubnetAsync(string virtualNetworkName, string subnetName, NetworkSecurityGroupAddAssociationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Commit resservedIP migration api validates and commits the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginCommitMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new Network Security Group.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Network Security Group operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginCreatingAsync(NetworkSecurityGroupCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the pecified Network Security Group from your
        /// subscription.If the Network Security group is still associated
        /// with some VM/Role/Subnet, the deletion will fail. In order to
        /// successfully delete the Network Security, it needs to be not used.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// The name of the Network Security Group to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginDeletingAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a rule from the specified Network Security Group.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// The name of the Network Security Group.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginDeletingRuleAsync(string networkSecurityGroupName, string ruleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Prepare resservedIP migration api validates and prepares the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginPrepareMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes a Network Security Group from a network interface.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginRemovingFromNetworkInterfaceAsync(string serviceName, string deploymentName, string roleName, string networkInterfaceName, string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes a Network Security Group from a role.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginRemovingFromRoleAsync(string serviceName, string deploymentName, string roleName, string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes a Network Security Group from a subnet.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginRemovingFromSubnetAsync(string virtualNetworkName, string subnetName, string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets a new Network Security Rule to existing Network Security Group.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Set Network Security Rule operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginSettingRuleAsync(string networkSecurityGroupName, string ruleName, NetworkSecuritySetRuleParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Commit resservedIP migration api validates and commits the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> CommitMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new Network Security Group.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Network Security Group operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> CreateAsync(NetworkSecurityGroupCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Network Security Group operation removes thespecified
        /// Network Security Group from your subscription.If the Network
        /// Security group is still associated with some VM/Role/Subnet, the
        /// deletion will fail. In order to successfully delete the Network
        /// Security, it needs to be not used.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// The name of the Network Security Group to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Network Security Rule operation removes a rule from the
        /// specified Network Security Group.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// The name of the Network Security Group.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteRuleAsync(string networkSecurityGroupName, string ruleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the details for the specified Network Security Group in the
        /// subscription.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// The name of the Network Security Group to retrieve.
        /// </param>
        /// <param name='detailLevel'>
        /// Use 'Full' to list rules.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A Network Security Group associated with your subscription.
        /// </returns>
        Task<NetworkSecurityGroupGetResponse> GetAsync(string networkSecurityGroupName, string detailLevel, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the Network Security Group applied to a specific network
        /// interface.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Network Security Group associated with an entity: subnet,
        /// network interface or role.
        /// </returns>
        Task<NetworkSecurityGroupGetAssociationResponse> GetForNetworkInterfaceAsync(string serviceName, string deploymentName, string roleName, string networkInterfaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the Network Security Group applied to a specific role.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Network Security Group associated with an entity: subnet,
        /// network interface or role.
        /// </returns>
        Task<NetworkSecurityGroupGetAssociationResponse> GetForRoleAsync(string serviceName, string deploymentName, string roleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the Network Security Group applied to a specific subnet.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Network Security Group associated with an entity: subnet,
        /// network interface or role.
        /// </returns>
        Task<NetworkSecurityGroupGetAssociationResponse> GetForSubnetAsync(string virtualNetworkName, string subnetName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all of the Network Security Groups for the subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Definitions operation response.
        /// </returns>
        Task<NetworkSecurityGroupListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Prepare resservedIP migration api validates and prepares the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> PrepareMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes a Network Security Group from a network interface.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> RemoveFromNetworkInterfaceAsync(string serviceName, string deploymentName, string roleName, string networkInterfaceName, string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes a Network Security Group from a role.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> RemoveFromRoleAsync(string serviceName, string deploymentName, string roleName, string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes a Network Security Group from a subnet.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> RemoveFromSubnetAsync(string virtualNetworkName, string subnetName, string networkSecurityGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Add new Network Security Rule to existing Network Security Group.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Set Network Security Rule operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> SetRuleAsync(string networkSecurityGroupName, string ruleName, NetworkSecuritySetRuleParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Validate network security group migration api validates the given
        /// network security group for IaaS Classic to ARM migration.
        /// </summary>
        /// <param name='networkSecurityGroupName'>
        /// Name of the network security group to be migrated.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Validate Network Migration operation response.
        /// </returns>
        Task<NetworkMigrationValidationResponse> ValidateMigrationAsync(string networkSecurityGroupName, CancellationToken cancellationToken);
    }
}