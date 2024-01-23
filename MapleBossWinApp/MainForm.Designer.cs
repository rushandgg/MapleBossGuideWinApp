﻿namespace MapleBossWinApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            MainTabControl = new System.Windows.Forms.TabControl();
            TabPage1 = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            CharacterLoadButton = new System.Windows.Forms.Button();
            SelectedHeroNumLabel = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            TotalHeroNumLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader12 = new System.Windows.Forms.ColumnHeader();
            columnHeader13 = new System.Windows.Forms.ColumnHeader();
            columnHeader14 = new System.Windows.Forms.ColumnHeader();
            columnHeader15 = new System.Windows.Forms.ColumnHeader();
            columnHeader16 = new System.Windows.Forms.ColumnHeader();
            label8 = new System.Windows.Forms.Label();
            FirstHeroListView = new System.Windows.Forms.ListView();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader10 = new System.Windows.Forms.ColumnHeader();
            columnHeader11 = new System.Windows.Forms.ColumnHeader();
            label7 = new System.Windows.Forms.Label();
            CharacterTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            APIKeyTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            TabPage2 = new System.Windows.Forms.TabPage();
            groupBox4 = new System.Windows.Forms.GroupBox();
            BossListView = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            groupBox3 = new System.Windows.Forms.GroupBox();
            TotalPriceLabel = new System.Windows.Forms.Label();
            SelectedHeroNumLabel2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            DifficultyComboBox = new System.Windows.Forms.ComboBox();
            BossNameComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            HeroTextBox = new System.Windows.Forms.TextBox();
            ListAddBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            HeroListView = new System.Windows.Forms.ListView();
            heroNum = new System.Windows.Forms.ColumnHeader();
            heroName = new System.Windows.Forms.ColumnHeader();
            heroClass = new System.Windows.Forms.ColumnHeader();
            heroLv = new System.Windows.Forms.ColumnHeader();
            heroPower = new System.Windows.Forms.ColumnHeader();
            maxBoss = new System.Windows.Forms.ColumnHeader();
            maxBossDiff = new System.Windows.Forms.ColumnHeader();
            stoneNum = new System.Windows.Forms.ColumnHeader();
            stoneTotalPrice = new System.Windows.Forms.ColumnHeader();
            TabPage3 = new System.Windows.Forms.TabPage();
            StartButton = new System.Windows.Forms.Button();
            ListButton = new System.Windows.Forms.Button();
            ManageButton = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader17 = new System.Windows.Forms.ColumnHeader();
            columnHeader18 = new System.Windows.Forms.ColumnHeader();
            columnHeader19 = new System.Windows.Forms.ColumnHeader();
            columnHeader20 = new System.Windows.Forms.ColumnHeader();
            columnHeader21 = new System.Windows.Forms.ColumnHeader();
            columnHeader22 = new System.Windows.Forms.ColumnHeader();
            columnHeader23 = new System.Windows.Forms.ColumnHeader();
            columnHeader24 = new System.Windows.Forms.ColumnHeader();
            columnHeader25 = new System.Windows.Forms.ColumnHeader();
            columnHeader26 = new System.Windows.Forms.ColumnHeader();
            columnHeader27 = new System.Windows.Forms.ColumnHeader();
            MainTabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            TabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(TabPage1);
            MainTabControl.Controls.Add(TabPage2);
            MainTabControl.Controls.Add(TabPage3);
            MainTabControl.Location = new System.Drawing.Point(190, 0);
            MainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new System.Drawing.Size(1508, 977);
            MainTabControl.TabIndex = 7;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(dataGridView1);
            TabPage1.Controls.Add(CharacterLoadButton);
            TabPage1.Controls.Add(SelectedHeroNumLabel);
            TabPage1.Controls.Add(label12);
            TabPage1.Controls.Add(TotalHeroNumLabel);
            TabPage1.Controls.Add(label9);
            TabPage1.Controls.Add(button2);
            TabPage1.Controls.Add(button1);
            TabPage1.Controls.Add(listView2);
            TabPage1.Controls.Add(label8);
            TabPage1.Controls.Add(FirstHeroListView);
            TabPage1.Controls.Add(label7);
            TabPage1.Controls.Add(CharacterTextBox);
            TabPage1.Controls.Add(label6);
            TabPage1.Controls.Add(APIKeyTextBox);
            TabPage1.Controls.Add(label5);
            TabPage1.Location = new System.Drawing.Point(4, 29);
            TabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabPage1.Size = new System.Drawing.Size(1500, 944);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "tabPage1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new System.Drawing.Point(903, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(371, 101);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            Column2.HeaderText = "Column2";
            Column2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            Column2.MaxDropDownItems = 6;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // CharacterLoadButton
            // 
            CharacterLoadButton.Location = new System.Drawing.Point(321, 79);
            CharacterLoadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CharacterLoadButton.Name = "CharacterLoadButton";
            CharacterLoadButton.Size = new System.Drawing.Size(123, 40);
            CharacterLoadButton.TabIndex = 14;
            CharacterLoadButton.Text = "불러오기";
            CharacterLoadButton.UseVisualStyleBackColor = true;
            // 
            // SelectedHeroNumLabel
            // 
            SelectedHeroNumLabel.AutoSize = true;
            SelectedHeroNumLabel.Location = new System.Drawing.Point(1204, 765);
            SelectedHeroNumLabel.Name = "SelectedHeroNumLabel";
            SelectedHeroNumLabel.Size = new System.Drawing.Size(25, 20);
            SelectedHeroNumLabel.TabIndex = 13;
            SelectedHeroNumLabel.Text = "49";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1113, 765);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(87, 20);
            label12.TabIndex = 12;
            label12.Text = "총 캐릭터 : ";
            // 
            // TotalHeroNumLabel
            // 
            TotalHeroNumLabel.AutoSize = true;
            TotalHeroNumLabel.Location = new System.Drawing.Point(519, 765);
            TotalHeroNumLabel.Name = "TotalHeroNumLabel";
            TotalHeroNumLabel.Size = new System.Drawing.Size(25, 20);
            TotalHeroNumLabel.TabIndex = 11;
            TotalHeroNumLabel.Text = "49";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(428, 765);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 20);
            label9.TabIndex = 10;
            label9.Text = "총 캐릭터 : ";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(577, 481);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(123, 60);
            button2.TabIndex = 9;
            button2.Text = "삭제";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(577, 327);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(123, 60);
            button1.TabIndex = 8;
            button1.Text = "추가";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new System.Drawing.Point(729, 209);
            listView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(505, 536);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "No";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "캐릭터명";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "직업";
            columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "레벨";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "전투력";
            columnHeader16.Width = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(726, 164);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(104, 20);
            label8.TabIndex = 6;
            label8.Text = "보스돌이 목록";
            // 
            // FirstHeroListView
            // 
            FirstHeroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            FirstHeroListView.FullRowSelect = true;
            FirstHeroListView.GridLines = true;
            FirstHeroListView.Location = new System.Drawing.Point(42, 209);
            FirstHeroListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FirstHeroListView.Name = "FirstHeroListView";
            FirstHeroListView.Size = new System.Drawing.Size(505, 536);
            FirstHeroListView.TabIndex = 5;
            FirstHeroListView.UseCompatibleStateImageBehavior = false;
            FirstHeroListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "No";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "캐릭터명";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "직업";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "레벨";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "전투력";
            columnHeader11.Width = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(38, 164);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(124, 20);
            label7.TabIndex = 4;
            label7.Text = "전체 유니온 캐릭";
            // 
            // CharacterTextBox
            // 
            CharacterTextBox.Location = new System.Drawing.Point(156, 83);
            CharacterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CharacterTextBox.Name = "CharacterTextBox";
            CharacterTextBox.Size = new System.Drawing.Size(139, 27);
            CharacterTextBox.TabIndex = 3;
            CharacterTextBox.Text = "신용왕미수";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(38, 91);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 20);
            label6.TabIndex = 2;
            label6.Text = "캐릭터명";
            // 
            // APIKeyTextBox
            // 
            APIKeyTextBox.Location = new System.Drawing.Point(156, 32);
            APIKeyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            APIKeyTextBox.Name = "APIKeyTextBox";
            APIKeyTextBox.Size = new System.Drawing.Size(286, 27);
            APIKeyTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 39);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 20);
            label5.TabIndex = 0;
            label5.Text = "Open API Key";
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(groupBox4);
            TabPage2.Controls.Add(groupBox3);
            TabPage2.Controls.Add(groupBox2);
            TabPage2.Controls.Add(groupBox1);
            TabPage2.Location = new System.Drawing.Point(4, 29);
            TabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabPage2.Size = new System.Drawing.Size(1500, 944);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "tabPage2";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BossListView);
            groupBox4.Location = new System.Drawing.Point(793, 169);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(652, 593);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "캐릭별 보스 목록";
            // 
            // BossListView
            // 
            BossListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            BossListView.GridLines = true;
            BossListView.Location = new System.Drawing.Point(18, 32);
            BossListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BossListView.Name = "BossListView";
            BossListView.Size = new System.Drawing.Size(607, 536);
            BossListView.TabIndex = 0;
            BossListView.UseCompatibleStateImageBehavior = false;
            BossListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "보스명";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "난이도";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "파티수";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "결정석값";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "삭제";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TotalPriceLabel);
            groupBox3.Controls.Add(SelectedHeroNumLabel2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new System.Drawing.Point(793, 28);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(652, 133);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "집계";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Location = new System.Drawing.Point(322, 63);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new System.Drawing.Size(59, 20);
            TotalPriceLabel.TabIndex = 3;
            TotalPriceLabel.Text = "총 수입";
            // 
            // SelectedHeroNumLabel2
            // 
            SelectedHeroNumLabel2.AutoSize = true;
            SelectedHeroNumLabel2.Location = new System.Drawing.Point(123, 63);
            SelectedHeroNumLabel2.Name = "SelectedHeroNumLabel2";
            SelectedHeroNumLabel2.Size = new System.Drawing.Size(59, 20);
            SelectedHeroNumLabel2.TabIndex = 2;
            SelectedHeroNumLabel2.Text = "총 수입";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 20);
            label3.TabIndex = 1;
            label3.Text = "보스돌이 수 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(249, 63);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 0;
            label4.Text = "총 수입 : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(DifficultyComboBox);
            groupBox2.Controls.Add(BossNameComboBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(HeroTextBox);
            groupBox2.Controls.Add(ListAddBtn);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(19, 28);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(767, 133);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "보스 내용기입";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(130, 28);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(286, 27);
            textBox1.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(17, 35);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(104, 20);
            label10.TabIndex = 7;
            label10.Text = "Open API Key";
            // 
            // DifficultyComboBox
            // 
            DifficultyComboBox.FormattingEnabled = true;
            DifficultyComboBox.Location = new System.Drawing.Point(325, 87);
            DifficultyComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DifficultyComboBox.Name = "DifficultyComboBox";
            DifficultyComboBox.Size = new System.Drawing.Size(131, 28);
            DifficultyComboBox.TabIndex = 6;
            DifficultyComboBox.Text = "카오스";
            // 
            // BossNameComboBox
            // 
            BossNameComboBox.FormattingEnabled = true;
            BossNameComboBox.Location = new System.Drawing.Point(187, 87);
            BossNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BossNameComboBox.Name = "BossNameComboBox";
            BossNameComboBox.Size = new System.Drawing.Size(131, 28);
            BossNameComboBox.TabIndex = 5;
            BossNameComboBox.Text = "자쿰";
            BossNameComboBox.SelectedIndexChanged += BossNameComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(183, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "최대보스 / 난이도";
            // 
            // HeroTextBox
            // 
            HeroTextBox.Location = new System.Drawing.Point(17, 87);
            HeroTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HeroTextBox.Name = "HeroTextBox";
            HeroTextBox.Size = new System.Drawing.Size(137, 27);
            HeroTextBox.TabIndex = 2;
            // 
            // ListAddBtn
            // 
            ListAddBtn.Location = new System.Drawing.Point(481, 66);
            ListAddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ListAddBtn.Name = "ListAddBtn";
            ListAddBtn.Size = new System.Drawing.Size(112, 49);
            ListAddBtn.TabIndex = 1;
            ListAddBtn.Text = "추가";
            ListAddBtn.UseVisualStyleBackColor = true;
            ListAddBtn.Click += ListAddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "캐릭터명";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HeroListView);
            groupBox1.Location = new System.Drawing.Point(19, 169);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(767, 593);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "캐릭터 목록";
            // 
            // HeroListView
            // 
            HeroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { heroNum, heroName, heroClass, heroLv, heroPower, maxBoss, maxBossDiff, stoneNum, stoneTotalPrice });
            HeroListView.FullRowSelect = true;
            HeroListView.GridLines = true;
            HeroListView.Location = new System.Drawing.Point(18, 32);
            HeroListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HeroListView.Name = "HeroListView";
            HeroListView.Size = new System.Drawing.Size(742, 536);
            HeroListView.TabIndex = 0;
            HeroListView.UseCompatibleStateImageBehavior = false;
            HeroListView.View = System.Windows.Forms.View.Details;
            HeroListView.SelectedIndexChanged += HeroListView_SelectedIndexChanged;
            // 
            // heroNum
            // 
            heroNum.Text = "No";
            heroNum.Width = 40;
            // 
            // heroName
            // 
            heroName.Text = "캐릭터명";
            heroName.Width = 90;
            // 
            // heroClass
            // 
            heroClass.Text = "직업";
            heroClass.Width = 90;
            // 
            // heroLv
            // 
            heroLv.Text = "레벨";
            // 
            // heroPower
            // 
            heroPower.Text = "전투력";
            // 
            // maxBoss
            // 
            maxBoss.Text = "최대보스";
            maxBoss.Width = 100;
            // 
            // maxBossDiff
            // 
            maxBossDiff.Text = "난이도";
            // 
            // stoneNum
            // 
            stoneNum.Text = "결정석수";
            stoneNum.Width = 70;
            // 
            // stoneTotalPrice
            // 
            stoneTotalPrice.Text = "결정석값";
            stoneTotalPrice.Width = 80;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(listView1);
            TabPage3.Location = new System.Drawing.Point(4, 29);
            TabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabPage3.Size = new System.Drawing.Size(1500, 944);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "tabPage3";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.Location = new System.Drawing.Point(0, 0);
            StartButton.Margin = new System.Windows.Forms.Padding(0);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(187, 92);
            StartButton.TabIndex = 8;
            StartButton.Text = "1. 시작하기";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ListButton
            // 
            ListButton.Location = new System.Drawing.Point(0, 88);
            ListButton.Margin = new System.Windows.Forms.Padding(0);
            ListButton.Name = "ListButton";
            ListButton.Size = new System.Drawing.Size(187, 92);
            ListButton.TabIndex = 9;
            ListButton.Text = "2. 리스트 확인";
            ListButton.UseVisualStyleBackColor = true;
            ListButton.Click += ListButton_Click;
            // 
            // ManageButton
            // 
            ManageButton.Location = new System.Drawing.Point(0, 177);
            ManageButton.Margin = new System.Windows.Forms.Padding(0);
            ManageButton.Name = "ManageButton";
            ManageButton.Size = new System.Drawing.Size(187, 92);
            ManageButton.TabIndex = 10;
            ManageButton.Text = "3. 캐릭터 관리";
            ManageButton.UseVisualStyleBackColor = true;
            ManageButton.Click += ManageButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader25, columnHeader26, columnHeader27 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(20, 127);
            listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(950, 536);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "No";
            columnHeader17.Width = 40;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "캐릭터명";
            columnHeader18.Width = 90;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "직업";
            columnHeader19.Width = 90;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "레벨";
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "전투력";
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "최대보스";
            columnHeader22.Width = 100;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "난이도";
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "결정석수";
            columnHeader24.Width = 70;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "결정석값";
            columnHeader25.Width = 80;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "주문서";
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "스타포스";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1711, 837);
            Controls.Add(ManageButton);
            Controls.Add(ListButton);
            Controls.Add(StartButton);
            Controls.Add(MainTabControl);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "메이플 보스 가이드 v0.1";
            Load += Form1_Load;
            MainTabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            TabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView BossListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox DifficultyComboBox;
        private System.Windows.Forms.ComboBox BossNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeroTextBox;
        private System.Windows.Forms.Button ListAddBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView HeroListView;
        private System.Windows.Forms.ColumnHeader heroNum;
        private System.Windows.Forms.ColumnHeader heroName;
        private System.Windows.Forms.ColumnHeader maxBoss;
        private System.Windows.Forms.ColumnHeader maxBossDiff;
        private System.Windows.Forms.ColumnHeader stoneNum;
        private System.Windows.Forms.ColumnHeader stoneTotalPrice;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.TabPage TabPage3;
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox APIKeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ListView FirstHeroListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.Label SelectedHeroNumLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TotalHeroNumLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label SelectedHeroNumLabel2;
        private System.Windows.Forms.ColumnHeader heroClass;
        private System.Windows.Forms.ColumnHeader heroLv;
        private System.Windows.Forms.ColumnHeader heroPower;
        private System.Windows.Forms.Button CharacterLoadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
    }
}

