/*
 * NOTE: Generated using OracleSDKGenerator, API Version: release
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;
using Oci.KeymanagementService.Models;

namespace Oci.KeymanagementService.Cmdlets
{
    [Cmdlet("New", "OCIKeymanagementKey")]
    [OutputType(new System.Type[] { typeof(Oci.KeymanagementService.Models.Key), typeof(Oci.KeymanagementService.Responses.CreateKeyResponse) })]
    public class NewOCIKeymanagementKey : OCIKmsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"CreateKeyDetails")]
        public CreateKeyDetails CreateKeyDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (e.g., if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateKeyRequest request;

            try
            {
                request = new CreateKeyRequest
                {
                    CreateKeyDetails = CreateKeyDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateKey(request).GetAwaiter().GetResult();
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

        private CreateKeyResponse response;
    }
}
