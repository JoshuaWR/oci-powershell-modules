/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;
using Oci.OsmanagementService.Models;

namespace Oci.OsmanagementService.Cmdlets
{
    [Cmdlet("Update", "OCIOsmanagementSoftwareSource")]
    [OutputType(new System.Type[] { typeof(Oci.OsmanagementService.Models.SoftwareSource), typeof(Oci.OsmanagementService.Responses.UpdateSoftwareSourceResponse) })]
    public class UpdateOCIOsmanagementSoftwareSource : OCIOsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the software source.")]
        public string SoftwareSourceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details about a Sofware Source to update")]
        public UpdateSoftwareSourceDetails UpdateSoftwareSourceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateSoftwareSourceRequest request;

            try
            {
                request = new UpdateSoftwareSourceRequest
                {
                    SoftwareSourceId = SoftwareSourceId,
                    UpdateSoftwareSourceDetails = UpdateSoftwareSourceDetails,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch
                };

                response = client.UpdateSoftwareSource(request).GetAwaiter().GetResult();
                WriteOutput(response, response.SoftwareSource);
                FinishProcessing(response);
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

        private UpdateSoftwareSourceResponse response;
    }
}
