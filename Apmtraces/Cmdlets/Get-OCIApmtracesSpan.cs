/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ApmtracesService.Requests;
using Oci.ApmtracesService.Responses;
using Oci.ApmtracesService.Models;
using Oci.Common.Model;

namespace Oci.ApmtracesService.Cmdlets
{
    [Cmdlet("Get", "OCIApmtracesSpan")]
    [OutputType(new System.Type[] { typeof(Oci.ApmtracesService.Models.Span), typeof(Oci.ApmtracesService.Responses.GetSpanResponse) })]
    public class GetOCIApmtracesSpan : OCITraceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The APM Domain ID the request is intended for.")]
        public string ApmDomainId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Application Performance Monitoring span identifier (spanId).")]
        public string SpanKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Application Performance Monitoring trace identifier (traceId).")]
        public string TraceKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetSpanRequest request;

            try
            {
                request = new GetSpanRequest
                {
                    ApmDomainId = ApmDomainId,
                    SpanKey = SpanKey,
                    TraceKey = TraceKey,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetSpan(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Span);
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

        private GetSpanResponse response;
    }
}
