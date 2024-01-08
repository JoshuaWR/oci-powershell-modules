/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200107
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.UsageapiService.Requests;
using Oci.UsageapiService.Responses;
using Oci.UsageapiService.Models;
using Oci.Common.Model;

namespace Oci.UsageapiService.Cmdlets
{
    [Cmdlet("Get", "OCIUsageapiUsageCarbonEmissionsQueriesList")]
    [OutputType(new System.Type[] { typeof(Oci.UsageapiService.Models.UsageCarbonEmissionsQueryCollection), typeof(Oci.UsageapiService.Responses.ListUsageCarbonEmissionsQueriesResponse) })]
    public class GetOCIUsageapiUsageCarbonEmissionsQueriesList : OCIUsageapiCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The compartment ID in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximumimum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. If not specified, the default is displayName.")]
        public System.Nullable<Oci.UsageapiService.Requests.ListUsageCarbonEmissionsQueriesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, whether 'asc' or 'desc'.")]
        public System.Nullable<Oci.UsageapiService.Requests.ListUsageCarbonEmissionsQueriesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListUsageCarbonEmissionsQueriesRequest request;

            try
            {
                request = new ListUsageCarbonEmissionsQueriesRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };
                IEnumerable<ListUsageCarbonEmissionsQueriesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.UsageCarbonEmissionsQueryCollection, true);
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
            IEnumerable<ListUsageCarbonEmissionsQueriesResponse> DefaultRequest(ListUsageCarbonEmissionsQueriesRequest request) => Enumerable.Repeat(client.ListUsageCarbonEmissionsQueries(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListUsageCarbonEmissionsQueriesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListUsageCarbonEmissionsQueriesResponse response;
        private delegate IEnumerable<ListUsageCarbonEmissionsQueriesResponse> RequestDelegate(ListUsageCarbonEmissionsQueriesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
