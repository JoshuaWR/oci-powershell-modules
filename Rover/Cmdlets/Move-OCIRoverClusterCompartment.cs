/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201210
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;
using Oci.RoverService.Models;

namespace Oci.RoverService.Cmdlets
{
    [Cmdlet("Move", "OCIRoverClusterCompartment")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.RoverService.Responses.ChangeRoverClusterCompartmentResponse) })]
    public class MoveOCIRoverClusterCompartment : OCIRoverClusterCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique RoverCluster identifier")]
        public string RoverClusterId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"CompartmentId of the destination compartment")]
        public ChangeRoverClusterCompartmentDetails ChangeRoverClusterCompartmentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeRoverClusterCompartmentRequest request;

            try
            {
                request = new ChangeRoverClusterCompartmentRequest
                {
                    RoverClusterId = RoverClusterId,
                    ChangeRoverClusterCompartmentDetails = ChangeRoverClusterCompartmentDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.ChangeRoverClusterCompartment(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private ChangeRoverClusterCompartmentResponse response;
    }
}
