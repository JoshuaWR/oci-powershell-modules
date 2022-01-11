/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180401
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MonitoringService.Requests;
using Oci.MonitoringService.Responses;
using Oci.MonitoringService.Models;

namespace Oci.MonitoringService.Cmdlets
{
    [Cmdlet("Submit", "OCIMonitoringMetricData")]
    [OutputType(new System.Type[] { typeof(Oci.MonitoringService.Models.PostMetricDataResponseDetails), typeof(Oci.MonitoringService.Responses.PostMetricDataResponse) })]
    public class SubmitOCIMonitoringMetricData : OCIMonitoringCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"An array of metric objects containing raw metric data points to be posted to the Monitoring service.")]
        public PostMetricDataDetails PostMetricDataDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer part of the request identifier token. If you need to contact Oracle about a particular request, please provide the complete request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            PostMetricDataRequest request;

            try
            {
                request = new PostMetricDataRequest
                {
                    PostMetricDataDetails = PostMetricDataDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.PostMetricData(request).GetAwaiter().GetResult();
                WriteOutput(response, response.PostMetricDataResponseDetails);
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

        private PostMetricDataResponse response;
    }
}
