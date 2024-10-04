namespace CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsbNovo = new System.Windows.Forms.ToolStripButton();
            tsbCancelar = new System.Windows.Forms.ToolStripButton();
            tsbSalvar = new System.Windows.Forms.ToolStripButton();
            tsbAlterar = new System.Windows.Forms.ToolStripButton();
            tsbExcluir = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            lbIdBuscar = new System.Windows.Forms.ToolStripLabel();
            tstIdBuscar = new System.Windows.Forms.ToolStripTextBox();
            tsbBuscar = new System.Windows.Forms.ToolStripButton();
            lbId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            lbendereco = new System.Windows.Forms.Label();
            txtEndereco = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtBairro = new System.Windows.Forms.TextBox();
            txtCidade = new System.Windows.Forms.TextBox();
            mskCep = new System.Windows.Forms.MaskedTextBox();
            mskTelefone = new System.Windows.Forms.MaskedTextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            txtUF = new System.Windows.Forms.TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.Color.White;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbNovo, tsbCancelar, tsbSalvar, tsbAlterar, tsbExcluir, toolStripSeparator1, lbIdBuscar, tstIdBuscar, tsbBuscar });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbNovo.Image = (System.Drawing.Image)resources.GetObject("tsbNovo.Image");
            tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbNovo.Name = "tsbNovo";
            tsbNovo.Size = new System.Drawing.Size(23, 22);
            tsbNovo.Text = "Novo";
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = (System.Drawing.Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new System.Drawing.Size(23, 22);
            tsbCancelar.Text = "Cancelar";
            // 
            // tsbSalvar
            // 
            tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSalvar.Image = (System.Drawing.Image)resources.GetObject("tsbSalvar.Image");
            tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSalvar.Name = "tsbSalvar";
            tsbSalvar.Size = new System.Drawing.Size(23, 22);
            tsbSalvar.Text = "Salvar";
            tsbSalvar.Click += tsbSalvar_Click;
            // 
            // tsbAlterar
            // 
            tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbAlterar.Image = (System.Drawing.Image)resources.GetObject("tsbAlterar.Image");
            tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbAlterar.Name = "tsbAlterar";
            tsbAlterar.Size = new System.Drawing.Size(23, 22);
            tsbAlterar.Text = "Alterar";
            tsbAlterar.Click += tsbAlterar_Click;
            // 
            // tsbExcluir
            // 
            tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbExcluir.Image = (System.Drawing.Image)resources.GetObject("tsbExcluir.Image");
            tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExcluir.Name = "tsbExcluir";
            tsbExcluir.Size = new System.Drawing.Size(23, 22);
            tsbExcluir.Text = "Excluir";
            tsbExcluir.Click += tsbExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbIdBuscar
            // 
            lbIdBuscar.Name = "lbIdBuscar";
            lbIdBuscar.Size = new System.Drawing.Size(76, 22);
            lbIdBuscar.Text = "Buscar por Id";
            // 
            // tstIdBuscar
            // 
            tstIdBuscar.Name = "tstIdBuscar";
            tstIdBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = (System.Drawing.Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new System.Drawing.Size(23, 22);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(9, 52);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(17, 15);
            lbId.TabIndex = 1;
            lbId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(12, 70);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(63, 23);
            txtId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(90, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(634, 23);
            txtNome.TabIndex = 4;
            // 
            // lbendereco
            // 
            lbendereco.AutoSize = true;
            lbendereco.Location = new System.Drawing.Point(8, 117);
            lbendereco.Name = "lbendereco";
            lbendereco.Size = new System.Drawing.Size(56, 15);
            lbendereco.TabIndex = 5;
            lbendereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new System.Drawing.Point(12, 140);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new System.Drawing.Size(712, 23);
            txtEndereco.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "CEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(143, 181);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Bairro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(424, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 241);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // txtBairro
            // 
            txtBairro.Location = new System.Drawing.Point(143, 199);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new System.Drawing.Size(263, 23);
            txtBairro.TabIndex = 11;
            // 
            // txtCidade
            // 
            txtCidade.Location = new System.Drawing.Point(424, 199);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new System.Drawing.Size(300, 23);
            txtCidade.TabIndex = 12;
            // 
            // mskCep
            // 
            mskCep.Location = new System.Drawing.Point(12, 199);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new System.Drawing.Size(115, 23);
            mskCep.TabIndex = 13;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new System.Drawing.Point(12, 259);
            mskTelefone.Mask = "(00)00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new System.Drawing.Size(169, 23);
            mskTelefone.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (System.Drawing.Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.espreguicadeira;
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new System.Drawing.Point(604, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(184, 133);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(727, 179);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(21, 15);
            label6.TabIndex = 16;
            label6.Text = "UF";
            // 
            // txtUF
            // 
            txtUF.Location = new System.Drawing.Point(731, 202);
            txtUF.Name = "txtUF";
            txtUF.Size = new System.Drawing.Size(57, 23);
            txtUF.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtUF);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(mskTelefone);
            Controls.Add(mskCep);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEndereco);
            Controls.Add(lbendereco);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbIdBuscar;
        private System.Windows.Forms.ToolStripTextBox tstIdBuscar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUF;
    }
}
