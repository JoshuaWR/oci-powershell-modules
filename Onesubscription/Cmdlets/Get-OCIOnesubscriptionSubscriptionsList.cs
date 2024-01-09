/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190111
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OnesubscriptionService.Requests;
using Oci.OnesubscriptionService.Responses;
using Oci.OnesubscriptionService.Models;
using Oci.Common.Model;

namespace Oci.OnesubscriptionService.Cmdlets
{
    [Cmdlet("Get", "OCIOnesubscriptionSubscriptionsList")]
    [OutputType(new System.Type[] { typeof(Oci.OnesubscriptionService.Models.SubscriptionSummary), typeof(Oci.OnesubscriptionService.Responses.ListSubscriptionsResponse) })]
    public class GetOCIOnesubscriptionSubscriptionsList : OCISubscriptionCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the root compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Plan Number")]
        public string PlanNumber { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Line level Subscription Id")]
        public string SubscriptionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Buyer Email Id")]
        public string BuyerEmail { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Boolean value to decide whether commitment services will be shown")]
        public System.Nullable<bool> IsCommitInfoRequired { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call. Default: (`50`)

Example: '500'", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the 'opc-next-page' response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending ('ASC') or descending ('DESC').")]
        public System.Nullable<Oci.OnesubscriptionService.Requests.ListSubscriptionsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order ('sortOrder').")]
        public System.Nullable<Oci.OnesubscriptionService.Requests.ListSubscriptionsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSubscriptionsRequest request;

            try
            {
                request = new ListSubscriptionsRequest
                {
                    CompartmentId = CompartmentId,
                    PlanNumber = PlanNumber,
                    SubscriptionId = SubscriptionId,
                    BuyerEmail = BuyerEmail,
                    IsCommitInfoRequired = IsCommitInfoRequired,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListSubscriptionsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListSubscriptionsResponse> DefaultRequest(ListSubscriptionsRequest request) => Enumerable.Repeat(client.ListSubscriptions(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSubscriptionsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSubscriptionsResponse response;
        private delegate IEnumerable<ListSubscriptionsResponse> RequestDelegate(ListSubscriptionsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
