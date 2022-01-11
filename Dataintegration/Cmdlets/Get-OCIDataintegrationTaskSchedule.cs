/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200430
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DataintegrationService.Requests;
using Oci.DataintegrationService.Responses;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Cmdlets
{
    [Cmdlet("Get", "OCIDataintegrationTaskSchedule")]
    [OutputType(new System.Type[] { typeof(Oci.DataintegrationService.Models.TaskSchedule), typeof(Oci.DataintegrationService.Responses.GetTaskScheduleResponse) })]
    public class GetOCIDataintegrationTaskSchedule : OCIDataIntegrationCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The workspace ID.")]
        public string WorkspaceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The application key.")]
        public string ApplicationKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"TaskSchedule Key")]
        public string TaskScheduleKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetTaskScheduleRequest request;

            try
            {
                request = new GetTaskScheduleRequest
                {
                    WorkspaceId = WorkspaceId,
                    ApplicationKey = ApplicationKey,
                    TaskScheduleKey = TaskScheduleKey,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetTaskSchedule(request).GetAwaiter().GetResult();
                WriteOutput(response, response.TaskSchedule);
                FinishProcessing(response);
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

        private GetTaskScheduleResponse response;
    }
}
