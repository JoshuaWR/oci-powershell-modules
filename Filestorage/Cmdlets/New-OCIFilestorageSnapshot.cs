/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20171215
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;
using Oci.FilestorageService.Models;

namespace Oci.FilestorageService.Cmdlets
{
    [Cmdlet("New", "OCIFilestorageSnapshot")]
    [OutputType(new System.Type[] { typeof(Oci.FilestorageService.Models.Snapshot), typeof(Oci.FilestorageService.Responses.CreateSnapshotResponse) })]
    public class NewOCIFilestorageSnapshot : OCIFileStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for creating a new snapshot.")]
        public CreateSnapshotDetails CreateSnapshotDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateSnapshotRequest request;

            try
            {
                request = new CreateSnapshotRequest
                {
                    CreateSnapshotDetails = CreateSnapshotDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateSnapshot(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Snapshot);
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

        private CreateSnapshotResponse response;
    }
}
