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
    [Cmdlet("Get", "OCIDatabaseDbHomePatchesList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.PatchSummary), typeof(Oci.DatabaseService.Responses.ListDbHomePatchesResponse) })]
    public class GetOCIDatabaseDbHomePatchesList : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Database Home [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string DbHomeId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The pagination token to continue listing from.")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListDbHomePatchesRequest request;

            try
            {
                request = new ListDbHomePatchesRequest
                {
                    DbHomeId = DbHomeId,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListDbHomePatchesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListDbHomePatchesResponse> DefaultRequest(ListDbHomePatchesRequest request) => Enumerable.Repeat(client.ListDbHomePatches(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListDbHomePatchesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListDbHomePatchesResponse response;
        private delegate IEnumerable<ListDbHomePatchesResponse> RequestDelegate(ListDbHomePatchesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
