/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoganalyticsService.Requests;
using Oci.LoganalyticsService.Responses;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Cmdlets
{
    [Cmdlet("Invoke", "OCILoganalyticsAppendLookupData")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.LoganalyticsService.Responses.AppendLookupDataResponse) })]
    public class InvokeOCILoganalyticsAppendLookupData : OCILogAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the lookup to operate on.")]
        public string LookupName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The file to append.", ParameterSetName = FromStreamSet)]
        public System.IO.Stream AppendLookupFileBody { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Use this parameter to provide the file location from where the input stream to be read. The file to append.", ParameterSetName = FromFileSet)]
        public String AppendLookupFileBodyFromFile { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"is force")]
        public System.Nullable<bool> IsForce { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The character encoding of the uploaded file.")]
        public string CharEncoding { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A value of `100-continue` requests preliminary verification of the request method, path, and headers before the request body is sent. If no error results from such verification, the server will send a 100 (Continue) interim response to indicate readiness for the request body. The only allowed value for this parameter is ""100-Continue"" (case-insensitive).")]
        public string Expect { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            AppendLookupDataRequest request;

            if (ParameterSetName.Equals(FromFileSet))
            {
                AppendLookupFileBody = System.IO.File.OpenRead(GetAbsoluteFilePath(AppendLookupFileBodyFromFile));
            }
            

            try
            {
                request = new AppendLookupDataRequest
                {
                    NamespaceName = NamespaceName,
                    LookupName = LookupName,
                    AppendLookupFileBody = AppendLookupFileBody,
                    IsForce = IsForce,
                    CharEncoding = CharEncoding,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch,
                    Expect = Expect
                };

                response = client.AppendLookupData(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private AppendLookupDataResponse response;
        private const string FromFileSet = "FromFile";
        private const string FromStreamSet = "FromStream";
    }
}
