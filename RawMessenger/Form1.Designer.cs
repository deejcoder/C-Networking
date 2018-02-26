namespace RawMessenger
{
    partial class MessengerWindow
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
            this.TopMenu = new System.Windows.Forms.Panel();
            this.Text_Message = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Text_Messages = new System.Windows.Forms.RichTextBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.TopMenu.Controls.Add(this.button5);
            this.TopMenu.Controls.Add(this.Button_Close);
            this.TopMenu.Controls.Add(this.label1);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.ForeColor = System.Drawing.Color.HotPink;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.TopMenu.Size = new System.Drawing.Size(543, 22);
            this.TopMenu.TabIndex = 3;
            this.TopMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.TopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseDown);
            // 
            // Text_Message
            // 
            this.Text_Message.Location = new System.Drawing.Point(173, 334);
            this.Text_Message.Name = "Text_Message";
            this.Text_Message.Size = new System.Drawing.Size(308, 20);
            this.Text_Message.TabIndex = 4;
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(487, 332);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(50, 23);
            this.Button_Send.TabIndex = 5;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.Button_Connect);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Text_IP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 344);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RM";
            // 
            // Text_IP
            // 
            this.Text_IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(101)))), ((int)(((byte)(126)))));
            this.Text_IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_IP.ForeColor = System.Drawing.Color.Gainsboro;
            this.Text_IP.Location = new System.Drawing.Point(13, 29);
            this.Text_IP.Name = "Text_IP";
            this.Text_IP.Size = new System.Drawing.Size(134, 13);
            this.Text_IP.TabIndex = 1;
            this.Text_IP.Text = "127.0.0.1:5050";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connect to...";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(12, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Blacklist";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Button_Connect
            // 
            this.Button_Connect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Button_Connect.FlatAppearance.BorderSize = 0;
            this.Button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Connect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Connect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_Connect.Location = new System.Drawing.Point(75, 48);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(72, 24);
            this.Button_Connect.TabIndex = 6;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = false;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Text_Messages
            // 
            this.Text_Messages.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Messages.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Messages.Location = new System.Drawing.Point(173, 30);
            this.Text_Messages.Name = "Text_Messages";
            this.Text_Messages.ReadOnly = true;
            this.Text_Messages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Text_Messages.Size = new System.Drawing.Size(364, 296);
            this.Text_Messages.TabIndex = 7;
            this.Text_Messages.Text = "";
            // 
            // Button_Close
            // 
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Close.Location = new System.Drawing.Point(524, 1);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(18, 19);
            this.Button_Close.TabIndex = 1;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(500, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 20);
            this.button5.TabIndex = 2;
            this.button5.Text = "_";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MessengerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 366);
            this.Controls.Add(this.Text_Messages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Text_Message);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessengerWindow";
            this.Text = "Raw Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.TextBox Text_Message;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_IP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.RichTextBox Text_Messages;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Button_Close;
    }
}

