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
    [Cmdlet("Update", "OCIDatacatalogAttribute")]
    [OutputType(new System.Type[] { typeof(Oci.DatacatalogService.Models.Attribute), typeof(Oci.DatacatalogService.Responses.UpdateAttributeResponse) })]
    public class UpdateOCIDatacatalogAttribute : OCIDataCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique catalog identifier.")]
        public string CatalogId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique data asset key.")]
        public string DataAssetKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique entity key.")]
        public string EntityKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique attribute key.")]
        public string AttributeKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated in the attribute.")]
        public UpdateAttributeDetails UpdateAttributeDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateAttributeRequest request;

            try
            {
                request = new UpdateAttributeRequest
                {
                    CatalogId = CatalogId,
                    DataAssetKey = DataAssetKey,
                    EntityKey = EntityKey,
                    AttributeKey = AttributeKey,
                    UpdateAttributeDetails = UpdateAttributeDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateAttribute(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Attribute);
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

        private UpdateAttributeResponse response;
    }
}
