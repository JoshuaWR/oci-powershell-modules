/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200107
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.UsageapiService.Requests;
using Oci.UsageapiService.Responses;
using Oci.UsageapiService.Models;
using Oci.Common.Model;

namespace Oci.UsageapiService.Cmdlets
{
    [Cmdlet("Invoke", "OCIUsageapiRequestSummarizedUsages")]
    [OutputType(new System.Type[] { typeof(Oci.UsageapiService.Models.UsageAggregation), typeof(Oci.UsageapiService.Responses.RequestSummarizedUsagesResponse) })]
    public class InvokeOCIUsageapiRequestSummarizedUsages : OCIUsageapiCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"getUsageRequest contains query inforamtion.")]
        public RequestSummarizedUsagesDetails RequestSummarizedUsagesDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximumimum number of items to return.")]
        public System.Nullable<int> Limit { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RequestSummarizedUsagesRequest request;

            try
            {
                request = new RequestSummarizedUsagesRequest
                {
                    RequestSummarizedUsagesDetails = RequestSummarizedUsagesDetails,
                    OpcRequestId = OpcRequestId,
                    Page = Page,
                    Limit = Limit
                };

                response = client.RequestSummarizedUsages(request).GetAwaiter().GetResult();
                WriteOutput(response, response.UsageAggregation);
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

        private RequestSummarizedUsagesResponse response;
    }
}
