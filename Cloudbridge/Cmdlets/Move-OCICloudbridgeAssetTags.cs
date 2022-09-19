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
    [Cmdlet("Move", "OCICloudbridgeAssetTags")]
    [OutputType(new System.Type[] { typeof(Oci.CloudbridgeService.Models.Asset), typeof(Oci.CloudbridgeService.Responses.ChangeAssetTagsResponse) })]
    public class MoveOCICloudbridgeAssetTags : OCIInventoryCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique asset identifier.")]
        public string AssetId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated.")]
        public ChangeAssetTagsDetails ChangeAssetTagsDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing the same action again. Retry tokens expire after 24 hours, but can be invalidated before 24 hours due to conflicting operations. For example, if a resource has been deleted and purged from the system, a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeAssetTagsRequest request;

            try
            {
                request = new ChangeAssetTagsRequest
                {
                    AssetId = AssetId,
                    ChangeAssetTagsDetails = ChangeAssetTagsDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.ChangeAssetTags(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Asset);
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

        private ChangeAssetTagsResponse response;
    }
}
