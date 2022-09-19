/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220509
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CloudbridgeService.Requests;
using Oci.CloudbridgeService.Responses;
using Oci.CloudbridgeService.Models;
using Oci.Common.Model;

namespace Oci.CloudbridgeService.Cmdlets
{
    [Cmdlet("Invoke", "OCICloudbridgeSubmitHistoricalMetrics")]
    [OutputType(new System.Type[] { typeof(Oci.CloudbridgeService.Models.HistoricalMetricCollection), typeof(Oci.CloudbridgeService.Responses.SubmitHistoricalMetricsResponse) })]
    public class InvokeOCICloudbridgeSubmitHistoricalMetrics : OCIInventoryCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Creates or updates all metrics related to the asset.")]
        public SubmitHistoricalMetricsDetails SubmitHistoricalMetricsDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique asset identifier.")]
        public string AssetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            SubmitHistoricalMetricsRequest request;

            try
            {
                request = new SubmitHistoricalMetricsRequest
                {
                    SubmitHistoricalMetricsDetails = SubmitHistoricalMetricsDetails,
                    AssetId = AssetId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.SubmitHistoricalMetrics(request).GetAwaiter().GetResult();
                WriteOutput(response, response.HistoricalMetricCollection);
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

        private SubmitHistoricalMetricsResponse response;
    }
}
