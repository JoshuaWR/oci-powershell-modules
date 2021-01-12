/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190301
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.SecretsService.Requests;
using Oci.SecretsService.Responses;
using Oci.SecretsService.Models;

namespace Oci.SecretsService.Cmdlets
{
    [Cmdlet("Get", "OCISecretsSecretBundle")]
    [OutputType(new System.Type[] { typeof(Oci.SecretsService.Models.SecretBundle), typeof(Oci.SecretsService.Responses.GetSecretBundleResponse) })]
    public class GetOCISecretsSecretBundle : OCISecretsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the secret.")]
        public string SecretId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version number of the secret.")]
        public System.Nullable<long> VersionNumber { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the secret. (This might be referred to as the name of the secret version. Names are unique across the different versions of a secret.)")]
        public string SecretVersionName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The rotation state of the secret version.")]
        public System.Nullable<Oci.SecretsService.Requests.GetSecretBundleRequest.StageEnum> Stage { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetSecretBundleRequest request;

            try
            {
                request = new GetSecretBundleRequest
                {
                    SecretId = SecretId,
                    OpcRequestId = OpcRequestId,
                    VersionNumber = VersionNumber,
                    SecretVersionName = SecretVersionName,
                    Stage = Stage
                };

                response = client.GetSecretBundle(request).GetAwaiter().GetResult();
                WriteOutput(response, response.SecretBundle);
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

        private GetSecretBundleResponse response;
    }
}
