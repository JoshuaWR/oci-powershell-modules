/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181116
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.WaasService.Requests;
using Oci.WaasService.Responses;
using Oci.WaasService.Models;
using Oci.Common.Model;

namespace Oci.WaasService.Cmdlets
{
    [Cmdlet("Update", "OCIWaasCertificate")]
    [OutputType(new System.Type[] { typeof(Oci.WaasService.Models.Certificate), typeof(Oci.WaasService.Responses.UpdateCertificateResponse) })]
    public class UpdateOCIWaasCertificate : OCIWaasCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the SSL certificate used in the WAAS policy. This number is generated when the certificate is added to the policy.")]
        public string CertificateId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the `PUT` or `DELETE` call for a resource, set the `if-match` parameter to the value of the etag from a previous `GET` or `POST` response for that resource. The resource will be updated or deleted only if the etag provided matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The new display name, freeform tags, and defined tags to apply to a certificate.")]
        public UpdateCertificateDetails UpdateCertificateDetails { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateCertificateRequest request;

            try
            {
                request = new UpdateCertificateRequest
                {
                    CertificateId = CertificateId,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch,
                    UpdateCertificateDetails = UpdateCertificateDetails
                };

                response = client.UpdateCertificate(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Certificate);
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

        private UpdateCertificateResponse response;
    }
}
