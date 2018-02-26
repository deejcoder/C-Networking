using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawMessenger.Networking;

namespace RawMessenger
{
    public partial class MessengerWindow : Form
    {


        //For dragging the window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(System.IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Dragging the window: mouse down on top menu bar
        private void TopMenu_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public MessengerWindow()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {



        }

        public void AppendToMessages(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendToMessages), new object[] { msg });
                return;
            }
            Text_Messages.Text += (msg);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        /*
         *  UI Interactions
         *  
         */

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            Server s = new Server(this);
            s.StartListening(Int32.Parse(Text_IP.Text));
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            Client c = new Client(this);
            c.Send(Text_IP.Text, Text_Message.Text);
        }


        private void Text_Messages_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
