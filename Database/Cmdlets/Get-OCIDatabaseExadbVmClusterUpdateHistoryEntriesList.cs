/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;
using Oci.Common.Model;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabaseExadbVmClusterUpdateHistoryEntriesList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.ExadbVmClusterUpdateHistoryEntrySummary), typeof(Oci.DatabaseService.Responses.ListExadbVmClusterUpdateHistoryEntriesResponse) })]
    public class GetOCIDatabaseExadbVmClusterUpdateHistoryEntriesList : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Exadata VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) on Exascale Infrastructure.")]
        public string ExadbVmClusterId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given update type exactly.")]
        public System.Nullable<Oci.DatabaseService.Requests.ListExadbVmClusterUpdateHistoryEntriesRequest.UpdateTypeEnum> UpdateType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The pagination token to continue listing from.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListExadbVmClusterUpdateHistoryEntriesRequest request;

            try
            {
                request = new ListExadbVmClusterUpdateHistoryEntriesRequest
                {
                    ExadbVmClusterId = ExadbVmClusterId,
                    UpdateType = UpdateType,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListExadbVmClusterUpdateHistoryEntriesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListExadbVmClusterUpdateHistoryEntriesResponse> DefaultRequest(ListExadbVmClusterUpdateHistoryEntriesRequest request) => Enumerable.Repeat(client.ListExadbVmClusterUpdateHistoryEntries(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListExadbVmClusterUpdateHistoryEntriesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListExadbVmClusterUpdateHistoryEntriesResponse response;
        private delegate IEnumerable<ListExadbVmClusterUpdateHistoryEntriesResponse> RequestDelegate(ListExadbVmClusterUpdateHistoryEntriesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
