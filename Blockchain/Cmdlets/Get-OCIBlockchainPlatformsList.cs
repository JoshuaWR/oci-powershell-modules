/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20191010
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.BlockchainService.Requests;
using Oci.BlockchainService.Responses;
using Oci.BlockchainService.Models;

namespace Oci.BlockchainService.Cmdlets
{
    [Cmdlet("Get", "OCIBlockchainPlatformsList")]
    [OutputType(new System.Type[] { typeof(Oci.BlockchainService.Models.BlockchainPlatformCollection), typeof(Oci.BlockchainService.Responses.ListBlockchainPlatformsResponse) })]
    public class GetOCIBlockchainPlatformsList : OCIBlockchainPlatformCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A user-friendly name. Does not have to be unique, and it's changeable. Example: `My new resource`")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page at which to start retrieving results.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.BlockchainService.Requests.ListBlockchainPlatformsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for TIMECREATED is descending. Default order for DISPLAYNAME is ascending. If no value is specified TIMECREATED is default.")]
        public System.Nullable<Oci.BlockchainService.Requests.ListBlockchainPlatformsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to only return resources that match the given lifecycle state. The state value is case-insensitive.")]
        public System.Nullable<Oci.BlockchainService.Models.BlockchainPlatform.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListBlockchainPlatformsRequest request;

            try
            {
                request = new ListBlockchainPlatformsRequest
                {
                    CompartmentId = CompartmentId,
                    DisplayName = DisplayName,
                    Page = Page,
                    Limit = Limit,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId,
                    LifecycleState = LifecycleState
                };
                IEnumerable<ListBlockchainPlatformsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.BlockchainPlatformCollection, true);
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
            IEnumerable<ListBlockchainPlatformsResponse> DefaultRequest(ListBlockchainPlatformsRequest request) => Enumerable.Repeat(client.ListBlockchainPlatforms(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListBlockchainPlatformsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListBlockchainPlatformsResponse response;
        private delegate IEnumerable<ListBlockchainPlatformsResponse> RequestDelegate(ListBlockchainPlatformsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
