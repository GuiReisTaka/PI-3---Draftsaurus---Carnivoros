namespace Entrega_1___PI
{
    partial class Tabuleiro
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
            this.components = new System.ComponentModel.Container();
            this.lblMao = new System.Windows.Forms.Label();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lblJogadorSorteado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstJogadoresNaPartida = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picDado = new System.Windows.Forms.PictureBox();
            this.lblFaceDado = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.VerificarVezDeJogar = new System.Windows.Forms.Timer(this.components);
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.txtExibirTabuleiro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMao6 = new System.Windows.Forms.PictureBox();
            this.picMao1 = new System.Windows.Forms.PictureBox();
            this.picMao4 = new System.Windows.Forms.PictureBox();
            this.picMao5 = new System.Windows.Forms.PictureBox();
            this.picMao3 = new System.Windows.Forms.PictureBox();
            this.picMao2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDinossauro = new System.Windows.Forms.TextBox();
            this.txtCercado = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMao6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.Location = new System.Drawing.Point(47, 476);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(95, 13);
            this.lblMao.TabIndex = 0;
            this.lblMao.Text = "Meus dinossauros:";
            this.lblMao.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(97, 27);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(75, 23);
            this.btnExibirMao.TabIndex = 1;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // lblJogadorSorteado
            // 
            this.lblJogadorSorteado.AutoSize = true;
            this.lblJogadorSorteado.Location = new System.Drawing.Point(6, 44);
            this.lblJogadorSorteado.Name = "lblJogadorSorteado";
            this.lblJogadorSorteado.Size = new System.Drawing.Size(94, 13);
            this.lblJogadorSorteado.TabIndex = 2;
            this.lblJogadorSorteado.Text = "Jogador Sorteado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstJogadoresNaPartida);
            this.groupBox1.Location = new System.Drawing.Point(17, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de jogadores";
            // 
            // lstJogadoresNaPartida
            // 
            this.lstJogadoresNaPartida.FormattingEnabled = true;
            this.lstJogadoresNaPartida.Location = new System.Drawing.Point(4, 21);
            this.lstJogadoresNaPartida.Name = "lstJogadoresNaPartida";
            this.lstJogadoresNaPartida.Size = new System.Drawing.Size(233, 69);
            this.lstJogadoresNaPartida.TabIndex = 0;
            this.lstJogadoresNaPartida.SelectedIndexChanged += new System.EventHandler(this.lstJogadoresNaPartida_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picDado);
            this.groupBox2.Controls.Add(this.lblFaceDado);
            this.groupBox2.Controls.Add(this.lblTurno);
            this.groupBox2.Controls.Add(this.lblJogadorSorteado);
            this.groupBox2.Location = new System.Drawing.Point(17, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 214);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações da Partida";
            // 
            // picDado
            // 
            this.picDado.Location = new System.Drawing.Point(60, 99);
            this.picDado.Name = "picDado";
            this.picDado.Size = new System.Drawing.Size(100, 100);
            this.picDado.TabIndex = 5;
            this.picDado.TabStop = false;
            // 
            // lblFaceDado
            // 
            this.lblFaceDado.AutoSize = true;
            this.lblFaceDado.Location = new System.Drawing.Point(6, 72);
            this.lblFaceDado.Name = "lblFaceDado";
            this.lblFaceDado.Size = new System.Drawing.Size(78, 13);
            this.lblFaceDado.TabIndex = 4;
            this.lblFaceDado.Text = "Face do Dado:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(6, 16);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            this.lblTurno.Click += new System.EventHandler(this.lblTurno_Click);
            // 
            // VerificarVezDeJogar
            // 
            this.VerificarVezDeJogar.Tick += new System.EventHandler(this.VerificarVezDeJogar_Tick);
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(89, 503);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(88, 33);
            this.btnExibirTabuleiro.TabIndex = 5;
            this.btnExibirTabuleiro.Text = "ExibirTabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // txtExibirTabuleiro
            // 
            this.txtExibirTabuleiro.Location = new System.Drawing.Point(21, 440);
            this.txtExibirTabuleiro.Multiline = true;
            this.txtExibirTabuleiro.Name = "txtExibirTabuleiro";
            this.txtExibirTabuleiro.ReadOnly = true;
            this.txtExibirTabuleiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExibirTabuleiro.Size = new System.Drawing.Size(233, 57);
            this.txtExibirTabuleiro.TabIndex = 6;
            this.txtExibirTabuleiro.TextChanged += new System.EventHandler(this.txtExibirTabuleiro_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.picMao6);
            this.panel1.Controls.Add(this.picMao1);
            this.panel1.Controls.Add(this.picMao4);
            this.panel1.Controls.Add(this.picMao5);
            this.panel1.Controls.Add(this.picMao3);
            this.panel1.Controls.Add(this.picMao2);
            this.panel1.Controls.Add(this.btnExibirMao);
            this.panel1.Controls.Add(this.lblMao);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 688);
            this.panel1.TabIndex = 8;
            // 
            // picMao6
            // 
            this.picMao6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMao6.Location = new System.Drawing.Point(145, 306);
            this.picMao6.Name = "picMao6";
            this.picMao6.Size = new System.Drawing.Size(100, 100);
            this.picMao6.TabIndex = 7;
            this.picMao6.TabStop = false;
            // 
            // picMao1
            // 
            this.picMao1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMao1.Location = new System.Drawing.Point(24, 63);
            this.picMao1.Name = "picMao1";
            this.picMao1.Size = new System.Drawing.Size(100, 100);
            this.picMao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMao1.TabIndex = 6;
            this.picMao1.TabStop = false;
            this.picMao1.Click += new System.EventHandler(this.picMao1_Click);
            // 
            // picMao4
            // 
            this.picMao4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMao4.Location = new System.Drawing.Point(145, 185);
            this.picMao4.Name = "picMao4";
            this.picMao4.Size = new System.Drawing.Size(100, 100);
            this.picMao4.TabIndex = 5;
            this.picMao4.TabStop = false;
            // 
            // picMao5
            // 
            this.picMao5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMao5.Location = new System.Drawing.Point(24, 306);
            this.picMao5.Name = "picMao5";
            this.picMao5.Size = new System.Drawing.Size(100, 100);
            this.picMao5.TabIndex = 4;
            this.picMao5.TabStop = false;
            // 
            // picMao3
            // 
            this.picMao3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMao3.Location = new System.Drawing.Point(24, 185);
            this.picMao3.Name = "picMao3";
            this.picMao3.Size = new System.Drawing.Size(100, 100);
            this.picMao3.TabIndex = 3;
            this.picMao3.TabStop = false;
            // 
            // picMao2
            // 
            this.picMao2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMao2.Location = new System.Drawing.Point(145, 63);
            this.picMao2.Name = "picMao2";
            this.picMao2.Size = new System.Drawing.Size(100, 100);
            this.picMao2.TabIndex = 2;
            this.picMao2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnAtualizar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnJogar);
            this.panel2.Controls.Add(this.txtCercado);
            this.panel2.Controls.Add(this.txtDinossauro);
            this.panel2.Controls.Add(this.btnExibirTabuleiro);
            this.panel2.Controls.Add(this.txtExibirTabuleiro);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(1101, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 688);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Entrega_1___PI.Properties.Resources.Tabuleiro_PI;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(290, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 688);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtDinossauro
            // 
            this.txtDinossauro.Location = new System.Drawing.Point(26, 594);
            this.txtDinossauro.Name = "txtDinossauro";
            this.txtDinossauro.Size = new System.Drawing.Size(100, 20);
            this.txtDinossauro.TabIndex = 7;
            // 
            // txtCercado
            // 
            this.txtCercado.Location = new System.Drawing.Point(154, 594);
            this.txtCercado.Name = "txtCercado";
            this.txtCercado.Size = new System.Drawing.Size(100, 20);
            this.txtCercado.TabIndex = 8;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(89, 638);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(88, 31);
            this.btnJogar.TabIndex = 9;
            this.btnJogar.Text = "Jogada";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dinossauro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cercado";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(55, 241);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(141, 30);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar Informações";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMao6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMao2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMao;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.Label lblJogadorSorteado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstJogadoresNaPartida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblFaceDado;
        private System.Windows.Forms.Timer VerificarVezDeJogar;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.TextBox txtExibirTabuleiro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picDado;
        private System.Windows.Forms.PictureBox picMao6;
        private System.Windows.Forms.PictureBox picMao1;
        private System.Windows.Forms.PictureBox picMao4;
        private System.Windows.Forms.PictureBox picMao5;
        private System.Windows.Forms.PictureBox picMao3;
        private System.Windows.Forms.PictureBox picMao2;
        private System.Windows.Forms.TextBox txtCercado;
        private System.Windows.Forms.TextBox txtDinossauro;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}