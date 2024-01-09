/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20230501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.NetworkfirewallService.Requests;
using Oci.NetworkfirewallService.Responses;
using Oci.NetworkfirewallService.Models;
using Oci.Common.Model;

namespace Oci.NetworkfirewallService.Cmdlets
{
    [Cmdlet("Get", "OCINetworkfirewallUrlList")]
    [OutputType(new System.Type[] { typeof(Oci.NetworkfirewallService.Models.UrlList), typeof(Oci.NetworkfirewallService.Responses.GetUrlListResponse) })]
    public class GetOCINetworkfirewallUrlList : OCINetworkFirewallCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Network Firewall Policy identifier")]
        public string NetworkFirewallPolicyId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique name identifier for url lists in the scope of Network Firewall Policy.")]
        public string UrlListName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetUrlListRequest request;

            try
            {
                request = new GetUrlListRequest
                {
                    NetworkFirewallPolicyId = NetworkFirewallPolicyId,
                    UrlListName = UrlListName,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetUrlList(request).GetAwaiter().GetResult();
                WriteOutput(response, response.UrlList);
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

        private GetUrlListResponse response;
    }
}
