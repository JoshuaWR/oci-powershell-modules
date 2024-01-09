/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MediaservicesService.Requests;
using Oci.MediaservicesService.Responses;
using Oci.MediaservicesService.Models;
using Oci.Common.Model;

namespace Oci.MediaservicesService.Cmdlets
{
    [Cmdlet("New", "OCIMediaservicesSessionToken")]
    [OutputType(new System.Type[] { typeof(Oci.MediaservicesService.Models.SessionToken), typeof(Oci.MediaservicesService.Responses.GenerateSessionTokenResponse) })]
    public class NewOCIMediaservicesSessionToken : OCIMediaStreamCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details to generate a new stream session token.")]
        public GenerateSessionTokenDetails GenerateSessionTokenDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GenerateSessionTokenRequest request;

            try
            {
                request = new GenerateSessionTokenRequest
                {
                    GenerateSessionTokenDetails = GenerateSessionTokenDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.GenerateSessionToken(request).GetAwaiter().GetResult();
                WriteOutput(response, response.SessionToken);
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

        private GenerateSessionTokenResponse response;
    }
}
