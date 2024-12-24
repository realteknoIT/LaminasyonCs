using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaminasyonMakinesi.Connection
{
    public class connectionMain
    {
        private S7Client _plcClient;
        private string _plcIp;

        public connectionMain(string plcIp)
        {
            _plcIp = plcIp;
            _plcClient = new S7Client();
        }

        public bool Connect()
        {
            var result = _plcClient.ConnectTo(_plcIp, 0, 1);
            return result == 0; // 0 = başarı
        }

        public void Disconnect()
        {
            _plcClient.Disconnect();
        }

        public byte[] ReadData(int dbNumber, int start, int size)
        {
            byte[] buffer = new byte[size];
            var result = _plcClient.DBRead(dbNumber, start, size, buffer);

            if (result != 0)
                throw new Exception($"PLC Read Error: {_plcClient.ErrorText(result)}");

            return buffer;
        }

        public void WriteData(int dbNumber, int start, byte[] data)
        {
            var result = _plcClient.DBWrite(dbNumber, start, data.Length, data);

            if (result != 0)
                throw new Exception($"PLC Write Error: {_plcClient.ErrorText(result)}");
        }
    }
}
