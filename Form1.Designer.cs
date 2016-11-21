namespace Simplex
{
    partial class Form1
    {
 
        private void InitializeComponent()
        {
            this.grpVariaveis = new System.Windows.Forms.GroupBox();
            this.btnAddVarBase = new System.Windows.Forms.Button();
            this.lstVariavelBase = new System.Windows.Forms.ListBox();
            this.grpNaoBase = new System.Windows.Forms.GroupBox();
            this.btnVarNaoBase = new System.Windows.Forms.Button();
            this.lstNaoBase = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMontarMatriz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grpVariaveis.SuspendLayout();

            // 
            // grpVariaveis
            // 
            this.grpVariaveis.Controls.Add(this.btnAddVarBase);
            this.grpVariaveis.Controls.Add(this.lstVariavelBase);
            this.grpVariaveis.Location = new System.Drawing.Point(12, 12);
            this.grpVariaveis.Name = "grpVariaveis";
            this.grpVariaveis.Size = new System.Drawing.Size(198, 358);
            this.grpVariaveis.TabIndex = 0;
            this.grpVariaveis.TabStop = false;
            this.grpVariaveis.Text = "Variáveis de Folga";
            // 
            // btnAddVarBase
            // 
            this.btnAddVarBase.Location = new System.Drawing.Point(6, 19);
            this.btnAddVarBase.Name = "btnAddVarBase";
            this.btnAddVarBase.Size = new System.Drawing.Size(186, 24);
            this.btnAddVarBase.TabIndex = 3;
            this.btnAddVarBase.Text = "Adicionar Variável de Folga";
            this.btnAddVarBase.UseVisualStyleBackColor = true;
            // 
            // lstVariavelBase
            // 
            this.lstVariavelBase.FormattingEnabled = true;
            this.lstVariavelBase.Location = new System.Drawing.Point(6, 49);
            this.lstVariavelBase.Name = "lstVariavelBase";
            this.lstVariavelBase.Size = new System.Drawing.Size(186, 303);
            this.lstVariavelBase.TabIndex = 2;
            // 
            // grpNaoBase
            // 
            this.grpNaoBase.Controls.Add(this.btnVarNaoBase);
            this.grpNaoBase.Controls.Add(this.lstNaoBase);
            this.grpNaoBase.Location = new System.Drawing.Point(216, 12);
            this.grpNaoBase.Name = "grpNaoBase";
            this.grpNaoBase.Size = new System.Drawing.Size(198, 358);
            this.grpNaoBase.TabIndex = 1;
            this.grpNaoBase.TabStop = false;
            this.grpNaoBase.Text = "Variáveis Base";
            // 
            // btnVarNaoBase
            // 
            this.btnVarNaoBase.Location = new System.Drawing.Point(6, 19);
            this.btnVarNaoBase.Name = "btnVarNaoBase";
            this.btnVarNaoBase.Size = new System.Drawing.Size(186, 24);
            this.btnVarNaoBase.TabIndex = 3;
            this.btnVarNaoBase.Text = "Adicionar Variável Base";
            this.btnVarNaoBase.UseVisualStyleBackColor = true;
            // 
            // lstNaoBase
            // 
            this.lstNaoBase.FormattingEnabled = true;
            this.lstNaoBase.Location = new System.Drawing.Point(6, 49);
            this.lstNaoBase.Name = "lstNaoBase";
            this.lstNaoBase.Size = new System.Drawing.Size(186, 303);
            this.lstNaoBase.TabIndex = 2;
            // 
            // dataGridView1
            // 

            
            this.dataGridView1.Location = new System.Drawing.Point(421, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 265);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMontarMatriz
            // 
            this.btnMontarMatriz.Location = new System.Drawing.Point(3, 382);
            this.btnMontarMatriz.Name = "btnMontarMatriz";
            this.btnMontarMatriz.Size = new System.Drawing.Size(177, 28);
            this.btnMontarMatriz.TabIndex = 3;
            this.btnMontarMatriz.Text = "MontarMatriz";
            this.btnMontarMatriz.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular Valores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstResultado
            // 

            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(423, 294);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(419, 108);
            this.lstResultado.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            this.ClientSize = new System.Drawing.Size(849, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMontarMatriz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpNaoBase);
            this.Controls.Add(this.grpVariaveis);    



        }


        private System.Windows.Forms.GroupBox grpVariaveis;

        private System.Windows.Forms.ListBox lstVariavelBase;
        private System.Windows.Forms.Button btnAddVarBase;
        private System.Windows.Forms.GroupBox grpNaoBase;
        private System.Windows.Forms.Button btnVarNaoBase;
        private System.Windows.Forms.ListBox lstNaoBase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMontarMatriz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button button2;

    }
}

