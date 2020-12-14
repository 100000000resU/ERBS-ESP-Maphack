using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BepInEx;
using System.Reflection;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine;
using Blis.Common;
using Blis.Common.Utils;
using Blis.Client;
using Blis.Client.UI;
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace BlackSurvivalCheat
{
    [BepInPlugin("BlackSurvivalCheat", "BlackSurvivalCheat", "1.0.0.0")]
    string pooopy = "shit";
    string shit = "cunt";
    public class CheatMain : BaseUnityPlugin
    {
        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }

            return false;
        }

        public static Harmony harmony;
        
        void Awake()
        {

            
          
            if (pooopy.Contains(shit))
            { 
                
                    harmony = new Harmony("Anyones_Cheat");
                    X_Ray.Load(harmony);
                    SightChanger.Load(harmony);
               
            }

        }
     
    }

}
