/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180608
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.VaultService.Requests;
using Oci.VaultService.Responses;
using Oci.VaultService.Models;

namespace Oci.VaultService.Cmdlets
{
    [Cmdlet("Get", "OCIVaultSecretVersion")]
    [OutputType(new System.Type[] { typeof(Oci.VaultService.Models.SecretVersion), typeof(Oci.VaultService.Responses.GetSecretVersionResponse) })]
    public class GetOCIVaultSecretVersion : OCIVaultsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the secret.")]
        public string SecretId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version number of the secret.")]
        public System.Nullable<long> SecretVersionNumber { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetSecretVersionRequest request;

            try
            {
                request = new GetSecretVersionRequest
                {
                    SecretId = SecretId,
                    SecretVersionNumber = SecretVersionNumber,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetSecretVersion(request).GetAwaiter().GetResult();
                WriteOutput(response, response.SecretVersion);
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

        private GetSecretVersionResponse response;
    }
}
