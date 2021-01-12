/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.LoganalyticsService.Requests;
using Oci.LoganalyticsService.Responses;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Cmdlets
{
    [Cmdlet("Get", "OCILoganalyticsEntityAssociationsList")]
    [OutputType(new System.Type[] { typeof(Oci.LoganalyticsService.Models.LogAnalyticsEntityCollection), typeof(Oci.LoganalyticsService.Responses.ListEntityAssociationsResponse) })]
    public class GetOCILoganalyticsEntityAssociationsList : OCILogAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The log analytics entity OCID.")]
        public string LogAnalyticsEntityId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Indicates whether to return direct associated entities or direct and inferred associated entities.")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListEntityAssociationsRequest.DirectOrAllAssociationsEnum> DirectOrAllAssociations { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListEntityAssociationsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort entities by. Only one sort order may be provided. Default order for timeCreated and timeUpdated is descending. Default order for entity name is ascending. If no value is specified timeCreated is default.")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListEntityAssociationsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListEntityAssociationsRequest request;

            try
            {
                request = new ListEntityAssociationsRequest
                {
                    NamespaceName = NamespaceName,
                    LogAnalyticsEntityId = LogAnalyticsEntityId,
                    DirectOrAllAssociations = DirectOrAllAssociations,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListEntityAssociationsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.LogAnalyticsEntityCollection, true);
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
            IEnumerable<ListEntityAssociationsResponse> DefaultRequest(ListEntityAssociationsRequest request) => Enumerable.Repeat(client.ListEntityAssociations(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListEntityAssociationsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListEntityAssociationsResponse response;
        private delegate IEnumerable<ListEntityAssociationsResponse> RequestDelegate(ListEntityAssociationsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
