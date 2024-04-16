/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;
using Oci.Common.Model;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Update", "OCIDatabaseAutonomousDatabaseSoftwareImage")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.AutonomousDatabaseSoftwareImage), typeof(Oci.DatabaseService.Responses.UpdateAutonomousDatabaseSoftwareImageResponse) })]
    public class UpdateOCIDatabaseAutonomousDatabaseSoftwareImage : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Autonomous Database Software Image [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string AutonomousDatabaseSoftwareImageId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request to update the properties of an Autonomous Database Software Image.")]
        public UpdateAutonomousDatabaseSoftwareImageDetails UpdateAutonomousDatabaseSoftwareImageDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateAutonomousDatabaseSoftwareImageRequest request;

            try
            {
                request = new UpdateAutonomousDatabaseSoftwareImageRequest
                {
                    AutonomousDatabaseSoftwareImageId = AutonomousDatabaseSoftwareImageId,
                    UpdateAutonomousDatabaseSoftwareImageDetails = UpdateAutonomousDatabaseSoftwareImageDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateAutonomousDatabaseSoftwareImage(request).GetAwaiter().GetResult();
                WriteOutput(response, response.AutonomousDatabaseSoftwareImage);
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

        private UpdateAutonomousDatabaseSoftwareImageResponse response;
    }
}
