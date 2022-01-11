/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;
using Oci.Common.Waiters;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Get", "OCIVirtualNetworkLocalPeeringGateway", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.LocalPeeringGateway), typeof(Oci.CoreService.Responses.GetLocalPeeringGatewayResponse) })]
    public class GetOCIVirtualNetworkLocalPeeringGateway : OCIVirtualNetworkCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the local peering gateway.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the local peering gateway.", ParameterSetName = PeeringStatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the local peering gateway.", ParameterSetName = Default)]
        public string LocalPeeringGatewayId { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = LifecycleStateParamSet)]
        public Oci.CoreService.Models.LocalPeeringGateway.LifecycleStateEnum[] WaitForLifecycleState { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = PeeringStatusParamSet)]
        public Oci.CoreService.Models.LocalPeeringGateway.PeeringStatusEnum[] WaitForPeeringStatus { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = PeeringStatusParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = PeeringStatusParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetLocalPeeringGatewayRequest request;

            try
            {
                request = new GetLocalPeeringGatewayRequest
                {
                    LocalPeeringGatewayId = LocalPeeringGatewayId
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

        private void HandleOutput(GetLocalPeeringGatewayRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case LifecycleStateParamSet:
                    response = client.Waiters.ForLocalPeeringGateway(request, waiterConfig, WaitForLifecycleState).Execute();
                    break;


                case PeeringStatusParamSet:
                    response = client.Waiters.ForLocalPeeringGateway(request, waiterConfig, WaitForPeeringStatus).Execute();
                    break;

                case Default:
                    response = client.GetLocalPeeringGateway(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.LocalPeeringGateway);
        }

        private GetLocalPeeringGatewayResponse response;
        private const string LifecycleStateParamSet = "LifecycleStateParamSet";
        private const string PeeringStatusParamSet = "PeeringStatusParamSet";
        private const string Default = "Default";
    }
}
