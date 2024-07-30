/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220528
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FleetsoftwareupdateService.Requests;
using Oci.FleetsoftwareupdateService.Responses;
using Oci.FleetsoftwareupdateService.Models;
using Oci.Common.Model;

namespace Oci.FleetsoftwareupdateService.Cmdlets
{
    [Cmdlet("Get", "OCIFleetsoftwareupdateFsuCollectionTarget")]
    [OutputType(new System.Type[] { typeof(Oci.FleetsoftwareupdateService.Models.FsuCollectionTarget), typeof(Oci.FleetsoftwareupdateService.Responses.GetFsuCollectionTargetResponse) })]
    public class GetOCIFleetsoftwareupdateFsuCollectionTarget : OCIFleetSoftwareUpdateCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Exadata Fleet Update Collection identifier.")]
        public string FsuCollectionId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Target resource OCID.")]
        public string TargetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetFsuCollectionTargetRequest request;

            try
            {
                request = new GetFsuCollectionTargetRequest
                {
                    FsuCollectionId = FsuCollectionId,
                    TargetId = TargetId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetFsuCollectionTarget(request).GetAwaiter().GetResult();
                WriteOutput(response, response.FsuCollectionTarget);
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

        private GetFsuCollectionTargetResponse response;
    }
}
