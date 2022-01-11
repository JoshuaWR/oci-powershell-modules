/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 1.0.015
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;
using Oci.DtsService.Models;

namespace Oci.DtsService.Cmdlets
{
    [Cmdlet("Remove", "OCIDtsTransferDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.DtsService.Responses.DeleteTransferDeviceResponse) })]
    public class RemoveOCIDtsTransferDevice : OCITransferDeviceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"ID of the Transfer Job")]
        public string Id { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Label of the Transfer Device")]
        public string TransferDeviceLabel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Ignore confirmation and force the Cmdlet to complete action.")]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (!ConfirmDelete("OCIDtsTransferDevice", "Remove"))
            {
               return;
            }

            DeleteTransferDeviceRequest request;

            try
            {
                request = new DeleteTransferDeviceRequest
                {
                    Id = Id,
                    TransferDeviceLabel = TransferDeviceLabel
                };

                response = client.DeleteTransferDevice(request).GetAwaiter().GetResult();
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

        private DeleteTransferDeviceResponse response;
    }
}
