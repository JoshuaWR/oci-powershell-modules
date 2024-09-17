/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20231107
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CapacitymanagementService.Requests;
using Oci.CapacitymanagementService.Responses;
using Oci.CapacitymanagementService.Models;
using Oci.Common.Model;

namespace Oci.CapacitymanagementService.Cmdlets
{
    [Cmdlet("New", "OCICapacitymanagementOccCustomer")]
    [OutputType(new System.Type[] { typeof(Oci.CapacitymanagementService.Models.OccCustomer), typeof(Oci.CapacitymanagementService.Responses.CreateOccCustomerResponse) })]
    public class NewOCICapacitymanagementOccCustomer : OCICapacityManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The request details for creating a customer.")]
        public CreateOccCustomerDetails CreateOccCustomerDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the customer group.")]
        public string OccCustomerGroupId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing. The only valid characters for request IDs are letters, numbers, underscore, and dash.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateOccCustomerRequest request;

            try
            {
                request = new CreateOccCustomerRequest
                {
                    CreateOccCustomerDetails = CreateOccCustomerDetails,
                    OccCustomerGroupId = OccCustomerGroupId,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateOccCustomer(request).GetAwaiter().GetResult();
                WriteOutput(response, response.OccCustomer);
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

        private CreateOccCustomerResponse response;
    }
}
