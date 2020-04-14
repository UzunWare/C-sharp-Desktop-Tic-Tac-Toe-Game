namespace Tic_Tac_Toe
{
    partial class form1
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
            this.Start = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerOne = new System.Windows.Forms.Button();
            this.PlayerTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(14, 11);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 51);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(14, 76);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(615, 546);
            this.Map.TabIndex = 1;
            // 
            // PlayerOne
            // 
            this.PlayerOne.Location = new System.Drawing.Point(529, 11);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(47, 35);
            this.PlayerOne.TabIndex = 2;
            this.PlayerOne.Text = "Player 1";
            this.PlayerOne.UseVisualStyleBackColor = true;
            // 
            // PlayerTwo
            // 
            this.PlayerTwo.Location = new System.Drawing.Point(582, 11);
            this.PlayerTwo.Name = "PlayerTwo";
            this.PlayerTwo.Size = new System.Drawing.Size(47, 35);
            this.PlayerTwo.TabIndex = 3;
            this.PlayerTwo.Text = "Player 2";
            this.PlayerTwo.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 634);
            this.Controls.Add(this.PlayerTwo);
            this.Controls.Add(this.PlayerOne);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel Map;
        private System.Windows.Forms.Button PlayerOne;
        private System.Windows.Forms.Button PlayerTwo;

    }
}

