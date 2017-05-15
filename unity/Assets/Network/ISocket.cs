﻿//*********************************************************************
// Description:
// Author: hiramtan@live.com
//*********************************************************************

using System;

namespace HiSocket.TCP
{
    public interface ISocket
    {
        /// <summary>
        /// if connected or not
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramAddress"></param>
        /// <param name="paramPort"></param>
        /// <param name="paramEventHandler">success connect call back</param>
        void Connect(string paramAddress, int paramPort, Action<bool> paramEventHandler = null);

        /// <summary>
        /// Ping
        /// </summary>
        /// <returns>返回ping值</returns>
        long Ping();

        /// <summary>
        /// send data to server
        /// </summary>
        /// <param name="param"></param>
        void Send(byte[] param);

        /// <summary>
        /// receive data from server 
        /// </summary>
        /// <param name="ar"></param>
        void Receive(IAsyncResult ar);

        /// <summary>
        /// disconnect with server
        /// </summary>
        void Close();
    }
}