/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoganalyticsService.Requests;
using Oci.LoganalyticsService.Responses;
using Oci.LoganalyticsService.Models;
using Oci.Common.Model;

namespace Oci.LoganalyticsService.Cmdlets
{
    [Cmdlet("Confirm", "OCILoganalyticsEndpoint")]
    [OutputType(new System.Type[] { typeof(Oci.LoganalyticsService.Models.ValidateEndpointResult), typeof(Oci.LoganalyticsService.Responses.ValidateEndpointResponse) })]
    public class ConfirmOCILoganalyticsEndpoint : OCILogAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details of the REST endpoint configuration to validate. This parameter also accepts subtypes <Oci.LoganalyticsService.Models.LogListTypeEndpoint>, <Oci.LoganalyticsService.Models.LogTypeEndpoint> of type <Oci.LoganalyticsService.Models.LogAnalyticsEndpoint>.")]
        public LogAnalyticsEndpoint ValidateEndpointDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ValidateEndpointRequest request;

            try
            {
                request = new ValidateEndpointRequest
                {
                    NamespaceName = NamespaceName,
                    ValidateEndpointDetails = ValidateEndpointDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.ValidateEndpoint(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ValidateEndpointResult);
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

        private ValidateEndpointResponse response;
    }
}
