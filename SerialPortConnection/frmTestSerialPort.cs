using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortConnection
{
    public partial class frmTestSerialPort : Form
    {
        private SerialPort objSerialPort;
        private string strMode;

        #region Constructor
        public frmTestSerialPort()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        #region private void frmTestSerialPort_Load(object sender, EventArgs e)
        private void frmTestSerialPort_Load(object sender, EventArgs e)
        {
            strMode = cmbMode.Text;
            InicializarAbrirPuerto();
            if (objSerialPort.IsOpen)
            {
                txtMessage.Text = "El puerto esta abierto";
                txtMessage.BackColor = Color.Green;
            }
        }
        #endregion

        private void btnAbrePuero_Click(object sender, EventArgs e)
        {
            //strMode = cmbMode.Text;
            //InicializarAbrirPuerto();
            //if (objSerialPort.IsOpen)
            //{
            //    txtMessage.Text = "El puerto esta abierto";
            //    txtMessage.BackColor = Color.Green;
            //}
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "Esperando recepción de datos.";
            txtMessage.BackColor = Color.Orange;
            if (objSerialPort.IsOpen)
                objSerialPort.Close();
            strMode = cmbMode.Text;
            InicializarAbrirPuerto();
        }

        delegate void datadelegate(string sdata);
        public void printdata(string data)
        {
            txtReceivedMessage.Text = data;
        }

        #region void objSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        void objSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            txtReceivedMessage.Invoke((MethodInvoker)delegate { txtReceivedMessage.Text = indata; });

        }
        #endregion

        #region void objSerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        void objSerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            txtError.Invoke((MethodInvoker)delegate { txtError.Text = e.EventType.ToString(); });
        }
        #endregion

        #region void objSerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        void objSerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            var strReturnMessage = string.Empty;

            //Para la interaccion con las interfaces solo se usan 3 pines. (6,8,9)
            switch (e.EventType)
            {
                case SerialPinChange.DsrChanged:
                    strReturnMessage = "Detecto Cambio PIN 6 DSR (Data Set Ready) Input";
                    break;
                case SerialPinChange.CtsChanged:
                    strReturnMessage = "Detecto Cambio PIN 8 CTS (Clear To Send) Input";
                    break;
                case SerialPinChange.Ring:
                    strReturnMessage = "Detecto Cambio PIN 9 RI (Ring Indicator) Input";
                    break;
            }
            SendMessage(strReturnMessage);
        }
        #endregion

        #endregion

        #region Metodos

        private void btnSendaData_Click(object sender, EventArgs e)
        {

            string strDataOut = "";
            objSerialPort.DiscardInBuffer();
            strDataOut = txtSendData.Text;
            objSerialPort.Write(strDataOut);
        }


        #region private void SendMessage(string message)
        private void SendMessage(string message)
        {
            if (message.Length > 0)
            {
                txtMessage.Invoke((MethodInvoker)delegate { txtMessage.Text = message; txtMessage.BackColor = Color.Chartreuse; });
            }
        }
        #endregion

        #region public string ByteArrayToHexString(byte[] data)
        public string ByteArrayToHexString(byte[] data)
        {
            var sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        #endregion

        #region private void InicializarAbrirPuerto()
        private void InicializarAbrirPuerto()
        {
            objSerialPort = new SerialPort(txtComPort.Text,
                                        int.Parse(txtBaudRate.Text),
                                        Parity.None,
                                        int.Parse(txtDataBits.Text));
            //objSerialPort.DtrEnable = true;
            //objSerialPort.RtsEnable = true;           
            objSerialPort.PinChanged += objSerialPort_PinChanged;
            objSerialPort.DataReceived += objSerialPort_DataReceived;
            objSerialPort.ErrorReceived += objSerialPort_ErrorReceived;
            objSerialPort.Open();
            objSerialPort.BreakState = false;
            objSerialPort.Handshake = Handshake.None;
        }
        #endregion       


        #endregion

        public class BitconverterExt
        {
            public static byte[] GetBytes(decimal dec)
            {
                //Load four 32 bit integers from the Decimal.GetBits function
                Int32[] bits = decimal.GetBits(dec);
                //Create a temporary list to hold the bytes
                List<byte> bytes = new List<byte>();
                //iterate each 32 bit integer
                foreach (Int32 i in bits)
                {
                    //add the bytes of the current 32bit integer
                    //to the bytes list
                    bytes.AddRange(BitConverter.GetBytes(i));
                }
                //return the bytes list as an array
                return bytes.ToArray();
            }
            public static decimal ToDecimal(byte[] bytes)
            {
                //check that it is even possible to convert the array
                if (bytes.Count() != 16)
                    throw new Exception("A decimal must be created from exactly 16 bytes");
                //make an array to convert back to int32's
                Int32[] bits = new Int32[4];
                for (int i = 0; i <= 15; i += 4)
                {
                    //convert every 4 bytes into an int32
                    bits[i / 4] = BitConverter.ToInt32(bytes, i);
                }
                //Use the decimal's new constructor to
                //create an instance of decimal
                return new decimal(bits);
            }
        }

       
    }
}

