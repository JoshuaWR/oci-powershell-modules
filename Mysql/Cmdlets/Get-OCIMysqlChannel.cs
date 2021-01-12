/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190415
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;
using Oci.MysqlService.Models;
using Oci.Common.Waiters;

namespace Oci.MysqlService.Cmdlets
{
    [Cmdlet("Get", "OCIMysqlChannel", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.MysqlService.Models.Channel), typeof(Oci.MysqlService.Responses.GetChannelResponse) })]
    public class GetOCIMysqlChannel : OCIChannelsCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Channel [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Channel [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).", ParameterSetName = Default)]
        public string ChannelId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer-defined unique identifier for the request. If you need to contact Oracle about a specific request, please provide the request ID that you supplied in this header with the request.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer-defined unique identifier for the request. If you need to contact Oracle about a specific request, please provide the request ID that you supplied in this header with the request.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For conditional requests. In the GET call for a resource, set the `If-None-Match` header to the value of the ETag from a previous GET (or POST or PUT) response for that resource. The server will return with either a 304 Not Modified response if the resource has not changed, or a 200 OK response with the updated representation.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For conditional requests. In the GET call for a resource, set the `If-None-Match` header to the value of the ETag from a previous GET (or POST or PUT) response for that resource. The server will return with either a 304 Not Modified response if the resource has not changed, or a 200 OK response with the updated representation.", ParameterSetName = Default)]
        public string IfNoneMatch { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = LifecycleStateParamSet)]
        public Oci.MysqlService.Models.Channel.LifecycleStateEnum[] WaitForLifecycleState { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetChannelRequest request;

            try
            {
                request = new GetChannelRequest
                {
                    ChannelId = ChannelId,
                    OpcRequestId = OpcRequestId,
                    IfNoneMatch = IfNoneMatch
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

        private void HandleOutput(GetChannelRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case LifecycleStateParamSet:
                    response = client.Waiters.ForChannel(request, waiterConfig, WaitForLifecycleState).Execute();
                    break;

                case Default:
                    response = client.GetChannel(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.Channel);
        }

        private GetChannelResponse response;
        private const string LifecycleStateParamSet = "LifecycleStateParamSet";
        private const string Default = "Default";
    }
}
