namespace UDPServer
{
    partial class FormUDPServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxScreenDisplay = new System.Windows.Forms.PictureBox();
            this.timerReceiveAndDisplay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScreenDisplay
            // 
            this.pictureBoxScreenDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxScreenDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxScreenDisplay.Name = "pictureBoxScreenDisplay";
            this.pictureBoxScreenDisplay.Size = new System.Drawing.Size(658, 282);
            this.pictureBoxScreenDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScreenDisplay.TabIndex = 0;
            this.pictureBoxScreenDisplay.TabStop = false;
            // 
            // timerReceiveAndDisplay
            // 
            this.timerReceiveAndDisplay.Interval = 10;
            this.timerReceiveAndDisplay.Tick += new System.EventHandler(this.timerReceiveAndDisplay_Tick);
            // 
            // FormUDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 306);
            this.Controls.Add(this.pictureBoxScreenDisplay);
            this.Name = "FormUDPServer";
            this.Text = "UDP Server";
            this.Load += new System.EventHandler(this.FormUDPServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScreenDisplay;
        private System.Windows.Forms.Timer timerReceiveAndDisplay;

    }
}

