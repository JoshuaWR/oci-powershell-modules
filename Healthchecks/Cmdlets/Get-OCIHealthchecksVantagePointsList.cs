/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.HealthchecksService.Requests;
using Oci.HealthchecksService.Responses;
using Oci.HealthchecksService.Models;
using Oci.Common.Model;

namespace Oci.HealthchecksService.Cmdlets
{
    [Cmdlet("Get", "OCIHealthchecksVantagePointsList")]
    [OutputType(new System.Type[] { typeof(Oci.HealthchecksService.Models.HealthChecksVantagePointSummary), typeof(Oci.HealthchecksService.Responses.ListHealthChecksVantagePointsResponse) })]
    public class GetOCIHealthchecksVantagePointsList : OCIHealthChecksCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by when listing vantage points.")]
        public System.Nullable<Oci.HealthchecksService.Requests.ListHealthChecksVantagePointsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Controls the sort order of results.")]
        public System.Nullable<Oci.HealthchecksService.Requests.ListHealthChecksVantagePointsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filters results that exactly match the `name` field.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filters results that exactly match the `displayName` field.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListHealthChecksVantagePointsRequest request;

            try
            {
                request = new ListHealthChecksVantagePointsRequest
                {
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    Name = Name,
                    DisplayName = DisplayName
                };
                IEnumerable<ListHealthChecksVantagePointsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListHealthChecksVantagePointsResponse> DefaultRequest(ListHealthChecksVantagePointsRequest request) => Enumerable.Repeat(client.ListHealthChecksVantagePoints(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListHealthChecksVantagePointsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListHealthChecksVantagePointsResponse response;
        private delegate IEnumerable<ListHealthChecksVantagePointsResponse> RequestDelegate(ListHealthChecksVantagePointsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
