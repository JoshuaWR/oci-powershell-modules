/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220504
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.GovernancerulescontrolplaneService.Requests;
using Oci.GovernancerulescontrolplaneService.Responses;
using Oci.GovernancerulescontrolplaneService.Models;
using Oci.Common.Model;

namespace Oci.GovernancerulescontrolplaneService.Cmdlets
{
    [Cmdlet("Get", "OCIGovernancerulescontrolplaneGovernanceRulesList")]
    [OutputType(new System.Type[] { typeof(Oci.GovernancerulescontrolplaneService.Models.GovernanceRuleCollection), typeof(Oci.GovernancerulescontrolplaneService.Responses.ListGovernanceRulesResponse) })]
    public class GetOCIGovernancerulescontrolplaneGovernanceRulesList : OCIGovernanceRuleCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique governance rule identifier.")]
        public string GovernanceRuleId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources whose lifecycle state matches the given lifecycle state.")]
        public System.Nullable<Oci.GovernancerulescontrolplaneService.Models.GovernanceRuleLifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire name given.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the type given.")]
        public System.Nullable<Oci.GovernancerulescontrolplaneService.Models.GovernanceRuleType> GovernanceRuleType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.GovernancerulescontrolplaneService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.")]
        public System.Nullable<Oci.GovernancerulescontrolplaneService.Requests.ListGovernanceRulesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListGovernanceRulesRequest request;

            try
            {
                request = new ListGovernanceRulesRequest
                {
                    CompartmentId = CompartmentId,
                    GovernanceRuleId = GovernanceRuleId,
                    LifecycleState = LifecycleState,
                    DisplayName = DisplayName,
                    GovernanceRuleType = GovernanceRuleType,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListGovernanceRulesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.GovernanceRuleCollection, true);
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
            IEnumerable<ListGovernanceRulesResponse> DefaultRequest(ListGovernanceRulesRequest request) => Enumerable.Repeat(client.ListGovernanceRules(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListGovernanceRulesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListGovernanceRulesResponse response;
        private delegate IEnumerable<ListGovernanceRulesResponse> RequestDelegate(ListGovernanceRulesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
