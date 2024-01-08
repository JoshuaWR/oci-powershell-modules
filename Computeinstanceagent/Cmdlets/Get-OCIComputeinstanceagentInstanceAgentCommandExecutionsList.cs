/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180530
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ComputeinstanceagentService.Requests;
using Oci.ComputeinstanceagentService.Responses;
using Oci.ComputeinstanceagentService.Models;
using Oci.Common.Model;

namespace Oci.ComputeinstanceagentService.Cmdlets
{
    [Cmdlet("Get", "OCIComputeinstanceagentInstanceAgentCommandExecutionsList")]
    [OutputType(new System.Type[] { typeof(Oci.ComputeinstanceagentService.Models.InstanceAgentCommandExecutionSummary), typeof(Oci.ComputeinstanceagentService.Responses.ListInstanceAgentCommandExecutionsResponse) })]
    public class GetOCIComputeinstanceagentInstanceAgentCommandExecutionsList : OCIComputeInstanceAgentCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the instance.")]
        public string InstanceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order (`sortOrder`). Default order for `TIMECREATED` is descending.

**Note:** In general, some ""List"" operations (for example, `ListInstances`) let you optionally filter by availability domain if the scope of the resource type is within a single availability domain. If you call one of these ""List"" operations without specifying an availability domain, the resources are grouped by availability domain, then sorted.")]
        public System.Nullable<Oci.ComputeinstanceagentService.Requests.ListInstanceAgentCommandExecutionsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`). The `DISPLAYNAME` sort order is case sensitive.")]
        public System.Nullable<Oci.ComputeinstanceagentService.Requests.ListInstanceAgentCommandExecutionsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to only return resources that match the given lifecycle state. The state value is case-insensitive.")]
        public System.Nullable<Oci.ComputeinstanceagentService.Models.InstanceAgentCommandExecutionSummary.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListInstanceAgentCommandExecutionsRequest request;

            try
            {
                request = new ListInstanceAgentCommandExecutionsRequest
                {
                    CompartmentId = CompartmentId,
                    InstanceId = InstanceId,
                    OpcRequestId = OpcRequestId,
                    Page = Page,
                    Limit = Limit,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    LifecycleState = LifecycleState
                };
                IEnumerable<ListInstanceAgentCommandExecutionsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListInstanceAgentCommandExecutionsResponse> DefaultRequest(ListInstanceAgentCommandExecutionsRequest request) => Enumerable.Repeat(client.ListInstanceAgentCommandExecutions(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListInstanceAgentCommandExecutionsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListInstanceAgentCommandExecutionsResponse response;
        private delegate IEnumerable<ListInstanceAgentCommandExecutionsResponse> RequestDelegate(ListInstanceAgentCommandExecutionsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
