/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoganalyticsService.Requests;
using Oci.LoganalyticsService.Responses;
using Oci.LoganalyticsService.Models;
using Oci.Common.Model;
using Oci.Common.Waiters;

namespace Oci.LoganalyticsService.Cmdlets
{
    [Cmdlet("Get", "OCILoganalyticsStorageWorkRequest", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.LoganalyticsService.Models.StorageWorkRequest), typeof(Oci.LoganalyticsService.Responses.GetStorageWorkRequestResponse) })]
    public class GetOCILoganalyticsStorageWorkRequest : OCILogAnalyticsCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Work Request Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the asynchronous request.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Work Request Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the asynchronous request.", ParameterSetName = Default)]
        public string WorkRequestId { get; set; }

        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.", ParameterSetName = Default)]
        public string NamespaceName { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = StatusParamSet)]
        public Oci.LoganalyticsService.Models.WorkRequestStatus[] WaitForStatus { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = StatusParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = StatusParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetStorageWorkRequestRequest request;

            try
            {
                request = new GetStorageWorkRequestRequest
                {
                    WorkRequestId = WorkRequestId,
                    NamespaceName = NamespaceName,
                    OpcRequestId = OpcRequestId
                };

                HandleOutput(request);
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

        private void HandleOutput(GetStorageWorkRequestRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case StatusParamSet:
                    response = client.Waiters.ForStorageWorkRequest(request, waiterConfig, WaitForStatus).Execute();
                    break;

                case Default:
                    response = client.GetStorageWorkRequest(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.StorageWorkRequest);
        }

        private GetStorageWorkRequestResponse response;
        private const string StatusParamSet = "StatusParamSet";
        private const string Default = "Default";
    }
}
