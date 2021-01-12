/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180401
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MonitoringService.Requests;
using Oci.MonitoringService.Responses;
using Oci.MonitoringService.Models;

namespace Oci.MonitoringService.Cmdlets
{
    [Cmdlet("Update", "OCIMonitoringAlarm")]
    [OutputType(new System.Type[] { typeof(Oci.MonitoringService.Models.Alarm), typeof(Oci.MonitoringService.Responses.UpdateAlarmResponse) })]
    public class UpdateOCIMonitoringAlarm : OCIMonitoringCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of an alarm.")]
        public string AlarmId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Document for updating an alarm.")]
        public UpdateAlarmDetails UpdateAlarmDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer part of the request identifier token. If you need to contact Oracle about a particular request, please provide the complete request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateAlarmRequest request;

            try
            {
                request = new UpdateAlarmRequest
                {
                    AlarmId = AlarmId,
                    UpdateAlarmDetails = UpdateAlarmDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateAlarm(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Alarm);
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

        private UpdateAlarmResponse response;
    }
}
