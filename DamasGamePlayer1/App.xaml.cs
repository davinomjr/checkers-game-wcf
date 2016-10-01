﻿using DamasGamePlayer1.Host;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DamasGamePlayer1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            log4net.Config.XmlConfigurator.Configure();
            InjectionContainer.Configure();
            HostConfigurator.RunServer();
            Hub hub = (Hub) InjectionContainer.Container.Resolve<IHubWindow>();
            hub.Show();
        }
    }
}
