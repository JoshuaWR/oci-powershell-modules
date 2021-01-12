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
    [Cmdlet("Get", "OCIDatabaseAutonomousDatabaseClonesList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.AutonomousDatabaseSummary), typeof(Oci.DatabaseService.Responses.ListAutonomousDatabaseClonesResponse) })]
    public class GetOCIDatabaseAutonomousDatabaseClonesList : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string AutonomousDatabaseId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The pagination token to continue listing from.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.DatabaseService.Requests.ListAutonomousDatabaseClonesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire display name given. The match is not case sensitive.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given lifecycle state exactly.")]
        public System.Nullable<Oci.DatabaseService.Models.AutonomousDatabaseSummary.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by.  You can provide one sort order (`sortOrder`).  Default order for TIMECREATED is descending.  Default order for DISPLAYNAME is ascending. The DISPLAYNAME sort order is case sensitive.

**Note:** If you do not include the availability domain filter, the resources are grouped by availability domain, then sorted.")]
        public System.Nullable<Oci.DatabaseService.Requests.ListAutonomousDatabaseClonesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given clone type exactly.")]
        public System.Nullable<Oci.DatabaseService.Requests.ListAutonomousDatabaseClonesRequest.CloneTypeEnum> CloneType { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAutonomousDatabaseClonesRequest request;

            try
            {
                request = new ListAutonomousDatabaseClonesRequest
                {
                    CompartmentId = CompartmentId,
                    AutonomousDatabaseId = AutonomousDatabaseId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    DisplayName = DisplayName,
                    LifecycleState = LifecycleState,
                    SortBy = SortBy,
                    CloneType = CloneType
                };
                IEnumerable<ListAutonomousDatabaseClonesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListAutonomousDatabaseClonesResponse> DefaultRequest(ListAutonomousDatabaseClonesRequest request) => Enumerable.Repeat(client.ListAutonomousDatabaseClones(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListAutonomousDatabaseClonesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListAutonomousDatabaseClonesResponse response;
        private delegate IEnumerable<ListAutonomousDatabaseClonesResponse> RequestDelegate(ListAutonomousDatabaseClonesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
