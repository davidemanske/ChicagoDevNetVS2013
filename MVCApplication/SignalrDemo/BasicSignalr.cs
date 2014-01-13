﻿/*
 * In the Application_Start method, or somewhere in app's start
 * you'll need to add the namespace inclusion:
 * 
 * using Microsoft.AspNet.SignalR;
 * 
 * and the code:
 * 
 * RouteTable.Routes.MapHubs();
 * 
 * */

using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalrDemo
{
    [HubName("myHub")]
    public class BasicSignalr : Hub
    {
        static int _hitCount;

        public void RecordHit()
        {
            _hitCount += 1;
            base.Clients.All.onHitCountUpdated(_hitCount);
        }
    }
}