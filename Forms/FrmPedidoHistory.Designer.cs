
namespace QuickFood.Forms
{
    partial class FrmPedidoHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbtFecha = new System.Windows.Forms.RadioButton();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.rbtMesero = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxMesero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cltNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msrNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pddFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pddTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pddEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Pedido";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cltNombre,
            this.msrNombre,
            this.pddFecha,
            this.pddTotal,
            this.pddEstado});
            this.dataGridView1.Location = new System.Drawing.Point(15, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 319);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(469, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(204, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbtFecha
            // 
            this.rbtFecha.AutoSize = true;
            this.rbtFecha.Location = new System.Drawing.Point(44, 12);
            this.rbtFecha.Name = "rbtFecha";
            this.rbtFecha.Size = new System.Drawing.Size(97, 17);
            this.rbtFecha.TabIndex = 8;
            this.rbtFecha.TabStop = true;
            this.rbtFecha.Text = "Fecha Pediddo";
            this.rbtFecha.UseVisualStyleBackColor = true;
            this.rbtFecha.CheckedChanged += new System.EventHandler(this.rbtFecha_CheckedChanged);
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Location = new System.Drawing.Point(147, 12);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(57, 17);
            this.rbtCliente.TabIndex = 9;
            this.rbtCliente.TabStop = true;
            this.rbtCliente.Text = "Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            this.rbtCliente.CheckedChanged += new System.EventHandler(this.rbtCliente_CheckedChanged);
            // 
            // rbtMesero
            // 
            this.rbtMesero.AutoSize = true;
            this.rbtMesero.Location = new System.Drawing.Point(210, 12);
            this.rbtMesero.Name = "rbtMesero";
            this.rbtMesero.Size = new System.Drawing.Size(60, 17);
            this.rbtMesero.TabIndex = 10;
            this.rbtMesero.TabStop = true;
            this.rbtMesero.Text = "Mesero";
            this.rbtMesero.UseVisualStyleBackColor = true;
            this.rbtMesero.CheckedChanged += new System.EventHandler(this.rbtMesero_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 35);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 34);
            this.panel2.TabIndex = 12;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(94, 4);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(239, 21);
            this.cbxCliente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxMesero);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 34);
            this.panel3.TabIndex = 13;
            // 
            // cbxMesero
            // 
            this.cbxMesero.FormattingEnabled = true;
            this.cbxMesero.Location = new System.Drawing.Point(94, 4);
            this.cbxMesero.Name = "cbxMesero";
            this.cbxMesero.Size = new System.Drawing.Size(239, 21);
            this.cbxMesero.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesero";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtFecha);
            this.panel4.Controls.Add(this.rbtCliente);
            this.panel4.Controls.Add(this.rbtMesero);
            this.panel4.Location = new System.Drawing.Point(32, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 46);
            this.panel4.TabIndex = 12;
            // 
            // cltNombre
            // 
            this.cltNombre.DataPropertyName = "cltNombre";
            this.cltNombre.HeaderText = "Cliente";
            this.cltNombre.Name = "cltNombre";
            this.cltNombre.ReadOnly = true;
            // 
            // msrNombre
            // 
            this.msrNombre.DataPropertyName = "msrNombre";
            this.msrNombre.HeaderText = "Mesero";
            this.msrNombre.Name = "msrNombre";
            this.msrNombre.ReadOnly = true;
            // 
            // pddFecha
            // 
            this.pddFecha.DataPropertyName = "pddFecha";
            this.pddFecha.HeaderText = "Fecha";
            this.pddFecha.Name = "pddFecha";
            this.pddFecha.ReadOnly = true;
            // 
            // pddTotal
            // 
            this.pddTotal.DataPropertyName = "pddTotal";
            this.pddTotal.HeaderText = "Total";
            this.pddTotal.Name = "pddTotal";
            this.pddTotal.ReadOnly = true;
            // 
            // pddEstado
            // 
            this.pddEstado.DataPropertyName = "pddEstado";
            this.pddEstado.HeaderText = "Estado";
            this.pddEstado.Name = "pddEstado";
            this.pddEstado.ReadOnly = true;
            // 
            // FrmPedidoHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPedidoHistory";
            this.Text = "Pedidos History";
            this.Load += new System.EventHandler(this.FrmPedidoHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbtFecha;
        private System.Windows.Forms.RadioButton rbtCliente;
        private System.Windows.Forms.RadioButton rbtMesero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxMesero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn msrNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pddFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn pddTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pddEstado;
    }
}