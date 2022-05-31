/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190325
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatacatalogService.Requests;
using Oci.DatacatalogService.Responses;
using Oci.DatacatalogService.Models;
using Oci.Common.Model;

namespace Oci.DatacatalogService.Cmdlets
{
    [Cmdlet("DisMount", "OCIDatacatalogCatalogPrivateEndpoint")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.DatacatalogService.Responses.DetachCatalogPrivateEndpointResponse) })]
    public class DisMountOCIDatacatalogCatalogPrivateEndpoint : OCIDataCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for private reverse connection endpoint to be used for attachment")]
        public DetachCatalogPrivateEndpointDetails DetachCatalogPrivateEndpointDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique catalog identifier.")]
        public string CatalogId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            DetachCatalogPrivateEndpointRequest request;

            try
            {
                request = new DetachCatalogPrivateEndpointRequest
                {
                    DetachCatalogPrivateEndpointDetails = DetachCatalogPrivateEndpointDetails,
                    CatalogId = CatalogId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.DetachCatalogPrivateEndpoint(request).GetAwaiter().GetResult();
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

        private DetachCatalogPrivateEndpointResponse response;
    }
}
