/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201210
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;
using Oci.RoverService.Models;
using Oci.Common.Model;

namespace Oci.RoverService.Cmdlets
{
    [Cmdlet("Update", "OCIRoverEntitlement")]
    [OutputType(new System.Type[] { typeof(Oci.RoverService.Models.RoverEntitlement), typeof(Oci.RoverService.Responses.UpdateRoverEntitlementResponse) })]
    public class UpdateOCIRoverEntitlement : OCIRoverEntitlementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"ID of the rover node or cluster entitlement")]
        public string RoverEntitlementId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated.")]
        public UpdateRoverEntitlementDetails UpdateRoverEntitlementDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateRoverEntitlementRequest request;

            try
            {
                request = new UpdateRoverEntitlementRequest
                {
                    RoverEntitlementId = RoverEntitlementId,
                    UpdateRoverEntitlementDetails = UpdateRoverEntitlementDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateRoverEntitlement(request).GetAwaiter().GetResult();
                WriteOutput(response, response.RoverEntitlement);
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

        private UpdateRoverEntitlementResponse response;
    }
}
