/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatascienceService.Requests;
using Oci.DatascienceService.Responses;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Cmdlets
{
    [Cmdlet("Get", "OCIDatascienceWorkRequestsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatascienceService.Models.WorkRequestSummary), typeof(Oci.DatascienceService.Responses.ListWorkRequestsResponse) })]
    public class GetOCIDatascienceWorkRequestsList : OCIDataScienceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"<b>Filter</b> results by the [OCID](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"<b>Filter</b> results by [OCID](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/identifiers.htm). Must be an OCID of the correct type for the resource type.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"<b>Filter</b> results by the type of the operation associated with the work request.")]
        public System.Nullable<Oci.DatascienceService.Requests.ListWorkRequestsRequest.OperationTypeEnum> OperationType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"<b>Filter</b> results by work request status.")]
        public System.Nullable<Oci.DatascienceService.Requests.ListWorkRequestsRequest.StatusEnum> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. 1 is the minimum, 1000 is the maximum. See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `500`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call.

See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies sort order to use, either `ASC` (ascending) or `DESC` (descending).")]
        public System.Nullable<Oci.DatascienceService.Requests.ListWorkRequestsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies the field to sort by. Accepts only one field. By default, when you sort by time fields, results are shown in descending order. All other fields default to ascending order.")]
        public System.Nullable<Oci.DatascienceService.Requests.ListWorkRequestsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

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
                    Id = Id,
                    OperationType = OperationType,
                    Status = Status,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListWorkRequestsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
                }
                FinishProcessing(response);
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
