/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.HealthchecksService.Requests;
using Oci.HealthchecksService.Responses;
using Oci.HealthchecksService.Models;

namespace Oci.HealthchecksService.Cmdlets
{
    [Cmdlet("Update", "OCIHealthchecksPingMonitor")]
    [OutputType(new System.Type[] { typeof(Oci.HealthchecksService.Models.PingMonitor), typeof(Oci.HealthchecksService.Responses.UpdatePingMonitorResponse) })]
    public class UpdateOCIHealthchecksPingMonitor : OCIHealthChecksCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of a monitor.")]
        public string MonitorId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for updating a Ping monitor.")]
        public UpdatePingMonitorDetails UpdatePingMonitorDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdatePingMonitorRequest request;

            try
            {
                request = new UpdatePingMonitorRequest
                {
                    MonitorId = MonitorId,
                    UpdatePingMonitorDetails = UpdatePingMonitorDetails,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch
                };

                response = client.UpdatePingMonitor(request).GetAwaiter().GetResult();
                WriteOutput(response, response.PingMonitor);
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

        private UpdatePingMonitorResponse response;
    }
}
