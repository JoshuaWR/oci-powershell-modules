/*
 * NOTE: Generated using OracleSDKGenerator, API Version: release
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;
using Oci.KeymanagementService.Models;
using Oci.Common.Model;

namespace Oci.KeymanagementService.Cmdlets
{
    [Cmdlet("Remove", "OCIKeymanagementEkmsPrivateEndpoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.KeymanagementService.Responses.DeleteEkmsPrivateEndpointResponse) })]
    public class RemoveOCIKeymanagementEkmsPrivateEndpoint : OCIEkmCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique EKMS private endpoint identifier.")]
        public string EkmsPrivateEndpointId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Ignore confirmation and force the Cmdlet to complete action.")]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (!ConfirmDelete("OCIKeymanagementEkmsPrivateEndpoint", "Remove"))
            {
               return;
            }

            DeleteEkmsPrivateEndpointRequest request;

            try
            {
                request = new DeleteEkmsPrivateEndpointRequest
                {
                    EkmsPrivateEndpointId = EkmsPrivateEndpointId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.DeleteEkmsPrivateEndpoint(request).GetAwaiter().GetResult();
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

        private DeleteEkmsPrivateEndpointResponse response;
    }
}
