/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210224
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CertificatesmanagementService.Requests;
using Oci.CertificatesmanagementService.Responses;
using Oci.CertificatesmanagementService.Models;

namespace Oci.CertificatesmanagementService.Cmdlets
{
    [Cmdlet("Get", "OCICertificatesmanagementCertificateAuthorityVersion")]
    [OutputType(new System.Type[] { typeof(Oci.CertificatesmanagementService.Models.CertificateAuthorityVersion), typeof(Oci.CertificatesmanagementService.Responses.GetCertificateAuthorityVersionResponse) })]
    public class GetOCICertificatesmanagementCertificateAuthorityVersion : OCICertificatesManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the certificate authority (CA).")]
        public string CertificateAuthorityId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version number of the certificate authority (CA).")]
        public System.Nullable<long> CertificateAuthorityVersionNumber { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCertificateAuthorityVersionRequest request;

            try
            {
                request = new GetCertificateAuthorityVersionRequest
                {
                    CertificateAuthorityId = CertificateAuthorityId,
                    CertificateAuthorityVersionNumber = CertificateAuthorityVersionNumber,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetCertificateAuthorityVersion(request).GetAwaiter().GetResult();
                WriteOutput(response, response.CertificateAuthorityVersion);
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

        private GetCertificateAuthorityVersionResponse response;
    }
}
