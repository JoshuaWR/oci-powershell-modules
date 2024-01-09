/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20230601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.JmsjavadownloadsService.Requests;
using Oci.JmsjavadownloadsService.Responses;
using Oci.JmsjavadownloadsService.Models;
using Oci.Common.Model;

namespace Oci.JmsjavadownloadsService.Cmdlets
{
    [Cmdlet("Remove", "OCIJmsjavadownloadsJavaLicenseAcceptanceRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.JmsjavadownloadsService.Responses.DeleteJavaLicenseAcceptanceRecordResponse) })]
    public class RemoveOCIJmsjavadownloadsJavaLicenseAcceptanceRecord : OCIJavaDownloadCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Java license acceptance record identifier.")]
        public string JavaLicenseAcceptanceRecordId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the ETag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the ETag you provide matches the resource's current ETag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Ignore confirmation and force the Cmdlet to complete action.")]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (!ConfirmDelete("OCIJmsjavadownloadsJavaLicenseAcceptanceRecord", "Remove"))
            {
               return;
            }

            DeleteJavaLicenseAcceptanceRecordRequest request;

            try
            {
                request = new DeleteJavaLicenseAcceptanceRecordRequest
                {
                    JavaLicenseAcceptanceRecordId = JavaLicenseAcceptanceRecordId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.DeleteJavaLicenseAcceptanceRecord(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private DeleteJavaLicenseAcceptanceRecordResponse response;
    }
}
