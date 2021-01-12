/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Cmdlets
{
    [Cmdlet("Get", "OCIObjectstorageBucket")]
    [OutputType(new System.Type[] { typeof(Oci.ObjectstorageService.Models.Bucket), typeof(Oci.ObjectstorageService.Responses.GetBucketResponse) })]
    public class GetOCIObjectstorageBucket : OCIObjectStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Object Storage namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the bucket. Avoid entering confidential information. Example: `my-new-bucket1`")]
        public string BucketName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag (ETag) to match. For creating and committing a multipart upload to an object, this is the entity tag of the target object. For uploading a part, this is the entity tag of the target part.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag (ETag) to avoid matching. The only valid value is '*', which indicates that the request should fail if the object already exists. For creating and committing a multipart upload, this is the entity tag of the target object. For uploading a part, this is the entity tag of the target part.")]
        public string IfNoneMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcClientRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Bucket summary includes the 'namespace', 'name', 'compartmentId', 'createdBy', 'timeCreated', and 'etag' fields. This parameter can also include 'approximateCount' (approximate number of objects) and 'approximateSize' (total approximate size in bytes of all objects). For example 'approximateCount,approximateSize'.")]
        public System.Collections.Generic.List<Oci.ObjectstorageService.Requests.GetBucketRequest.FieldsEnum> Fields { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetBucketRequest request;

            try
            {
                request = new GetBucketRequest
                {
                    NamespaceName = NamespaceName,
                    BucketName = BucketName,
                    IfMatch = IfMatch,
                    IfNoneMatch = IfNoneMatch,
                    OpcClientRequestId = OpcClientRequestId,
                    Fields = Fields
                };

                response = client.GetBucket(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Bucket);
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

        private GetBucketResponse response;
    }
}
