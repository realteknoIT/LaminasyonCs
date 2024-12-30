using LaminasyonMakinesi.View;
using Sharp7;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaminasyonMakinesi
{
    class Plc
    {
        async Task PlcConnect()
        {
            if (!Config.Plc.Connected)
            {
                int connectCount = 0;

                        //Config.PlcStatu = "PLC'YE BAĞLANILIYOR";
  
                while (connectCount < 1)
                {
                    int result = Config.Plc.ConnectTo(Config.PlcIP, 0, 0);

                    if (Config.PlcStatu == 0)
                    {
                        //Text = "PLC BAĞLANTISI YAPILDI";
          
                        return;
                    }
                    connectCount++;
                    await Task.Delay(100);
                }               

                        //Text = "PLC BAĞLI DEĞİL";
            }
            Config.PlcStatu = 1;
        }
        
        public static void ReadPlc()
        {
            byte[] Buffer = new byte[52];
            int result = Config.Plc.DBRead(3, 0, 52, Buffer);
            if (result != 0)
            {
                Globals.UpdateStatus (Config.Plc.ErrorText(result));
                return;
            }

            int machineSpeed = S7.GetDIntAt(Buffer, 0); 
            int tempInTop = S7.GetDIntAt(Buffer, 4); 
            int tempInBottom = S7.GetDIntAt(Buffer, 8); 
            int tempBrulorInFabric = S7.GetDIntAt(Buffer, 12); 
            int tempBrulorInPrimer = S7.GetDIntAt(Buffer, 16);
            int tempOutTop = S7.GetDIntAt(Buffer, 20);
            int tempOutBottom = S7.GetDIntAt(Buffer, 24); 
            int tempBrulorOutFabric = S7.GetDIntAt(Buffer, 28); 
            int tempBrulorOutPrimer = S7.GetDIntAt(Buffer, 32); 
            int flowInTop = S7.GetDIntAt(Buffer, 36);
            int flowInBottom = S7.GetDIntAt(Buffer, 40); 
            int flowBrulorInFabric = S7.GetDIntAt(Buffer, 44);
            int flowBrulorInPrimer = S7.GetDIntAt(Buffer, 48);

            Globals.MachineSpeed = machineSpeed; 
            Globals.TempInTop = tempInTop; 
            Globals.TempInBottom = tempInBottom; 
            Globals.TempBrulorInFabric = tempBrulorInFabric; 
            Globals.TempBrulorInPrimer = tempBrulorInPrimer; 
            Globals.TempOutTop = tempOutTop; 
            Globals.TempOutBottom = tempOutBottom; 
            Globals.TempBrulorOutFabric = tempBrulorOutFabric;
            Globals.TempBrulorOutPrimer = tempBrulorOutPrimer; 
            Globals.FlowInTop = flowInTop; 
            Globals.FlowInBottom = flowInBottom; 
            Globals.FlowBrulorInFabric = flowBrulorInFabric;
            Globals.FlowBrulorInPrimer = flowBrulorInPrimer;



        }

        public static void WritePlc()
        {

        }

        public static void ConnectPlc()
        {

        }
    }
}
