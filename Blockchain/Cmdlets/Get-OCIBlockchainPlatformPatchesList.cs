/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20191010
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
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
    [Cmdlet("Get", "OCIBlockchainPlatformPatchesList")]
    [OutputType(new System.Type[] { typeof(Oci.BlockchainService.Models.BlockchainPlatformPatchCollection), typeof(Oci.BlockchainService.Responses.ListBlockchainPlatformPatchesResponse) })]
    public class GetOCIBlockchainPlatformPatchesList : OCIBlockchainPlatformCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique service identifier.")]
        public string BlockchainPlatformId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page at which to start retrieving results.")]
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
            ListBlockchainPlatformPatchesRequest request;

            try
            {
                request = new ListBlockchainPlatformPatchesRequest
                {
                    BlockchainPlatformId = BlockchainPlatformId,
                    Page = Page,
                    Limit = Limit,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListBlockchainPlatformPatchesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.BlockchainPlatformPatchCollection, true);
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
            IEnumerable<ListBlockchainPlatformPatchesResponse> DefaultRequest(ListBlockchainPlatformPatchesRequest request) => Enumerable.Repeat(client.ListBlockchainPlatformPatches(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListBlockchainPlatformPatchesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListBlockchainPlatformPatchesResponse response;
        private delegate IEnumerable<ListBlockchainPlatformPatchesResponse> RequestDelegate(ListBlockchainPlatformPatchesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
