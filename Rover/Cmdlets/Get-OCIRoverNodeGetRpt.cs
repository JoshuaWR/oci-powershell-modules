/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201210
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;
using Oci.RoverService.Models;
using Oci.Common.Model;

namespace Oci.RoverService.Cmdlets
{
    [Cmdlet("Get", "OCIRoverNodeGetRpt")]
    [OutputType(new System.Type[] { typeof(Oci.RoverService.Models.RoverNodeGetRpt), typeof(Oci.RoverService.Responses.GetRoverNodeGetRptResponse) })]
    public class GetOCIRoverNodeGetRpt : OCIRoverNodeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique RoverNode identifier")]
        public string RoverNodeId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Java Web Token which is a signature of the request that is signed with the resource's private key This is meant solely in the context of getRpt")]
        public string Jwt { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetRoverNodeGetRptRequest request;

            try
            {
                request = new GetRoverNodeGetRptRequest
                {
                    RoverNodeId = RoverNodeId,
                    Jwt = Jwt,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetRoverNodeGetRpt(request).GetAwaiter().GetResult();
                WriteOutput(response, response.RoverNodeGetRpt);
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

        private GetRoverNodeGetRptResponse response;
    }
}
