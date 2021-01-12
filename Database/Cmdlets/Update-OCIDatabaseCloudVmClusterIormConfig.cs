/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;
using Oci.Common.Waiters;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Update", "OCIDatabaseCloudVmClusterIormConfig", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.ExadataIormConfig), typeof(Oci.DatabaseService.Responses.UpdateCloudVmClusterIormConfigResponse) })]
    public class UpdateOCIDatabaseCloudVmClusterIormConfig : OCIDatabaseCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The cloud VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The cloud VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).", ParameterSetName = Default)]
        public string CloudVmClusterId { get; set; }

        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request to perform database update.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request to perform database update.", ParameterSetName = Default)]
        public ExadataIormConfigUpdateDetails CloudVmClusterIormConfigUpdateDetails { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.", ParameterSetName = Default)]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = StatusParamSet)]
        public WorkrequestsService.Models.WorkRequest.StatusEnum[] WaitForStatus { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = StatusParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = StatusParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateCloudVmClusterIormConfigRequest request;

            try
            {
                request = new UpdateCloudVmClusterIormConfigRequest
                {
                    CloudVmClusterId = CloudVmClusterId,
                    CloudVmClusterIormConfigUpdateDetails = CloudVmClusterIormConfigUpdateDetails,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch
                };

                HandleOutput(request);
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

        private void HandleOutput(UpdateCloudVmClusterIormConfigRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case StatusParamSet:
                    response = client.Waiters.ForUpdateCloudVmClusterIormConfig(request, waiterConfig, WaitForStatus).Execute();
                    break;

                case Default:
                    response = client.UpdateCloudVmClusterIormConfig(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.ExadataIormConfig);
        }

        private UpdateCloudVmClusterIormConfigResponse response;
        private const string StatusParamSet = "StatusParamSet";
        private const string Default = "Default";
    }
}
