/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.NetworkloadbalancerService.Requests;
using Oci.NetworkloadbalancerService.Responses;
using Oci.NetworkloadbalancerService.Models;
using Oci.Common.Model;

namespace Oci.NetworkloadbalancerService.Cmdlets
{
    [Cmdlet("Get", "OCINetworkloadbalancerListener")]
    [OutputType(new System.Type[] { typeof(Oci.NetworkloadbalancerService.Models.Listener), typeof(Oci.NetworkloadbalancerService.Responses.GetListenerResponse) })]
    public class GetOCINetworkloadbalancerListener : OCINetworkLoadBalancerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network load balancer to update.")]
        public string NetworkLoadBalancerId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the listener to get.

Example: `example_listener`")]
        public string ListenerName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you must contact Oracle about a particular request, then provide the request identifier.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The system returns the requested resource, with a 200 status, only if the resource has no etag matching the one specified. If the condition fails for the GET and HEAD methods, then the system returns the HTTP status code `304 (Not Modified)`.

Example: `example-etag`")]
        public string IfNoneMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetListenerRequest request;

            try
            {
                request = new GetListenerRequest
                {
                    NetworkLoadBalancerId = NetworkLoadBalancerId,
                    ListenerName = ListenerName,
                    OpcRequestId = OpcRequestId,
                    IfNoneMatch = IfNoneMatch
                };

                response = client.GetListener(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Listener);
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

        private GetListenerResponse response;
    }
}
