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

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Remove", "OCIVirtualNetworkDrgRouteDistributionStatements")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.CoreService.Responses.RemoveDrgRouteDistributionStatementsResponse) })]
    public class RemoveOCIVirtualNetworkDrgRouteDistributionStatements : OCIVirtualNetworkCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route distribution.")]
        public string DrgRouteDistributionId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request with one or more route distribution statements to remove from the route distribution.")]
        public RemoveDrgRouteDistributionStatementsDetails RemoveDrgRouteDistributionStatementsDetails { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RemoveDrgRouteDistributionStatementsRequest request;

            try
            {
                request = new RemoveDrgRouteDistributionStatementsRequest
                {
                    DrgRouteDistributionId = DrgRouteDistributionId,
                    RemoveDrgRouteDistributionStatementsDetails = RemoveDrgRouteDistributionStatementsDetails
                };

                response = client.RemoveDrgRouteDistributionStatements(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private RemoveDrgRouteDistributionStatementsResponse response;
    }
}
