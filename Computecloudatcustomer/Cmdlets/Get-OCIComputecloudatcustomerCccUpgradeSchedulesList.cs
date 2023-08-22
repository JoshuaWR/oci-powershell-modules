/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20221208
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ComputecloudatcustomerService.Requests;
using Oci.ComputecloudatcustomerService.Responses;
using Oci.ComputecloudatcustomerService.Models;
using Oci.Common.Model;

namespace Oci.ComputecloudatcustomerService.Cmdlets
{
    [Cmdlet("Get", "OCIComputecloudatcustomerCccUpgradeSchedulesList")]
    [OutputType(new System.Type[] { typeof(Oci.ComputecloudatcustomerService.Models.CccUpgradeScheduleCollection), typeof(Oci.ComputecloudatcustomerService.Responses.ListCccUpgradeSchedulesResponse) })]
    public class GetOCIComputecloudatcustomerCccUpgradeSchedulesList : OCIComputeCloudAtCustomerCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Compute Cloud@Customer upgrade schedule [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public string CccUpgradeScheduleId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Default is false. When set to true, the hierarchy of compartments is traversed and all compartments and sub-compartments in the tenancy are returned. Depends on the 'accessLevel' setting.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED. Setting this to ACCESSIBLE returns only those compartments for which the user has INSPECT permissions directly or indirectly (permissions can be on a resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.")]
        public System.Nullable<Oci.ComputecloudatcustomerService.Requests.ListCccUpgradeSchedulesRequest.AccessLevelEnum> AccessLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return resources only when their lifecycleState matches the given lifecycleState.")]
        public System.Nullable<Oci.ComputecloudatcustomerService.Models.CccUpgradeSchedule.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire display name given.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources whose display name contains the substring.")]
        public string DisplayNameContains { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.ComputecloudatcustomerService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.")]
        public System.Nullable<Oci.ComputecloudatcustomerService.Requests.ListCccUpgradeSchedulesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListCccUpgradeSchedulesRequest request;

            try
            {
                request = new ListCccUpgradeSchedulesRequest
                {
                    CccUpgradeScheduleId = CccUpgradeScheduleId,
                    CompartmentId = CompartmentId,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    AccessLevel = AccessLevel,
                    LifecycleState = LifecycleState,
                    DisplayName = DisplayName,
                    DisplayNameContains = DisplayNameContains,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListCccUpgradeSchedulesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.CccUpgradeScheduleCollection, true);
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
            IEnumerable<ListCccUpgradeSchedulesResponse> DefaultRequest(ListCccUpgradeSchedulesRequest request) => Enumerable.Repeat(client.ListCccUpgradeSchedules(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListCccUpgradeSchedulesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListCccUpgradeSchedulesResponse response;
        private delegate IEnumerable<ListCccUpgradeSchedulesResponse> RequestDelegate(ListCccUpgradeSchedulesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
