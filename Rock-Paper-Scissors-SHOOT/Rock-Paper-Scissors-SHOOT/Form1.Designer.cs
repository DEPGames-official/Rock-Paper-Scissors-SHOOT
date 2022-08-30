namespace Rock_Paper_Scissors_SHOOT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RPCText = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.RPCTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RPCText
            // 
            this.RPCText.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RPCText.Location = new System.Drawing.Point(181, 135);
            this.RPCText.Name = "RPCText";
            this.RPCText.Size = new System.Drawing.Size(376, 163);
            this.RPCText.TabIndex = 0;
            this.RPCText.Text = "RPC";
            this.RPCText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(298, 301);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(127, 32);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RPCTimer
            // 
            this.RPCTimer.Tick += new System.EventHandler(this.RPCTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.RPCText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RPCText;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Timer RPCTimer;
    }
}
