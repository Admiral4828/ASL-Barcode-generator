
namespace Test
{
    partial class Barkod
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtOlkeKodu = new System.Windows.Forms.TextBox();
            this.txtBarKod = new System.Windows.Forms.TextBox();
            this.txtIstehsalciKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOlkeler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Barkod (EAN13) Hazirla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOlkeKodu
            // 
            this.txtOlkeKodu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOlkeKodu.Location = new System.Drawing.Point(146, 13);
            this.txtOlkeKodu.Name = "txtOlkeKodu";
            this.txtOlkeKodu.ReadOnly = true;
            this.txtOlkeKodu.Size = new System.Drawing.Size(91, 26);
            this.txtOlkeKodu.TabIndex = 22;
            // 
            // txtBarKod
            // 
            this.txtBarKod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarKod.Location = new System.Drawing.Point(146, 78);
            this.txtBarKod.Name = "txtBarKod";
            this.txtBarKod.ReadOnly = true;
            this.txtBarKod.Size = new System.Drawing.Size(328, 26);
            this.txtBarKod.TabIndex = 21;
            // 
            // txtIstehsalciKodu
            // 
            this.txtIstehsalciKodu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIstehsalciKodu.Location = new System.Drawing.Point(146, 46);
            this.txtIstehsalciKodu.MaxLength = 4;
            this.txtIstehsalciKodu.Name = "txtIstehsalciKodu";
            this.txtIstehsalciKodu.Size = new System.Drawing.Size(328, 26);
            this.txtIstehsalciKodu.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "İhtehsalçı kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ölke kodu";
            // 
            // cmbOlkeler
            // 
            this.cmbOlkeler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOlkeler.FormattingEnabled = true;
            this.cmbOlkeler.Items.AddRange(new object[] {
            "000 ABŞ",
            "139 ABŞ",
            "200 Daxili nömrələmə",
            "299 Daxili nömrələmə",
            "300 Fransa",
            "379 Fransa",
            "380 Bolqarıstan",
            "383 Sloveniya",
            "385 Xorvatiya",
            "387 Bosniya və Herseqovina",
            "400 Almaniya",
            "440 Almaniya",
            "450 Yaponiya",
            "459 Yaponiya",
            "490 Yaponiya",
            "499 Yaponiya",
            "460 Rusiya",
            "469 Rusiya",
            "470 Qırğızıstan",
            "471 Tayvan",
            "474 Estoniya",
            "475 Latviya",
            "476 Azərbaycan",
            "477 Litva",
            "478 Özbəkistan",
            "479 Şri Lanka",
            "480 Filippin",
            "481 Belarus",
            "482 Ukrayna",
            "484 Moldova",
            "485 Ermənistan",
            "486 Gürcüstan",
            "487 Qazaxıstan",
            "489 Hong Kong",
            "500-509 Böyük Britaniya",
            "518 Fil dişi Sahili",
            "520 Yunanıstan",
            "528 Livan",
            "529 Kipr",
            "530 Albaniya",
            "531 Makedoniya",
            "535 Malta",
            "539 İrlandiya",
            "540-549 Belçika, Lüksemburq",
            "560 Portuqaliya",
            "569 İslandiya",
            "570-579 Danimarka",
            "590 Polşa",
            "594 Rumıniya",
            "599 Macarıstan",
            "600-601 Cənubi Afrika",
            "603 Qana",
            "608 Bəhreyn",
            "609 Mavriki",
            "611 Mərakeş",
            "613 Əlcəzair",
            "616 Kenya",
            "619 Tunis",
            "621 Suriya",
            "622 Misir",
            "624 Liviya",
            "625 İordaniya",
            "626 İran",
            "627 Küveyt",
            "628 Səudiyyə Ərəbistanı",
            "629 B.Ə.Ə.",
            "640-649 Finlandiya",
            "690-695 Çin",
            "700-709 Norveç",
            "729 İsrail",
            "730-739 İsveç",
            "740 Qvatemala",
            "741 Salvador",
            "742 Honduras",
            "743 Nikaraqua",
            "744 Kosta Rika",
            "745 Panama",
            "746 Dominik Respublikası",
            "750 Meksika",
            "754 - 755 Kanada",
            "759 Venesuela",
            "760-769 İsveçrə",
            "770 Kolumbiya",
            "773 Uruqvay",
            "775 Peru",
            "777 Boliviya",
            "779 Argentina",
            "780 Çili",
            "784 Paraqvay",
            "786 Ekvador",
            "789-790 Braziliya",
            "800-839 İtaliya",
            "840-849 İspaniya",
            "850 Kuba",
            "858 Slovakiya",
            "859 Çexiya",
            "860 Serbiya və Monteneqro",
            "865 Monqolustan",
            "867 Şimali Koreya",
            "869 Türkiyə",
            "870 Niderland",
            "879 Niderland",
            "880 Cənubi Koreya",
            "884 Kamboca",
            "885 Tayland",
            "888 Sinqapur",
            "890 Hindistan",
            "893 Vyetnam",
            "899 İndoneziya",
            "900 Avstriya",
            "919 Avstriya",
            "930 Avstraliya",
            "939 Avstraliya",
            "940 Yeni Zelandiya",
            "949 Yeni Zelandiya",
            "950 Baş ofis",
            "955 Malayziya",
            "958 Makao",
            "978 Kitablar (ISBN)",
            "979 Kitablar (ISBN)",
            "980 Qaytarılacaq daxilolmalar",
            "981 Valyuta kuponları",
            "982 Valyuta kuponları",
            "990 Kuponla",
            "999 Kuponla"});
            this.cmbOlkeler.Location = new System.Drawing.Point(243, 13);
            this.cmbOlkeler.Name = "cmbOlkeler";
            this.cmbOlkeler.Size = new System.Drawing.Size(231, 27);
            this.cmbOlkeler.TabIndex = 16;
            this.cmbOlkeler.SelectedIndexChanged += new System.EventHandler(this.cmbOlkeler_SelectedIndexChanged);
            // 
            // Barkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOlkeKodu);
            this.Controls.Add(this.txtBarKod);
            this.Controls.Add(this.txtIstehsalciKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOlkeler);
            this.Name = "Barkod";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOlkeKodu;
        private System.Windows.Forms.TextBox txtBarKod;
        private System.Windows.Forms.TextBox txtIstehsalciKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOlkeler;
    }
}

