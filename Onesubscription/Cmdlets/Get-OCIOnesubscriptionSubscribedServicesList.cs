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
    [Cmdlet("Get", "OCIOnesubscriptionSubscribedServicesList")]
    [OutputType(new System.Type[] { typeof(Oci.OnesubscriptionService.Models.SubscribedServiceSummary), typeof(Oci.OnesubscriptionService.Responses.ListSubscribedServicesResponse) })]
    public class GetOCIOnesubscriptionSubscribedServicesList : OCISubscribedServiceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the root compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Line level Subscription Id")]
        public string SubscriptionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Order Line identifier at subscribed service level . This identifier is originated in Order Management module. Default is null.")]
        public System.Nullable<long> OrderLineId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"This param is used to filter subscribed services based on its status")]
        public string Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call. Default: (`50`)

Example: '500'", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the 'opc-next-page' response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending ('ASC') or descending ('DESC').")]
        public System.Nullable<Oci.OnesubscriptionService.Requests.ListSubscribedServicesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order ('sortOrder').")]
        public System.Nullable<Oci.OnesubscriptionService.Requests.ListSubscribedServicesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSubscribedServicesRequest request;

            try
            {
                request = new ListSubscribedServicesRequest
                {
                    CompartmentId = CompartmentId,
                    SubscriptionId = SubscriptionId,
                    OrderLineId = OrderLineId,
                    Status = Status,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListSubscribedServicesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListSubscribedServicesResponse> DefaultRequest(ListSubscribedServicesRequest request) => Enumerable.Repeat(client.ListSubscribedServices(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSubscribedServicesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSubscribedServicesResponse response;
        private delegate IEnumerable<ListSubscribedServicesResponse> RequestDelegate(ListSubscribedServicesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
