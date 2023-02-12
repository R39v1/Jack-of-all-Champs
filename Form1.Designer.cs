namespace Jack_of_All_Champs
{
    partial class FormJoAC
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoAC));
            this.flowLayoutPanelScrollList = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonProgressBarRed = new System.Windows.Forms.Button();
            this.buttonProgressBarGreen = new System.Windows.Forms.Button();
            this.buttonBackGroundColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelScrollList
            // 
            this.flowLayoutPanelScrollList.AutoScroll = true;
            this.flowLayoutPanelScrollList.Location = new System.Drawing.Point(12, 45);
            this.flowLayoutPanelScrollList.Name = "flowLayoutPanelScrollList";
            this.flowLayoutPanelScrollList.Size = new System.Drawing.Size(790, 569);
            this.flowLayoutPanelScrollList.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonSave.Location = new System.Drawing.Point(12, 620);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(790, 49);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonProgressBarRed
            // 
            this.buttonProgressBarRed.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonProgressBarRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgressBarRed.Location = new System.Drawing.Point(12, 12);
            this.buttonProgressBarRed.Name = "buttonProgressBarRed";
            this.buttonProgressBarRed.Size = new System.Drawing.Size(790, 25);
            this.buttonProgressBarRed.TabIndex = 2;
            this.buttonProgressBarRed.UseVisualStyleBackColor = false;
            // 
            // buttonProgressBarGreen
            // 
            this.buttonProgressBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonProgressBarGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgressBarGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProgressBarGreen.Location = new System.Drawing.Point(12, 12);
            this.buttonProgressBarGreen.Name = "buttonProgressBarGreen";
            this.buttonProgressBarGreen.Size = new System.Drawing.Size(100, 25);
            this.buttonProgressBarGreen.TabIndex = 3;
            this.buttonProgressBarGreen.UseVisualStyleBackColor = false;
            // 
            // buttonBackGroundColor
            // 
            this.buttonBackGroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackGroundColor.ForeColor = System.Drawing.Color.Silver;
            this.buttonBackGroundColor.Location = new System.Drawing.Point(0, 671);
            this.buttonBackGroundColor.Name = "buttonBackGroundColor";
            this.buttonBackGroundColor.Size = new System.Drawing.Size(10, 10);
            this.buttonBackGroundColor.TabIndex = 4;
            this.buttonBackGroundColor.UseVisualStyleBackColor = true;
            this.buttonBackGroundColor.Click += new System.EventHandler(this.buttonBackGroundColor_Click);
            // 
            // FormJoAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(814, 681);
            this.Controls.Add(this.buttonBackGroundColor);
            this.Controls.Add(this.buttonProgressBarGreen);
            this.Controls.Add(this.buttonProgressBarRed);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.flowLayoutPanelScrollList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormJoAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jack of All Champs                                                               " +
    "                                                                                " +
    "             by Raffi#0826";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelScrollList;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonProgressBarRed;
        private System.Windows.Forms.Button buttonProgressBarGreen;
        private System.Windows.Forms.Button buttonBackGroundColor;
    }
}

