/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220509
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CloudbridgeService.Requests;
using Oci.CloudbridgeService.Responses;
using Oci.CloudbridgeService.Models;
using Oci.Common.Model;

namespace Oci.CloudbridgeService.Cmdlets
{
    [Cmdlet("Update", "OCICloudbridgeAssetSource")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.CloudbridgeService.Responses.UpdateAssetSourceResponse) })]
    public class UpdateOCICloudbridgeAssetSource : OCIDiscoveryCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the asset source.")]
        public string AssetSourceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Asset source information to be updated. This parameter also accepts subtype <Oci.CloudbridgeService.Models.UpdateVmWareAssetSourceDetails> of type <Oci.CloudbridgeService.Models.UpdateAssetSourceDetails>.")]
        public UpdateAssetSourceDetails UpdateAssetSourceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateAssetSourceRequest request;

            try
            {
                request = new UpdateAssetSourceRequest
                {
                    AssetSourceId = AssetSourceId,
                    UpdateAssetSourceDetails = UpdateAssetSourceDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateAssetSource(request).GetAwaiter().GetResult();
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

        private UpdateAssetSourceResponse response;
    }
}
