/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190506
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OdaService.Requests;
using Oci.OdaService.Responses;
using Oci.OdaService.Models;
using Oci.Common.Model;

namespace Oci.OdaService.Cmdlets
{
    [Cmdlet("New", "OCIOdaAuthenticationProvider")]
    [OutputType(new System.Type[] { typeof(Oci.OdaService.Models.AuthenticationProvider), typeof(Oci.OdaService.Responses.CreateAuthenticationProviderResponse) })]
    public class NewOCIOdaAuthenticationProvider : OCIManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Digital Assistant instance identifier.")]
        public string OdaInstanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Property values required to create the new Authentication Provider.")]
        public CreateAuthenticationProviderDetails CreateAuthenticationProviderDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing. This value is included in the opc-request-id response header.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so that you can retry the request if there's a timeout or server error without the risk of executing that same action again.

Retry tokens expire after 24 hours, but they can become invalid before then if there are conflicting operations. For example, if an instance was deleted and purged from the system, then the service might reject a retry of the original creation request.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateAuthenticationProviderRequest request;

            try
            {
                request = new CreateAuthenticationProviderRequest
                {
                    OdaInstanceId = OdaInstanceId,
                    CreateAuthenticationProviderDetails = CreateAuthenticationProviderDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateAuthenticationProvider(request).GetAwaiter().GetResult();
                WriteOutput(response, response.AuthenticationProvider);
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

        private CreateAuthenticationProviderResponse response;
    }
}
