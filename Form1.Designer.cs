namespace AppCSEcoCycle
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTeam = new System.Windows.Forms.Label();
            this.lbIndiv = new System.Windows.Forms.Label();
            this.btnT = new System.Windows.Forms.Button();
            this.btnCT = new System.Windows.Forms.Button();
            this.btnEco = new System.Windows.Forms.Button();
            this.btnArme = new System.Windows.Forms.Button();
            this.btnForce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlant = new System.Windows.Forms.Button();
            this.btnDefuse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.btnNoStuff = new System.Windows.Forms.Button();
            this.btnMidStuff = new System.Windows.Forms.Button();
            this.btnFullStuff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam.Location = new System.Drawing.Point(67, 92);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(164, 40);
            this.lbTeam.TabIndex = 0;
            this.lbTeam.Text = "unkwon $";
            // 
            // lbIndiv
            // 
            this.lbIndiv.AutoSize = true;
            this.lbIndiv.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndiv.Location = new System.Drawing.Point(382, 90);
            this.lbIndiv.Name = "lbIndiv";
            this.lbIndiv.Size = new System.Drawing.Size(112, 42);
            this.lbIndiv.TabIndex = 1;
            this.lbIndiv.Text = "800 $";
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.Red;
            this.btnT.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.Color.White;
            this.btnT.Location = new System.Drawing.Point(160, 172);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(112, 46);
            this.btnT.TabIndex = 2;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnTerroriste_Click);
            // 
            // btnCT
            // 
            this.btnCT.BackColor = System.Drawing.Color.Blue;
            this.btnCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCT.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCT.ForeColor = System.Drawing.Color.White;
            this.btnCT.Location = new System.Drawing.Point(297, 172);
            this.btnCT.Name = "btnCT";
            this.btnCT.Size = new System.Drawing.Size(112, 46);
            this.btnCT.TabIndex = 3;
            this.btnCT.Text = "CT";
            this.btnCT.UseVisualStyleBackColor = false;
            this.btnCT.Click += new System.EventHandler(this.btnCouterTerroriste_Click);
            // 
            // btnEco
            // 
            this.btnEco.Location = new System.Drawing.Point(150, 240);
            this.btnEco.Name = "btnEco";
            this.btnEco.Size = new System.Drawing.Size(75, 23);
            this.btnEco.TabIndex = 4;
            this.btnEco.Text = "éco";
            this.btnEco.UseVisualStyleBackColor = true;
            this.btnEco.Click += new System.EventHandler(this.btnEco_Click);
            // 
            // btnArme
            // 
            this.btnArme.Location = new System.Drawing.Point(150, 341);
            this.btnArme.Name = "btnArme";
            this.btnArme.Size = new System.Drawing.Size(75, 23);
            this.btnArme.TabIndex = 5;
            this.btnArme.Text = "Armé";
            this.btnArme.UseVisualStyleBackColor = true;
            this.btnArme.Click += new System.EventHandler(this.btnArme_Click);
            // 
            // btnForce
            // 
            this.btnForce.Location = new System.Drawing.Point(150, 274);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(75, 23);
            this.btnForce.TabIndex = 6;
            this.btnForce.Text = "Force Buy";
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "+";
            // 
            // btnPlant
            // 
            this.btnPlant.Location = new System.Drawing.Point(276, 253);
            this.btnPlant.Name = "btnPlant";
            this.btnPlant.Size = new System.Drawing.Size(75, 23);
            this.btnPlant.TabIndex = 8;
            this.btnPlant.Text = "Plant";
            this.btnPlant.UseVisualStyleBackColor = true;
            this.btnPlant.Click += new System.EventHandler(this.btnPlant_Click);
            // 
            // btnDefuse
            // 
            this.btnDefuse.Location = new System.Drawing.Point(276, 309);
            this.btnDefuse.Name = "btnDefuse";
            this.btnDefuse.Size = new System.Drawing.Size(75, 23);
            this.btnDefuse.TabIndex = 9;
            this.btnDefuse.Text = "Defuse";
            this.btnDefuse.UseVisualStyleBackColor = true;
            this.btnDefuse.Click += new System.EventHandler(this.btnDefuse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Moyenne Argent indiv :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moyenne Argent équipe:";
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWin.ForeColor = System.Drawing.Color.White;
            this.btnWin.Location = new System.Drawing.Point(17, 253);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(79, 33);
            this.btnWin.TabIndex = 12;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLose
            // 
            this.btnLose.BackColor = System.Drawing.Color.Maroon;
            this.btnLose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLose.ForeColor = System.Drawing.Color.White;
            this.btnLose.Location = new System.Drawing.Point(17, 302);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(79, 33);
            this.btnLose.TabIndex = 13;
            this.btnLose.Text = "Lose";
            this.btnLose.UseVisualStyleBackColor = false;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "+";
            // 
            // btnCalculer
            // 
            this.btnCalculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.ForeColor = System.Drawing.Color.White;
            this.btnCalculer.Location = new System.Drawing.Point(541, 274);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(113, 33);
            this.btnCalculer.TabIndex = 15;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = false;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.Navy;
            this.btnRecommencer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecommencer.Location = new System.Drawing.Point(568, 342);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(86, 22);
            this.btnRecommencer.TabIndex = 16;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = false;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // btnNoStuff
            // 
            this.btnNoStuff.Location = new System.Drawing.Point(421, 255);
            this.btnNoStuff.Name = "btnNoStuff";
            this.btnNoStuff.Size = new System.Drawing.Size(88, 25);
            this.btnNoStuff.TabIndex = 17;
            this.btnNoStuff.Text = "Aucun";
            this.btnNoStuff.UseVisualStyleBackColor = true;
            // 
            // btnMidStuff
            // 
            this.btnMidStuff.Location = new System.Drawing.Point(421, 286);
            this.btnMidStuff.Name = "btnMidStuff";
            this.btnMidStuff.Size = new System.Drawing.Size(88, 22);
            this.btnMidStuff.TabIndex = 18;
            this.btnMidStuff.Text = "Un peu";
            this.btnMidStuff.UseVisualStyleBackColor = true;
            this.btnMidStuff.Click += new System.EventHandler(this.btnMidStuff_Click);
            // 
            // btnFullStuff
            // 
            this.btnFullStuff.Location = new System.Drawing.Point(421, 314);
            this.btnFullStuff.Name = "btnFullStuff";
            this.btnFullStuff.Size = new System.Drawing.Size(88, 23);
            this.btnFullStuff.TabIndex = 19;
            this.btnFullStuff.Text = "Full Stuff";
            this.btnFullStuff.UseVisualStyleBackColor = true;
            this.btnFullStuff.Click += new System.EventHandler(this.btnFullStuff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stuff ?";
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(150, 309);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(75, 23);
            this.btnPM.TabIndex = 22;
            this.btnPM.Text = "PM";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Choisie le Side Adverse :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 390);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFullStuff);
            this.Controls.Add(this.btnMidStuff);
            this.Controls.Add(this.btnNoStuff);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDefuse);
            this.Controls.Add(this.btnPlant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnForce);
            this.Controls.Add(this.btnArme);
            this.Controls.Add(this.btnEco);
            this.Controls.Add(this.btnCT);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.lbIndiv);
            this.Controls.Add(this.lbTeam);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eco Cyclie App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.Label lbIndiv;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnCT;
        private System.Windows.Forms.Button btnEco;
        private System.Windows.Forms.Button btnArme;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlant;
        private System.Windows.Forms.Button btnDefuse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Button btnNoStuff;
        private System.Windows.Forms.Button btnMidStuff;
        private System.Windows.Forms.Button btnFullStuff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Label label7;
    }
}

