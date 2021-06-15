/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200129
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DataflowService.Requests;
using Oci.DataflowService.Responses;
using Oci.DataflowService.Models;

namespace Oci.DataflowService.Cmdlets
{
    [Cmdlet("Get", "OCIDataflowApplicationsList")]
    [OutputType(new System.Type[] { typeof(Oci.DataflowService.Models.ApplicationSummary), typeof(Oci.DataflowService.Responses.ListApplicationsResponse) })]
    public class GetOCIDataflowApplicationsList : OCIDataFlowCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of results to return in a paginated `List` call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` or `opc-prev-page` response header from the last `List` call to sent back to server for getting the next page of results.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field used to sort the results. Multiple fields are not supported.")]
        public System.Nullable<Oci.DataflowService.Requests.ListApplicationsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ordering of results in ascending or descending order.")]
        public System.Nullable<Oci.DataflowService.Requests.ListApplicationsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The query parameter for the Spark application name.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the user who created the resource.")]
        public string OwnerPrincipalId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The displayName prefix.")]
        public string DisplayNameStartsWith { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Spark version utilized to run the application.")]
        public string SparkVersion { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListApplicationsRequest request;

            try
            {
                request = new ListApplicationsRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    DisplayName = DisplayName,
                    OwnerPrincipalId = OwnerPrincipalId,
                    DisplayNameStartsWith = DisplayNameStartsWith,
                    SparkVersion = SparkVersion
                };
                IEnumerable<ListApplicationsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListApplicationsResponse> DefaultRequest(ListApplicationsRequest request) => Enumerable.Repeat(client.ListApplications(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListApplicationsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListApplicationsResponse response;
        private delegate IEnumerable<ListApplicationsResponse> RequestDelegate(ListApplicationsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
