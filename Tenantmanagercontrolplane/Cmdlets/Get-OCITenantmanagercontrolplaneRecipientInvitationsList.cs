/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.TenantmanagercontrolplaneService.Requests;
using Oci.TenantmanagercontrolplaneService.Responses;
using Oci.TenantmanagercontrolplaneService.Models;

namespace Oci.TenantmanagercontrolplaneService.Cmdlets
{
    [Cmdlet("Get", "OCITenantmanagercontrolplaneRecipientInvitationsList")]
    [OutputType(new System.Type[] { typeof(Oci.TenantmanagercontrolplaneService.Models.RecipientInvitationCollection), typeof(Oci.TenantmanagercontrolplaneService.Responses.ListRecipientInvitationsResponse) })]
    public class GetOCITenantmanagercontrolplaneRecipientInvitationsList : OCIRecipientInvitationCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The tenancy that sent the invitation.")]
        public string SenderTenancyId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The lifecycle state of the resource.")]
        public System.Nullable<Oci.TenantmanagercontrolplaneService.Models.LifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The status of the recipient invitation.")]
        public System.Nullable<Oci.TenantmanagercontrolplaneService.Models.RecipientInvitationStatus> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListRecipientInvitationsRequest request;

            try
            {
                request = new ListRecipientInvitationsRequest
                {
                    CompartmentId = CompartmentId,
                    SenderTenancyId = SenderTenancyId,
                    LifecycleState = LifecycleState,
                    Status = Status,
                    OpcRequestId = OpcRequestId,
                    Page = Page
                };
                IEnumerable<ListRecipientInvitationsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.RecipientInvitationCollection, true);
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
            IEnumerable<ListRecipientInvitationsResponse> DefaultRequest(ListRecipientInvitationsRequest request) => Enumerable.Repeat(client.ListRecipientInvitations(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListRecipientInvitationsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListRecipientInvitationsResponse response;
        private delegate IEnumerable<ListRecipientInvitationsResponse> RequestDelegate(ListRecipientInvitationsRequest request);
        private const string AllPageSet = "AllPages";
    }
}
