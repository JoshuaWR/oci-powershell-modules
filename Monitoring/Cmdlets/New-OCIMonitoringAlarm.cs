/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180401
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MonitoringService.Requests;
using Oci.MonitoringService.Responses;
using Oci.MonitoringService.Models;
using Oci.Common.Model;

namespace Oci.MonitoringService.Cmdlets
{
    [Cmdlet("New", "OCIMonitoringAlarm")]
    [OutputType(new System.Type[] { typeof(Oci.MonitoringService.Models.Alarm), typeof(Oci.MonitoringService.Responses.CreateAlarmResponse) })]
    public class NewOCIMonitoringAlarm : OCIMonitoringCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Document for creating an alarm.")]
        public CreateAlarmDetails CreateAlarmDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer part of the request identifier token. If you need to contact Oracle about a particular request, please provide the complete request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateAlarmRequest request;

            try
            {
                request = new CreateAlarmRequest
                {
                    CreateAlarmDetails = CreateAlarmDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateAlarm(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Alarm);
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

        private CreateAlarmResponse response;
    }
}
