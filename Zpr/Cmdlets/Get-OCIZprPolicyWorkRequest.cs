/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20240301
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ZprService.Requests;
using Oci.ZprService.Responses;
using Oci.ZprService.Models;
using Oci.Common.Model;

namespace Oci.ZprService.Cmdlets
{
    [Cmdlet("Get", "OCIZprPolicyWorkRequest")]
    [OutputType(new System.Type[] { typeof(Oci.ZprService.Models.WorkRequest), typeof(Oci.ZprService.Responses.GetZprPolicyWorkRequestResponse) })]
    public class GetOCIZprPolicyWorkRequest : OCIZprCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the asynchronous work request.")]
        public string WorkRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID. The only valid characters for request IDs are letters, numbers, underscore, and dash.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetZprPolicyWorkRequestRequest request;

            try
            {
                request = new GetZprPolicyWorkRequestRequest
                {
                    WorkRequestId = WorkRequestId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetZprPolicyWorkRequest(request).GetAwaiter().GetResult();
                WriteOutput(response, response.WorkRequest);
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

        private GetZprPolicyWorkRequestResponse response;
    }
}
