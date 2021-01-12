/*
 * NOTE: Generated using OracleSDKGenerator, API Version: release
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;
using Oci.KeymanagementService.Models;

namespace Oci.KeymanagementService.Cmdlets
{
    [Cmdlet("Restore", "OCIKeymanagementKeyFromFile")]
    [OutputType(new System.Type[] { typeof(Oci.KeymanagementService.Models.Key), typeof(Oci.KeymanagementService.Responses.RestoreKeyFromFileResponse) })]
    public class RestoreOCIKeymanagementKeyFromFile : OCIKmsManagementCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The content length of the body.")]
        public System.Nullable<long> ContentLength { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The encrypted backup file to upload to restore the key.", ParameterSetName = FromStreamSet)]
        public System.IO.Stream RestoreKeyFromFileDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Use this parameter to provide the file location from where the input stream to be read. The encrypted backup file to upload to restore the key.", ParameterSetName = FromFileSet)]
        public String RestoreKeyFromFileDetailsFromFile { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The base64-encoded MD5 hash value of the body, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 14.15. If the Content-MD5 header is present, Key Management performs an integrity check on the body of the HTTP request by computing the MD5 hash for the body and comparing it to the MD5 hash supplied in the header. If the two hashes don't match, the object is rejected and a response with 400 Unmatched Content MD5 error is returned, along with the message: ""The computed MD5 of the request body (ACTUAL_MD5) does not match the Content-MD5 header (HEADER_MD5).""")]
        public string ContentMd5 { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (e.g., if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RestoreKeyFromFileRequest request;

            if (ParameterSetName.Equals(FromFileSet))
            {
                RestoreKeyFromFileDetails = System.IO.File.OpenRead(GetAbsoluteFilePath(RestoreKeyFromFileDetailsFromFile));
            }
            

            try
            {
                request = new RestoreKeyFromFileRequest
                {
                    ContentLength = ContentLength,
                    RestoreKeyFromFileDetails = RestoreKeyFromFileDetails,
                    IfMatch = IfMatch,
                    ContentMd5 = ContentMd5,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.RestoreKeyFromFile(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Key);
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

        private RestoreKeyFromFileResponse response;
        private const string FromFileSet = "FromFile";
        private const string FromStreamSet = "FromStream";
    }
}
