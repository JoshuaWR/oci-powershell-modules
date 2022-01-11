/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200531
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoggingService.Requests;
using Oci.LoggingService.Responses;
using Oci.LoggingService.Models;

namespace Oci.LoggingService.Cmdlets
{
    [Cmdlet("New", "OCILoggingLogSavedSearch")]
    [OutputType(new System.Type[] { typeof(Oci.LoggingService.Models.LogSavedSearch), typeof(Oci.LoggingService.Responses.CreateLogSavedSearchResponse) })]
    public class NewOCILoggingLogSavedSearch : OCILoggingManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specification of the Saved Search to create")]
        public CreateLogSavedSearchDetails CreateLogSavedSearchDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error, without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (e.g., if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateLogSavedSearchRequest request;

            try
            {
                request = new CreateLogSavedSearchRequest
                {
                    CreateLogSavedSearchDetails = CreateLogSavedSearchDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateLogSavedSearch(request).GetAwaiter().GetResult();
                WriteOutput(response, response.LogSavedSearch);
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

        private CreateLogSavedSearchResponse response;
    }
}
