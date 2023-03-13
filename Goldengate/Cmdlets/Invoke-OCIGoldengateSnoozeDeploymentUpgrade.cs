/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200407
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.GoldengateService.Requests;
using Oci.GoldengateService.Responses;
using Oci.GoldengateService.Models;
using Oci.Common.Model;

namespace Oci.GoldengateService.Cmdlets
{
    [Cmdlet("Invoke", "OCIGoldengateSnoozeDeploymentUpgrade")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.GoldengateService.Responses.SnoozeDeploymentUpgradeResponse) })]
    public class InvokeOCIGoldengateSnoozeDeploymentUpgrade : OCIGoldenGateCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A unique Deployment Upgrade identifier.")]
        public string DeploymentUpgradeId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A placeholder for any additional metadata to describe the snooze of deployment upgrade. This parameter also accepts subtype <Oci.GoldengateService.Models.DefaultSnoozeDeploymentUpgradeDetails> of type <Oci.GoldengateService.Models.SnoozeDeploymentUpgradeDetails>.")]
        public SnoozeDeploymentUpgradeDetails SnoozeDeploymentUpgradeDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource is updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried, in case of a timeout or server error, without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request is rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            SnoozeDeploymentUpgradeRequest request;

            try
            {
                request = new SnoozeDeploymentUpgradeRequest
                {
                    DeploymentUpgradeId = DeploymentUpgradeId,
                    SnoozeDeploymentUpgradeDetails = SnoozeDeploymentUpgradeDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.SnoozeDeploymentUpgrade(request).GetAwaiter().GetResult();
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

        private SnoozeDeploymentUpgradeResponse response;
    }
}
