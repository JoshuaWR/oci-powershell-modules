/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
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
    [Cmdlet("Get", "OCILoganalyticsLabelsList")]
    [OutputType(new System.Type[] { typeof(Oci.LoganalyticsService.Models.LogAnalyticsLabelCollection), typeof(Oci.LoganalyticsService.Responses.ListLabelsResponse) })]
    public class GetOCILoganalyticsLabelsList : OCILogAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The label name used for filtering.  Only items with, or associated with, the specified label name will be returned.")]
        public string LabelName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The label display text used for filtering.  Only labels with the specified name or description will be returned.")]
        public string LabelDisplayText { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The system value used for filtering.  Only items with the specified system value will be returned.  Valid values are built in, custom (for user defined items), or all (for all items, regardless of system value).")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListLabelsRequest.IsSystemEnum> IsSystem { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The label priority used for filtering.  Only labels with the specified priority will be returned.")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListLabelsRequest.LabelPriorityEnum> LabelPriority { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A flag indicating whether or not to count the label usage per source and per rule.")]
        public System.Nullable<bool> IsCountPop { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A flag indicating whether or not return the aliases used by each label.")]
        public System.Nullable<bool> IsAliasPop { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListLabelsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The attribute used to sort the returned labels")]
        public System.Nullable<Oci.LoganalyticsService.Requests.ListLabelsRequest.LabelSortByEnum> LabelSortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListLabelsRequest request;

            try
            {
                request = new ListLabelsRequest
                {
                    NamespaceName = NamespaceName,
                    LabelName = LabelName,
                    LabelDisplayText = LabelDisplayText,
                    IsSystem = IsSystem,
                    LabelPriority = LabelPriority,
                    IsCountPop = IsCountPop,
                    IsAliasPop = IsAliasPop,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    LabelSortBy = LabelSortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListLabelsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.LogAnalyticsLabelCollection, true);
                }
                if(!ParameterSetName.Equals(AllPageSet) && !ParameterSetName.Equals(LimitSet) && response.OpcNextPage != null)
                {
                    WriteWarning("This operation supports pagination and not all resources were returned. Re-run using the -All option to auto paginate and list all resources.");
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
            IEnumerable<ListLabelsResponse> DefaultRequest(ListLabelsRequest request) => Enumerable.Repeat(client.ListLabels(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListLabelsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListLabelsResponse response;
        private delegate IEnumerable<ListLabelsResponse> RequestDelegate(ListLabelsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
