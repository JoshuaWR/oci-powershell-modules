/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;
using Oci.ObjectstorageService.Models;
using Oci.Common.Model;

namespace Oci.ObjectstorageService.Cmdlets
{
    [Cmdlet("Invoke", "OCIObjectstorageCommitMultipartUpload")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.ObjectstorageService.Responses.CommitMultipartUploadResponse) })]
    public class InvokeOCIObjectstorageCommitMultipartUpload : OCIObjectStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Object Storage namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the bucket. Avoid entering confidential information. Example: `my-new-bucket1`")]
        public string BucketName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the object. Avoid entering confidential information. Example: `test/object1.log`")]
        public string ObjectName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The upload ID for a multipart upload.")]
        public string UploadId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The part numbers and entity tags (ETags) for the parts you want to commit.")]
        public CommitMultipartUploadDetails CommitMultipartUploadDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag (ETag) to match with the ETag of an existing resource. If the specified ETag matches the ETag of the existing resource, GET and HEAD requests will return the resource and PUT and POST requests will upload the resource.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag (ETag) to avoid matching. The only valid value is '*', which indicates that the request should fail if the resource already exists.")]
        public string IfNoneMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcClientRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CommitMultipartUploadRequest request;

            try
            {
                request = new CommitMultipartUploadRequest
                {
                    NamespaceName = NamespaceName,
                    BucketName = BucketName,
                    ObjectName = ObjectName,
                    UploadId = UploadId,
                    CommitMultipartUploadDetails = CommitMultipartUploadDetails,
                    IfMatch = IfMatch,
                    IfNoneMatch = IfNoneMatch,
                    OpcClientRequestId = OpcClientRequestId
                };

                response = client.CommitMultipartUpload(request).GetAwaiter().GetResult();
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

        private CommitMultipartUploadResponse response;
    }
}
