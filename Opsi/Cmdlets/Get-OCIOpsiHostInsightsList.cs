/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OpsiService.Requests;
using Oci.OpsiService.Responses;
using Oci.OpsiService.Models;
using Oci.Common.Model;

namespace Oci.OpsiService.Cmdlets
{
    [Cmdlet("Get", "OCIOpsiHostInsightsList")]
    [OutputType(new System.Type[] { typeof(Oci.OpsiService.Models.HostInsightSummaryCollection), typeof(Oci.OpsiService.Responses.ListHostInsightsResponse) })]
    public class GetOCIOpsiHostInsightsList : OCIOperationsInsightsCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Optional list of host insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public System.Collections.Generic.List<string> Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Resource Status")]
        public System.Collections.Generic.List<Oci.OpsiService.Models.ResourceStatus> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Lifecycle states")]
        public System.Collections.Generic.List<Oci.OpsiService.Models.LifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter by one or more host types. Possible values are CLOUD-HOST, EXTERNAL-HOST")]
        public System.Collections.Generic.List<string> HostType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter by one or more platform types. Supported platformType(s) for MACS-managed external host insight: [LINUX]. Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].")]
        public System.Collections.Generic.List<Oci.OpsiService.Requests.ListHostInsightsRequest.PlatformTypeEnum> PlatformType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine). Example: `50`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.OpsiService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Host insight list sort options. If `fields` parameter is selected, the `sortBy` parameter must be one of the fields specified.")]
        public System.Nullable<Oci.OpsiService.Requests.ListHostInsightsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Enterprise Manager bridge identifier")]
        public string EnterpriseManagerBridgeId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"[OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of exadata insight resource.")]
        public string ExadataInsightId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A flag to search all resources within a given compartment and all sub-compartments.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListHostInsightsRequest request;

            try
            {
                request = new ListHostInsightsRequest
                {
                    CompartmentId = CompartmentId,
                    Id = Id,
                    Status = Status,
                    LifecycleState = LifecycleState,
                    HostType = HostType,
                    PlatformType = PlatformType,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    EnterpriseManagerBridgeId = EnterpriseManagerBridgeId,
                    ExadataInsightId = ExadataInsightId,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListHostInsightsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.HostInsightSummaryCollection, true);
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
            IEnumerable<ListHostInsightsResponse> DefaultRequest(ListHostInsightsRequest request) => Enumerable.Repeat(client.ListHostInsights(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListHostInsightsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListHostInsightsResponse response;
        private delegate IEnumerable<ListHostInsightsResponse> RequestDelegate(ListHostInsightsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
