/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ApmsyntheticsService.Requests;
using Oci.ApmsyntheticsService.Responses;
using Oci.ApmsyntheticsService.Models;
using Oci.Common.Model;

namespace Oci.ApmsyntheticsService.Cmdlets
{
    [Cmdlet("Get", "OCIApmsyntheticsOnPremiseVantagePointsList")]
    [OutputType(new System.Type[] { typeof(Oci.ApmsyntheticsService.Models.OnPremiseVantagePointCollection), typeof(Oci.ApmsyntheticsService.Responses.ListOnPremiseVantagePointsResponse) })]
    public class GetOCIApmsyntheticsOnPremiseVantagePointsList : OCIApmSyntheticCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The APM domain ID the request is intended for.")]
        public string ApmDomainId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of results per page, or items to return in a paginated ""List"" call. For information on how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `50`")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`). Default sort order is ascending.")]
        public System.Nullable<Oci.ApmsyntheticsService.Models.SortOrders> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order of displayName is ascending. Default order of timeCreated and timeUpdated is descending. The displayName sort by is case-sensitive.")]
        public System.Nullable<Oci.ApmsyntheticsService.Requests.ListOnPremiseVantagePointsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the entire display name.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the entire name.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListOnPremiseVantagePointsRequest request;

            try
            {
                request = new ListOnPremiseVantagePointsRequest
                {
                    ApmDomainId = ApmDomainId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    DisplayName = DisplayName,
                    Name = Name,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListOnPremiseVantagePointsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.OnPremiseVantagePointCollection, true);
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
            IEnumerable<ListOnPremiseVantagePointsResponse> DefaultRequest(ListOnPremiseVantagePointsRequest request) => Enumerable.Repeat(client.ListOnPremiseVantagePoints(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListOnPremiseVantagePointsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListOnPremiseVantagePointsResponse response;
        private delegate IEnumerable<ListOnPremiseVantagePointsResponse> RequestDelegate(ListOnPremiseVantagePointsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
