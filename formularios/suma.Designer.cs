namespace formularios
{
    partial class suma
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
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.buGuardar = new System.Windows.Forms.Button();
            this.texProdu = new System.Windows.Forms.TextBox();
            this.texVendido = new System.Windows.Forms.TextBox();
            this.texValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buLeer = new System.Windows.Forms.Button();
            this.buCrear = new System.Windows.Forms.Button();
            this.buNuevo = new System.Windows.Forms.Button();
            this.buAtras = new System.Windows.Forms.Button();
            this.texBUSCAR = new System.Windows.Forms.TextBox();
            this.texSumado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buSumar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV2
            // 
            this.DGV2.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV2.Location = new System.Drawing.Point(14, 55);
            this.DGV2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV2.Name = "DGV2";
            this.DGV2.Size = new System.Drawing.Size(344, 206);
            this.DGV2.TabIndex = 0;
            this.DGV2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV2_CellClick);
            // 
            // buGuardar
            // 
            this.buGuardar.BackColor = System.Drawing.Color.Cyan;
            this.buGuardar.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buGuardar.Location = new System.Drawing.Point(307, 20);
            this.buGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buGuardar.Name = "buGuardar";
            this.buGuardar.Size = new System.Drawing.Size(87, 28);
            this.buGuardar.TabIndex = 1;
            this.buGuardar.Text = "guardar";
            this.buGuardar.UseVisualStyleBackColor = false;
            this.buGuardar.Click += new System.EventHandler(this.buGuardar_Click);
            // 
            // texProdu
            // 
            this.texProdu.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texProdu.Location = new System.Drawing.Point(440, 76);
            this.texProdu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texProdu.Name = "texProdu";
            this.texProdu.Size = new System.Drawing.Size(116, 26);
            this.texProdu.TabIndex = 2;
            // 
            // texVendido
            // 
            this.texVendido.Location = new System.Drawing.Point(440, 124);
            this.texVendido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texVendido.Name = "texVendido";
            this.texVendido.Size = new System.Drawing.Size(116, 22);
            this.texVendido.TabIndex = 3;
            // 
            // texValor
            // 
            this.texValor.Location = new System.Drawing.Point(440, 183);
            this.texValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texValor.Name = "texValor";
            this.texValor.Size = new System.Drawing.Size(116, 22);
            this.texValor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pagado:";
            // 
            // buLeer
            // 
            this.buLeer.BackColor = System.Drawing.Color.Cyan;
            this.buLeer.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buLeer.Location = new System.Drawing.Point(197, 20);
            this.buLeer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buLeer.Name = "buLeer";
            this.buLeer.Size = new System.Drawing.Size(87, 28);
            this.buLeer.TabIndex = 11;
            this.buLeer.Text = "leer";
            this.buLeer.UseVisualStyleBackColor = false;
            this.buLeer.Click += new System.EventHandler(this.buLeer_Click);
            // 
            // buCrear
            // 
            this.buCrear.BackColor = System.Drawing.Color.Cyan;
            this.buCrear.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buCrear.Location = new System.Drawing.Point(103, 20);
            this.buCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buCrear.Name = "buCrear";
            this.buCrear.Size = new System.Drawing.Size(87, 28);
            this.buCrear.TabIndex = 12;
            this.buCrear.Text = "crear";
            this.buCrear.UseVisualStyleBackColor = false;
            this.buCrear.Click += new System.EventHandler(this.buCrear_Click);
            // 
            // buNuevo
            // 
            this.buNuevo.BackColor = System.Drawing.Color.Cyan;
            this.buNuevo.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buNuevo.Location = new System.Drawing.Point(14, 20);
            this.buNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buNuevo.Name = "buNuevo";
            this.buNuevo.Size = new System.Drawing.Size(82, 28);
            this.buNuevo.TabIndex = 13;
            this.buNuevo.Text = "Nuevo";
            this.buNuevo.UseVisualStyleBackColor = false;
            this.buNuevo.Click += new System.EventHandler(this.buNuevo_Click);
            // 
            // buAtras
            // 
            this.buAtras.BackColor = System.Drawing.Color.Cyan;
            this.buAtras.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buAtras.Location = new System.Drawing.Point(440, 233);
            this.buAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buAtras.Name = "buAtras";
            this.buAtras.Size = new System.Drawing.Size(87, 28);
            this.buAtras.TabIndex = 14;
            this.buAtras.Text = "Atras";
            this.buAtras.UseVisualStyleBackColor = false;
            this.buAtras.Click += new System.EventHandler(this.buAtras_Click);
            // 
            // texBUSCAR
            // 
            this.texBUSCAR.Location = new System.Drawing.Point(36, 290);
            this.texBUSCAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texBUSCAR.Name = "texBUSCAR";
            this.texBUSCAR.Size = new System.Drawing.Size(153, 22);
            this.texBUSCAR.TabIndex = 15;
            this.texBUSCAR.TextChanged += new System.EventHandler(this.texBUSCAR_TextChanged);
            // 
            // texSumado
            // 
            this.texSumado.Location = new System.Drawing.Point(299, 290);
            this.texSumado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texSumado.Name = "texSumado";
            this.texSumado.Size = new System.Drawing.Size(116, 22);
            this.texSumado.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Buscar Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sumar Ingreso";
            // 
            // buSumar
            // 
            this.buSumar.BackColor = System.Drawing.Color.Cyan;
            this.buSumar.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buSumar.Location = new System.Drawing.Point(440, 284);
            this.buSumar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buSumar.Name = "buSumar";
            this.buSumar.Size = new System.Drawing.Size(87, 28);
            this.buSumar.TabIndex = 21;
            this.buSumar.Text = "Sumar";
            this.buSumar.UseVisualStyleBackColor = false;
            this.buSumar.Click += new System.EventHandler(this.buSumar_Click);
            // 
            // suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(567, 322);
            this.Controls.Add(this.buSumar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texSumado);
            this.Controls.Add(this.texBUSCAR);
            this.Controls.Add(this.buAtras);
            this.Controls.Add(this.buNuevo);
            this.Controls.Add(this.buCrear);
            this.Controls.Add(this.buLeer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texValor);
            this.Controls.Add(this.texVendido);
            this.Controls.Add(this.texProdu);
            this.Controls.Add(this.buGuardar);
            this.Controls.Add(this.DGV2);
            this.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "suma";
            this.Opacity = 0.8D;
            this.Text = "suma";
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox texProdu;
        public System.Windows.Forms.TextBox texVendido;
        public System.Windows.Forms.TextBox texValor;
        private System.Windows.Forms.Button buLeer;
        private System.Windows.Forms.Button buCrear;
        private System.Windows.Forms.Button buNuevo;
        public System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.Button buAtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox texBUSCAR;
        public System.Windows.Forms.TextBox texSumado;
        private System.Windows.Forms.Button buSumar;
    }
}