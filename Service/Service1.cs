﻿/*
Copyright 2004-2012 Hugo Anton Feldhammer, Urs Geissbühler, Daniel Milner


This file is part of Net Profiles mod.

Net Profiles mod is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Net Profiles mod is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Net Profiles mod.  If not, see <http://www.gnu.org/licenses/>.
*/

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Threading;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics;
using System.ServiceProcess;
//using System.Text;

using AppModule.InterProcessComm;
using AppModule.NamedPipes;

namespace Service
{
    public partial class Service1 : ServiceBase
    {
        public static IChannelManager PipeManager;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            PipeManager = new PipeManager();
            PipeManager.Initialize();
        }

        protected override void OnStop()
        {
            if (PipeManager != null)
            {
                PipeManager.Stop();
            }
        }
    }

}
