/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ApmconfigService.Requests;
using Oci.ApmconfigService.Responses;
using Oci.ApmconfigService.Models;
using Oci.Common.Model;

namespace Oci.ApmconfigService.Cmdlets
{
    [Cmdlet("New", "OCIApmconfigConfig")]
    [OutputType(new System.Type[] { typeof(Oci.ApmconfigService.Models.Config), typeof(Oci.ApmconfigService.Responses.CreateConfigResponse) })]
    public class NewOCIApmconfigConfig : OCIConfigCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The APM Domain ID the request is intended for.")]
        public string ApmDomainId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The configuration details of the new item. This parameter also accepts subtypes <Oci.ApmconfigService.Models.CreateSpanFilterDetails>, <Oci.ApmconfigService.Models.CreateMetricGroupDetails>, <Oci.ApmconfigService.Models.CreateOptionsDetails>, <Oci.ApmconfigService.Models.CreateApdexRulesDetails> of type <Oci.ApmconfigService.Models.CreateConfigDetails>.")]
        public CreateConfigDetails CreateConfigDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Indicates that the request is a dry run, if set to ""true"". A dry run request does not modify the configuration item details and is used only to perform validation on the submitted data.")]
        public string OpcDryRun { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateConfigRequest request;

            try
            {
                request = new CreateConfigRequest
                {
                    ApmDomainId = ApmDomainId,
                    CreateConfigDetails = CreateConfigDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId,
                    OpcDryRun = OpcDryRun
                };

                response = client.CreateConfig(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Config);
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

        private CreateConfigResponse response;
    }
}
