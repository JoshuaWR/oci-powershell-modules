/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210330
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.StackmonitoringService.Requests;
using Oci.StackmonitoringService.Responses;
using Oci.StackmonitoringService.Models;
using Oci.Common.Model;

namespace Oci.StackmonitoringService.Cmdlets
{
    [Cmdlet("Invoke", "OCIStackmonitoringPublishMetricExtension")]
    [OutputType(new System.Type[] { typeof(Oci.StackmonitoringService.Models.MetricExtension), typeof(Oci.StackmonitoringService.Responses.PublishMetricExtensionResponse) })]
    public class InvokeOCIStackmonitoringPublishMetricExtension : OCIStackMonitoringCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the metric extension resource.")]
        public string MetricExtensionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            PublishMetricExtensionRequest request;

            try
            {
                request = new PublishMetricExtensionRequest
                {
                    MetricExtensionId = MetricExtensionId,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken,
                    IfMatch = IfMatch
                };

                response = client.PublishMetricExtension(request).GetAwaiter().GetResult();
                WriteOutput(response, response.MetricExtension);
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

        private PublishMetricExtensionResponse response;
    }
}
