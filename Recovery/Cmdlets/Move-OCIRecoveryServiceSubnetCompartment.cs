/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210216
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.RecoveryService.Requests;
using Oci.RecoveryService.Responses;
using Oci.RecoveryService.Models;
using Oci.Common.Model;

namespace Oci.RecoveryService.Cmdlets
{
    [Cmdlet("Move", "OCIRecoveryServiceSubnetCompartment")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.RecoveryService.Responses.ChangeRecoveryServiceSubnetCompartmentResponse) })]
    public class MoveOCIRecoveryServiceSubnetCompartment : OCIDatabaseRecoveryCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The recovery service subnet OCID.")]
        public string RecoveryServiceSubnetId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The configuration details required to move a Recovery Service subnet from the existing compartment to a specified compartment.")]
        public ChangeRecoveryServiceSubnetCompartmentDetails ChangeRecoveryServiceSubnetCompartmentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeRecoveryServiceSubnetCompartmentRequest request;

            try
            {
                request = new ChangeRecoveryServiceSubnetCompartmentRequest
                {
                    RecoveryServiceSubnetId = RecoveryServiceSubnetId,
                    ChangeRecoveryServiceSubnetCompartmentDetails = ChangeRecoveryServiceSubnetCompartmentDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.ChangeRecoveryServiceSubnetCompartment(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private ChangeRecoveryServiceSubnetCompartmentResponse response;
    }
}
