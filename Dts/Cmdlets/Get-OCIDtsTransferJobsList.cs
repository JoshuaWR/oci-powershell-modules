/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 1.0.015
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;
using Oci.DtsService.Models;

namespace Oci.DtsService.Cmdlets
{
    [Cmdlet("Get", "OCIDtsTransferJobsList")]
    [OutputType(new System.Type[] { typeof(Oci.DtsService.Models.TransferJobSummary), typeof(Oci.DtsService.Responses.ListTransferJobsResponse) })]
    public class GetOCIDtsTransferJobsList : OCITransferJobCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"compartment id")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"filtering by lifecycleState")]
        public System.Nullable<Oci.DtsService.Requests.ListTransferJobsRequest.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"filtering by displayName")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `50`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListTransferJobsRequest request;

            try
            {
                request = new ListTransferJobsRequest
                {
                    CompartmentId = CompartmentId,
                    LifecycleState = LifecycleState,
                    DisplayName = DisplayName,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListTransferJobsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListTransferJobsResponse> DefaultRequest(ListTransferJobsRequest request) => Enumerable.Repeat(client.ListTransferJobs(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListTransferJobsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListTransferJobsResponse response;
        private delegate IEnumerable<ListTransferJobsResponse> RequestDelegate(ListTransferJobsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
