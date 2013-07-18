// Copyright 2013 Travis Purdy. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace UDPServer
{
    public partial class FormUDPServer : Form
    {
        UdpClient ReceiveClient;
        IPEndPoint ReceiveEndPoint;

        Image ReceiveImage;

        public FormUDPServer()
        {
            InitializeComponent();
        }

        private void FormUDPServer_Load(object sender, EventArgs e)
        {
            ReceiveClient = new UdpClient(11000);
            ReceiveEndPoint = new IPEndPoint(IPAddress.Any, 11000);
            timerReceiveAndDisplay.Enabled = true;
        }

        private void timerReceiveAndDisplay_Tick(object sender, EventArgs e)
        {
            if (ReceiveImage != null)
            {
                ReceiveImage.Dispose();
            }
            MemoryStream ms = new MemoryStream(ReceiveClient.Receive(ref ReceiveEndPoint));
            ReceiveImage = Image.FromStream(ms);
            pictureBoxScreenDisplay.Image = ReceiveImage;
            ms.Close();
            ms.Dispose();
            Application.DoEvents();
        }

    }
}
