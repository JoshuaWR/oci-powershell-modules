/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200131
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CloudguardService.Requests;
using Oci.CloudguardService.Responses;
using Oci.CloudguardService.Models;
using Oci.Common.Model;

namespace Oci.CloudguardService.Cmdlets
{
    [Cmdlet("Invoke", "OCICloudguardRequestSummarizedTrendProblems")]
    [OutputType(new System.Type[] { typeof(Oci.CloudguardService.Models.ProblemTrendAggregationCollection), typeof(Oci.CloudguardService.Responses.RequestSummarizedTrendProblemsResponse) })]
    public class InvokeOCICloudguardRequestSummarizedTrendProblems : OCICloudGuardCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Start time for a filter. If start time is not specified, start time will be set to current time - 30 days.")]
        public System.Nullable<System.DateTime> TimeFirstDetectedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"End time for a filter. If end time is not specified, end time will be set to current time.")]
        public System.Nullable<System.DateTime> TimeFirstDetectedLessThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Default is false. When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned depending on the setting of `accessLevel`.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Valid values are `RESTRICTED` and `ACCESSIBLE`. Default is `RESTRICTED`. Setting this to `ACCESSIBLE` returns only those compartments for which the user has INSPECT permissions directly or indirectly (permissions can be on a resource in a subcompartment). When set to `RESTRICTED` permissions are checked and no partial results are displayed.")]
        public System.Nullable<Oci.CloudguardService.Requests.RequestSummarizedTrendProblemsRequest.AccessLevelEnum> AccessLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return")]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RequestSummarizedTrendProblemsRequest request;

            try
            {
                request = new RequestSummarizedTrendProblemsRequest
                {
                    CompartmentId = CompartmentId,
                    TimeFirstDetectedGreaterThanOrEqualTo = TimeFirstDetectedGreaterThanOrEqualTo,
                    TimeFirstDetectedLessThanOrEqualTo = TimeFirstDetectedLessThanOrEqualTo,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    AccessLevel = AccessLevel,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId
                };

                response = client.RequestSummarizedTrendProblems(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ProblemTrendAggregationCollection);
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

        private RequestSummarizedTrendProblemsResponse response;
    }
}
