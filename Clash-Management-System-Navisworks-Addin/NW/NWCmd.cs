﻿using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Autodesk.Navisworks.Api;
using System.Collections.Generic;
using Autodesk.Navisworks.Api.Plugins;
using Autodesk.Navisworks.Api.DocumentParts;
using Clash_Management_System_Navisworks_Addin.NW;
using Clash_Management_System_Navisworks_Addin.Views;
using Clash_Management_System_Navisworks_Addin.Testing;

namespace Clash_Management_System_Navisworks_Addin
{
    [Plugin("Clash-Management-System-Navisworks-Addin", "WYHk", DisplayName = "Hello!")]
    [RibbonLayout("Clash-Management-System-Navisworks-Addin.xaml")]
    [RibbonTab("ID_CustomTab_1", DisplayName = "Clash Management")]
    [Command("BE", CanToggle = true, DisplayName = "Button1")]
    [Command("WPFUI", CanToggle = true, DisplayName = "Button2")]


    class Clash_Management_System_Navisworks_Addin : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string commandId, params string[] parameters)
        {
            switch (commandId)
            {
                case "BE":
                    SearchSetClassTests.SearchSetTest();
                    break;

                case "WPFUI":
                    MainWindow mainMenu = new MainWindow();
                    mainMenu.Show();
                    break;
            }

            return 0;
        }
    }
}