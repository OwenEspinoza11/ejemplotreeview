namespace WinFormsApp1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("IR");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Inss patronal", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inss laboral", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Deducciones de ley", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.txtInssP = new System.Windows.Forms.TextBox();
            this.txtxInssL = new System.Windows.Forms.TextBox();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIngreso = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tvDatos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingreso mensual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inss laboral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inss patronal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "IR";
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(197, 233);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(100, 23);
            this.txtIR.TabIndex = 5;
            // 
            // txtInssP
            // 
            this.txtInssP.Location = new System.Drawing.Point(197, 185);
            this.txtInssP.Name = "txtInssP";
            this.txtInssP.Size = new System.Drawing.Size(100, 23);
            this.txtInssP.TabIndex = 6;
            // 
            // txtxInssL
            // 
            this.txtxInssL.Location = new System.Drawing.Point(197, 134);
            this.txtxInssL.Name = "txtxInssL";
            this.txtxInssL.Size = new System.Drawing.Size(100, 23);
            this.txtxInssL.TabIndex = 7;
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Location = new System.Drawing.Point(197, 29);
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.mtxtCodigo.TabIndex = 8;
            // 
            // mtxtIngreso
            // 
            this.mtxtIngreso.Location = new System.Drawing.Point(197, 72);
            this.mtxtIngreso.Name = "mtxtIngreso";
            this.mtxtIngreso.Size = new System.Drawing.Size(100, 23);
            this.mtxtIngreso.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(54, 316);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(135, 316);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tvDatos
            // 
            this.tvDatos.Location = new System.Drawing.Point(327, 12);
            this.tvDatos.Name = "tvDatos";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "IR";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Inss patronal";
            treeNode3.Name = "Nodo1";
            treeNode3.Text = "Inss laboral";
            treeNode4.Name = "Nodo0";
            treeNode4.Text = "Deducciones de ley";
            this.tvDatos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvDatos.Size = new System.Drawing.Size(176, 339);
            this.tvDatos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 388);
            this.Controls.Add(this.tvDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mtxtIngreso);
            this.Controls.Add(this.mtxtCodigo);
            this.Controls.Add(this.txtxInssL);
            this.Controls.Add(this.txtInssP);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcularinss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIR;
        private TextBox txtInssP;
        private TextBox txtxInssL;
        private MaskedTextBox mtxtCodigo;
        private MaskedTextBox mtxtIngreso;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TreeView tvDatos;
    }
}