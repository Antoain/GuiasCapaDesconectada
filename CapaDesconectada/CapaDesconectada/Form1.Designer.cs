namespace CapaDesconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridnoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridTipado = new System.Windows.Forms.DataGridView();
            this.btnObtenernoTipado = new System.Windows.Forms.Button();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBusquedaNT = new System.Windows.Forms.TextBox();
            this.btnBuscarNT = new System.Windows.Forms.Button();
            this.btnBuscarT = new System.Windows.Forms.Button();
            this.txtBuscarT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbCustomerID = new System.Windows.Forms.TextBox();
            this.textbompanyName = new System.Windows.Forms.TextBox();
            this.txtbContactname = new System.Windows.Forms.TextBox();
            this.txtbContacttitle = new System.Windows.Forms.TextBox();
            this.txtbAdress = new System.Windows.Forms.TextBox();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.btnActualizarNT = new System.Windows.Forms.Button();
            this.btnActualzarT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridnoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridnoTipado);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet no Tipado";
            // 
            // GridnoTipado
            // 
            this.GridnoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridnoTipado.Location = new System.Drawing.Point(6, 21);
            this.GridnoTipado.Name = "GridnoTipado";
            this.GridnoTipado.RowHeadersWidth = 51;
            this.GridnoTipado.RowTemplate.Height = 24;
            this.GridnoTipado.Size = new System.Drawing.Size(389, 316);
            this.GridnoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridTipado);
            this.groupBox2.Location = new System.Drawing.Point(512, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // GridTipado
            // 
            this.GridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipado.Location = new System.Drawing.Point(6, 21);
            this.GridTipado.Name = "GridTipado";
            this.GridTipado.RowHeadersWidth = 51;
            this.GridTipado.RowTemplate.Height = 24;
            this.GridTipado.Size = new System.Drawing.Size(381, 316);
            this.GridTipado.TabIndex = 0;
            // 
            // btnObtenernoTipado
            // 
            this.btnObtenernoTipado.Location = new System.Drawing.Point(46, 401);
            this.btnObtenernoTipado.Name = "btnObtenernoTipado";
            this.btnObtenernoTipado.Size = new System.Drawing.Size(244, 31);
            this.btnObtenernoTipado.TabIndex = 2;
            this.btnObtenernoTipado.Text = "Obtener  Datos No Tipados";
            this.btnObtenernoTipado.UseVisualStyleBackColor = true;
            this.btnObtenernoTipado.Click += new System.EventHandler(this.btnObtenernoTipado_Click);
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(630, 409);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(203, 23);
            this.btnObtenerTipado.TabIndex = 3;
            this.btnObtenerTipado.Text = "Obtener Dato Tipado";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // tbBusquedaNT
            // 
            this.tbBusquedaNT.Location = new System.Drawing.Point(94, 495);
            this.tbBusquedaNT.Name = "tbBusquedaNT";
            this.tbBusquedaNT.Size = new System.Drawing.Size(235, 22);
            this.tbBusquedaNT.TabIndex = 5;
            // 
            // btnBuscarNT
            // 
            this.btnBuscarNT.Location = new System.Drawing.Point(123, 534);
            this.btnBuscarNT.Name = "btnBuscarNT";
            this.btnBuscarNT.Size = new System.Drawing.Size(148, 23);
            this.btnBuscarNT.TabIndex = 6;
            this.btnBuscarNT.Text = "Buscar Cliente";
            this.btnBuscarNT.UseVisualStyleBackColor = true;
            this.btnBuscarNT.Click += new System.EventHandler(this.btnBuscarNT_Click);
            // 
            // btnBuscarT
            // 
            this.btnBuscarT.Location = new System.Drawing.Point(706, 532);
            this.btnBuscarT.Name = "btnBuscarT";
            this.btnBuscarT.Size = new System.Drawing.Size(148, 23);
            this.btnBuscarT.TabIndex = 9;
            this.btnBuscarT.Text = "Buscar Cliente";
            this.btnBuscarT.UseVisualStyleBackColor = true;
            this.btnBuscarT.Click += new System.EventHandler(this.btnBuscarT_Click);
            // 
            // txtBuscarT
            // 
            this.txtBuscarT.Location = new System.Drawing.Point(677, 493);
            this.txtBuscarT.Name = "txtBuscarT";
            this.txtBuscarT.Size = new System.Drawing.Size(235, 22);
            this.txtBuscarT.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(985, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "CompanyName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(985, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(985, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(985, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(985, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adress";
            // 
            // txtbCustomerID
            // 
            this.txtbCustomerID.Location = new System.Drawing.Point(1117, 101);
            this.txtbCustomerID.Name = "txtbCustomerID";
            this.txtbCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtbCustomerID.TabIndex = 15;
            // 
            // textbompanyName
            // 
            this.textbompanyName.Location = new System.Drawing.Point(1117, 149);
            this.textbompanyName.Name = "textbompanyName";
            this.textbompanyName.Size = new System.Drawing.Size(100, 22);
            this.textbompanyName.TabIndex = 16;
            // 
            // txtbContactname
            // 
            this.txtbContactname.Location = new System.Drawing.Point(1117, 182);
            this.txtbContactname.Name = "txtbContactname";
            this.txtbContactname.Size = new System.Drawing.Size(100, 22);
            this.txtbContactname.TabIndex = 17;
            // 
            // txtbContacttitle
            // 
            this.txtbContacttitle.Location = new System.Drawing.Point(1117, 211);
            this.txtbContacttitle.Name = "txtbContacttitle";
            this.txtbContacttitle.Size = new System.Drawing.Size(100, 22);
            this.txtbContacttitle.TabIndex = 18;
            // 
            // txtbAdress
            // 
            this.txtbAdress.Location = new System.Drawing.Point(1117, 257);
            this.txtbAdress.Name = "txtbAdress";
            this.txtbAdress.Size = new System.Drawing.Size(100, 22);
            this.txtbAdress.TabIndex = 19;
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(78, 438);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarCliente.TabIndex = 20;
            this.btnInsertarCliente.Text = "Enviar";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(630, 440);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarT.TabIndex = 21;
            this.btnInsertarT.Text = "Enviar Tipado";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // btnActualizarNT
            // 
            this.btnActualizarNT.Location = new System.Drawing.Point(159, 438);
            this.btnActualizarNT.Name = "btnActualizarNT";
            this.btnActualizarNT.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarNT.TabIndex = 22;
            this.btnActualizarNT.Text = "Actualizar";
            this.btnActualizarNT.UseVisualStyleBackColor = true;
            this.btnActualizarNT.Click += new System.EventHandler(this.btnActualizarNT_Click);
            // 
            // btnActualzarT
            // 
            this.btnActualzarT.Location = new System.Drawing.Point(758, 438);
            this.btnActualzarT.Name = "btnActualzarT";
            this.btnActualzarT.Size = new System.Drawing.Size(75, 23);
            this.btnActualzarT.TabIndex = 23;
            this.btnActualzarT.Text = "Actualizar";
            this.btnActualzarT.UseVisualStyleBackColor = true;
            this.btnActualzarT.Click += new System.EventHandler(this.btnActualzarT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 622);
            this.Controls.Add(this.btnActualzarT);
            this.Controls.Add(this.btnActualizarNT);
            this.Controls.Add(this.btnInsertarT);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.txtbAdress);
            this.Controls.Add(this.txtbContacttitle);
            this.Controls.Add(this.txtbContactname);
            this.Controls.Add(this.textbompanyName);
            this.Controls.Add(this.txtbCustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarT);
            this.Controls.Add(this.txtBuscarT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarNT);
            this.Controls.Add(this.tbBusquedaNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTipado);
            this.Controls.Add(this.btnObtenernoTipado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridnoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridnoTipado;
        private System.Windows.Forms.DataGridView GridTipado;
        private System.Windows.Forms.Button btnObtenernoTipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusquedaNT;
        private System.Windows.Forms.Button btnBuscarNT;
        private System.Windows.Forms.Button btnBuscarT;
        private System.Windows.Forms.TextBox txtBuscarT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbCustomerID;
        private System.Windows.Forms.TextBox textbompanyName;
        private System.Windows.Forms.TextBox txtbContactname;
        private System.Windows.Forms.TextBox txtbContacttitle;
        private System.Windows.Forms.TextBox txtbAdress;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Button btnInsertarT;
        private System.Windows.Forms.Button btnActualizarNT;
        private System.Windows.Forms.Button btnActualzarT;
    }
}

