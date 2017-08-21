namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioBTC = new System.Windows.Forms.RadioButton();
            this.radioETH = new System.Windows.Forms.RadioButton();
            this.radioXRP = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBTC
            // 
            this.radioBTC.AutoSize = true;
            this.radioBTC.BackColor = System.Drawing.Color.Transparent;
            this.radioBTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBTC.ForeColor = System.Drawing.Color.White;
            this.radioBTC.Location = new System.Drawing.Point(13, 13);
            this.radioBTC.Name = "radioBTC";
            this.radioBTC.Size = new System.Drawing.Size(65, 17);
            this.radioBTC.TabIndex = 1;
            this.radioBTC.TabStop = true;
            this.radioBTC.Text = "BitCoin";
            this.radioBTC.UseVisualStyleBackColor = false;
            this.radioBTC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioETH
            // 
            this.radioETH.AutoSize = true;
            this.radioETH.BackColor = System.Drawing.Color.Transparent;
            this.radioETH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioETH.ForeColor = System.Drawing.Color.White;
            this.radioETH.Location = new System.Drawing.Point(77, 13);
            this.radioETH.Name = "radioETH";
            this.radioETH.Size = new System.Drawing.Size(78, 17);
            this.radioETH.TabIndex = 2;
            this.radioETH.Text = "Ethereum";
            this.radioETH.UseVisualStyleBackColor = false;
            this.radioETH.CheckedChanged += new System.EventHandler(this.radioETH_CheckedChanged);
            // 
            // radioXRP
            // 
            this.radioXRP.AutoSize = true;
            this.radioXRP.BackColor = System.Drawing.Color.Transparent;
            this.radioXRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioXRP.ForeColor = System.Drawing.Color.White;
            this.radioXRP.Location = new System.Drawing.Point(153, 13);
            this.radioXRP.Name = "radioXRP";
            this.radioXRP.Size = new System.Drawing.Size(50, 17);
            this.radioXRP.TabIndex = 3;
            this.radioXRP.Text = "XRP";
            this.radioXRP.UseVisualStyleBackColor = false;
            this.radioXRP.CheckedChanged += new System.EventHandler(this.radioXRP_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(201, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(258, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioXRP);
            this.Controls.Add(this.radioETH);
            this.Controls.Add(this.radioBTC);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "CryptoStalk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBTC;
        private System.Windows.Forms.RadioButton radioETH;
        private System.Windows.Forms.RadioButton radioXRP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

    }
}

