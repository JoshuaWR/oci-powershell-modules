/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;
using Oci.DnsService.Models;
using Oci.Common.Model;
using Oci.Common.Waiters;

namespace Oci.DnsService.Cmdlets
{
    [Cmdlet("Get", "OCIDnsResolver", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.DnsService.Models.Resolver), typeof(Oci.DnsService.Responses.GetResolverResponse) })]
    public class GetOCIDnsResolver : OCIDnsCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the target resolver.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the target resolver.", ParameterSetName = Default)]
        public string ResolverId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-Modified-Since` header field makes a GET or HEAD request method conditional on the selected representation's modification date being more recent than the date provided in the field-value.  Transfer of the selected representation's data is avoided if that data has not changed.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-Modified-Since` header field makes a GET or HEAD request method conditional on the selected representation's modification date being more recent than the date provided in the field-value.  Transfer of the selected representation's data is avoided if that data has not changed.", ParameterSetName = Default)]
        public string IfModifiedSince { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-None-Match` header field makes the request method conditional on the absence of any current representation of the target resource, when the field-value is `*`, or having a selected representation with an entity-tag that does not match any of those listed in the field-value.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-None-Match` header field makes the request method conditional on the absence of any current representation of the target resource, when the field-value is `*`, or having a selected representation with an entity-tag that does not match any of those listed in the field-value.", ParameterSetName = Default)]
        public string IfNoneMatch { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.", ParameterSetName = Default)]
        public System.Nullable<Oci.DnsService.Models.Scope> Scope { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = LifecycleStateParamSet)]
        public Oci.DnsService.Models.Resolver.LifecycleStateEnum[] WaitForLifecycleState { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetResolverRequest request;

            try
            {
                request = new GetResolverRequest
                {
                    ResolverId = ResolverId,
                    IfModifiedSince = IfModifiedSince,
                    IfNoneMatch = IfNoneMatch,
                    OpcRequestId = OpcRequestId,
                    Scope = Scope
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

        private void HandleOutput(GetResolverRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case LifecycleStateParamSet:
                    response = client.Waiters.ForResolver(request, waiterConfig, WaitForLifecycleState).Execute();
                    break;

                case Default:
                    response = client.GetResolver(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.Resolver);
        }

        private GetResolverResponse response;
        private const string LifecycleStateParamSet = "LifecycleStateParamSet";
        private const string Default = "Default";
    }
}
