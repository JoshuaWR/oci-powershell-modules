/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180608
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.VaultService.Requests;
using Oci.VaultService.Responses;
using Oci.VaultService.Models;
using Oci.Common.Model;

namespace Oci.VaultService.Cmdlets
{
    [Cmdlet("Stop", "OCIVaultSecretDeletion")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.VaultService.Responses.CancelSecretDeletionResponse) })]
    public class StopOCIVaultSecretDeletion : OCIVaultsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the secret.")]
        public string SecretId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CancelSecretDeletionRequest request;

            try
            {
                request = new CancelSecretDeletionRequest
                {
                    SecretId = SecretId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.CancelSecretDeletion(request).GetAwaiter().GetResult();
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

        private CancelSecretDeletionResponse response;
    }
}
