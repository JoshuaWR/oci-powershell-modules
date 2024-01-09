/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200430
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DataintegrationService.Requests;
using Oci.DataintegrationService.Responses;
using Oci.DataintegrationService.Models;
using Oci.Common.Model;

namespace Oci.DataintegrationService.Cmdlets
{
    [Cmdlet("Get", "OCIDataintegrationCountStatistic")]
    [OutputType(new System.Type[] { typeof(Oci.DataintegrationService.Models.CountStatistic), typeof(Oci.DataintegrationService.Responses.GetCountStatisticResponse) })]
    public class GetOCIDataintegrationCountStatistic : OCIDataIntegrationCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The workspace ID.")]
        public string WorkspaceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A unique key of the container object, such as workspace, project, and so on, to count statistics for. The statistics is fetched for the given key.")]
        public string CountStatisticKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCountStatisticRequest request;

            try
            {
                request = new GetCountStatisticRequest
                {
                    WorkspaceId = WorkspaceId,
                    CountStatisticKey = CountStatisticKey,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetCountStatistic(request).GetAwaiter().GetResult();
                WriteOutput(response, response.CountStatistic);
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

        private GetCountStatisticResponse response;
    }
}
