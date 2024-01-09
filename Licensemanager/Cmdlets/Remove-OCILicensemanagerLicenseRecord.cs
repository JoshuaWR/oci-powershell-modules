/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220430
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LicensemanagerService.Requests;
using Oci.LicensemanagerService.Responses;
using Oci.LicensemanagerService.Models;
using Oci.Common.Model;

namespace Oci.LicensemanagerService.Cmdlets
{
    [Cmdlet("Remove", "OCILicensemanagerLicenseRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.LicensemanagerService.Responses.DeleteLicenseRecordResponse) })]
    public class RemoveOCILicensemanagerLicenseRecord : OCILicenseManagerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique license record identifier.")]
        public string LicenseRecordId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Ignore confirmation and force the Cmdlet to complete action.")]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (!ConfirmDelete("OCILicensemanagerLicenseRecord", "Remove"))
            {
               return;
            }

            DeleteLicenseRecordRequest request;

            try
            {
                request = new DeleteLicenseRecordRequest
                {
                    LicenseRecordId = LicenseRecordId,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch
                };

                response = client.DeleteLicenseRecord(request).GetAwaiter().GetResult();
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

        private DeleteLicenseRecordResponse response;
    }
}
