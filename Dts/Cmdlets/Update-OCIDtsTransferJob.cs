/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 1.0.017
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;
using Oci.DtsService.Models;
using Oci.Common.Model;

namespace Oci.DtsService.Cmdlets
{
    [Cmdlet("Update", "OCIDtsTransferJob")]
    [OutputType(new System.Type[] { typeof(Oci.DtsService.Models.TransferJob), typeof(Oci.DtsService.Responses.UpdateTransferJobResponse) })]
    public class UpdateOCIDtsTransferJob : OCITransferJobCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"ID of the Transfer Job")]
        public string Id { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"fields to update")]
        public UpdateTransferJobDetails UpdateTransferJobDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag to match. Optional, if set, the update will be successful only if the object's tag matches the tag specified in the request.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateTransferJobRequest request;

            try
            {
                request = new UpdateTransferJobRequest
                {
                    Id = Id,
                    UpdateTransferJobDetails = UpdateTransferJobDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateTransferJob(request).GetAwaiter().GetResult();
                WriteOutput(response, response.TransferJob);
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

        private UpdateTransferJobResponse response;
    }
}
