/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190325
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatacatalogService.Requests;
using Oci.DatacatalogService.Responses;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Cmdlets
{
    [Cmdlet("Get", "OCIDatacatalogWorkRequestErrorsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatacatalogService.Models.WorkRequestError), typeof(Oci.DatacatalogService.Responses.ListWorkRequestErrorsResponse) })]
    public class GetOCIDatacatalogWorkRequestErrorsList : OCIDataCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the asynchronous request.")]
        public string WorkRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for TIMESTAMP is descending. Default order for CODE and MESSAGE is ascending. If no value is specified TIMESTAMP is default.")]
        public System.Nullable<Oci.DatacatalogService.Requests.ListWorkRequestErrorsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.DatacatalogService.Requests.ListWorkRequestErrorsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListWorkRequestErrorsRequest request;

            try
            {
                request = new ListWorkRequestErrorsRequest
                {
                    WorkRequestId = WorkRequestId,
                    OpcRequestId = OpcRequestId,
                    Page = Page,
                    Limit = Limit,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };
                IEnumerable<ListWorkRequestErrorsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListWorkRequestErrorsResponse> DefaultRequest(ListWorkRequestErrorsRequest request) => Enumerable.Repeat(client.ListWorkRequestErrors(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListWorkRequestErrorsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListWorkRequestErrorsResponse response;
        private delegate IEnumerable<ListWorkRequestErrorsResponse> RequestDelegate(ListWorkRequestErrorsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
