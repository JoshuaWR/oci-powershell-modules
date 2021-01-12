/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190111
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.BudgetService.Requests;
using Oci.BudgetService.Responses;
using Oci.BudgetService.Models;

namespace Oci.BudgetService.Cmdlets
{
    [Cmdlet("Get", "OCIBudgetAlertRulesList")]
    [OutputType(new System.Type[] { typeof(Oci.BudgetService.Models.AlertRuleSummary), typeof(Oci.BudgetService.Responses.ListAlertRulesResponse) })]
    public class GetOCIBudgetAlertRulesList : OCIBudgetCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Budget OCID")]
        public string BudgetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.BudgetService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. If not specified, the default is timeCreated. The default sort order for timeCreated is DESC. The default sort order for displayName is ASC in alphanumeric order.")]
        public System.Nullable<Oci.BudgetService.Models.SortBy> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The current state of the resource to filter by.")]
        public System.Nullable<Oci.BudgetService.Models.LifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A user-friendly name. Does not have to be unique, and it's changeable.

Example: `My new resource`")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAlertRulesRequest request;

            try
            {
                request = new ListAlertRulesRequest
                {
                    BudgetId = BudgetId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    LifecycleState = LifecycleState,
                    DisplayName = DisplayName,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListAlertRulesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListAlertRulesResponse> DefaultRequest(ListAlertRulesRequest request) => Enumerable.Repeat(client.ListAlertRules(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListAlertRulesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListAlertRulesResponse response;
        private delegate IEnumerable<ListAlertRulesResponse> RequestDelegate(ListAlertRulesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
