namespace ConversorDeMoedaGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTaxaDeCambio;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbMoeda;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTaxaDeCambio = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            
            // lblTaxaDeCambio
            this.lblTaxaDeCambio.AutoSize = true;
            this.lblTaxaDeCambio.Location = new System.Drawing.Point(12, 9);
            this.lblTaxaDeCambio.Name = "lblTaxaDeCambio";
            this.lblTaxaDeCambio.Size = new System.Drawing.Size(135, 13);
            this.lblTaxaDeCambio.TabIndex = 3;
            this.lblTaxaDeCambio.Text = "Taxa de câmbio atual: 1 USD";

            // lblValor
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 42);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor em:";

            // cmbMoeda
            this.cmbMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.cmbMoeda.Location = new System.Drawing.Point(87, 39);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(100, 21);
            this.cmbMoeda.TabIndex = 5;
            this.cmbMoeda.SelectedIndexChanged += new System.EventHandler(this.cmbMoeda_SelectedIndexChanged);

            // txtValor
            this.txtValor.Location = new System.Drawing.Point(193, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 0;

            // btnConverter
            this.btnConverter.Location = new System.Drawing.Point(299, 37);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 72);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;

            // Form1
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.cmbMoeda);
            this.Controls.Add(this.lblTaxaDeCambio);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Conversor de Moeda";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
