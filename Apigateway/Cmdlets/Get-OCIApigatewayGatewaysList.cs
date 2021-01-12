/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ApigatewayService.Requests;
using Oci.ApigatewayService.Responses;
using Oci.ApigatewayService.Models;

namespace Oci.ApigatewayService.Cmdlets
{
    [Cmdlet("Get", "OCIApigatewayGatewaysList")]
    [OutputType(new System.Type[] { typeof(Oci.ApigatewayService.Models.GatewayCollection), typeof(Oci.ApigatewayService.Responses.ListGatewaysResponse) })]
    public class GetOCIApigatewayGatewaysList : OCIGatewayCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ocid of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter gateways by the certificate ocid.")]
        public string CertificateId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A user-friendly name. Does not have to be unique, and it's changeable.

Example: `My new resource`")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given lifecycle state.

Example: `SUCCEEDED`")]
        public System.Nullable<Oci.ApigatewayService.Models.Gateway.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'. The default order depends on the sortBy value.")]
        public System.Nullable<Oci.ApigatewayService.Requests.ListGatewaysRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order (`sortOrder`). Default order for `timeCreated` is descending. Default order for `displayName` is ascending. The `displayName` sort order is case sensitive.")]
        public System.Nullable<Oci.ApigatewayService.Requests.ListGatewaysRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request id for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListGatewaysRequest request;

            try
            {
                request = new ListGatewaysRequest
                {
                    CompartmentId = CompartmentId,
                    CertificateId = CertificateId,
                    DisplayName = DisplayName,
                    LifecycleState = LifecycleState,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListGatewaysResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.GatewayCollection, true);
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
            IEnumerable<ListGatewaysResponse> DefaultRequest(ListGatewaysRequest request) => Enumerable.Repeat(client.ListGateways(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListGatewaysResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListGatewaysResponse response;
        private delegate IEnumerable<ListGatewaysResponse> RequestDelegate(ListGatewaysRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
