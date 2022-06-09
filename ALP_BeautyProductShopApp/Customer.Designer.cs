
namespace ALP_BeautyProductShopApp
{
    partial class Customer
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.cBox_City = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.dTP_dob = new System.Windows.Forms.DateTimePicker();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.tBox_Address = new System.Windows.Forms.TextBox();
            this.tBox_CustName = new System.Windows.Forms.TextBox();
            this.dTP_memberjoin = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tBox_memberID = new System.Windows.Forms.TextBox();
            this.tBox_CustID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Search.Location = new System.Drawing.Point(761, 283);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 29);
            this.btn_Search.TabIndex = 174;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tBox_Search
            // 
            this.tBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Search.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Search.Location = new System.Drawing.Point(27, 286);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(590, 23);
            this.tBox_Search.TabIndex = 173;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(24, 324);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customer.Size = new System.Drawing.Size(845, 264);
            this.dgv_Customer.TabIndex = 172;
            this.dgv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellClick);
            this.dgv_Customer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellEnter);
            // 
            // cBox_City
            // 
            this.cBox_City.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.cBox_City.FormattingEnabled = true;
            this.cBox_City.Items.AddRange(new object[] {
            "Kabupaten Aceh Barat",
            "Kabupaten Aceh Barat Daya",
            "Kabupaten Aceh Besar",
            "Kabupaten Aceh Jaya",
            "Kabupaten Aceh Selatan",
            "Kabupaten Aceh Singkil",
            "Kabupaten Aceh Tamiang",
            "Kabupaten Aceh Tengah",
            "Kabupaten Aceh Tenggara",
            "Kabupaten Aceh Timur",
            "Kabupaten Aceh Utara",
            "Kabupaten Bener Meriah",
            "Kabupaten Bireuen",
            "Kabupaten Gayo Lues",
            "Kabupaten Nagan Raya",
            "Kabupaten Pidie",
            "Kabupaten Pidie Jaya",
            "Kabupaten Simeulue",
            "Kota Banda Aceh",
            "Kota Langsa",
            "Kota Lhokseumawe",
            "Kota Sabang",
            "Kota Subulussalam",
            "Kabupaten Asahan",
            "Kabupaten Batubara",
            "Kabupaten Dairi",
            "Kabupaten Deli Serdang",
            "Kabupaten Humbang Hasundutan",
            "Kabupaten Karo",
            "Kabupaten Labuhanbatu",
            "Kabupaten Labuhanbatu Selatan",
            "Kabupaten Labuhanbatu Utara",
            "Kabupaten Langkat",
            "Kabupaten Mandailing Natal",
            "Kabupaten Nias",
            "Kabupaten Nias Barat",
            "Kabupaten Nias Selatan",
            "Kabupaten Nias Utara",
            "Kabupaten Padang Lawas",
            "Kabupaten Padang Lawas Utara",
            "Kabupaten Pakpak Bharat",
            "Kabupaten Samosir",
            "Kabupaten Serdang Bedagai",
            "Kabupaten Simalungun",
            "Kabupaten Tapanuli Selatan",
            "Kabupaten Tapanuli Tengah",
            "Kabupaten Tapanuli Utara",
            "Kabupaten Toba Samosir",
            "Kota Binjai",
            "Kota Gunungsitoli",
            "Kota Medan",
            "Kota Padangsidempuan",
            "Kota Pematangsiantar",
            "Kota Sibolga",
            "Kota Tanjungbalai",
            "Kota Tebing Tinggi",
            "Kabupaten Agam",
            "Kabupaten Dharmasraya",
            "Kabupaten Kepulauan Mentawai",
            "Kabupaten Lima Puluh Kota",
            "Kabupaten Padang Pariaman",
            "Kabupaten Pasaman",
            "Kabupaten Pasaman Barat",
            "Kabupaten Pesisir Selatan",
            "Kabupaten Sijunjung",
            "Kabupaten Solok",
            "Kabupaten Solok Selatan",
            "Kabupaten Tanah Datar",
            "Kota Bukittinggi",
            "Kota Padang",
            "Kota Padangpanjang",
            "Kota Pariaman",
            "Kota Payakumbuh",
            "Kota Sawahlunto",
            "Kota Solok",
            "Kabupaten Banyuasin",
            "Kabupaten Empat Lawang",
            "Kabupaten Lahat",
            "Kabupaten Muara Enim",
            "Kabupaten Musi Banyuasin",
            "Kabupaten Musi Rawas",
            "Kabupaten Musi Rawas Utara",
            "Kabupaten Ogan Ilir",
            "Kabupaten Ogan Komering Ilir",
            "Kabupaten Ogan Komering Ulu",
            "Kabupaten Ogan Komering Ulu Selatan",
            "Kabupaten Ogan Komering Ulu Timur",
            "Kabupaten Penukal Abab Lematang Ilir",
            "Kota Lubuklinggau",
            "Kota Pagar Alam",
            "Kota Palembang",
            "Kota Prabumulih",
            "Kabupaten Bengkalis",
            "Kabupaten Indragiri Hilir",
            "Kabupaten Indragiri Hulu",
            "Kabupaten Kampar",
            "Kabupaten Kepulauan Meranti",
            "Kabupaten Kuantan Singingi",
            "Kabupaten Pelalawan",
            "Kabupaten Rokan Hilir",
            "Kabupaten Rokan Hulu",
            "Kabupaten Siak",
            "Kota Dumai",
            "Kota Pekanbaru",
            "Kabupaten Bintan",
            "Kabupaten Karimun",
            "Kabupaten Kepulauan Anambas",
            "Kabupaten Lingga",
            "Kabupaten Natuna",
            "Kota Batam",
            "Kota Tanjung Pinang",
            "Kabupaten Batanghari",
            "Kabupaten Bungo",
            "Kabupaten Kerinci",
            "Kabupaten Merangin",
            "Kabupaten Muaro Jambi",
            "Kabupaten Sarolangun",
            "Kabupaten Tanjung Jabung Barat",
            "Kabupaten Tanjung Jabung Timur",
            "Kabupaten Tebo",
            "Kota Jambi",
            "Kota Sungai Penuh",
            "Kabupaten Bengkulu Selatan",
            "Kabupaten Bengkulu Tengah",
            "Kabupaten Bengkulu Utara",
            "Kabupaten Kaur",
            "Kabupaten Kepahiang",
            "Kabupaten Lebong",
            "Kabupaten Mukomuko",
            "Kabupaten Rejang Lebong",
            "Kabupaten Seluma",
            "Kota Bengkulu",
            "Kabupaten Bangka",
            "Kabupaten Bangka Barat",
            "Kabupaten Bangka Selatan",
            "Kabupaten Bangka Tengah",
            "Kabupaten Belitung",
            "Kabupaten Belitung Timur",
            "Kota Pangkal Pinang",
            "Kabupaten Lampung Tengah",
            "Kabupaten Lampung Utara",
            "Kabupaten Lampung Selatan",
            "Kabupaten Lampung Barat",
            "Kabupaten Lampung Timur",
            "Kabupaten Mesuji",
            "Kabupaten Pesawaran",
            "Kabupaten Pesisir Barat",
            "Kabupaten Pringsewu",
            "Kabupaten Tulang Bawang",
            "Kabupaten Tulang Bawang Barat",
            "Kabupaten Tanggamus",
            "Kabupaten Way Kanan",
            "Kota Bandar Lampung",
            "Kota Metro",
            "Kabupaten Lebak",
            "Kabupaten Pandeglang",
            "Kabupaten Serang",
            "Kabupaten Tangerang",
            "Kota Cilegon",
            "Kota Serang",
            "Kota Tangerang",
            "Kota Tangerang Selatan",
            "Kabupaten Bandung",
            "Kabupaten Bandung Barat",
            "Kabupaten Bekasi",
            "Kabupaten Bogor",
            "Kabupaten Ciamis",
            "Kabupaten Cianjur",
            "Kabupaten Cirebon",
            "Kabupaten Garut",
            "Kabupaten Indramayu",
            "Kabupaten Karawang",
            "Kabupaten Kuningan",
            "Kabupaten Majalengka",
            "Kabupaten Pangandaran",
            "Kabupaten Purwakarta",
            "Kabupaten Subang",
            "Kabupaten Sukabumi",
            "Kabupaten Sumedang",
            "Kabupaten Tasikmalaya",
            "Kota Bandung",
            "Kota Banjar",
            "Kota Bekasi",
            "Kota Bogor",
            "Kota Cimahi",
            "Kota Cirebon",
            "Kota Depok",
            "Kota Sukabumi",
            "Kota Tasikmalaya",
            "Kabupaten Banjarnegara",
            "Kabupaten Banyumas",
            "Kabupaten Batang",
            "Kabupaten Blora",
            "Kabupaten Boyolali",
            "Kabupaten Brebes",
            "Kabupaten Cilacap",
            "Kabupaten Demak",
            "Kabupaten Grobogan",
            "Kabupaten Jepara",
            "Kabupaten Karanganyar",
            "Kabupaten Kebumen",
            "Kabupaten Kendal",
            "Kabupaten Klaten",
            "Kabupaten Kudus",
            "Kabupaten Magelang",
            "Kabupaten Pati",
            "Kabupaten Pekalongan",
            "Kabupaten Pemalang",
            "Kabupaten Purbalingga",
            "Kabupaten Purworejo",
            "Kabupaten Rembang",
            "Kabupaten Semarang",
            "Kabupaten Sragen",
            "Kabupaten Sukoharjo",
            "Kabupaten Tegal",
            "Kabupaten Temanggung",
            "Kabupaten Wonogiri",
            "Kabupaten Wonosobo",
            "Kota Magelang",
            "Kota Pekalongan",
            "Kota Salatiga",
            "Kota Semarang",
            "Kota Surakarta",
            "Kota Tegal",
            "Kabupaten Bangkalan",
            "Kabupaten Banyuwangi",
            "Kabupaten Blitar",
            "Kabupaten Bojonegoro",
            "Kabupaten Bondowoso",
            "Kabupaten Gresik",
            "Kabupaten Jember",
            "Kabupaten Jombang",
            "Kabupaten Kediri",
            "Kabupaten Lamongan",
            "Kabupaten Lumajang",
            "Kabupaten Madiun",
            "Kabupaten Magetan",
            "Kabupaten Malang",
            "Kabupaten Mojokerto",
            "Kabupaten Nganjuk",
            "Kabupaten Ngawi",
            "Kabupaten Pacitan",
            "Kabupaten Pamekasan",
            "Kabupaten Pasuruan",
            "Kabupaten Ponorogo",
            "Kabupaten Probolinggo",
            "Kabupaten Sampang",
            "Kabupaten Sidoarjo",
            "Kabupaten Situbondo",
            "Kabupaten Sumenep",
            "Kabupaten Trenggalek",
            "Kabupaten Tuban",
            "Kabupaten Tulungagung",
            "Kota Batu",
            "Kota Blitar",
            "Kota Kediri",
            "Kota Madiun",
            "Kota Malang",
            "Kota Mojokerto",
            "Kota Pasuruan",
            "Kota Probolinggo",
            "Kota Surabaya",
            "Kota Administrasi Jakarta Barat",
            "Kota Administrasi Jakarta Pusat",
            "Kota Administrasi Jakarta Selatan",
            "Kota Administrasi Jakarta Timur",
            "Kota Administrasi Jakarta Utara",
            "Kabupaten Administrasi Kepulauan Seribu",
            "Kabupaten Bantul",
            "Kabupaten Gunungkidul",
            "Kabupaten Kulon Progo",
            "Kabupaten Sleman",
            "Kota Yogyakarta",
            "Kabupaten Badung",
            "Kabupaten Bangli",
            "Kabupaten Buleleng",
            "Kabupaten Gianyar",
            "Kabupaten Jembrana",
            "Kabupaten Karangasem",
            "Kabupaten Klungkung",
            "Kabupaten Tabanan",
            "Kota Denpasar",
            "Kabupaten Bima",
            "Kabupaten Dompu",
            "Kabupaten Lombok Barat",
            "Kabupaten Lombok Tengah",
            "Kabupaten Lombok Timur",
            "Kabupaten Lombok Utara",
            "Kabupaten Sumbawa",
            "Kabupaten Sumbawa Barat",
            "Kota Bima",
            "Kota Mataram",
            "Kabupaten Alor",
            "Kabupaten Belu",
            "Kabupaten Ende",
            "Kabupaten Flores Timur",
            "Kabupaten Kupang",
            "Kabupaten Lembata",
            "Kabupaten Malaka",
            "Kabupaten Manggarai",
            "Kabupaten Manggarai Barat",
            "Kabupaten Manggarai Timur",
            "Kabupaten Ngada",
            "Kabupaten Nagekeo",
            "Kabupaten Rote Ndao",
            "Kabupaten Sabu Raijua",
            "Kabupaten Sikka",
            "Kabupaten Sumba Barat",
            "Kabupaten Sumba Barat Daya",
            "Kabupaten Sumba Tengah",
            "Kabupaten Sumba Timur",
            "Kabupaten Timor Tengah Selatan",
            "Kabupaten Timor Tengah Utara",
            "Kota Kupang",
            "Kabupaten Bengkayang",
            "Kabupaten Kapuas Hulu",
            "Kabupaten Kayong Utara",
            "Kabupaten Ketapang",
            "Kabupaten Kubu Raya",
            "Kabupaten Landak",
            "Kabupaten Melawi",
            "Kabupaten Mempawah",
            "Kabupaten Sambas",
            "Kabupaten Sanggau",
            "Kabupaten Sekadau",
            "Kabupaten Sintang",
            "Kota Pontianak",
            "Kota Singkawang",
            "Kabupaten Balangan",
            "Kabupaten Banjar",
            "Kabupaten Barito Kuala",
            "Kabupaten Hulu Sungai Selatan",
            "Kabupaten Hulu Sungai Tengah",
            "Kabupaten Hulu Sungai Utara",
            "Kabupaten Kotabaru",
            "Kabupaten Tabalong",
            "Kabupaten Tanah Bumbu",
            "Kabupaten Tanah Laut",
            "Kabupaten Tapin",
            "Kota Banjarbaru",
            "Kota Banjarmasin",
            "Kabupaten Barito Selatan",
            "Kabupaten Barito Timur",
            "Kabupaten Barito Utara",
            "Kabupaten Gunung Mas",
            "Kabupaten Kapuas",
            "Kabupaten Katingan",
            "Kabupaten Kotawaringin Barat",
            "Kabupaten Kotawaringin Timur",
            "Kabupaten Lamandau",
            "Kabupaten Murung Raya",
            "Kabupaten Pulang Pisau",
            "Kabupaten Sukamara",
            "Kabupaten Seruyan",
            "Kota Palangka Raya",
            "Kabupaten Berau",
            "Kabupaten Kutai Barat",
            "Kabupaten Kutai Kartanegara",
            "Kabupaten Kutai Timur",
            "Kabupaten Mahakam Ulu",
            "Kabupaten Paser",
            "Kabupaten Penajam Paser Utara",
            "Kota Balikpapan",
            "Kota Bontang",
            "Kota Samarinda",
            "Kabupaten Bulungan",
            "Kabupaten Malinau",
            "Kabupaten Nunukan",
            "Kabupaten Tana Tidung",
            "Kota Tarakan",
            "Kabupaten Boalemo",
            "Kabupaten Bone Bolango",
            "Kabupaten Gorontalo",
            "Kabupaten Gorontalo Utara",
            "Kabupaten Pohuwato",
            "Kota Gorontalo",
            "Kabupaten Bantaeng",
            "Kabupaten Barru",
            "Kabupaten Bone",
            "Kabupaten Bulukumba",
            "Kabupaten Enrekang",
            "Kabupaten Gowa",
            "Kabupaten Jeneponto",
            "Kabupaten Kepulauan Selayar",
            "Kabupaten Luwu",
            "Kabupaten Luwu Timur",
            "Kabupaten Luwu Utara",
            "Kabupaten Maros",
            "Kabupaten Pangkajene dan Kepulauan",
            "Kabupaten Pinrang",
            "Kabupaten Sidenreng Rappang",
            "Kabupaten Sinjai",
            "Kabupaten Soppeng",
            "Kabupaten Takalar",
            "Kabupaten Tana Toraja",
            "Kabupaten Toraja Utara",
            "Kabupaten Wajo",
            "Kota Makassar",
            "Kota Palopo",
            "Kota Parepare",
            "Kabupaten Bombana",
            "Kabupaten Buton",
            "Kabupaten Buton Selatan",
            "Kabupaten Buton Tengah",
            "Kabupaten Buton Utara",
            "Kabupaten Kolaka",
            "Kabupaten Kolaka Timur",
            "Kabupaten Kolaka Utara",
            "Kabupaten Konawe",
            "Kabupaten Konawe Kepulauan",
            "Kabupaten Konawe Selatan",
            "Kabupaten Konawe Utara",
            "Kabupaten Muna",
            "Kabupaten Muna Barat",
            "Kabupaten Wakatobi",
            "Kota Bau-Bau",
            "Kota Kendari",
            "Kabupaten Banggai",
            "Kabupaten Banggai Kepulauan",
            "Kabupaten Banggai Laut",
            "Kabupaten Buol",
            "Kabupaten Donggala",
            "Kabupaten Morowali",
            "Kabupaten Morowali Utara",
            "Kabupaten Parigi Moutong",
            "Kabupaten Poso",
            "Kabupaten Sigi",
            "Kabupaten Tojo Una-Una",
            "Kabupaten Toli-Toli",
            "Kota Palu",
            "Kabupaten Bolaang Mongondow",
            "Kabupaten Bolaang Mongondow Selatan",
            "Kabupaten Bolaang Mongondow Timur",
            "Kabupaten Bolaang Mongondow Utara",
            "Kabupaten Kepulauan Sangihe",
            "Kabupaten Kepulauan Siau Tagulandang Biaro",
            "Kabupaten Kepulauan Talaud",
            "Kabupaten Minahasa",
            "Kabupaten Minahasa Selatan",
            "Kabupaten Minahasa Tenggara",
            "Kabupaten Minahasa Utara",
            "Kota Bitung",
            "Kota Kotamobagu",
            "Kota Manado",
            "Kota Tomohon",
            "Kabupaten Majene",
            "Kabupaten Mamasa",
            "Kabupaten Mamuju",
            "Kabupaten Mamuju Tengah",
            "Kabupaten Mamuju Utara",
            "Kabupaten Polewali Mandar",
            "Kota Mamuju",
            "Kabupaten Buru",
            "Kabupaten Buru Selatan",
            "Kabupaten Kepulauan Aru",
            "Kabupaten Maluku Barat Daya",
            "Kabupaten Maluku Tengah",
            "Kabupaten Maluku Tenggara",
            "Kabupaten Maluku Tenggara Barat",
            "Kabupaten Seram Bagian Barat",
            "Kabupaten Seram Bagian Timur",
            "Kota Ambon",
            "Kota Tual",
            "Kabupaten Halmahera Barat",
            "Kabupaten Halmahera Tengah",
            "Kabupaten Halmahera Utara",
            "Kabupaten Halmahera Selatan",
            "Kabupaten Kepulauan Sula",
            "Kabupaten Halmahera Timur",
            "Kabupaten Pulau Morotai",
            "Kabupaten Pulau Taliabu",
            "Kota Ternate",
            "Kota Tidore Kepulauan",
            "Kabupaten Asmat",
            "Kabupaten Biak Numfor",
            "Kabupaten Boven Digoel",
            "Kabupaten Deiyai",
            "Kabupaten Dogiyai",
            "Kabupaten Intan Jaya",
            "Kabupaten Jayapura",
            "Kabupaten Jayawijaya",
            "Kabupaten Keerom",
            "Kabupaten Kepulauan Yapen",
            "Kabupaten Lanny Jaya",
            "Kabupaten Mamberamo Raya",
            "Kabupaten Mamberamo Tengah",
            "Kabupaten Mappi",
            "Kabupaten Merauke",
            "Kabupaten Mimika",
            "Kabupaten Nabire",
            "Kabupaten Nduga",
            "Kabupaten Paniai",
            "Kabupaten Pegunungan Bintang",
            "Kabupaten Puncak",
            "Kabupaten Puncak Jaya",
            "Kabupaten Sarmi",
            "Kabupaten Supiori",
            "Kabupaten Tolikara",
            "Kabupaten Waropen",
            "Kabupaten Yahukimo",
            "Kabupaten Yalimo",
            "Kota Jayapura",
            "Kabupaten Fakfak",
            "Kabupaten Kaimana",
            "Kabupaten Manokwari",
            "Kabupaten Manokwari Selatan",
            "Kabupaten Maybrat",
            "Kabupaten Pegunungan Arfak",
            "Kabupaten Raja Ampat",
            "Kabupaten Sorong",
            "Kabupaten Sorong Selatan",
            "Kabupaten Tambrauw",
            "Kabupaten Teluk Bintuni",
            "Kabupaten Teluk Wondama"});
            this.cBox_City.Location = new System.Drawing.Point(155, 160);
            this.cBox_City.Name = "cBox_City";
            this.cBox_City.Size = new System.Drawing.Size(242, 25);
            this.cBox_City.TabIndex = 197;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label6.Location = new System.Drawing.Point(29, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 196;
            this.label6.Text = "City";
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.LightCoral;
            this.btn_View.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_View.Location = new System.Drawing.Point(289, 251);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(111, 29);
            this.btn_View.TabIndex = 195;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // dTP_dob
            // 
            this.dTP_dob.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.dTP_dob.Location = new System.Drawing.Point(530, 207);
            this.dTP_dob.Name = "dTP_dob";
            this.dTP_dob.Size = new System.Drawing.Size(211, 23);
            this.dTP_dob.TabIndex = 194;
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Phone.Location = new System.Drawing.Point(530, 157);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(211, 23);
            this.tBox_Phone.TabIndex = 192;
            // 
            // tBox_Address
            // 
            this.tBox_Address.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Address.Location = new System.Drawing.Point(530, 115);
            this.tBox_Address.Name = "tBox_Address";
            this.tBox_Address.Size = new System.Drawing.Size(342, 23);
            this.tBox_Address.TabIndex = 191;
            // 
            // tBox_CustName
            // 
            this.tBox_CustName.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_CustName.Location = new System.Drawing.Point(155, 115);
            this.tBox_CustName.Name = "tBox_CustName";
            this.tBox_CustName.Size = new System.Drawing.Size(242, 23);
            this.tBox_CustName.TabIndex = 190;
            // 
            // dTP_memberjoin
            // 
            this.dTP_memberjoin.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.dTP_memberjoin.Location = new System.Drawing.Point(661, 68);
            this.dTP_memberjoin.Name = "dTP_memberjoin";
            this.dTP_memberjoin.Size = new System.Drawing.Size(211, 23);
            this.dTP_memberjoin.TabIndex = 189;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Delete.Location = new System.Drawing.Point(418, 251);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(111, 29);
            this.btn_Delete.TabIndex = 188;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Update.Location = new System.Drawing.Point(160, 251);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(111, 29);
            this.btn_Update.TabIndex = 187;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Save.Location = new System.Drawing.Point(27, 251);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 29);
            this.btn_Save.TabIndex = 186;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tBox_memberID
            // 
            this.tBox_memberID.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_memberID.Location = new System.Drawing.Point(403, 68);
            this.tBox_memberID.Name = "tBox_memberID";
            this.tBox_memberID.Size = new System.Drawing.Size(89, 23);
            this.tBox_memberID.TabIndex = 185;
            // 
            // tBox_CustID
            // 
            this.tBox_CustID.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_CustID.Location = new System.Drawing.Point(155, 68);
            this.tBox_CustID.Name = "tBox_CustID";
            this.tBox_CustID.Size = new System.Drawing.Size(89, 23);
            this.tBox_CustID.TabIndex = 184;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label9.Location = new System.Drawing.Point(425, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 182;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label8.Location = new System.Drawing.Point(425, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 181;
            this.label8.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label5.Location = new System.Drawing.Point(425, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 179;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 178;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label3.Location = new System.Drawing.Point(522, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 177;
            this.label3.Text = "Membership Join";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label2.Location = new System.Drawing.Point(266, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 176;
            this.label2.Text = "Membership ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 175;
            this.label1.Text = "Customer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label7.Location = new System.Drawing.Point(29, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 180;
            this.label7.Text = "Email";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Email.Location = new System.Drawing.Point(155, 201);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(242, 23);
            this.tBox_Email.TabIndex = 193;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(33, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 1);
            this.panel1.TabIndex = 199;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 23);
            this.lblTitle.TabIndex = 198;
            this.lblTitle.Text = "Customer List";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightCoral;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_clear.Location = new System.Drawing.Point(767, 207);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 29);
            this.btn_clear.TabIndex = 200;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.LightCoral;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_refresh.Location = new System.Drawing.Point(630, 283);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(111, 29);
            this.btn_refresh.TabIndex = 201;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cBox_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.dTP_dob);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.tBox_Address);
            this.Controls.Add(this.tBox_CustName);
            this.Controls.Add(this.dTP_memberjoin);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tBox_memberID);
            this.Controls.Add(this.tBox_CustID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tBox_Search);
            this.Controls.Add(this.dgv_Customer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.ComboBox cBox_City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.DateTimePicker dTP_dob;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.TextBox tBox_Address;
        private System.Windows.Forms.TextBox tBox_CustName;
        private System.Windows.Forms.DateTimePicker dTP_memberjoin;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tBox_memberID;
        private System.Windows.Forms.TextBox tBox_CustID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBox_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_refresh;
    }
}