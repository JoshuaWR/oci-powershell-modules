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
    [Cmdlet("Get", "OCIOdaWorkRequestsList")]
    [OutputType(new System.Type[] { typeof(Oci.OdaService.Models.WorkRequestSummary), typeof(Oci.OdaService.Responses.ListWorkRequestsResponse) })]
    public class GetOCIOdaWorkRequestsList : OCIOdaCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"List the Digital Assistant instances that belong to this compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing. This value is included in the opc-request-id response header.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"List only the information for this Digital Assistant instance.")]
        public string OdaInstanceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"List only the information for this resource.")]
        public string ResourceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page at which to start retrieving results.

You get this value from the `opc-next-page` header in a previous list request. To retireve the first page, omit this query parameter.

Example: `MToxMA==`")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can specify only one sort order. If no value is specified, then the default is `TIME_ACCEPTED`.

The default sort order for the time fields is descending. The default order for `DISPLAYNAME` and `STATUS` is ascending.default: TIME_ACCEPTED")]
        public System.Nullable<Oci.OdaService.Requests.ListWorkRequestsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Sort the results in this order, use either `ASC` (ascending) or `DESC` (descending).")]
        public System.Nullable<Oci.OdaService.Requests.ListWorkRequestsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListWorkRequestsRequest request;

            try
            {
                request = new ListWorkRequestsRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    OdaInstanceId = OdaInstanceId,
                    ResourceId = ResourceId,
                    Page = Page,
                    Limit = Limit,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };
                IEnumerable<ListWorkRequestsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
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
            IEnumerable<ListWorkRequestsResponse> DefaultRequest(ListWorkRequestsRequest request) => Enumerable.Repeat(client.ListWorkRequests(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListWorkRequestsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListWorkRequestsResponse response;
        private delegate IEnumerable<ListWorkRequestsResponse> RequestDelegate(ListWorkRequestsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
