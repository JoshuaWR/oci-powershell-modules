/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OpsiService.Requests;
using Oci.OpsiService.Responses;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Cmdlets
{
    [Cmdlet("Get", "OCIOpsiAwrSnapshotsList")]
    [OutputType(new System.Type[] { typeof(Oci.OpsiService.Models.AwrSnapshotCollection), typeof(Oci.OpsiService.Responses.ListAwrSnapshotsResponse) })]
    public class GetOCIOpsiAwrSnapshotsList : OCIOperationsInsightsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Awr Hub identifier")]
        public string AwrHubId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"AWR source database identifier.")]
        public string AwrSourceDatabaseIdentifier { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The optional greater than or equal to query parameter to filter the timestamp. The timestamp format to be followed is: YYYY-MM-DDTHH:MM:SSZ, example 2020-12-03T19:00:53Z")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The optional less than or equal to query parameter to filter the timestamp. The timestamp format to be followed is: YYYY-MM-DDTHH:MM:SSZ, example 2020-12-03T19:00:53Z")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine). Example: `50`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.OpsiService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The option to sort the AWR snapshot summary data. Default sort is by timeBegin.")]
        public System.Nullable<Oci.OpsiService.Requests.ListAwrSnapshotsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAwrSnapshotsRequest request;

            try
            {
                request = new ListAwrSnapshotsRequest
                {
                    AwrHubId = AwrHubId,
                    AwrSourceDatabaseIdentifier = AwrSourceDatabaseIdentifier,
                    TimeGreaterThanOrEqualTo = TimeGreaterThanOrEqualTo,
                    TimeLessThanOrEqualTo = TimeLessThanOrEqualTo,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListAwrSnapshotsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.AwrSnapshotCollection, true);
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
            IEnumerable<ListAwrSnapshotsResponse> DefaultRequest(ListAwrSnapshotsRequest request) => Enumerable.Repeat(client.ListAwrSnapshots(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListAwrSnapshotsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListAwrSnapshotsResponse response;
        private delegate IEnumerable<ListAwrSnapshotsResponse> RequestDelegate(ListAwrSnapshotsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
