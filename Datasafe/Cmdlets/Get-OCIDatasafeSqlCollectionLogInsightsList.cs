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
    [Cmdlet("Get", "OCIDatasafeSqlCollectionLogInsightsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatasafeService.Models.SqlCollectionLogInsightsCollection), typeof(Oci.DatasafeService.Responses.ListSqlCollectionLogInsightsResponse) })]
    public class GetOCIDatasafeSqlCollectionLogInsightsList : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"An optional filter to return the stats of the SQL collection logs collected after the date-time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"An optional filter to return the stats of the SQL collection logs collected before the date-time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the SQL collection resource.")]
        public string SqlCollectionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of items to return per page in a paginated ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The group by parameter to summarize SQL collection log insights aggregation.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListSqlCollectionLogInsightsRequest.GroupByEnum> GroupBy { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSqlCollectionLogInsightsRequest request;

            try
            {
                request = new ListSqlCollectionLogInsightsRequest
                {
                    TimeStarted = TimeStarted,
                    TimeEnded = TimeEnded,
                    SqlCollectionId = SqlCollectionId,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId,
                    GroupBy = GroupBy
                };
                IEnumerable<ListSqlCollectionLogInsightsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.SqlCollectionLogInsightsCollection, true);
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
            IEnumerable<ListSqlCollectionLogInsightsResponse> DefaultRequest(ListSqlCollectionLogInsightsRequest request) => Enumerable.Repeat(client.ListSqlCollectionLogInsights(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSqlCollectionLogInsightsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSqlCollectionLogInsightsResponse response;
        private delegate IEnumerable<ListSqlCollectionLogInsightsResponse> RequestDelegate(ListSqlCollectionLogInsightsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
