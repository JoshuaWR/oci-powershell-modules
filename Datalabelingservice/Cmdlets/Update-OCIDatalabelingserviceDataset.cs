/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatalabelingService.Requests;
using Oci.DatalabelingService.Responses;
using Oci.DatalabelingService.Models;
using Oci.Common.Model;

namespace Oci.DatalabelingService.Cmdlets
{
    [Cmdlet("Update", "OCIDatalabelingserviceDataset")]
    [OutputType(new System.Type[] { typeof(Oci.DatalabelingService.Models.Dataset), typeof(Oci.DatalabelingService.Responses.UpdateDatasetResponse) })]
    public class UpdateOCIDatalabelingserviceDataset : OCIDataLabelingManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Dataset OCID")]
        public string DatasetId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for updating a Dataset.")]
        public UpdateDatasetDetails UpdateDatasetDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateDatasetRequest request;

            try
            {
                request = new UpdateDatasetRequest
                {
                    DatasetId = DatasetId,
                    UpdateDatasetDetails = UpdateDatasetDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateDataset(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Dataset);
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

        private UpdateDatasetResponse response;
    }
}
