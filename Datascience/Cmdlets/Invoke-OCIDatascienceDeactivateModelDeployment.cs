/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatascienceService.Requests;
using Oci.DatascienceService.Responses;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Cmdlets
{
    [Cmdlet("Invoke", "OCIDatascienceDeactivateModelDeployment")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.DatascienceService.Responses.DeactivateModelDeploymentResponse) })]
    public class InvokeOCIDatascienceDeactivateModelDeployment : OCIDataScienceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the model deployment.")]
        public string ModelDeploymentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource is updated or deleted only if the `etag` you provide matches the resource's current `etag` value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle assigned identifier for the request. If you need to contact Oracle about a particular request, then provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            DeactivateModelDeploymentRequest request;

            try
            {
                request = new DeactivateModelDeploymentRequest
                {
                    ModelDeploymentId = ModelDeploymentId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.DeactivateModelDeployment(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private DeactivateModelDeploymentResponse response;
    }
}
