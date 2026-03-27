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
            this.lblFaceDado = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.VerificarVezDeJogar = new System.Windows.Forms.Timer(this.components);
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.txtExibirTabuleiro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.Location = new System.Drawing.Point(93, 832);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(95, 13);
            this.lblMao.TabIndex = 0;
            this.lblMao.Text = "Meus dinossauros:";
            this.lblMao.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(12, 827);
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
            this.groupBox1.Location = new System.Drawing.Point(518, 832);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de jogadores";
            // 
            // lstJogadoresNaPartida
            // 
            this.lstJogadoresNaPartida.FormattingEnabled = true;
            this.lstJogadoresNaPartida.Location = new System.Drawing.Point(0, 19);
            this.lstJogadoresNaPartida.Name = "lstJogadoresNaPartida";
            this.lstJogadoresNaPartida.Size = new System.Drawing.Size(176, 69);
            this.lstJogadoresNaPartida.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFaceDado);
            this.groupBox2.Controls.Add(this.lblTurno);
            this.groupBox2.Controls.Add(this.lblJogadorSorteado);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações da Partida";
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
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(426, 12);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(88, 23);
            this.btnExibirTabuleiro.TabIndex = 5;
            this.btnExibirTabuleiro.Text = "ExibirTabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            // 
            // txtExibirTabuleiro
            // 
            this.txtExibirTabuleiro.Location = new System.Drawing.Point(520, 12);
            this.txtExibirTabuleiro.Name = "txtExibirTabuleiro";
            this.txtExibirTabuleiro.Size = new System.Drawing.Size(174, 20);
            this.txtExibirTabuleiro.TabIndex = 6;
            this.txtExibirTabuleiro.TextChanged += new System.EventHandler(this.txtExibirTabuleiro_TextChanged);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Entrega_1___PI.Properties.Resources.Tabuleiro_PI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(706, 940);
            this.Controls.Add(this.txtExibirTabuleiro);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.lblMao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}