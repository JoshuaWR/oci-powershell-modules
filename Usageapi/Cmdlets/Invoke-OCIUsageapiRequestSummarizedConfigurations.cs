/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200107
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.UsageapiService.Requests;
using Oci.UsageapiService.Responses;
using Oci.UsageapiService.Models;

namespace Oci.UsageapiService.Cmdlets
{
    [Cmdlet("Invoke", "OCIUsageapiRequestSummarizedConfigurations")]
    [OutputType(new System.Type[] { typeof(Oci.UsageapiService.Models.ConfigurationAggregation), typeof(Oci.UsageapiService.Responses.RequestSummarizedConfigurationsResponse) })]
    public class InvokeOCIUsageapiRequestSummarizedConfigurations : OCIUsageapiCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"tenant id")]
        public string TenantId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RequestSummarizedConfigurationsRequest request;

            try
            {
                request = new RequestSummarizedConfigurationsRequest
                {
                    TenantId = TenantId,
                    OpcRequestId = OpcRequestId
                };

                response = client.RequestSummarizedConfigurations(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ConfigurationAggregation);
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

        private RequestSummarizedConfigurationsResponse response;
    }
}
