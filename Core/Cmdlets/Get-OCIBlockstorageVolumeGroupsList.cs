/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Get", "OCIBlockstorageVolumeGroupsList")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.VolumeGroup), typeof(Oci.CoreService.Responses.ListVolumeGroupsResponse) })]
    public class GetOCIBlockstorageVolumeGroupsList : OCIBlockstorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the availability domain.

Example: `Uocm:PHX-AD-1`")]
        public string AvailabilityDomain { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `50`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given display name exactly.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order (`sortOrder`). Default order for TIMECREATED is descending. Default order for DISPLAYNAME is ascending. The DISPLAYNAME sort order is case sensitive.

**Note:** In general, some ""List"" operations (for example, `ListInstances`) let you optionally filter by availability domain if the scope of the resource type is within a single availability domain. If you call one of these ""List"" operations without specifying an availability domain, the resources are grouped by availability domain, then sorted.")]
        public System.Nullable<Oci.CoreService.Requests.ListVolumeGroupsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`). The DISPLAYNAME sort order is case sensitive.")]
        public System.Nullable<Oci.CoreService.Requests.ListVolumeGroupsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to only return resources that match the given lifecycle state.  The state value is case-insensitive.")]
        public System.Nullable<Oci.CoreService.Models.VolumeGroup.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListVolumeGroupsRequest request;

            try
            {
                request = new ListVolumeGroupsRequest
                {
                    CompartmentId = CompartmentId,
                    AvailabilityDomain = AvailabilityDomain,
                    Limit = Limit,
                    Page = Page,
                    DisplayName = DisplayName,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    LifecycleState = LifecycleState
                };
                IEnumerable<ListVolumeGroupsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListVolumeGroupsResponse> DefaultRequest(ListVolumeGroupsRequest request) => Enumerable.Repeat(client.ListVolumeGroups(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListVolumeGroupsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListVolumeGroupsResponse response;
        private delegate IEnumerable<ListVolumeGroupsResponse> RequestDelegate(ListVolumeGroupsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
