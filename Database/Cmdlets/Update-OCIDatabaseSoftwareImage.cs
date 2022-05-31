/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
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
    [Cmdlet("Update", "OCIDatabaseSoftwareImage")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.DatabaseSoftwareImage), typeof(Oci.DatabaseService.Responses.UpdateDatabaseSoftwareImageResponse) })]
    public class UpdateOCIDatabaseSoftwareImage : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The DB system [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string DatabaseSoftwareImageId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request to update the properties of a DB system.")]
        public UpdateDatabaseSoftwareImageDetails UpdateDatabaseSoftwareImageDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateDatabaseSoftwareImageRequest request;

            try
            {
                request = new UpdateDatabaseSoftwareImageRequest
                {
                    DatabaseSoftwareImageId = DatabaseSoftwareImageId,
                    UpdateDatabaseSoftwareImageDetails = UpdateDatabaseSoftwareImageDetails,
                    IfMatch = IfMatch
                };

                response = client.UpdateDatabaseSoftwareImage(request).GetAwaiter().GetResult();
                WriteOutput(response, response.DatabaseSoftwareImage);
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

        private UpdateDatabaseSoftwareImageResponse response;
    }
}
