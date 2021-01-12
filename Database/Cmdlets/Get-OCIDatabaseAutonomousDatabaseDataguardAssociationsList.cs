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
    [Cmdlet("Get", "OCIDatabaseAutonomousDatabaseDataguardAssociationsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.AutonomousDatabaseDataguardAssociation), typeof(Oci.DatabaseService.Responses.ListAutonomousDatabaseDataguardAssociationsResponse) })]
    public class GetOCIDatabaseAutonomousDatabaseDataguardAssociationsList : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string AutonomousDatabaseId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The pagination token to continue listing from.")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAutonomousDatabaseDataguardAssociationsRequest request;

            try
            {
                request = new ListAutonomousDatabaseDataguardAssociationsRequest
                {
                    AutonomousDatabaseId = AutonomousDatabaseId,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListAutonomousDatabaseDataguardAssociationsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListAutonomousDatabaseDataguardAssociationsResponse> DefaultRequest(ListAutonomousDatabaseDataguardAssociationsRequest request) => Enumerable.Repeat(client.ListAutonomousDatabaseDataguardAssociations(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListAutonomousDatabaseDataguardAssociationsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListAutonomousDatabaseDataguardAssociationsResponse response;
        private delegate IEnumerable<ListAutonomousDatabaseDataguardAssociationsResponse> RequestDelegate(ListAutonomousDatabaseDataguardAssociationsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
