/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190331
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.AnalyticsService.Requests;
using Oci.AnalyticsService.Responses;
using Oci.AnalyticsService.Models;
using Oci.Common.Model;

namespace Oci.AnalyticsService.Cmdlets
{
    [Cmdlet("New", "OCIAnalyticsPrivateAccessChannel")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.AnalyticsService.Responses.CreatePrivateAccessChannelResponse) })]
    public class NewOCIAnalyticsPrivateAccessChannel : OCIAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the AnalyticsInstance.")]
        public string AnalyticsInstanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Input payload for creating a private access channel for an Analytics instance.")]
        public CreatePrivateAccessChannelDetails CreatePrivateAccessChannelDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreatePrivateAccessChannelRequest request;

            try
            {
                request = new CreatePrivateAccessChannelRequest
                {
                    AnalyticsInstanceId = AnalyticsInstanceId,
                    CreatePrivateAccessChannelDetails = CreatePrivateAccessChannelDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreatePrivateAccessChannel(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private CreatePrivateAccessChannelResponse response;
    }
}
