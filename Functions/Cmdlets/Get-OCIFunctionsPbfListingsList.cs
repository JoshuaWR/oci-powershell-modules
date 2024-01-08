/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.FunctionsService.Requests;
using Oci.FunctionsService.Responses;
using Oci.FunctionsService.Models;
using Oci.Common.Model;

namespace Oci.FunctionsService.Cmdlets
{
    [Cmdlet("Get", "OCIFunctionsPbfListingsList")]
    [OutputType(new System.Type[] { typeof(Oci.FunctionsService.Models.PbfListingsCollection), typeof(Oci.FunctionsService.Responses.ListPbfListingsResponse) })]
    public class GetOCIFunctionsPbfListingsList : OCIFunctionsManagementCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"unique PbfListing identifier")]
        public string PbfListingId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire PBF name given.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that contain the supplied filter text in the PBF name given.")]
        public string NameContains { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that start with the supplied filter text in the PBF name given.")]
        public string NameStartsWith { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the service trigger sources of a PBF.")]
        public System.Collections.Generic.List<string> Trigger { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources their lifecycleState matches the given lifecycleState.")]
        public System.Nullable<Oci.FunctionsService.Models.PbfListing.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return. 1 is the minimum, 50 is the maximum.

Default: 10", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The pagination token for a list query returned by a previous operation")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies sort order.

* **ASC:** Ascending sort order. * **DESC:** Descending sort order.")]
        public System.Nullable<Oci.FunctionsService.Requests.ListPbfListingsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for name is ascending.")]
        public System.Nullable<Oci.FunctionsService.Requests.ListPbfListingsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListPbfListingsRequest request;

            try
            {
                request = new ListPbfListingsRequest
                {
                    PbfListingId = PbfListingId,
                    Name = Name,
                    NameContains = NameContains,
                    NameStartsWith = NameStartsWith,
                    Trigger = Trigger,
                    LifecycleState = LifecycleState,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListPbfListingsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.PbfListingsCollection, true);
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
            IEnumerable<ListPbfListingsResponse> DefaultRequest(ListPbfListingsRequest request) => Enumerable.Repeat(client.ListPbfListings(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListPbfListingsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListPbfListingsResponse response;
        private delegate IEnumerable<ListPbfListingsResponse> RequestDelegate(ListPbfListingsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
