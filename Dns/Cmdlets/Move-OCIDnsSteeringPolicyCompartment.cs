/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;
using Oci.DnsService.Models;

namespace Oci.DnsService.Cmdlets
{
    [Cmdlet("Move", "OCIDnsSteeringPolicyCompartment")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.DnsService.Responses.ChangeSteeringPolicyCompartmentResponse) })]
    public class MoveOCIDnsSteeringPolicyCompartment : OCIDnsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the target steering policy.")]
        public string SteeringPolicyId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for moving a steering policy into a different compartment.")]
        public ChangeSteeringPolicyCompartmentDetails ChangeSteeringPolicyCompartmentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-Match` header field makes the request method conditional on the existence of at least one current representation of the target resource, when the field-value is `*`, or having a current representation of the target resource that has an entity-tag matching a member of the list of entity-tags provided in the field-value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.")]
        public System.Nullable<Oci.DnsService.Models.Scope> Scope { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeSteeringPolicyCompartmentRequest request;

            try
            {
                request = new ChangeSteeringPolicyCompartmentRequest
                {
                    SteeringPolicyId = SteeringPolicyId,
                    ChangeSteeringPolicyCompartmentDetails = ChangeSteeringPolicyCompartmentDetails,
                    IfMatch = IfMatch,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId,
                    Scope = Scope
                };

                response = client.ChangeSteeringPolicyCompartment(request).GetAwaiter().GetResult();
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

        private ChangeSteeringPolicyCompartmentResponse response;
    }
}
