/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatasafeService.Requests;
using Oci.DatasafeService.Responses;
using Oci.DatasafeService.Models;
using Oci.Common.Model;

namespace Oci.DatasafeService.Cmdlets
{
    [Cmdlet("Get", "OCIDatasafeSecurityPolicyDeploymentsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatasafeService.Models.SecurityPolicyDeploymentCollection), typeof(Oci.DatasafeService.Responses.ListSecurityPolicyDeploymentsResponse) })]
    public class GetOCIDatasafeSecurityPolicyDeploymentsList : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the specified compartment OCID.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Default is false. When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned. Depends on the 'accessLevel' setting.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED. Setting this to ACCESSIBLE returns only those compartments for which the user has INSPECT permissions directly or indirectly (permissions can be on a resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListSecurityPolicyDeploymentsRequest.AccessLevelEnum> AccessLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the specified display name.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of items to return per page in a paginated ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The current state of the security policy deployment.")]
        public System.Nullable<Oci.DatasafeService.Models.SecurityPolicyDeploymentLifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"An optional filter to return only resources that match the specified OCID of the security policy deployment resource.")]
        public string SecurityPolicyDeploymentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items related to a specific target OCID.")]
        public string TargetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"An optional filter to return only resources that match the specified OCID of the security policy resource.")]
        public string SecurityPolicyId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (ASC) or descending (DESC).")]
        public System.Nullable<Oci.DatasafeService.Requests.ListSecurityPolicyDeploymentsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field used for sorting. Only one sorting order (sortOrder) can be specified. The default order for TIMECREATED is descending. The default order for DISPLAYNAME is ascending. The DISPLAYNAME sort order is case sensitive.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListSecurityPolicyDeploymentsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSecurityPolicyDeploymentsRequest request;

            try
            {
                request = new ListSecurityPolicyDeploymentsRequest
                {
                    CompartmentId = CompartmentId,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    AccessLevel = AccessLevel,
                    DisplayName = DisplayName,
                    Limit = Limit,
                    Page = Page,
                    LifecycleState = LifecycleState,
                    SecurityPolicyDeploymentId = SecurityPolicyDeploymentId,
                    TargetId = TargetId,
                    SecurityPolicyId = SecurityPolicyId,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListSecurityPolicyDeploymentsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.SecurityPolicyDeploymentCollection, true);
                }
                if(!ParameterSetName.Equals(AllPageSet) && !ParameterSetName.Equals(LimitSet) && response.OpcNextPage != null)
                {
                    WriteWarning("This operation supports pagination and not all resources were returned. Re-run using the -All option to auto paginate and list all resources.");
                }
                FinishProcessing(response);
            }
            catch (OciException ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
            TerminatingErrorDuringExecution(new OperationCanceledException("Cmdlet execution interrupted"));
        }

        private RequestDelegate GetRequestDelegate()
        {
            IEnumerable<ListSecurityPolicyDeploymentsResponse> DefaultRequest(ListSecurityPolicyDeploymentsRequest request) => Enumerable.Repeat(client.ListSecurityPolicyDeployments(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSecurityPolicyDeploymentsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSecurityPolicyDeploymentsResponse response;
        private delegate IEnumerable<ListSecurityPolicyDeploymentsResponse> RequestDelegate(ListSecurityPolicyDeploymentsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
