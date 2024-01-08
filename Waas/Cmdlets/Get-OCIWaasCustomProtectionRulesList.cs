/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181116
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.WaasService.Requests;
using Oci.WaasService.Responses;
using Oci.WaasService.Models;
using Oci.Common.Model;

namespace Oci.WaasService.Cmdlets
{
    [Cmdlet("Get", "OCIWaasCustomProtectionRulesList")]
    [OutputType(new System.Type[] { typeof(Oci.WaasService.Models.CustomProtectionRuleSummary), typeof(Oci.WaasService.Responses.ListCustomProtectionRulesResponse) })]
    public class GetOCIWaasCustomProtectionRulesList : OCIWaasCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment. This number is generated when the compartment is created.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated call. If unspecified, defaults to `10`.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous paginated call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value by which custom protection rules are sorted in a paginated 'List' call. If unspecified, defaults to `timeCreated`.")]
        public System.Nullable<Oci.WaasService.Requests.ListCustomProtectionRulesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the sorting direction of resources in a paginated 'List' call. If unspecified, defaults to `DESC`.")]
        public System.Nullable<Oci.WaasService.Requests.ListCustomProtectionRulesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter custom protection rules using a list of custom protection rule OCIDs.")]
        public System.Collections.Generic.List<string> Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter custom protection rules using a list of display names.")]
        public System.Collections.Generic.List<string> DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter Custom Protection rules using a list of lifecycle states.")]
        public System.Collections.Generic.List<Oci.WaasService.Models.LifecycleStates> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter that matches Custom Protection rules created on or after the specified date-time.")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter that matches custom protection rules created before the specified date-time.")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListCustomProtectionRulesRequest request;

            try
            {
                request = new ListCustomProtectionRulesRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    Id = Id,
                    DisplayName = DisplayName,
                    LifecycleState = LifecycleState,
                    TimeCreatedGreaterThanOrEqualTo = TimeCreatedGreaterThanOrEqualTo,
                    TimeCreatedLessThan = TimeCreatedLessThan
                };
                IEnumerable<ListCustomProtectionRulesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListCustomProtectionRulesResponse> DefaultRequest(ListCustomProtectionRulesRequest request) => Enumerable.Repeat(client.ListCustomProtectionRules(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListCustomProtectionRulesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListCustomProtectionRulesResponse response;
        private delegate IEnumerable<ListCustomProtectionRulesResponse> RequestDelegate(ListCustomProtectionRulesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
