/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;
using Oci.OsmanagementService.Models;
using Oci.Common.Model;

namespace Oci.OsmanagementService.Cmdlets
{
    [Cmdlet("Remove", "OCIOsmanagementPackagesFromSoftwareSource")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.OsmanagementService.Responses.RemovePackagesFromSoftwareSourceResponse) })]
    public class RemoveOCIOsmanagementPackagesFromSoftwareSource : OCIOsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the software source.")]
        public string SoftwareSourceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A list of package identifiers")]
        public RemovePackagesFromSoftwareSourceDetails RemovePackagesFromSoftwareSourceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RemovePackagesFromSoftwareSourceRequest request;

            try
            {
                request = new RemovePackagesFromSoftwareSourceRequest
                {
                    SoftwareSourceId = SoftwareSourceId,
                    RemovePackagesFromSoftwareSourceDetails = RemovePackagesFromSoftwareSourceDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.RemovePackagesFromSoftwareSource(request).GetAwaiter().GetResult();
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

        private RemovePackagesFromSoftwareSourceResponse response;
    }
}
