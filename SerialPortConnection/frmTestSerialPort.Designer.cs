namespace SerialPortConnection
{
    partial class frmTestSerialPort
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.txtStopBits = new System.Windows.Forms.TextBox();
            this.txtReceivedMessage = new System.Windows.Forms.TextBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAbrePuero = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSendaData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mode";
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(95, 12);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(100, 20);
            this.txtComPort.TabIndex = 6;
            this.txtComPort.Text = "COM1";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(95, 36);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(100, 20);
            this.txtBaudRate.TabIndex = 7;
            this.txtBaudRate.Text = "9600";
            // 
            // txtParity
            // 
            this.txtParity.Location = new System.Drawing.Point(95, 60);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(100, 20);
            this.txtParity.TabIndex = 8;
            this.txtParity.Text = "0";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(95, 84);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(100, 20);
            this.txtDataBits.TabIndex = 9;
            this.txtDataBits.Text = "8";
            // 
            // txtStopBits
            // 
            this.txtStopBits.Location = new System.Drawing.Point(95, 109);
            this.txtStopBits.Name = "txtStopBits";
            this.txtStopBits.Size = new System.Drawing.Size(100, 20);
            this.txtStopBits.TabIndex = 10;
            this.txtStopBits.Text = "1";
            // 
            // txtReceivedMessage
            // 
            this.txtReceivedMessage.Location = new System.Drawing.Point(201, 84);
            this.txtReceivedMessage.Multiline = true;
            this.txtReceivedMessage.Name = "txtReceivedMessage";
            this.txtReceivedMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceivedMessage.Size = new System.Drawing.Size(237, 73);
            this.txtReceivedMessage.TabIndex = 12;
            this.txtReceivedMessage.Text = "Received Message";
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Text",
            "Hex"});
            this.cmbMode.Location = new System.Drawing.Point(95, 136);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(100, 21);
            this.cmbMode.TabIndex = 13;
            this.cmbMode.Text = "Text";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(29, 218);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(409, 20);
            this.txtMessage.TabIndex = 14;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(29, 189);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(103, 23);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAbrePuero
            // 
            this.btnAbrePuero.Location = new System.Drawing.Point(138, 189);
            this.btnAbrePuero.Name = "btnAbrePuero";
            this.btnAbrePuero.Size = new System.Drawing.Size(103, 23);
            this.btnAbrePuero.TabIndex = 16;
            this.btnAbrePuero.Text = "Escucha Puerto";
            this.btnAbrePuero.UseVisualStyleBackColor = true;
            this.btnAbrePuero.Click += new System.EventHandler(this.btnAbrePuero_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(201, 12);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(237, 68);
            this.txtError.TabIndex = 17;
            this.txtError.Text = "Puerto Abierto";
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(29, 255);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(409, 20);
            this.txtSendData.TabIndex = 18;
            // 
            // btnSendaData
            // 
            this.btnSendaData.Location = new System.Drawing.Point(30, 292);
            this.btnSendaData.Name = "btnSendaData";
            this.btnSendaData.Size = new System.Drawing.Size(75, 23);
            this.btnSendaData.TabIndex = 19;
            this.btnSendaData.Text = "Enviar";
            this.btnSendaData.UseVisualStyleBackColor = true;
            this.btnSendaData.Click += new System.EventHandler(this.btnSendaData_Click);
            // 
            // frmTestSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 398);
            this.Controls.Add(this.btnSendaData);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnAbrePuero);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.txtReceivedMessage);
            this.Controls.Add(this.txtStopBits);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTestSerialPort";
            this.Text = "Test Serial Port Sensor";
            this.Load += new System.EventHandler(this.frmTestSerialPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtParity;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.TextBox txtStopBits;
        private System.Windows.Forms.TextBox txtReceivedMessage;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAbrePuero;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button btnSendaData;
    }
}

