/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20230801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ClusterplacementgroupsService.Requests;
using Oci.ClusterplacementgroupsService.Responses;
using Oci.ClusterplacementgroupsService.Models;
using Oci.Common.Model;

namespace Oci.ClusterplacementgroupsService.Cmdlets
{
    [Cmdlet("Get", "OCIClusterplacementgroupsList")]
    [OutputType(new System.Type[] { typeof(Oci.ClusterplacementgroupsService.Models.ClusterPlacementGroupCollection), typeof(Oci.ClusterplacementgroupsService.Responses.ListClusterPlacementGroupsResponse) })]
    public class GetOCIClusterplacementgroupsList : OCIClusterPlacementGroupsCPCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the specified compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the specified lifecycle state.")]
        public System.Nullable<Oci.ClusterplacementgroupsService.Models.ClusterPlacementGroup.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the entire display name specified.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the specified availability domain.")]
        public string Ad { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the specified unique cluster placement group identifier.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.ClusterplacementgroupsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can specify only one sort order. The default order for `timeCreated` is descending. The default order for `name` is ascending.")]
        public System.Nullable<Oci.ClusterplacementgroupsService.Requests.ListClusterPlacementGroupsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"When set to `true`, cluster placement groups in all compartments under the specified compartment are returned. The default is set to `false`.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListClusterPlacementGroupsRequest request;

            try
            {
                request = new ListClusterPlacementGroupsRequest
                {
                    CompartmentId = CompartmentId,
                    LifecycleState = LifecycleState,
                    Name = Name,
                    Ad = Ad,
                    Id = Id,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListClusterPlacementGroupsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.ClusterPlacementGroupCollection, true);
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
            IEnumerable<ListClusterPlacementGroupsResponse> DefaultRequest(ListClusterPlacementGroupsRequest request) => Enumerable.Repeat(client.ListClusterPlacementGroups(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListClusterPlacementGroupsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListClusterPlacementGroupsResponse response;
        private delegate IEnumerable<ListClusterPlacementGroupsResponse> RequestDelegate(ListClusterPlacementGroupsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
