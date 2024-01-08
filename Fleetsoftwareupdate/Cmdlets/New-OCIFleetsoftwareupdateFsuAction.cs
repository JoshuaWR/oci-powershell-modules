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
    [Cmdlet("New", "OCIFleetsoftwareupdateFsuAction")]
    [OutputType(new System.Type[] { typeof(Oci.FleetsoftwareupdateService.Models.FsuAction), typeof(Oci.FleetsoftwareupdateService.Responses.CreateFsuActionResponse) })]
    public class NewOCIFleetsoftwareupdateFsuAction : OCIFleetSoftwareUpdateCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for the new Exadata Fleet Update Action. This parameter also accepts subtypes <Oci.FleetsoftwareupdateService.Models.CreateApplyActionDetails>, <Oci.FleetsoftwareupdateService.Models.CreateStageActionDetails>, <Oci.FleetsoftwareupdateService.Models.CreateRollbackActionDetails>, <Oci.FleetsoftwareupdateService.Models.CreateCleanupActionDetails>, <Oci.FleetsoftwareupdateService.Models.CreatePrecheckActionDetails> of type <Oci.FleetsoftwareupdateService.Models.CreateFsuActionDetails>.")]
        public CreateFsuActionDetails CreateFsuActionDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateFsuActionRequest request;

            try
            {
                request = new CreateFsuActionRequest
                {
                    CreateFsuActionDetails = CreateFsuActionDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateFsuAction(request).GetAwaiter().GetResult();
                WriteOutput(response, response.FsuAction);
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

        private CreateFsuActionResponse response;
    }
}
