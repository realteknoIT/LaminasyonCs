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

            int result1 = Config.Plc.DBRead(14, 0, 13, Buffer);
            if (result != 0)
            {
                Globals.UpdateStatus(Config.Plc.ErrorText(result1));
                return;
            }

            bool acilStop = S7.GetBitAt(Buffer, 0, 0); 
            bool stepMbOkumaYazma = S7.GetBitAt(Buffer, 0, 1); 
            bool stepAcilStop = S7.GetBitAt(Buffer, 0, 2); 
            bool akisSicaklikMbOkumaYazma = S7.GetBitAt(Buffer, 0, 3); 
            bool partnerPlcHaberlesme = S7.GetBitAt(Buffer, 0, 4); 
            bool sunBrulorEnabled = S7.GetBitAt(Buffer, 0, 5);
            bool sunBrulorReset = S7.GetBitAt(Buffer, 0, 6); 
            bool sunBrulorHome = S7.GetBitAt(Buffer, 0, 7); 
            bool sunBrulorMove = S7.GetBitAt(Buffer, 1, 0); 
            bool astBrulorEnabled = S7.GetBitAt(Buffer, 1, 1); 
            bool astBrulorReset = S7.GetBitAt(Buffer, 1, 2); 
            bool astBrulorHome = S7.GetBitAt(Buffer, 1, 3);
            bool astBrulorMove = S7.GetBitAt(Buffer, 1, 4);

            Globals.AcilStop = acilStop; 
            Globals.StepMBOkumaYazma = stepMbOkumaYazma; 
            Globals.StepAcilStop = stepAcilStop; 
            Globals.AkisSicaklikMBOkumaYazma = akisSicaklikMbOkumaYazma; 
            Globals.PartnerPlcHaberlesme = partnerPlcHaberlesme; 
            Globals.SunBrulorEnabled = sunBrulorEnabled; 
            Globals.SunBrulorReset = sunBrulorReset; 
            Globals.SunBrulorHome = sunBrulorHome; 
            Globals.SunBrulorMove = sunBrulorMove; 
            Globals.AstBrulorEnabled = astBrulorEnabled;
            Globals.AstBrulorReset = astBrulorReset; 
            Globals.AstBrulorHome = astBrulorHome;
            Globals.AstBrulorMove = astBrulorMove;



        }

        public static void WritePlc()
        {

        }

        public static void ConnectPlc()
        {

        }
    }
}
