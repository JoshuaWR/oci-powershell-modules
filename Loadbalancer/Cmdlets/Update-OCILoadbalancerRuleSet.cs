/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20170115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoadbalancerService.Requests;
using Oci.LoadbalancerService.Responses;
using Oci.LoadbalancerService.Models;

namespace Oci.LoadbalancerService.Cmdlets
{
    [Cmdlet("Update", "OCILoadbalancerRuleSet")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.LoadbalancerService.Responses.UpdateRuleSetResponse) })]
    public class UpdateOCILoadbalancerRuleSet : OCILoadBalancerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the specified load balancer.")]
        public string LoadBalancerId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the rule set to update.

Example: `example_rule_set`")]
        public string RuleSetName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The configuration details to update a set of rules.")]
        public UpdateRuleSetDetails UpdateRuleSetDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateRuleSetRequest request;

            try
            {
                request = new UpdateRuleSetRequest
                {
                    LoadBalancerId = LoadBalancerId,
                    RuleSetName = RuleSetName,
                    UpdateRuleSetDetails = UpdateRuleSetDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateRuleSet(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private UpdateRuleSetResponse response;
    }
}
