/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20221208
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ComputecloudatcustomerService.Requests;
using Oci.ComputecloudatcustomerService.Responses;
using Oci.ComputecloudatcustomerService.Models;
using Oci.Common.Model;

namespace Oci.ComputecloudatcustomerService.Cmdlets
{
    [Cmdlet("Update", "OCIComputecloudatcustomerCccUpgradeSchedule")]
    [OutputType(new System.Type[] { typeof(Oci.ComputecloudatcustomerService.Models.CccUpgradeSchedule), typeof(Oci.ComputecloudatcustomerService.Responses.UpdateCccUpgradeScheduleResponse) })]
    public class UpdateOCIComputecloudatcustomerCccUpgradeSchedule : OCIComputeCloudAtCustomerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Compute Cloud@Customer upgrade schedule [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public string CccUpgradeScheduleId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated in the Compute Cloud@Customer upgrade schedule.")]
        public UpdateCccUpgradeScheduleDetails UpdateCccUpgradeScheduleDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateCccUpgradeScheduleRequest request;

            try
            {
                request = new UpdateCccUpgradeScheduleRequest
                {
                    CccUpgradeScheduleId = CccUpgradeScheduleId,
                    UpdateCccUpgradeScheduleDetails = UpdateCccUpgradeScheduleDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateCccUpgradeSchedule(request).GetAwaiter().GetResult();
                WriteOutput(response, response.CccUpgradeSchedule);
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

        private UpdateCccUpgradeScheduleResponse response;
    }
}
