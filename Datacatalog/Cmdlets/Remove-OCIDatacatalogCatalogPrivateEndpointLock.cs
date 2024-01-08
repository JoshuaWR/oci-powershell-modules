/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190325
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
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
    [Cmdlet("Remove", "OCIDatacatalogCatalogPrivateEndpointLock")]
    [OutputType(new System.Type[] { typeof(Oci.DatacatalogService.Models.CatalogPrivateEndpoint), typeof(Oci.DatacatalogService.Responses.RemoveCatalogPrivateEndpointLockResponse) })]
    public class RemoveOCIDatacatalogCatalogPrivateEndpointLock : OCIDataCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique private reverse connection identifier.")]
        public string CatalogPrivateEndpointId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"RemoveResourceLockDetails body parameter")]
        public RemoveResourceLockDetails RemoveResourceLockDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RemoveCatalogPrivateEndpointLockRequest request;

            try
            {
                request = new RemoveCatalogPrivateEndpointLockRequest
                {
                    CatalogPrivateEndpointId = CatalogPrivateEndpointId,
                    RemoveResourceLockDetails = RemoveResourceLockDetails,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch
                };

                response = client.RemoveCatalogPrivateEndpointLock(request).GetAwaiter().GetResult();
                WriteOutput(response, response.CatalogPrivateEndpoint);
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

        private RemoveCatalogPrivateEndpointLockResponse response;
    }
}
