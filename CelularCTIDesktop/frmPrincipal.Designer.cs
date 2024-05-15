﻿namespace CelularCTI.Desktop
{
    partial class frmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnPesquisarFabricante = new System.Windows.Forms.Button();
            this.btnPesquisarModelo = new System.Windows.Forms.Button();
            this.btnPesquisarPreco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numPrecoMaximo = new System.Windows.Forms.NumericUpDown();
            this.numPrecoMinimo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.lstCelulares = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMinimo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFabricante);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.btnPesquisarFabricante);
            this.groupBox1.Controls.Add(this.btnPesquisarModelo);
            this.groupBox1.Controls.Add(this.btnPesquisarPreco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numPrecoMaximo);
            this.groupBox1.Controls.Add(this.numPrecoMinimo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(672, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:  ";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(123, 122);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(343, 31);
            this.cmbFabricante.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(123, 77);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(344, 30);
            this.txtModelo.TabIndex = 9;
            // 
            // btnPesquisarFabricante
            // 
            this.btnPesquisarFabricante.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFabricante.Location = new System.Drawing.Point(495, 119);
            this.btnPesquisarFabricante.Name = "btnPesquisarFabricante";
            this.btnPesquisarFabricante.Size = new System.Drawing.Size(82, 28);
            this.btnPesquisarFabricante.TabIndex = 8;
            this.btnPesquisarFabricante.Text = ">>";
            this.btnPesquisarFabricante.UseVisualStyleBackColor = true;
            this.btnPesquisarFabricante.Click += new System.EventHandler(this.btnPesquisarFabricante_Click);
            // 
            // btnPesquisarModelo
            // 
            this.btnPesquisarModelo.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarModelo.Location = new System.Drawing.Point(495, 77);
            this.btnPesquisarModelo.Name = "btnPesquisarModelo";
            this.btnPesquisarModelo.Size = new System.Drawing.Size(82, 28);
            this.btnPesquisarModelo.TabIndex = 7;
            this.btnPesquisarModelo.Text = ">>";
            this.btnPesquisarModelo.UseVisualStyleBackColor = true;
            this.btnPesquisarModelo.Click += new System.EventHandler(this.btnPesquisarModelo_Click);
            // 
            // btnPesquisarPreco
            // 
            this.btnPesquisarPreco.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPreco.Location = new System.Drawing.Point(495, 36);
            this.btnPesquisarPreco.Name = "btnPesquisarPreco";
            this.btnPesquisarPreco.Size = new System.Drawing.Size(82, 28);
            this.btnPesquisarPreco.TabIndex = 6;
            this.btnPesquisarPreco.Text = ">>";
            this.btnPesquisarPreco.UseVisualStyleBackColor = true;
            this.btnPesquisarPreco.Click += new System.EventHandler(this.btnPesquisarPreco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "a";
            // 
            // numPrecoMaximo
            // 
            this.numPrecoMaximo.DecimalPlaces = 2;
            this.numPrecoMaximo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPrecoMaximo.Location = new System.Drawing.Point(319, 34);
            this.numPrecoMaximo.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numPrecoMaximo.Name = "numPrecoMaximo";
            this.numPrecoMaximo.Size = new System.Drawing.Size(151, 30);
            this.numPrecoMaximo.TabIndex = 4;
            this.numPrecoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoMaximo.ThousandsSeparator = true;
            // 
            // numPrecoMinimo
            // 
            this.numPrecoMinimo.DecimalPlaces = 2;
            this.numPrecoMinimo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPrecoMinimo.Location = new System.Drawing.Point(123, 34);
            this.numPrecoMinimo.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numPrecoMinimo.Name = "numPrecoMinimo";
            this.numPrecoMinimo.Size = new System.Drawing.Size(151, 30);
            this.numPrecoMinimo.TabIndex = 3;
            this.numPrecoMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoMinimo.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarTodos);
            this.groupBox2.Controls.Add(this.lstCelulares);
            this.groupBox2.Location = new System.Drawing.Point(25, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 423);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celulares : ";
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodos.Location = new System.Drawing.Point(512, 362);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(141, 28);
            this.btnListarTodos.TabIndex = 8;
            this.btnListarTodos.Text = "&Listar todos aparelhos";
            this.btnListarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // lstCelulares
            // 
            this.lstCelulares.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCelulares.FormattingEnabled = true;
            this.lstCelulares.ItemHeight = 19;
            this.lstCelulares.Location = new System.Drawing.Point(17, 37);
            this.lstCelulares.Name = "lstCelulares";
            this.lstCelulares.Size = new System.Drawing.Size(636, 308);
            this.lstCelulares.TabIndex = 2;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(42, 662);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(82, 28);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(172, 662);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 28);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(459, 662);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 28);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(596, 662);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(82, 28);
            this.btnCliente.TabIndex = 10;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(317, 662);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 28);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 728);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Loja CelularCTi - O seu mundo mobile";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMinimo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPrecoMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnPesquisarFabricante;
        private System.Windows.Forms.Button btnPesquisarModelo;
        private System.Windows.Forms.Button btnPesquisarPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPrecoMaximo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCelulares;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnExcluir;
    }
}

