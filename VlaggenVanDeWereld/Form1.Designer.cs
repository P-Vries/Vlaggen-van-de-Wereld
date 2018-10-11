namespace VlaggenVanDeWereld
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
            this.btnSlaOp = new System.Windows.Forms.Button();
            this.txbVlagURL = new System.Windows.Forms.TextBox();
            this.txbLandNaam = new System.Windows.Forms.TextBox();
            this.pbVlag = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.pnlIn = new System.Windows.Forms.Panel();
            this.btnLaad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.pnlQuiz = new System.Windows.Forms.Panel();
            this.btnCheckAns = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAntwoord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVlag)).BeginInit();
            this.pnlIn.SuspendLayout();
            this.pnlQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSlaOp
            // 
            this.btnSlaOp.Location = new System.Drawing.Point(260, 3);
            this.btnSlaOp.Name = "btnSlaOp";
            this.btnSlaOp.Size = new System.Drawing.Size(75, 23);
            this.btnSlaOp.TabIndex = 0;
            this.btnSlaOp.Text = "Sla op";
            this.btnSlaOp.UseVisualStyleBackColor = true;
            this.btnSlaOp.Click += new System.EventHandler(this.btnSlaOp_Click);
            // 
            // txbVlagURL
            // 
            this.txbVlagURL.Location = new System.Drawing.Point(135, 3);
            this.txbVlagURL.Name = "txbVlagURL";
            this.txbVlagURL.Size = new System.Drawing.Size(100, 20);
            this.txbVlagURL.TabIndex = 1;
            // 
            // txbLandNaam
            // 
            this.txbLandNaam.Location = new System.Drawing.Point(0, 3);
            this.txbLandNaam.Name = "txbLandNaam";
            this.txbLandNaam.Size = new System.Drawing.Size(100, 20);
            this.txbLandNaam.TabIndex = 2;
            // 
            // pbVlag
            // 
            this.pbVlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVlag.Location = new System.Drawing.Point(362, 12);
            this.pbVlag.Name = "pbVlag";
            this.pbVlag.Size = new System.Drawing.Size(426, 397);
            this.pbVlag.TabIndex = 3;
            this.pbVlag.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Land naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Land vlag (URL-Link)";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(579, 425);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 6;
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(713, 415);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(75, 23);
            this.btnVolgende.TabIndex = 8;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // pnlIn
            // 
            this.pnlIn.Controls.Add(this.btnLaad);
            this.pnlIn.Controls.Add(this.txbLandNaam);
            this.pnlIn.Controls.Add(this.btnSlaOp);
            this.pnlIn.Controls.Add(this.txbVlagURL);
            this.pnlIn.Controls.Add(this.label1);
            this.pnlIn.Controls.Add(this.label2);
            this.pnlIn.Location = new System.Drawing.Point(12, 12);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(335, 82);
            this.pnlIn.TabIndex = 10;
            // 
            // btnLaad
            // 
            this.btnLaad.Location = new System.Drawing.Point(0, 51);
            this.btnLaad.Name = "btnLaad";
            this.btnLaad.Size = new System.Drawing.Size(335, 23);
            this.btnLaad.TabIndex = 7;
            this.btnLaad.Text = "Laad";
            this.btnLaad.UseVisualStyleBackColor = true;
            this.btnLaad.Click += new System.EventHandler(this.btnLaad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Location = new System.Drawing.Point(12, 100);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(335, 23);
            this.btnStartQuiz.TabIndex = 11;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // pnlQuiz
            // 
            this.pnlQuiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuiz.Controls.Add(this.btnCheckAns);
            this.pnlQuiz.Controls.Add(this.label3);
            this.pnlQuiz.Controls.Add(this.txbAntwoord);
            this.pnlQuiz.Location = new System.Drawing.Point(12, 129);
            this.pnlQuiz.Name = "pnlQuiz";
            this.pnlQuiz.Size = new System.Drawing.Size(335, 84);
            this.pnlQuiz.TabIndex = 12;
            this.pnlQuiz.Visible = false;
            // 
            // btnCheckAns
            // 
            this.btnCheckAns.Location = new System.Drawing.Point(116, 58);
            this.btnCheckAns.Name = "btnCheckAns";
            this.btnCheckAns.Size = new System.Drawing.Size(216, 23);
            this.btnCheckAns.TabIndex = 2;
            this.btnCheckAns.Text = "Check antwoord";
            this.btnCheckAns.UseVisualStyleBackColor = true;
            this.btnCheckAns.Click += new System.EventHandler(this.btnCheckAns_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naam van het Land: ";
            // 
            // txbAntwoord
            // 
            this.txbAntwoord.Location = new System.Drawing.Point(116, 8);
            this.txbAntwoord.Name = "txbAntwoord";
            this.txbAntwoord.Size = new System.Drawing.Size(216, 20);
            this.txbAntwoord.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlQuiz);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.pnlIn);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.pbVlag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbVlag)).EndInit();
            this.pnlIn.ResumeLayout(false);
            this.pnlIn.PerformLayout();
            this.pnlQuiz.ResumeLayout(false);
            this.pnlQuiz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlaOp;
        private System.Windows.Forms.TextBox txbVlagURL;
        private System.Windows.Forms.TextBox txbLandNaam;
        private System.Windows.Forms.PictureBox pbVlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Panel pnlIn;
        private System.Windows.Forms.Button btnLaad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Panel pnlQuiz;
        private System.Windows.Forms.Button btnCheckAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAntwoord;
    }
}

