/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181116
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.WaasService.Requests;
using Oci.WaasService.Responses;
using Oci.WaasService.Models;

namespace Oci.WaasService.Cmdlets
{
    [Cmdlet("Get", "OCIWaasWafConfig")]
    [OutputType(new System.Type[] { typeof(Oci.WaasService.Models.WafConfig), typeof(Oci.WaasService.Responses.GetWafConfigResponse) })]
    public class GetOCIWaasWafConfig : OCIWaasCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the WAAS policy.")]
        public string WaasPolicyId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetWafConfigRequest request;

            try
            {
                request = new GetWafConfigRequest
                {
                    WaasPolicyId = WaasPolicyId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetWafConfig(request).GetAwaiter().GetResult();
                WriteOutput(response, response.WafConfig);
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

        private GetWafConfigResponse response;
    }
}
