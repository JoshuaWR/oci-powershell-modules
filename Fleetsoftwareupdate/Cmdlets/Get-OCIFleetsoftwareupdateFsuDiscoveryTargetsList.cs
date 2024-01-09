/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220528
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.FleetsoftwareupdateService.Requests;
using Oci.FleetsoftwareupdateService.Responses;
using Oci.FleetsoftwareupdateService.Models;
using Oci.Common.Model;

namespace Oci.FleetsoftwareupdateService.Cmdlets
{
    [Cmdlet("Get", "OCIFleetsoftwareupdateFsuDiscoveryTargetsList")]
    [OutputType(new System.Type[] { typeof(Oci.FleetsoftwareupdateService.Models.TargetSummaryCollection), typeof(Oci.FleetsoftwareupdateService.Responses.ListFsuDiscoveryTargetsResponse) })]
    public class GetOCIFleetsoftwareupdateFsuDiscoveryTargetsList : OCIFleetSoftwareUpdateCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Exadata Fleet Update Discovery identifier.")]
        public string FsuDiscoveryId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return a resource whose target OCID matches the given OCID.")]
        public string TargetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only entries whose status matches the given status.")]
        public System.Nullable<Oci.FleetsoftwareupdateService.Requests.ListFsuDiscoveryTargetsRequest.StatusEnum> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.FleetsoftwareupdateService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided.")]
        public System.Nullable<Oci.FleetsoftwareupdateService.Requests.ListFsuDiscoveryTargetsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListFsuDiscoveryTargetsRequest request;

            try
            {
                request = new ListFsuDiscoveryTargetsRequest
                {
                    FsuDiscoveryId = FsuDiscoveryId,
                    CompartmentId = CompartmentId,
                    TargetId = TargetId,
                    Status = Status,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListFsuDiscoveryTargetsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.TargetSummaryCollection, true);
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
            IEnumerable<ListFsuDiscoveryTargetsResponse> DefaultRequest(ListFsuDiscoveryTargetsRequest request) => Enumerable.Repeat(client.ListFsuDiscoveryTargets(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListFsuDiscoveryTargetsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListFsuDiscoveryTargetsResponse response;
        private delegate IEnumerable<ListFsuDiscoveryTargetsResponse> RequestDelegate(ListFsuDiscoveryTargetsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
