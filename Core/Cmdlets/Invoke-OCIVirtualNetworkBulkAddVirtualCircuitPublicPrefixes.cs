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
    [Cmdlet("Invoke", "OCIVirtualNetworkBulkAddVirtualCircuitPublicPrefixes")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.CoreService.Responses.BulkAddVirtualCircuitPublicPrefixesResponse) })]
    public class InvokeOCIVirtualNetworkBulkAddVirtualCircuitPublicPrefixes : OCIVirtualNetworkCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the virtual circuit.")]
        public string VirtualCircuitId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request with publix prefixes to be added to the virtual circuit")]
        public BulkAddVirtualCircuitPublicPrefixesDetails BulkAddVirtualCircuitPublicPrefixesDetails { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            BulkAddVirtualCircuitPublicPrefixesRequest request;

            try
            {
                request = new BulkAddVirtualCircuitPublicPrefixesRequest
                {
                    VirtualCircuitId = VirtualCircuitId,
                    BulkAddVirtualCircuitPublicPrefixesDetails = BulkAddVirtualCircuitPublicPrefixesDetails
                };

                response = client.BulkAddVirtualCircuitPublicPrefixes(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private BulkAddVirtualCircuitPublicPrefixesResponse response;
    }
}
