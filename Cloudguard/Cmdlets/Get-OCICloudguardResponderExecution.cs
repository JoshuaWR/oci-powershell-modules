/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200131
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CloudguardService.Requests;
using Oci.CloudguardService.Responses;
using Oci.CloudguardService.Models;
using Oci.Common.Model;

namespace Oci.CloudguardService.Cmdlets
{
    [Cmdlet("Get", "OCICloudguardResponderExecution")]
    [OutputType(new System.Type[] { typeof(Oci.CloudguardService.Models.ResponderExecution), typeof(Oci.CloudguardService.Responses.GetResponderExecutionResponse) })]
    public class GetOCICloudguardResponderExecution : OCICloudGuardCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The identifier of the responder execution.")]
        public string ResponderExecutionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetResponderExecutionRequest request;

            try
            {
                request = new GetResponderExecutionRequest
                {
                    ResponderExecutionId = ResponderExecutionId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetResponderExecution(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ResponderExecution);
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

        private GetResponderExecutionResponse response;
    }
}
