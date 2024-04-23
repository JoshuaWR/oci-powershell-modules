/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;
using Oci.Common.Model;
using Oci.Common.Waiters;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Remove", "OCIVirtualNetworkVcnCidr", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.CoreService.Responses.RemoveVcnCidrResponse) })]
    public class RemoveOCIVirtualNetworkVcnCidr : OCIVirtualNetworkCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN.", ParameterSetName = Default)]
        public string VcnId { get; set; }

        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details object for removing a VCN CIDR.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details object for removing a VCN CIDR.", ParameterSetName = Default)]
        public RemoveVcnCidrDetails RemoveVcnCidrDetails { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).", ParameterSetName = Default)]
        public string OpcRetryToken { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.", ParameterSetName = StatusParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.", ParameterSetName = Default)]
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
            RemoveVcnCidrRequest request;

            try
            {
                request = new RemoveVcnCidrRequest
                {
                    VcnId = VcnId,
                    RemoveVcnCidrDetails = RemoveVcnCidrDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken,
                    IfMatch = IfMatch
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

        private void HandleOutput(RemoveVcnCidrRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case StatusParamSet:
                    response = client.Waiters.ForRemoveVcnCidr(request, waiterConfig, WaitForStatus).Execute();
                    break;

                case Default:
                    response = client.RemoveVcnCidr(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
        }

        private RemoveVcnCidrResponse response;
        private const string StatusParamSet = "StatusParamSet";
        private const string Default = "Default";
    }
}
