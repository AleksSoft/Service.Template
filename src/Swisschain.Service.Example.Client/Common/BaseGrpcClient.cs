﻿using System;
using System.Net.Http;
using Grpc.Net.Client;

namespace Swisschain.Service.Example.Client.Common
{
    public class BaseGrpcClient : IDisposable
    {
        protected GrpcChannel Channel { get; }

        public BaseGrpcClient(string serverGrpcUrl)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            Channel = GrpcChannel.ForAddress(serverGrpcUrl);
        }

        public void Dispose()
        {
            Channel?.Dispose();
        }
    }
}