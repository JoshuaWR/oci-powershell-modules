/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;
using Oci.OsmanagementService.Models;

namespace Oci.OsmanagementService.Cmdlets
{
    [Cmdlet("Mount", "OCIOsmanagementParentSoftwareSourceToManagedInstance")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.OsmanagementService.Responses.AttachParentSoftwareSourceToManagedInstanceResponse) })]
    public class MountOCIOsmanagementParentSoftwareSourceToManagedInstance : OCIOsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"OCID for the managed instance")]
        public string ManagedInstanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for attaching a Software Source to a Managed Instance")]
        public AttachParentSoftwareSourceToManagedInstanceDetails AttachParentSoftwareSourceToManagedInstanceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            AttachParentSoftwareSourceToManagedInstanceRequest request;

            try
            {
                request = new AttachParentSoftwareSourceToManagedInstanceRequest
                {
                    ManagedInstanceId = ManagedInstanceId,
                    AttachParentSoftwareSourceToManagedInstanceDetails = AttachParentSoftwareSourceToManagedInstanceDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.AttachParentSoftwareSourceToManagedInstance(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private AttachParentSoftwareSourceToManagedInstanceResponse response;
    }
}
