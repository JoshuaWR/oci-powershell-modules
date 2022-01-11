/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;
using Oci.OsmanagementService.Models;

namespace Oci.OsmanagementService.Cmdlets
{
    [Cmdlet("New", "OCIOsmanagementManagedInstanceGroup")]
    [OutputType(new System.Type[] { typeof(Oci.OsmanagementService.Models.ManagedInstanceGroup), typeof(Oci.OsmanagementService.Responses.CreateManagedInstanceGroupResponse) })]
    public class NewOCIOsmanagementManagedInstanceGroup : OCIOsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details about a Managed Instance Group to create")]
        public CreateManagedInstanceGroupDetails CreateManagedInstanceGroupDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateManagedInstanceGroupRequest request;

            try
            {
                request = new CreateManagedInstanceGroupRequest
                {
                    CreateManagedInstanceGroupDetails = CreateManagedInstanceGroupDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateManagedInstanceGroup(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ManagedInstanceGroup);
                FinishProcessing(response);
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

        private CreateManagedInstanceGroupResponse response;
    }
}
