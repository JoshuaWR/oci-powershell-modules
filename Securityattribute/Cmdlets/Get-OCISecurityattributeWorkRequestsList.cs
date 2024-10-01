/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20240815
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.SecurityattributeService.Requests;
using Oci.SecurityattributeService.Responses;
using Oci.SecurityattributeService.Models;
using Oci.Common.Model;

namespace Oci.SecurityattributeService.Cmdlets
{
    [Cmdlet("Get", "OCISecurityattributeWorkRequestsList")]
    [OutputType(new System.Type[] { typeof(Oci.SecurityattributeService.Models.SecurityAttributeWorkRequestSummary), typeof(Oci.SecurityattributeService.Responses.ListSecurityAttributeWorkRequestsResponse) })]
    public class GetOCISecurityattributeWorkRequestsList : OCISecurityAttributeCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The identifier of the resource the work request affects.")]
        public string ResourceIdentifier { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID. The only valid characters for request IDs are letters, numbers, underscore, and dash.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSecurityAttributeWorkRequestsRequest request;

            try
            {
                request = new ListSecurityAttributeWorkRequestsRequest
                {
                    CompartmentId = CompartmentId,
                    Page = Page,
                    Limit = Limit,
                    ResourceIdentifier = ResourceIdentifier,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListSecurityAttributeWorkRequestsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListSecurityAttributeWorkRequestsResponse> DefaultRequest(ListSecurityAttributeWorkRequestsRequest request) => Enumerable.Repeat(client.ListSecurityAttributeWorkRequests(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSecurityAttributeWorkRequestsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSecurityAttributeWorkRequestsResponse response;
        private delegate IEnumerable<ListSecurityAttributeWorkRequestsResponse> RequestDelegate(ListSecurityAttributeWorkRequestsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
