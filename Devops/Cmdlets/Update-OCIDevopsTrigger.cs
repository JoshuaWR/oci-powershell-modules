/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DevopsService.Requests;
using Oci.DevopsService.Responses;
using Oci.DevopsService.Models;
using Oci.Common.Model;

namespace Oci.DevopsService.Cmdlets
{
    [Cmdlet("Update", "OCIDevopsTrigger")]
    [OutputType(new System.Type[] { typeof(Oci.DevopsService.Models.Trigger), typeof(Oci.DevopsService.Responses.UpdateTriggerResponse) })]
    public class UpdateOCIDevopsTrigger : OCIDevopsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique trigger identifier.")]
        public string TriggerId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated. This parameter also accepts subtypes <Oci.DevopsService.Models.UpdateBitbucketServerTriggerDetails>, <Oci.DevopsService.Models.UpdateVbsTriggerDetails>, <Oci.DevopsService.Models.UpdateGitlabServerTriggerDetails>, <Oci.DevopsService.Models.UpdateDevopsCodeRepositoryTriggerDetails>, <Oci.DevopsService.Models.UpdateGithubTriggerDetails>, <Oci.DevopsService.Models.UpdateGitlabTriggerDetails>, <Oci.DevopsService.Models.UpdateBitbucketCloudTriggerDetails> of type <Oci.DevopsService.Models.UpdateTriggerDetails>.")]
        public UpdateTriggerDetails UpdateTriggerDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateTriggerRequest request;

            try
            {
                request = new UpdateTriggerRequest
                {
                    TriggerId = TriggerId,
                    UpdateTriggerDetails = UpdateTriggerDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateTrigger(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Trigger);
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

        private UpdateTriggerResponse response;
    }
}
