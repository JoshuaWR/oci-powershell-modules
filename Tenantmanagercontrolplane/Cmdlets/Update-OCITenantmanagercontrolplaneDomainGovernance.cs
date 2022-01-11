/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.TenantmanagercontrolplaneService.Requests;
using Oci.TenantmanagercontrolplaneService.Responses;
using Oci.TenantmanagercontrolplaneService.Models;

namespace Oci.TenantmanagercontrolplaneService.Cmdlets
{
    [Cmdlet("Update", "OCITenantmanagercontrolplaneDomainGovernance")]
    [OutputType(new System.Type[] { typeof(Oci.TenantmanagercontrolplaneService.Models.DomainGovernance), typeof(Oci.TenantmanagercontrolplaneService.Responses.UpdateDomainGovernanceResponse) })]
    public class UpdateOCITenantmanagercontrolplaneDomainGovernance : OCIDomainGovernanceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The domain governance OCID.")]
        public string DomainGovernanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated.")]
        public UpdateDomainGovernanceDetails UpdateDomainGovernanceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateDomainGovernanceRequest request;

            try
            {
                request = new UpdateDomainGovernanceRequest
                {
                    DomainGovernanceId = DomainGovernanceId,
                    UpdateDomainGovernanceDetails = UpdateDomainGovernanceDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateDomainGovernance(request).GetAwaiter().GetResult();
                WriteOutput(response, response.DomainGovernance);
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

        private UpdateDomainGovernanceResponse response;
    }
}
