namespace journeyThroughTheHood
{
    partial class HoodAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoodAdventure));
            this.outputLabel = new System.Windows.Forms.Label();
            this.buttQ = new System.Windows.Forms.Label();
            this.buttW = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.wLabel = new System.Windows.Forms.Label();
            this.buttE = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.DimGray;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(447, 46);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "You come out of work at 9pm and it\'s pouring. Do you?";
            // 
            // buttQ
            // 
            this.buttQ.BackColor = System.Drawing.Color.DarkBlue;
            this.buttQ.ForeColor = System.Drawing.SystemColors.Control;
            this.buttQ.Location = new System.Drawing.Point(269, 268);
            this.buttQ.Name = "buttQ";
            this.buttQ.Size = new System.Drawing.Size(100, 23);
            this.buttQ.TabIndex = 1;
            this.buttQ.Text = "Q";
            this.buttQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttW
            // 
            this.buttW.BackColor = System.Drawing.Color.Red;
            this.buttW.ForeColor = System.Drawing.SystemColors.Control;
            this.buttW.Location = new System.Drawing.Point(269, 309);
            this.buttW.Name = "buttW";
            this.buttW.Size = new System.Drawing.Size(100, 23);
            this.buttW.TabIndex = 2;
            this.buttW.Text = "W";
            this.buttW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLabel
            // 
            this.qLabel.BackColor = System.Drawing.Color.Transparent;
            this.qLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qLabel.ForeColor = System.Drawing.Color.Red;
            this.qLabel.Location = new System.Drawing.Point(26, 268);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(237, 30);
            this.qLabel.TabIndex = 3;
            this.qLabel.Text = "Take the bus";
            // 
            // wLabel
            // 
            this.wLabel.BackColor = System.Drawing.Color.Transparent;
            this.wLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wLabel.ForeColor = System.Drawing.Color.Red;
            this.wLabel.Location = new System.Drawing.Point(26, 312);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(237, 32);
            this.wLabel.TabIndex = 4;
            this.wLabel.Text = "Walk home";
            // 
            // buttE
            // 
            this.buttE.BackColor = System.Drawing.Color.Green;
            this.buttE.ForeColor = System.Drawing.SystemColors.Control;
            this.buttE.Location = new System.Drawing.Point(269, 356);
            this.buttE.Name = "buttE";
            this.buttE.Size = new System.Drawing.Size(100, 23);
            this.buttE.TabIndex = 5;
            this.buttE.Text = "E";
            this.buttE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttE.Visible = false;
            // 
            // eLabel
            // 
            this.eLabel.BackColor = System.Drawing.Color.Transparent;
            this.eLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLabel.ForeColor = System.Drawing.Color.Red;
            this.eLabel.Location = new System.Drawing.Point(26, 356);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(237, 32);
            this.eLabel.TabIndex = 6;
            // 
            // HoodAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.buttE);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.buttW);
            this.Controls.Add(this.buttQ);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoodAdventure";
            this.Text = "Journey Through The Hood";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HoodAdventure_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label buttQ;
        private System.Windows.Forms.Label buttW;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.Label buttE;
        private System.Windows.Forms.Label eLabel;
    }
}

