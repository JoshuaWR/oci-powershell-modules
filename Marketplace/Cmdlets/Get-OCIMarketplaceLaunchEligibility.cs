/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MarketplaceService.Requests;
using Oci.MarketplaceService.Responses;
using Oci.MarketplaceService.Models;
using Oci.Common.Model;

namespace Oci.MarketplaceService.Cmdlets
{
    [Cmdlet("Get", "OCIMarketplaceLaunchEligibility")]
    [OutputType(new System.Type[] { typeof(Oci.MarketplaceService.Models.LaunchEligibility), typeof(Oci.MarketplaceService.Responses.GetLaunchEligibilityResponse) })]
    public class GetOCIMarketplaceLaunchEligibility : OCIAccountCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique identifier for the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Image ID")]
        public string ImageId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetLaunchEligibilityRequest request;

            try
            {
                request = new GetLaunchEligibilityRequest
                {
                    CompartmentId = CompartmentId,
                    ImageId = ImageId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetLaunchEligibility(request).GetAwaiter().GetResult();
                WriteOutput(response, response.LaunchEligibility);
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

        private GetLaunchEligibilityResponse response;
    }
}
