/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20171215
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;
using Oci.FilestorageService.Models;
using Oci.Common.Model;

namespace Oci.FilestorageService.Cmdlets
{
    [Cmdlet("Get", "OCIFilestorageFilesystemSnapshotPoliciesList")]
    [OutputType(new System.Type[] { typeof(Oci.FilestorageService.Models.FilesystemSnapshotPolicySummary), typeof(Oci.FilestorageService.Responses.ListFilesystemSnapshotPoliciesResponse) })]
    public class GetOCIFilestorageFilesystemSnapshotPoliciesList : OCIFileStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the availability domain.

Example: `Uocm:PHX-AD-1`")]
        public string AvailabilityDomain { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. 1 is the minimum, 1000 is the maximum.

For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `500`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call.

For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A user-friendly name. It does not have to be unique, and it is changeable.

Example: `My resource`")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter results by the specified lifecycle state. Must be a valid state for the resource type.")]
        public System.Nullable<Oci.FilestorageService.Requests.ListFilesystemSnapshotPoliciesRequest.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter results by [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm). Must be an OCID of the correct type for the resouce type.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide either value, but not both. By default, when you sort by time created, results are shown in descending order. When you sort by displayName, results are shown in ascending alphanumeric order.")]
        public System.Nullable<Oci.FilestorageService.Requests.ListFilesystemSnapshotPoliciesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc', where 'asc' is ascending and 'desc' is descending. The default order is 'desc' except for numeric values.")]
        public System.Nullable<Oci.FilestorageService.Requests.ListFilesystemSnapshotPoliciesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListFilesystemSnapshotPoliciesRequest request;

            try
            {
                request = new ListFilesystemSnapshotPoliciesRequest
                {
                    CompartmentId = CompartmentId,
                    AvailabilityDomain = AvailabilityDomain,
                    Limit = Limit,
                    Page = Page,
                    DisplayName = DisplayName,
                    LifecycleState = LifecycleState,
                    Id = Id,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListFilesystemSnapshotPoliciesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListFilesystemSnapshotPoliciesResponse> DefaultRequest(ListFilesystemSnapshotPoliciesRequest request) => Enumerable.Repeat(client.ListFilesystemSnapshotPolicies(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListFilesystemSnapshotPoliciesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListFilesystemSnapshotPoliciesResponse response;
        private delegate IEnumerable<ListFilesystemSnapshotPoliciesResponse> RequestDelegate(ListFilesystemSnapshotPoliciesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
