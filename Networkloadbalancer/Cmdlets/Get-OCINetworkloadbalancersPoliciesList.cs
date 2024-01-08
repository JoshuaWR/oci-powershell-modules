/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.NetworkloadbalancerService.Requests;
using Oci.NetworkloadbalancerService.Responses;
using Oci.NetworkloadbalancerService.Models;
using Oci.Common.Model;

namespace Oci.NetworkloadbalancerService.Cmdlets
{
    [Cmdlet("Get", "OCINetworkloadbalancersPoliciesList")]
    [OutputType(new System.Type[] { typeof(Oci.NetworkloadbalancerService.Models.NetworkLoadBalancersPolicyCollection), typeof(Oci.NetworkloadbalancerService.Responses.ListNetworkLoadBalancersPoliciesResponse) })]
    public class GetOCINetworkloadbalancersPoliciesList : OCINetworkLoadBalancerCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you must contact Oracle about a particular request, then provide the request identifier.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page or items to return, in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page from which to start retrieving results. For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' (ascending) or 'desc' (descending).")]
        public System.Nullable<Oci.NetworkloadbalancerService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order can be provided. The default order for timeCreated is descending. The default order for displayName is ascending. If no value is specified, then timeCreated is the default.")]
        public System.Nullable<Oci.NetworkloadbalancerService.Requests.ListNetworkLoadBalancersPoliciesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListNetworkLoadBalancersPoliciesRequest request;

            try
            {
                request = new ListNetworkLoadBalancersPoliciesRequest
                {
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy
                };
                IEnumerable<ListNetworkLoadBalancersPoliciesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.NetworkLoadBalancersPolicyCollection, true);
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
            IEnumerable<ListNetworkLoadBalancersPoliciesResponse> DefaultRequest(ListNetworkLoadBalancersPoliciesRequest request) => Enumerable.Repeat(client.ListNetworkLoadBalancersPolicies(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListNetworkLoadBalancersPoliciesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListNetworkLoadBalancersPoliciesResponse response;
        private delegate IEnumerable<ListNetworkLoadBalancersPoliciesResponse> RequestDelegate(ListNetworkLoadBalancersPoliciesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
