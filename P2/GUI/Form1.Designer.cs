
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Wal_Baz = new System.Windows.Forms.TextBox();
            this.Wal_1_S = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Wal_1_W = new System.Windows.Forms.TextBox();
            this.Wal_2_W = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Wal_2_S = new System.Windows.Forms.TextBox();
            this.Wal_3_S = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Wal_3_W = new System.Windows.Forms.TextBox();
            this.Wal_4_S = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Wal_4_W = new System.Windows.Forms.TextBox();
            this.Wal_5_S = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Wal_5_W = new System.Windows.Forms.TextBox();
            this.Wal_6_S = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Wal_6_W = new System.Windows.Forms.TextBox();
            this.Wal_7_S = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Wal_7_W = new System.Windows.Forms.TextBox();
            this.Wal_8_S = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Wal_8_W = new System.Windows.Forms.TextBox();
            this.Wal_9_S = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Wal_9_W = new System.Windows.Forms.TextBox();
            this.Wal_10_S = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Wal_10_W = new System.Windows.Forms.TextBox();
            this.Przycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("EFN MacMenuTT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waluta bazowa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("EFN MacMenuTT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pozostałe waluty:";
            // 
            // Wal_Baz
            // 
            this.Wal_Baz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_Baz.Location = new System.Drawing.Point(204, 7);
            this.Wal_Baz.MaxLength = 3;
            this.Wal_Baz.Name = "Wal_Baz";
            this.Wal_Baz.Size = new System.Drawing.Size(66, 26);
            this.Wal_Baz.TabIndex = 2;
            this.Wal_Baz.Text = "USD";
            this.Wal_Baz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_Baz.TextChanged += new System.EventHandler(this.Wal_Baz_TextChanged);
            // 
            // Wal_1_S
            // 
            this.Wal_1_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_1_S.Location = new System.Drawing.Point(16, 89);
            this.Wal_1_S.MaxLength = 3;
            this.Wal_1_S.Name = "Wal_1_S";
            this.Wal_1_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_1_S.TabIndex = 3;
            this.Wal_1_S.Text = "USD";
            this.Wal_1_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_1_S.TextChanged += new System.EventHandler(this.Wal_1_S_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // Wal_1_W
            // 
            this.Wal_1_W.Enabled = false;
            this.Wal_1_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_1_W.Location = new System.Drawing.Point(124, 89);
            this.Wal_1_W.Name = "Wal_1_W";
            this.Wal_1_W.ReadOnly = true;
            this.Wal_1_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_1_W.TabIndex = 5;
            this.Wal_1_W.Text = "-";
            this.Wal_1_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_2_W
            // 
            this.Wal_2_W.Enabled = false;
            this.Wal_2_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_2_W.Location = new System.Drawing.Point(124, 121);
            this.Wal_2_W.Name = "Wal_2_W";
            this.Wal_2_W.ReadOnly = true;
            this.Wal_2_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_2_W.TabIndex = 8;
            this.Wal_2_W.Text = "-";
            this.Wal_2_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(87, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // Wal_2_S
            // 
            this.Wal_2_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_2_S.Location = new System.Drawing.Point(16, 121);
            this.Wal_2_S.MaxLength = 3;
            this.Wal_2_S.Name = "Wal_2_S";
            this.Wal_2_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_2_S.TabIndex = 6;
            this.Wal_2_S.Text = "GBP";
            this.Wal_2_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_2_S.TextChanged += new System.EventHandler(this.Wal_2_S_TextChanged);
            // 
            // Wal_3_S
            // 
            this.Wal_3_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_3_S.Location = new System.Drawing.Point(16, 153);
            this.Wal_3_S.MaxLength = 3;
            this.Wal_3_S.Name = "Wal_3_S";
            this.Wal_3_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_3_S.TabIndex = 3;
            this.Wal_3_S.Text = "EUR";
            this.Wal_3_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_3_S.TextChanged += new System.EventHandler(this.Wal_3_S_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(87, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "-";
            // 
            // Wal_3_W
            // 
            this.Wal_3_W.Enabled = false;
            this.Wal_3_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_3_W.Location = new System.Drawing.Point(124, 153);
            this.Wal_3_W.Name = "Wal_3_W";
            this.Wal_3_W.ReadOnly = true;
            this.Wal_3_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_3_W.TabIndex = 5;
            this.Wal_3_W.Text = "-";
            this.Wal_3_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_4_S
            // 
            this.Wal_4_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_4_S.Location = new System.Drawing.Point(16, 185);
            this.Wal_4_S.MaxLength = 3;
            this.Wal_4_S.Name = "Wal_4_S";
            this.Wal_4_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_4_S.TabIndex = 6;
            this.Wal_4_S.Text = "PLN";
            this.Wal_4_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_4_S.TextChanged += new System.EventHandler(this.Wal_4_S_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(87, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "-";
            // 
            // Wal_4_W
            // 
            this.Wal_4_W.Enabled = false;
            this.Wal_4_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_4_W.Location = new System.Drawing.Point(124, 185);
            this.Wal_4_W.Name = "Wal_4_W";
            this.Wal_4_W.ReadOnly = true;
            this.Wal_4_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_4_W.TabIndex = 8;
            this.Wal_4_W.Text = "-";
            this.Wal_4_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_5_S
            // 
            this.Wal_5_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_5_S.Location = new System.Drawing.Point(16, 217);
            this.Wal_5_S.MaxLength = 3;
            this.Wal_5_S.Name = "Wal_5_S";
            this.Wal_5_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_5_S.TabIndex = 3;
            this.Wal_5_S.Text = "JPY";
            this.Wal_5_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_5_S.TextChanged += new System.EventHandler(this.Wal_5_S_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(87, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "-";
            // 
            // Wal_5_W
            // 
            this.Wal_5_W.Enabled = false;
            this.Wal_5_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_5_W.Location = new System.Drawing.Point(124, 217);
            this.Wal_5_W.Name = "Wal_5_W";
            this.Wal_5_W.ReadOnly = true;
            this.Wal_5_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_5_W.TabIndex = 5;
            this.Wal_5_W.Text = "-";
            this.Wal_5_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_6_S
            // 
            this.Wal_6_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_6_S.Location = new System.Drawing.Point(16, 249);
            this.Wal_6_S.MaxLength = 3;
            this.Wal_6_S.Name = "Wal_6_S";
            this.Wal_6_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_6_S.TabIndex = 6;
            this.Wal_6_S.Text = "CZK";
            this.Wal_6_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_6_S.TextChanged += new System.EventHandler(this.Wal_6_S_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(87, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "-";
            // 
            // Wal_6_W
            // 
            this.Wal_6_W.Enabled = false;
            this.Wal_6_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_6_W.Location = new System.Drawing.Point(124, 249);
            this.Wal_6_W.Name = "Wal_6_W";
            this.Wal_6_W.ReadOnly = true;
            this.Wal_6_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_6_W.TabIndex = 8;
            this.Wal_6_W.Text = "-";
            this.Wal_6_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_7_S
            // 
            this.Wal_7_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_7_S.Location = new System.Drawing.Point(16, 281);
            this.Wal_7_S.MaxLength = 3;
            this.Wal_7_S.Name = "Wal_7_S";
            this.Wal_7_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_7_S.TabIndex = 3;
            this.Wal_7_S.Text = "BTC";
            this.Wal_7_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_7_S.TextChanged += new System.EventHandler(this.Wal_7_S_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(87, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 34);
            this.label9.TabIndex = 4;
            this.label9.Text = "-";
            // 
            // Wal_7_W
            // 
            this.Wal_7_W.Enabled = false;
            this.Wal_7_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_7_W.Location = new System.Drawing.Point(124, 281);
            this.Wal_7_W.Name = "Wal_7_W";
            this.Wal_7_W.ReadOnly = true;
            this.Wal_7_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_7_W.TabIndex = 5;
            this.Wal_7_W.Text = "-";
            this.Wal_7_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_8_S
            // 
            this.Wal_8_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_8_S.Location = new System.Drawing.Point(16, 313);
            this.Wal_8_S.MaxLength = 3;
            this.Wal_8_S.Name = "Wal_8_S";
            this.Wal_8_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_8_S.TabIndex = 6;
            this.Wal_8_S.Text = "HRK";
            this.Wal_8_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_8_S.TextChanged += new System.EventHandler(this.Wal_8_S_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(87, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 34);
            this.label10.TabIndex = 7;
            this.label10.Text = "-";
            // 
            // Wal_8_W
            // 
            this.Wal_8_W.Enabled = false;
            this.Wal_8_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_8_W.Location = new System.Drawing.Point(124, 313);
            this.Wal_8_W.Name = "Wal_8_W";
            this.Wal_8_W.ReadOnly = true;
            this.Wal_8_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_8_W.TabIndex = 8;
            this.Wal_8_W.Text = "-";
            this.Wal_8_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_9_S
            // 
            this.Wal_9_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_9_S.Location = new System.Drawing.Point(16, 345);
            this.Wal_9_S.MaxLength = 3;
            this.Wal_9_S.Name = "Wal_9_S";
            this.Wal_9_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_9_S.TabIndex = 3;
            this.Wal_9_S.Text = "NOK";
            this.Wal_9_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_9_S.TextChanged += new System.EventHandler(this.Wal_9_S_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(87, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 34);
            this.label11.TabIndex = 4;
            this.label11.Text = "-";
            // 
            // Wal_9_W
            // 
            this.Wal_9_W.Enabled = false;
            this.Wal_9_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_9_W.Location = new System.Drawing.Point(124, 345);
            this.Wal_9_W.Name = "Wal_9_W";
            this.Wal_9_W.ReadOnly = true;
            this.Wal_9_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_9_W.TabIndex = 5;
            this.Wal_9_W.Text = "-";
            this.Wal_9_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wal_10_S
            // 
            this.Wal_10_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_10_S.Location = new System.Drawing.Point(16, 377);
            this.Wal_10_S.MaxLength = 3;
            this.Wal_10_S.Name = "Wal_10_S";
            this.Wal_10_S.Size = new System.Drawing.Size(66, 26);
            this.Wal_10_S.TabIndex = 6;
            this.Wal_10_S.Text = "TRY";
            this.Wal_10_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wal_10_S.TextChanged += new System.EventHandler(this.Wal_10_S_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("EFN MacMenuTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(87, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 34);
            this.label12.TabIndex = 7;
            this.label12.Text = "-";
            // 
            // Wal_10_W
            // 
            this.Wal_10_W.Enabled = false;
            this.Wal_10_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wal_10_W.Location = new System.Drawing.Point(124, 377);
            this.Wal_10_W.Name = "Wal_10_W";
            this.Wal_10_W.ReadOnly = true;
            this.Wal_10_W.Size = new System.Drawing.Size(146, 26);
            this.Wal_10_W.TabIndex = 8;
            this.Wal_10_W.Text = "-";
            this.Wal_10_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Przycisk
            // 
            this.Przycisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Przycisk.BackgroundImage = global::GUI.Properties.Resources.kantor;
            this.Przycisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Przycisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Przycisk.Location = new System.Drawing.Point(333, 14);
            this.Przycisk.Name = "Przycisk";
            this.Przycisk.Size = new System.Drawing.Size(392, 391);
            this.Przycisk.TabIndex = 9;
            this.Przycisk.UseVisualStyleBackColor = false;
            this.Przycisk.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(758, 448);
            this.Controls.Add(this.Przycisk);
            this.Controls.Add(this.Wal_10_W);
            this.Controls.Add(this.Wal_8_W);
            this.Controls.Add(this.Wal_6_W);
            this.Controls.Add(this.Wal_4_W);
            this.Controls.Add(this.Wal_2_W);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wal_10_S);
            this.Controls.Add(this.Wal_8_S);
            this.Controls.Add(this.Wal_6_S);
            this.Controls.Add(this.Wal_4_S);
            this.Controls.Add(this.Wal_9_W);
            this.Controls.Add(this.Wal_7_W);
            this.Controls.Add(this.Wal_5_W);
            this.Controls.Add(this.Wal_3_W);
            this.Controls.Add(this.Wal_2_S);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Wal_1_W);
            this.Controls.Add(this.Wal_9_S);
            this.Controls.Add(this.Wal_7_S);
            this.Controls.Add(this.Wal_5_S);
            this.Controls.Add(this.Wal_3_S);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wal_1_S);
            this.Controls.Add(this.Wal_Baz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Konwerter Walut free no scam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Wal_Baz;
        private System.Windows.Forms.TextBox Wal_1_S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Wal_1_W;
        private System.Windows.Forms.TextBox Wal_2_W;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Wal_2_S;
        private System.Windows.Forms.TextBox Wal_3_S;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Wal_3_W;
        private System.Windows.Forms.TextBox Wal_4_S;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Wal_4_W;
        private System.Windows.Forms.TextBox Wal_5_S;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Wal_5_W;
        private System.Windows.Forms.TextBox Wal_6_S;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Wal_6_W;
        private System.Windows.Forms.TextBox Wal_7_S;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Wal_7_W;
        private System.Windows.Forms.TextBox Wal_8_S;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Wal_8_W;
        private System.Windows.Forms.TextBox Wal_9_S;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Wal_9_W;
        private System.Windows.Forms.TextBox Wal_10_S;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Wal_10_W;
        private System.Windows.Forms.Button Przycisk;
    }
}

