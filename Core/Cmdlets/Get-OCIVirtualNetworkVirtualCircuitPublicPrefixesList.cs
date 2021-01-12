/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Get", "OCIVirtualNetworkVirtualCircuitPublicPrefixesList")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.VirtualCircuitPublicPrefix), typeof(Oci.CoreService.Responses.ListVirtualCircuitPublicPrefixesResponse) })]
    public class GetOCIVirtualNetworkVirtualCircuitPublicPrefixesList : OCIVirtualNetworkCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the virtual circuit.")]
        public string VirtualCircuitId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to only return resources that match the given verification state. The state value is case-insensitive.")]
        public System.Nullable<Oci.CoreService.Models.VirtualCircuitPublicPrefix.VerificationStateEnum> VerificationState { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListVirtualCircuitPublicPrefixesRequest request;

            try
            {
                request = new ListVirtualCircuitPublicPrefixesRequest
                {
                    VirtualCircuitId = VirtualCircuitId,
                    VerificationState = VerificationState
                };

                response = client.ListVirtualCircuitPublicPrefixes(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Items, true);
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

        private ListVirtualCircuitPublicPrefixesResponse response;
    }
}
