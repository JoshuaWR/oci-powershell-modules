/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210831
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ThreatintelligenceService.Requests;
using Oci.ThreatintelligenceService.Responses;
using Oci.ThreatintelligenceService.Models;
using Oci.Common.Model;

namespace Oci.ThreatintelligenceService.Cmdlets
{
    [Cmdlet("Get", "OCIThreatintelligenceIndicatorCountsList")]
    [OutputType(new System.Type[] { typeof(Oci.ThreatintelligenceService.Models.IndicatorCountCollection), typeof(Oci.ThreatintelligenceService.Responses.ListIndicatorCountsResponse) })]
    public class GetOCIThreatintelligenceIndicatorCountsList : OCIThreatintelCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the tenancy to use to filter results.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.ThreatintelligenceService.Models.SortOrder> SortOrder { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListIndicatorCountsRequest request;

            try
            {
                request = new ListIndicatorCountsRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    SortOrder = SortOrder
                };

                response = client.ListIndicatorCounts(request).GetAwaiter().GetResult();
                WriteOutput(response, response.IndicatorCountCollection);
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

        private ListIndicatorCountsResponse response;
    }
}
