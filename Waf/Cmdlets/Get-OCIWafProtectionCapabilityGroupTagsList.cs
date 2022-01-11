/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210930
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.WafService.Requests;
using Oci.WafService.Responses;
using Oci.WafService.Models;

namespace Oci.WafService.Cmdlets
{
    [Cmdlet("Get", "OCIWafProtectionCapabilityGroupTagsList")]
    [OutputType(new System.Type[] { typeof(Oci.WafService.Models.ProtectionCapabilityGroupTagCollection), typeof(Oci.WafService.Responses.ListProtectionCapabilityGroupTagsResponse) })]
    public class GetOCIWafProtectionCapabilityGroupTagsList : OCIWafCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that matches given type.")]
        public System.Nullable<Oci.WafService.Models.ProtectionCapabilitySummary.TypeEnum> Type { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.WafService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for name is ascending. If no value is specified name is default.")]
        public System.Nullable<Oci.WafService.Requests.ListProtectionCapabilityGroupTagsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire name given.")]
        public string Name { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListProtectionCapabilityGroupTagsRequest request;

            try
            {
                request = new ListProtectionCapabilityGroupTagsRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    Page = Page,
                    Limit = Limit,
                    Type = Type,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    Name = Name
                };
                IEnumerable<ListProtectionCapabilityGroupTagsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.ProtectionCapabilityGroupTagCollection, true);
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
            IEnumerable<ListProtectionCapabilityGroupTagsResponse> DefaultRequest(ListProtectionCapabilityGroupTagsRequest request) => Enumerable.Repeat(client.ListProtectionCapabilityGroupTags(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListProtectionCapabilityGroupTagsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListProtectionCapabilityGroupTagsResponse response;
        private delegate IEnumerable<ListProtectionCapabilityGroupTagsResponse> RequestDelegate(ListProtectionCapabilityGroupTagsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
