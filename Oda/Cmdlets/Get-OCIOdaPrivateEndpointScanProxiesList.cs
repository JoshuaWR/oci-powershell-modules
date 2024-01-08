/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190506
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OdaService.Requests;
using Oci.OdaService.Responses;
using Oci.OdaService.Models;
using Oci.Common.Model;

namespace Oci.OdaService.Cmdlets
{
    [Cmdlet("Get", "OCIOdaPrivateEndpointScanProxiesList")]
    [OutputType(new System.Type[] { typeof(Oci.OdaService.Models.OdaPrivateEndpointScanProxyCollection), typeof(Oci.OdaService.Responses.ListOdaPrivateEndpointScanProxiesResponse) })]
    public class GetOCIOdaPrivateEndpointScanProxiesList : OCIManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique ODA Private Endpoint identifier which is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public string OdaPrivateEndpointId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"List only the ODA Private Endpoint Scan Proxies that are in this lifecycle state.")]
        public System.Nullable<Oci.OdaService.Models.OdaPrivateEndpointScanProxy.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page at which to start retrieving results.

You get this value from the `opc-next-page` header in a previous list request. To retireve the first page, omit this query parameter.

Example: `MToxMA==`")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Sort the results in this order, use either `ASC` (ascending) or `DESC` (descending).")]
        public System.Nullable<Oci.OdaService.Requests.ListOdaPrivateEndpointScanProxiesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Sort on this field. You can specify one sort order only. The default sort field is `TIMECREATED`.

The default sort order for `TIMECREATED` is descending, and the default sort order for `DISPLAYNAME` is ascending.")]
        public System.Nullable<Oci.OdaService.Requests.ListOdaPrivateEndpointScanProxiesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing. This value is included in the opc-request-id response header.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListOdaPrivateEndpointScanProxiesRequest request;

            try
            {
                request = new ListOdaPrivateEndpointScanProxiesRequest
                {
                    OdaPrivateEndpointId = OdaPrivateEndpointId,
                    LifecycleState = LifecycleState,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListOdaPrivateEndpointScanProxiesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.OdaPrivateEndpointScanProxyCollection, true);
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
            IEnumerable<ListOdaPrivateEndpointScanProxiesResponse> DefaultRequest(ListOdaPrivateEndpointScanProxiesRequest request) => Enumerable.Repeat(client.ListOdaPrivateEndpointScanProxies(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListOdaPrivateEndpointScanProxiesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListOdaPrivateEndpointScanProxiesResponse response;
        private delegate IEnumerable<ListOdaPrivateEndpointScanProxiesResponse> RequestDelegate(ListOdaPrivateEndpointScanProxiesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
