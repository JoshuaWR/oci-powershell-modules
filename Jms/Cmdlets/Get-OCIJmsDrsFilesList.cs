/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210610
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.JmsService.Requests;
using Oci.JmsService.Responses;
using Oci.JmsService.Models;
using Oci.Common.Model;

namespace Oci.JmsService.Cmdlets
{
    [Cmdlet("Get", "OCIJmsDrsFilesList")]
    [OutputType(new System.Type[] { typeof(Oci.JmsService.Models.DrsFileCollection), typeof(Oci.JmsService.Responses.ListDrsFilesResponse) })]
    public class GetOCIJmsDrsFilesList : OCIJavaManagementServiceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Fleet.")]
        public string FleetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. The token is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.JmsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field that sorts the DRS details results. Only one sort order can be provided. The default order for _drsFileKey_ is **descending**. If no value is specified, then _drsFileKey_ is default.")]
        public System.Nullable<Oci.JmsService.Models.DrsFileSortBy> SortBy { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListDrsFilesRequest request;

            try
            {
                request = new ListDrsFilesRequest
                {
                    FleetId = FleetId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy
                };
                IEnumerable<ListDrsFilesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.DrsFileCollection, true);
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
            IEnumerable<ListDrsFilesResponse> DefaultRequest(ListDrsFilesRequest request) => Enumerable.Repeat(client.ListDrsFiles(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListDrsFilesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListDrsFilesResponse response;
        private delegate IEnumerable<ListDrsFilesResponse> RequestDelegate(ListDrsFilesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
