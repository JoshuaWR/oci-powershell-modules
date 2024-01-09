/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180917
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ResourcemanagerService.Requests;
using Oci.ResourcemanagerService.Responses;
using Oci.ResourcemanagerService.Models;
using Oci.Common.Model;

namespace Oci.ResourcemanagerService.Cmdlets
{
    [Cmdlet("New", "OCIResourcemanagerPrivateEndpoint")]
    [OutputType(new System.Type[] { typeof(Oci.ResourcemanagerService.Models.PrivateEndpoint), typeof(Oci.ResourcemanagerService.Responses.CreatePrivateEndpointResponse) })]
    public class NewOCIResourcemanagerPrivateEndpoint : OCIResourceManagerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Creation details for a private endpoint.")]
        public CreatePrivateEndpointDetails CreatePrivateEndpointDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of retrying the same action. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreatePrivateEndpointRequest request;

            try
            {
                request = new CreatePrivateEndpointRequest
                {
                    CreatePrivateEndpointDetails = CreatePrivateEndpointDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreatePrivateEndpoint(request).GetAwaiter().GetResult();
                WriteOutput(response, response.PrivateEndpoint);
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

        private CreatePrivateEndpointResponse response;
    }
}
