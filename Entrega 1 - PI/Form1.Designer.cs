namespace Entrega_1___PI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.lblIdpartida = new System.Windows.Forms.Label();
            this.lblNomeDaPartida = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstJogadoresDaPartida = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdPartidaCriada = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(78, 402);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(106, 31);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Partidas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.Location = new System.Drawing.Point(35, 87);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(196, 290);
            this.lstListaDePartidas.TabIndex = 3;
            this.lstListaDePartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaDePartidas_SelectedIndexChanged);
            // 
            // lblIdpartida
            // 
            this.lblIdpartida.AutoSize = true;
            this.lblIdpartida.Location = new System.Drawing.Point(23, 30);
            this.lblIdpartida.Name = "lblIdpartida";
            this.lblIdpartida.Size = new System.Drawing.Size(21, 13);
            this.lblIdpartida.TabIndex = 4;
            this.lblIdpartida.Text = "ID:";
            // 
            // lblNomeDaPartida
            // 
            this.lblNomeDaPartida.AutoSize = true;
            this.lblNomeDaPartida.Location = new System.Drawing.Point(23, 65);
            this.lblNomeDaPartida.Name = "lblNomeDaPartida";
            this.lblNomeDaPartida.Size = new System.Drawing.Size(38, 13);
            this.lblNomeDaPartida.TabIndex = 5;
            this.lblNomeDaPartida.Text = "Nome:";
            this.lblNomeDaPartida.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(23, 99);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(87, 13);
            this.lblDataPartida.TabIndex = 6;
            this.lblDataPartida.Text = "Data de Criação:";
            this.lblDataPartida.Click += new System.EventHandler(this.lblDataPartida_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblDataPartida);
            this.groupBox1.Controls.Add(this.lblIdpartida);
            this.groupBox1.Controls.Add(this.lblNomeDaPartida);
            this.groupBox1.Location = new System.Drawing.Point(239, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Partida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstJogadoresDaPartida
            // 
            this.lstJogadoresDaPartida.FormattingEnabled = true;
            this.lstJogadoresDaPartida.Location = new System.Drawing.Point(237, 282);
            this.lstJogadoresDaPartida.Name = "lstJogadoresDaPartida";
            this.lstJogadoresDaPartida.Size = new System.Drawing.Size(183, 95);
            this.lstJogadoresDaPartida.TabIndex = 8;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(817, 428);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 9;
            this.lblVersao.Text = "Versão";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista de Jogadores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(111, 25);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(132, 20);
            this.txtNomePartida.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome da Partida:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome do Grupo: Carnivoros";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(111, 63);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(132, 20);
            this.txtSenhaPartida.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Senha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblIdPartidaCriada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNomePartida);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSenhaPartida);
            this.groupBox2.Location = new System.Drawing.Point(560, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 129);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // lblIdPartidaCriada
            // 
            this.lblIdPartidaCriada.AutoSize = true;
            this.lblIdPartidaCriada.Location = new System.Drawing.Point(5, 99);
            this.lblIdPartidaCriada.Name = "lblIdPartidaCriada";
            this.lblIdPartidaCriada.Size = new System.Drawing.Size(105, 13);
            this.lblIdPartidaCriada.TabIndex = 21;
            this.lblIdPartidaCriada.Text = "ID da Partida Criada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Criar Partida";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(644, 230);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(88, 33);
            this.btnCriarPartida.TabIndex = 20;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadoresDaPartida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Label lblIdpartida;
        private System.Windows.Forms.Label lblNomeDaPartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstJogadoresDaPartida;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblIdPartidaCriada;
    }
}

