namespace GoNoGoTest
{
    partial class Form1
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
            this.buttonInicio = new System.Windows.Forms.Button();
            this.Monitor = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tamarillo = new System.Windows.Forms.Timer(this.components);
            this.tverde = new System.Windows.Forms.Timer(this.components);
            this.trojo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInicio.Location = new System.Drawing.Point(340, 12);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 23);
            this.buttonInicio.TabIndex = 1;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // Monitor
            // 
            this.Monitor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Monitor.Location = new System.Drawing.Point(184, 38);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(400, 400);
            this.Monitor.TabIndex = 2;
            this.Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tamarillo
            // 
            this.tamarillo.Interval = 1000;
            this.tamarillo.Tick += new System.EventHandler(this.tamarillo_Tick);
            // 
            // tverde
            // 
            this.tverde.Interval = 700;
            this.tverde.Tick += new System.EventHandler(this.tverde_Tick);
            // 
            // trojo
            // 
            this.trojo.Interval = 700;
            this.trojo.Tick += new System.EventHandler(this.trojo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.buttonInicio);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "GoNoGoTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label Monitor;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer tamarillo;
        private System.Windows.Forms.Timer tverde;
        private System.Windows.Forms.Timer trojo;
    }
}

