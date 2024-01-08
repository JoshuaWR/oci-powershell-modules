/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OsubsubscriptionService.Requests;
using Oci.OsubsubscriptionService.Responses;
using Oci.OsubsubscriptionService.Models;
using Oci.Common.Model;

namespace Oci.OsubsubscriptionService.Cmdlets
{
    [Cmdlet("Get", "OCIOsubsubscriptionCommitmentsList")]
    [OutputType(new System.Type[] { typeof(Oci.OsubsubscriptionService.Models.CommitmentSummary), typeof(Oci.OsubsubscriptionService.Responses.ListCommitmentsResponse) })]
    public class GetOCIOsubsubscriptionCommitmentsList : OCICommitmentCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"This param is used to get the commitments for a particular subscribed service")]
        public string SubscribedServiceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call. Default: (`50`)

Example: `500`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.OsubsubscriptionService.Requests.ListCommitmentsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order (`sortOrder`).")]
        public System.Nullable<Oci.OsubsubscriptionService.Requests.ListCommitmentsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"This header is meant to be used only for internal purposes and will be ignored on any public request. The purpose of this header is to help on Gateway to API calls identification.")]
        public string XOneGatewaySubscriptionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCI home region name in case home region is not us-ashburn-1 (IAD), e.g. ap-mumbai-1, us-phoenix-1 etc.")]
        public string XOneOriginRegion { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListCommitmentsRequest request;

            try
            {
                request = new ListCommitmentsRequest
                {
                    SubscribedServiceId = SubscribedServiceId,
                    CompartmentId = CompartmentId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId,
                    XOneGatewaySubscriptionId = XOneGatewaySubscriptionId,
                    XOneOriginRegion = XOneOriginRegion
                };
                IEnumerable<ListCommitmentsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListCommitmentsResponse> DefaultRequest(ListCommitmentsRequest request) => Enumerable.Repeat(client.ListCommitments(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListCommitmentsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListCommitmentsResponse response;
        private delegate IEnumerable<ListCommitmentsResponse> RequestDelegate(ListCommitmentsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
