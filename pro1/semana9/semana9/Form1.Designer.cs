
namespace semana9
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LAFP = new System.Windows.Forms.Label();
            this.AFP = new System.Windows.Forms.Button();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.ISSS = new System.Windows.Forms.Button();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.LISSS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSalario = new System.Windows.Forms.Button();
            this.txtSalN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(134, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.Location = new System.Drawing.Point(134, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(134, 179);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 22);
            this.txtDUI.TabIndex = 6;
            this.txtDUI.TextChanged += new System.EventHandler(this.txtDUI_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(134, 223);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 22);
            this.txtSalario.TabIndex = 7;
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.BackColor = System.Drawing.Color.Snow;
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(131, 283);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(33, 17);
            this.Registro.TabIndex = 8;
            this.Registro.Text = ".....";
            this.Registro.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LAFP
            // 
            this.LAFP.AutoSize = true;
            this.LAFP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAFP.Location = new System.Drawing.Point(466, 122);
            this.LAFP.Name = "LAFP";
            this.LAFP.Size = new System.Drawing.Size(37, 17);
            this.LAFP.TabIndex = 11;
            this.LAFP.Text = "AFP";
            // 
            // AFP
            // 
            this.AFP.BackColor = System.Drawing.Color.Navy;
            this.AFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AFP.Location = new System.Drawing.Point(570, 75);
            this.AFP.Name = "AFP";
            this.AFP.Size = new System.Drawing.Size(81, 32);
            this.AFP.TabIndex = 12;
            this.AFP.Text = "AFP";
            this.AFP.UseVisualStyleBackColor = false;
            this.AFP.Click += new System.EventHandler(this.AFP_Click);
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(534, 122);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(171, 22);
            this.txtAFP.TabIndex = 13;
            this.txtAFP.TextChanged += new System.EventHandler(this.txtAFP_TextChanged);
            // 
            // ISSS
            // 
            this.ISSS.BackColor = System.Drawing.Color.Navy;
            this.ISSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISSS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ISSS.Location = new System.Drawing.Point(570, 163);
            this.ISSS.Name = "ISSS";
            this.ISSS.Size = new System.Drawing.Size(88, 38);
            this.ISSS.TabIndex = 14;
            this.ISSS.Text = "ISSS";
            this.ISSS.UseVisualStyleBackColor = false;
            this.ISSS.Click += new System.EventHandler(this.ISSS_Click);
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(534, 209);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(171, 22);
            this.txtISSS.TabIndex = 15;
            this.txtISSS.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LISSS
            // 
            this.LISSS.AutoSize = true;
            this.LISSS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LISSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISSS.Location = new System.Drawing.Point(466, 214);
            this.LISSS.Name = "LISSS";
            this.LISSS.Size = new System.Drawing.Size(42, 17);
            this.LISSS.TabIndex = 16;
            this.LISSS.Text = "ISSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "INGRESE LOS SIGUIENTES DATOS:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::semana9.Properties.Resources.wallhaven_x852jv;
            this.pictureBox5.Location = new System.Drawing.Point(4, 314);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(374, 11);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::semana9.Properties.Resources.wallhaven_j399zq;
            this.pictureBox4.Location = new System.Drawing.Point(412, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(362, 23);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::semana9.Properties.Resources.wallhaven_j399zq;
            this.pictureBox3.Location = new System.Drawing.Point(412, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(362, 24);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::semana9.Properties.Resources.wallhaven_j399zq;
            this.pictureBox2.Location = new System.Drawing.Point(749, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 357);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::semana9.Properties.Resources.wallhaven_j399zq;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 357);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btSalario
            // 
            this.btSalario.BackColor = System.Drawing.Color.Navy;
            this.btSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalario.Location = new System.Drawing.Point(570, 255);
            this.btSalario.Name = "btSalario";
            this.btSalario.Size = new System.Drawing.Size(103, 45);
            this.btSalario.TabIndex = 23;
            this.btSalario.Text = "SALARIO NETO";
            this.btSalario.UseVisualStyleBackColor = false;
            this.btSalario.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSalN
            // 
            this.txtSalN.Location = new System.Drawing.Point(534, 303);
            this.txtSalN.Name = "txtSalN";
            this.txtSalN.Size = new System.Drawing.Size(171, 22);
            this.txtSalN.TabIndex = 24;
            this.txtSalN.TextChanged += new System.EventHandler(this.txtSalN_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Salario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(427, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Haga click sobre el dato que necesita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalN);
            this.Controls.Add(this.btSalario);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LISSS);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.ISSS);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.AFP);
            this.Controls.Add(this.LAFP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LAFP;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Button AFP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LISSS;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Button ISSS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalN;
        private System.Windows.Forms.Button btSalario;
        private System.Windows.Forms.Label label7;
    }
}

