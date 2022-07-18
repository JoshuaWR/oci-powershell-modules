/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.MediaservicesService.Requests;
using Oci.MediaservicesService.Responses;
using Oci.MediaservicesService.Models;
using Oci.Common.Model;

namespace Oci.MediaservicesService.Cmdlets
{
    [Cmdlet("Get", "OCIMediaservicesStreamDistributionChannelsList")]
    [OutputType(new System.Type[] { typeof(Oci.MediaservicesService.Models.StreamDistributionChannelCollection), typeof(Oci.MediaservicesService.Responses.ListStreamDistributionChannelsResponse) })]
    public class GetOCIMediaservicesStreamDistributionChannelsList : OCIMediaServicesCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Stream Distribution Channel identifier.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources with lifecycleState matching the given lifecycleState.")]
        public System.Nullable<Oci.MediaservicesService.Models.StreamDistributionChannel.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the entire display name given.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.MediaservicesService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.")]
        public System.Nullable<Oci.MediaservicesService.Models.SortBy> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListStreamDistributionChannelsRequest request;

            try
            {
                request = new ListStreamDistributionChannelsRequest
                {
                    CompartmentId = CompartmentId,
                    Id = Id,
                    LifecycleState = LifecycleState,
                    DisplayName = DisplayName,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    Page = Page,
                    Limit = Limit,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListStreamDistributionChannelsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.StreamDistributionChannelCollection, true);
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
            IEnumerable<ListStreamDistributionChannelsResponse> DefaultRequest(ListStreamDistributionChannelsRequest request) => Enumerable.Repeat(client.ListStreamDistributionChannels(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListStreamDistributionChannelsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListStreamDistributionChannelsResponse response;
        private delegate IEnumerable<ListStreamDistributionChannelsResponse> RequestDelegate(ListStreamDistributionChannelsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
