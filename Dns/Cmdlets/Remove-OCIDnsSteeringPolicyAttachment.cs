/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;
using Oci.DnsService.Models;
using Oci.Common.Model;

namespace Oci.DnsService.Cmdlets
{
    [Cmdlet("Remove", "OCIDnsSteeringPolicyAttachment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.DnsService.Responses.DeleteSteeringPolicyAttachmentResponse) })]
    public class RemoveOCIDnsSteeringPolicyAttachment : OCIDnsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the target steering policy attachment.")]
        public string SteeringPolicyAttachmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-Match` header field makes the request method conditional on the existence of at least one current representation of the target resource, when the field-value is `*`, or having a current representation of the target resource that has an entity-tag matching a member of the list of entity-tags provided in the field-value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-Unmodified-Since` header field makes the request method conditional on the selected representation's last modification date being earlier than or equal to the date provided in the field-value.  This field accomplishes the same purpose as If-Match for cases where the user agent does not have an entity-tag for the representation.")]
        public string IfUnmodifiedSince { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.")]
        public System.Nullable<Oci.DnsService.Models.Scope> Scope { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Ignore confirmation and force the Cmdlet to complete action.")]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (!ConfirmDelete("OCIDnsSteeringPolicyAttachment", "Remove"))
            {
               return;
            }

            DeleteSteeringPolicyAttachmentRequest request;

            try
            {
                request = new DeleteSteeringPolicyAttachmentRequest
                {
                    SteeringPolicyAttachmentId = SteeringPolicyAttachmentId,
                    IfMatch = IfMatch,
                    IfUnmodifiedSince = IfUnmodifiedSince,
                    OpcRequestId = OpcRequestId,
                    Scope = Scope
                };

                response = client.DeleteSteeringPolicyAttachment(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private DeleteSteeringPolicyAttachmentResponse response;
    }
}
