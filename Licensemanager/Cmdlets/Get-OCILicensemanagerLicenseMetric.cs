/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220430
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LicensemanagerService.Requests;
using Oci.LicensemanagerService.Responses;
using Oci.LicensemanagerService.Models;
using Oci.Common.Model;

namespace Oci.LicensemanagerService.Cmdlets
{
    [Cmdlet("Get", "OCILicensemanagerLicenseMetric")]
    [OutputType(new System.Type[] { typeof(Oci.LicensemanagerService.Models.LicenseMetric), typeof(Oci.LicensemanagerService.Responses.GetLicenseMetricResponse) })]
    public class GetOCILicensemanagerLicenseMetric : OCILicenseManagerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) used for the license record, product license, and configuration.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Indicates if the given compartment is the root compartment.")]
        public System.Nullable<bool> IsCompartmentIdInSubtree { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetLicenseMetricRequest request;

            try
            {
                request = new GetLicenseMetricRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    IsCompartmentIdInSubtree = IsCompartmentIdInSubtree
                };

                response = client.GetLicenseMetric(request).GetAwaiter().GetResult();
                WriteOutput(response, response.LicenseMetric);
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

        private GetLicenseMetricResponse response;
    }
}
