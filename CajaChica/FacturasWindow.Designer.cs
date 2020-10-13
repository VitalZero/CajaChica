namespace CajaChica
{
    partial class FacturasWindow
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
            this.proveedor = new System.Windows.Forms.TextBox();
            this.rfc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.concepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.retencion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.montoTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(15, 27);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(300, 23);
            this.proveedor.TabIndex = 1;
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(321, 27);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(100, 23);
            this.rfc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "RFC";
            // 
            // concepto
            // 
            this.concepto.Location = new System.Drawing.Point(427, 27);
            this.concepto.Name = "concepto";
            this.concepto.Size = new System.Drawing.Size(150, 23);
            this.concepto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concepto";
            // 
            // fechaFactura
            // 
            this.fechaFactura.CustomFormat = "";
            this.fechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFactura.Location = new System.Drawing.Point(15, 71);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(100, 23);
            this.fechaFactura.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Factura";
            // 
            // numFactura
            // 
            this.numFactura.Location = new System.Drawing.Point(121, 71);
            this.numFactura.Name = "numFactura";
            this.numFactura.Size = new System.Drawing.Size(100, 23);
            this.numFactura.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Num Factura";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(227, 71);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(100, 23);
            this.monto.TabIndex = 11;
            this.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto $";
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(333, 71);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(100, 23);
            this.iva.TabIndex = 13;
            this.iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "I.V.A.";
            // 
            // retencion
            // 
            this.retencion.Location = new System.Drawing.Point(439, 71);
            this.retencion.Name = "retencion";
            this.retencion.Size = new System.Drawing.Size(100, 23);
            this.retencion.TabIndex = 15;
            this.retencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Retención";
            // 
            // cuenta
            // 
            this.cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cuenta.Location = new System.Drawing.Point(15, 115);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(300, 23);
            this.cuenta.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cuenta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // montoTotal
            // 
            this.montoTotal.Enabled = false;
            this.montoTotal.Location = new System.Drawing.Point(477, 115);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Size = new System.Drawing.Size(100, 23);
            this.montoTotal.TabIndex = 20;
            this.montoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Monto Total $";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(93, 144);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FacturasWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 182);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.montoTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.retencion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.concepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proveedor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturasWindow";
            this.ShowInTaskbar = false;
            this.Text = "Agregar Facturas";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proveedor;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox concepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox retencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox montoTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCerrar;
    }
}