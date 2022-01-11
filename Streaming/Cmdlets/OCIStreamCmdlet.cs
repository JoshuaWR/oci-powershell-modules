/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180418
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.Common.Retry;
using Oci.StreamingService;

namespace Oci.StreamingService.Cmdlets
{
    public abstract class OCIStreamCmdlet : Oci.PSModules.Common.Cmdlets.OCICmdlet
    { 

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The value to use as the service endpoint, including any required API version path")]
        public override string Endpoint { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            try
            {
                bool noretry = AvoidRetry();
                WriteDebug($"Retry strategy : {!noretry}");
                retryConfig = (noretry) ? null : new RetryConfiguration();
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                client?.Dispose();
                int timeout = GetPreferredTimeout();
                WriteDebug($"Cmdlet Timeout : {timeout} milliseconds.");
                client = new StreamClient(AuthProvider, new Oci.Common.ClientConfiguration
                {
                    RetryConfiguration = retryConfig,
                    TimeoutMillis = timeout,
                    ClientUserAgent = PSUserAgent
                });
                WriteDebug("Choosing Endpoint:" + Endpoint);
                client.SetEndpoint(Endpoint);
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            client.Dispose();
        }

        protected override void TerminatingErrorDuringExecution(Exception ex)
        {
            client?.Dispose();
            base.TerminatingErrorDuringExecution(ex);
        }

        protected StreamClient client;
        private RetryConfiguration retryConfig;
    }
}