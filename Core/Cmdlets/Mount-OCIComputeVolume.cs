/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Mount", "OCIComputeVolume")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.VolumeAttachment), typeof(Oci.CoreService.Responses.AttachVolumeResponse) })]
    public class MountOCIComputeVolume : OCIComputeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Attach volume request. This parameter also accepts subtypes <Oci.CoreService.Models.AttachServiceDeterminedVolumeDetails>, <Oci.CoreService.Models.AttachEmulatedVolumeDetails>, <Oci.CoreService.Models.AttachIScsiVolumeDetails>, <Oci.CoreService.Models.AttachParavirtualizedVolumeDetails> of type <Oci.CoreService.Models.AttachVolumeDetails>.")]
        public AttachVolumeDetails AttachVolumeDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            AttachVolumeRequest request;

            try
            {
                request = new AttachVolumeRequest
                {
                    AttachVolumeDetails = AttachVolumeDetails,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.AttachVolume(request).GetAwaiter().GetResult();
                WriteOutput(response, response.VolumeAttachment);
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

        private AttachVolumeResponse response;
    }
}
