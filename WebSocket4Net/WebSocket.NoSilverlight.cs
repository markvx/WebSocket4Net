﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Authentication;
using System.Text;
using SuperSocket.ClientEngine;

namespace WebSocket4Net
{
    public partial class WebSocket
    {
        private SslProtocols m_SecureProtocols = SslProtocols.Default;

        private TcpClientSession CreateSecureTcpSession(EndPoint endPoint, int receiveBufferSize)
        {
            return new SslStreamTcpSession(endPoint, receiveBufferSize, m_SecureProtocols);
        }
    }
}
