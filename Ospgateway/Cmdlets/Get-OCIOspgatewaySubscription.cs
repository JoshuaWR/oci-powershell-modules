/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20191001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OspgatewayService.Requests;
using Oci.OspgatewayService.Responses;
using Oci.OspgatewayService.Models;
using Oci.Common.Model;

namespace Oci.OspgatewayService.Cmdlets
{
    [Cmdlet("Get", "OCIOspgatewaySubscription")]
    [OutputType(new System.Type[] { typeof(Oci.OspgatewayService.Models.Subscription), typeof(Oci.OspgatewayService.Responses.GetSubscriptionResponse) })]
    public class GetOCIOspgatewaySubscription : OCISubscriptionServiceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Subscription id(OCID).")]
        public string SubscriptionId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The home region's public name of the logged in user.")]
        public string OspHomeRegion { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetSubscriptionRequest request;

            try
            {
                request = new GetSubscriptionRequest
                {
                    SubscriptionId = SubscriptionId,
                    OspHomeRegion = OspHomeRegion,
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetSubscription(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Subscription);
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

        private GetSubscriptionResponse response;
    }
}
