/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190415
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;
using Oci.MysqlService.Models;
using Oci.Common.Model;

namespace Oci.MysqlService.Cmdlets
{
    [Cmdlet("Get", "OCIMysqlHeatWaveClusterMemoryEstimate")]
    [OutputType(new System.Type[] { typeof(Oci.MysqlService.Models.HeatWaveClusterMemoryEstimate), typeof(Oci.MysqlService.Responses.GetHeatWaveClusterMemoryEstimateResponse) })]
    public class GetOCIMysqlHeatWaveClusterMemoryEstimate : OCIDbSystemCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The DB System [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string DbSystemId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer-defined unique identifier for the request. If you need to contact Oracle about a specific request, please provide the request ID that you supplied in this header with the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetHeatWaveClusterMemoryEstimateRequest request;

            try
            {
                request = new GetHeatWaveClusterMemoryEstimateRequest
                {
                    DbSystemId = DbSystemId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetHeatWaveClusterMemoryEstimate(request).GetAwaiter().GetResult();
                WriteOutput(response, response.HeatWaveClusterMemoryEstimate);
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

        private GetHeatWaveClusterMemoryEstimateResponse response;
    }
}
