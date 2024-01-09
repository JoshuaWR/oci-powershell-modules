/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200202
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ManagementagentService.Requests;
using Oci.ManagementagentService.Responses;
using Oci.ManagementagentService.Models;
using Oci.Common.Model;

namespace Oci.ManagementagentService.Cmdlets
{
    [Cmdlet("Get", "OCIManagementagentsList")]
    [OutputType(new System.Type[] { typeof(Oci.ManagementagentService.Models.ManagementAgentSummary), typeof(Oci.ManagementagentService.Responses.ListManagementAgentsResponse) })]
    public class GetOCIManagementagentsList : OCIManagementAgentCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment to which a request will be scoped.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only Management Agents having the particular Plugin installed. A special pluginName of 'None' can be provided and this will return only Management Agents having no plugin installed.")]
        public System.Collections.Generic.List<string> PluginName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only Management Agents having the particular agent version.")]
        public System.Collections.Generic.List<string> Version { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only Management Agents having the particular display name.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only Management Agents in the particular lifecycle state.")]
        public System.Nullable<Oci.ManagementagentService.Models.LifecycleStates> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only Management Agents in the particular availability status.")]
        public System.Nullable<Oci.ManagementagentService.Models.AvailabilityStatus> AvailabilityStatus { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only Management Agents having the particular agent host id.")]
        public string HostId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only results having the particular platform type.")]
        public System.Collections.Generic.List<Oci.ManagementagentService.Models.PlatformTypes> PlatformType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"true, if the agent image is manually downloaded and installed. false, if the agent is deployed as a plugin in Oracle Cloud Agent.")]
        public System.Nullable<bool> IsCustomerDeployed { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return either agents or gateway types depending upon install type selected by user. By default both install type will be returned.")]
        public System.Nullable<Oci.ManagementagentService.Models.InstallTypes> InstallType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter to return only results having the particular gatewayId.")]
        public System.Collections.Generic.List<string> GatewayId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.ManagementagentService.Requests.ListManagementAgentsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending. If no value is specified timeCreated is default.")]
        public System.Nullable<Oci.ManagementagentService.Requests.ListManagementAgentsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"if set to true then it fetches resources for all compartments where user has access to else only on the compartment specified.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"When the value is ""ACCESSIBLE"", insufficient permissions for a compartment will filter out resources in that compartment without rejecting the request.")]
        public string AccessLevel { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListManagementAgentsRequest request;

            try
            {
                request = new ListManagementAgentsRequest
                {
                    CompartmentId = CompartmentId,
                    PluginName = PluginName,
                    Version = Version,
                    DisplayName = DisplayName,
                    LifecycleState = LifecycleState,
                    AvailabilityStatus = AvailabilityStatus,
                    HostId = HostId,
                    PlatformType = PlatformType,
                    IsCustomerDeployed = IsCustomerDeployed,
                    InstallType = InstallType,
                    GatewayId = GatewayId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    AccessLevel = AccessLevel
                };
                IEnumerable<ListManagementAgentsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListManagementAgentsResponse> DefaultRequest(ListManagementAgentsRequest request) => Enumerable.Repeat(client.ListManagementAgents(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListManagementAgentsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListManagementAgentsResponse response;
        private delegate IEnumerable<ListManagementAgentsResponse> RequestDelegate(ListManagementAgentsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
