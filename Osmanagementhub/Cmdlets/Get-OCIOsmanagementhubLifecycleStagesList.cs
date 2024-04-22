/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220901
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OsmanagementhubService.Requests;
using Oci.OsmanagementhubService.Responses;
using Oci.OsmanagementhubService.Models;
using Oci.Common.Model;

namespace Oci.OsmanagementhubService.Cmdlets
{
    [Cmdlet("Get", "OCIOsmanagementhubLifecycleStagesList")]
    [OutputType(new System.Type[] { typeof(Oci.OsmanagementhubService.Models.LifecycleStageCollection), typeof(Oci.OsmanagementhubService.Responses.ListLifecycleStagesResponse) })]
    public class GetOCIOsmanagementhubLifecycleStagesList : OCILifecycleEnvironmentCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment that contains the resources to list. This filter returns only resources contained within the specified compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return resources that match the given display names.")]
        public System.Collections.Generic.List<string> DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return resources that may partially match the given display name.")]
        public string DisplayNameContains { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the lifecycle stage.")]
        public string LifecycleStageId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the software source. This filter returns resources associated with this software source.")]
        public string SoftwareSourceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only profiles that match the given archType.")]
        public System.Nullable<Oci.OsmanagementhubService.Models.ArchType> ArchType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given operating system family.")]
        public System.Nullable<Oci.OsmanagementhubService.Models.OsFamily> OsFamily { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources whose location matches the given value.")]
        public System.Collections.Generic.List<Oci.OsmanagementhubService.Models.ManagedInstanceLocation> Location { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources whose location does not match the given value.")]
        public System.Collections.Generic.List<Oci.OsmanagementhubService.Models.ManagedInstanceLocation> LocationNotEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `50`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `3`")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only lifecycle stages whose lifecycle state matches the given lifecycle state.")]
        public System.Nullable<Oci.OsmanagementhubService.Models.LifecycleStage.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.OsmanagementhubService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.")]
        public System.Nullable<Oci.OsmanagementhubService.Requests.ListLifecycleStagesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListLifecycleStagesRequest request;

            try
            {
                request = new ListLifecycleStagesRequest
                {
                    CompartmentId = CompartmentId,
                    DisplayName = DisplayName,
                    DisplayNameContains = DisplayNameContains,
                    LifecycleStageId = LifecycleStageId,
                    SoftwareSourceId = SoftwareSourceId,
                    ArchType = ArchType,
                    OsFamily = OsFamily,
                    Location = Location,
                    LocationNotEqualTo = LocationNotEqualTo,
                    Limit = Limit,
                    Page = Page,
                    LifecycleState = LifecycleState,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListLifecycleStagesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.LifecycleStageCollection, true);
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
            IEnumerable<ListLifecycleStagesResponse> DefaultRequest(ListLifecycleStagesRequest request) => Enumerable.Repeat(client.ListLifecycleStages(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListLifecycleStagesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListLifecycleStagesResponse response;
        private delegate IEnumerable<ListLifecycleStagesResponse> RequestDelegate(ListLifecycleStagesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
