/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ApigatewayService.Requests;
using Oci.ApigatewayService.Responses;
using Oci.ApigatewayService.Models;
using Oci.Common.Model;

namespace Oci.ApigatewayService.Cmdlets
{
    [Cmdlet("Move", "OCIApigatewayUsagePlanCompartment")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.ApigatewayService.Responses.ChangeUsagePlanCompartmentResponse) })]
    public class MoveOCIApigatewayUsagePlanCompartment : OCIUsagePlansCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ocid of the usage plan.")]
        public string UsagePlanId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details of the target compartment.")]
        public ChangeUsagePlanCompartmentDetails ChangeUsagePlanCompartmentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request id for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeUsagePlanCompartmentRequest request;

            try
            {
                request = new ChangeUsagePlanCompartmentRequest
                {
                    UsagePlanId = UsagePlanId,
                    ChangeUsagePlanCompartmentDetails = ChangeUsagePlanCompartmentDetails,
                    OpcRetryToken = OpcRetryToken,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.ChangeUsagePlanCompartment(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private ChangeUsagePlanCompartmentResponse response;
    }
}
