/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181116
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.WaasService.Requests;
using Oci.WaasService.Responses;
using Oci.WaasService.Models;
using Oci.Common.Model;
using Oci.Common.Waiters;

namespace Oci.WaasService.Cmdlets
{
    [Cmdlet("Get", "OCIWaasCustomProtectionRule", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.WaasService.Models.CustomProtectionRule), typeof(Oci.WaasService.Responses.GetCustomProtectionRuleResponse) })]
    public class GetOCIWaasCustomProtectionRule : OCIWaasCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the custom protection rule. This number is generated when the custom protection rule is added to the compartment.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the custom protection rule. This number is generated when the custom protection rule is added to the compartment.", ParameterSetName = Default)]
        public string CustomProtectionRuleId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = LifecycleStateParamSet)]
        public Oci.WaasService.Models.LifecycleStates[] WaitForLifecycleState { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCustomProtectionRuleRequest request;

            try
            {
                request = new GetCustomProtectionRuleRequest
                {
                    CustomProtectionRuleId = CustomProtectionRuleId,
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

        private void HandleOutput(GetCustomProtectionRuleRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case LifecycleStateParamSet:
                    response = client.Waiters.ForCustomProtectionRule(request, waiterConfig, WaitForLifecycleState).Execute();
                    break;

                case Default:
                    response = client.GetCustomProtectionRule(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.CustomProtectionRule);
        }

        private GetCustomProtectionRuleResponse response;
        private const string LifecycleStateParamSet = "LifecycleStateParamSet";
        private const string Default = "Default";
    }
}
