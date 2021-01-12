/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabaseVmClusterPatchHistoryEntriesList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.PatchHistoryEntrySummary), typeof(Oci.DatabaseService.Responses.ListVmClusterPatchHistoryEntriesResponse) })]
    public class GetOCIDatabaseVmClusterPatchHistoryEntriesList : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string VmClusterId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The pagination token to continue listing from.")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListVmClusterPatchHistoryEntriesRequest request;

            try
            {
                request = new ListVmClusterPatchHistoryEntriesRequest
                {
                    VmClusterId = VmClusterId,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListVmClusterPatchHistoryEntriesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
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
            IEnumerable<ListVmClusterPatchHistoryEntriesResponse> DefaultRequest(ListVmClusterPatchHistoryEntriesRequest request) => Enumerable.Repeat(client.ListVmClusterPatchHistoryEntries(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListVmClusterPatchHistoryEntriesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListVmClusterPatchHistoryEntriesResponse response;
        private delegate IEnumerable<ListVmClusterPatchHistoryEntriesResponse> RequestDelegate(ListVmClusterPatchHistoryEntriesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
