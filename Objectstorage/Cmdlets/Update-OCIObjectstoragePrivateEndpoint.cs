/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;
using Oci.ObjectstorageService.Models;
using Oci.Common.Model;

namespace Oci.ObjectstorageService.Cmdlets
{
    [Cmdlet("Update", "OCIObjectstoragePrivateEndpoint")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.ObjectstorageService.Responses.UpdatePrivateEndpointResponse) })]
    public class UpdateOCIObjectstoragePrivateEndpoint : OCIObjectStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Object Storage namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the private endpoint. Avoid entering confidential information. Example: `my-new-pe-1`")]
        public string PeName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request object for updating the Private Endpoint.")]
        public UpdatePrivateEndpointDetails UpdatePrivateEndpointDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcClientRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag (ETag) to match with the ETag of an existing resource. If the specified ETag matches the ETag of the existing resource, GET and HEAD requests will return the resource and PUT and POST requests will upload the resource.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdatePrivateEndpointRequest request;

            try
            {
                request = new UpdatePrivateEndpointRequest
                {
                    NamespaceName = NamespaceName,
                    PeName = PeName,
                    UpdatePrivateEndpointDetails = UpdatePrivateEndpointDetails,
                    OpcClientRequestId = OpcClientRequestId,
                    IfMatch = IfMatch
                };

                response = client.UpdatePrivateEndpoint(request).GetAwaiter().GetResult();
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

        private UpdatePrivateEndpointResponse response;
    }
}
