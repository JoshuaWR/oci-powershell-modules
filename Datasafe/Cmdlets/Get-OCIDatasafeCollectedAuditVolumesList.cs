/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
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
    [Cmdlet("Get", "OCIDatasafeCollectedAuditVolumesList")]
    [OutputType(new System.Type[] { typeof(Oci.DatasafeService.Models.CollectedAuditVolumeCollection), typeof(Oci.DatasafeService.Responses.ListCollectedAuditVolumesResponse) })]
    public class GetOCIDatasafeCollectedAuditVolumesList : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the audit.")]
        public string AuditProfileId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the work request.")]
        public string WorkRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifying `monthInConsiderationGreaterThan` parameter will retrieve all items for which the event month is greater than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).

**Example:** 2016-12-19T00:00:00.000Z")]
        public System.Nullable<System.DateTime> MonthInConsiderationGreaterThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifying `monthInConsiderationLessThan` parameter will retrieve all items for which the event month is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).

**Example:** 2016-12-19T00:00:00.000Z")]
        public System.Nullable<System.DateTime> MonthInConsiderationLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of items to return per page in a paginated ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (ASC) or descending (DESC).")]
        public System.Nullable<Oci.DatasafeService.Requests.ListCollectedAuditVolumesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can specify only one sort order(sortOrder). The default order for all fields is ascending.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListCollectedAuditVolumesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListCollectedAuditVolumesRequest request;

            try
            {
                request = new ListCollectedAuditVolumesRequest
                {
                    AuditProfileId = AuditProfileId,
                    WorkRequestId = WorkRequestId,
                    MonthInConsiderationGreaterThan = MonthInConsiderationGreaterThan,
                    MonthInConsiderationLessThan = MonthInConsiderationLessThan,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListCollectedAuditVolumesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.CollectedAuditVolumeCollection, true);
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
            IEnumerable<ListCollectedAuditVolumesResponse> DefaultRequest(ListCollectedAuditVolumesRequest request) => Enumerable.Repeat(client.ListCollectedAuditVolumes(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListCollectedAuditVolumesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListCollectedAuditVolumesResponse response;
        private delegate IEnumerable<ListCollectedAuditVolumesResponse> RequestDelegate(ListCollectedAuditVolumesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
