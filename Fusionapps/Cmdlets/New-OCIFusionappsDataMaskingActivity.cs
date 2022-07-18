/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FusionappsService.Requests;
using Oci.FusionappsService.Responses;
using Oci.FusionappsService.Models;
using Oci.Common.Model;

namespace Oci.FusionappsService.Cmdlets
{
    [Cmdlet("New", "OCIFusionappsDataMaskingActivity")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.FusionappsService.Responses.CreateDataMaskingActivityResponse) })]
    public class NewOCIFusionappsDataMaskingActivity : OCIDataMaskingActivityCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"unique FusionEnvironment identifier")]
        public string FusionEnvironmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for the new DataMaskingActivity.")]
        public CreateDataMaskingActivityDetails CreateDataMaskingActivityDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateDataMaskingActivityRequest request;

            try
            {
                request = new CreateDataMaskingActivityRequest
                {
                    FusionEnvironmentId = FusionEnvironmentId,
                    CreateDataMaskingActivityDetails = CreateDataMaskingActivityDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateDataMaskingActivity(request).GetAwaiter().GetResult();
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

        private CreateDataMaskingActivityResponse response;
    }
}
