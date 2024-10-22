/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20171215
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;
using Oci.FilestorageService.Models;
using Oci.Common.Model;

namespace Oci.FilestorageService.Cmdlets
{
    [Cmdlet("Remove", "OCIFilestorageFilesystemSnapshotPolicyLock")]
    [OutputType(new System.Type[] { typeof(Oci.FilestorageService.Models.FilesystemSnapshotPolicy), typeof(Oci.FilestorageService.Responses.RemoveFilesystemSnapshotPolicyLockResponse) })]
    public class RemoveOCIFilestorageFilesystemSnapshotPolicyLock : OCIFileStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the file system snapshot policy.")]
        public string FilesystemSnapshotPolicyId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details to be updated for the RemoveLock.")]
        public ResourceLock RemoveFilesystemSnapshotPolicyLockDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RemoveFilesystemSnapshotPolicyLockRequest request;

            try
            {
                request = new RemoveFilesystemSnapshotPolicyLockRequest
                {
                    FilesystemSnapshotPolicyId = FilesystemSnapshotPolicyId,
                    RemoveFilesystemSnapshotPolicyLockDetails = RemoveFilesystemSnapshotPolicyLockDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.RemoveFilesystemSnapshotPolicyLock(request).GetAwaiter().GetResult();
                WriteOutput(response, response.FilesystemSnapshotPolicy);
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

        private RemoveFilesystemSnapshotPolicyLockResponse response;
    }
}
