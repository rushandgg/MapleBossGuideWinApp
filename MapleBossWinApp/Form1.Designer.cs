namespace MapleBossWinApp
{
    partial class Form1
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
            this.HeroListView = new System.Windows.Forms.ListView();
            this.heroNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heroName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxBoss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stoneTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListAddBtn = new System.Windows.Forms.Button();
            this.HeroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxBossTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BossListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BossNameComboBox = new System.Windows.Forms.ComboBox();
            this.DfficultyComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeroListView
            // 
            this.HeroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.heroNum,
            this.heroName,
            this.maxBoss,
            this.stoneNum,
            this.stoneTotalPrice});
            this.HeroListView.HideSelection = false;
            this.HeroListView.Location = new System.Drawing.Point(16, 24);
            this.HeroListView.Name = "HeroListView";
            this.HeroListView.Size = new System.Drawing.Size(515, 279);
            this.HeroListView.TabIndex = 0;
            this.HeroListView.UseCompatibleStateImageBehavior = false;
            this.HeroListView.View = System.Windows.Forms.View.Details;
            // 
            // heroNum
            // 
            this.heroNum.Text = "No";
            // 
            // heroName
            // 
            this.heroName.Text = "캐릭터명";
            this.heroName.Width = 100;
            // 
            // maxBoss
            // 
            this.maxBoss.Text = "최대보스";
            this.maxBoss.Width = 100;
            // 
            // stoneNum
            // 
            this.stoneNum.Text = "결정석수";
            this.stoneNum.Width = 120;
            // 
            // stoneTotalPrice
            // 
            this.stoneTotalPrice.Text = "결정석값";
            this.stoneTotalPrice.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HeroListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐릭터 목록";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DfficultyComboBox);
            this.groupBox2.Controls.Add(this.BossNameComboBox);
            this.groupBox2.Controls.Add(this.MaxBossTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.HeroTextBox);
            this.groupBox2.Controls.Add(this.ListAddBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "목록 추가하기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "캐릭터명";
            // 
            // ListAddBtn
            // 
            this.ListAddBtn.Location = new System.Drawing.Point(421, 33);
            this.ListAddBtn.Name = "ListAddBtn";
            this.ListAddBtn.Size = new System.Drawing.Size(100, 37);
            this.ListAddBtn.TabIndex = 1;
            this.ListAddBtn.Text = "추가";
            this.ListAddBtn.UseVisualStyleBackColor = true;
            this.ListAddBtn.Click += new System.EventHandler(this.ListAddBtn_Click);
            // 
            // HeroTextBox
            // 
            this.HeroTextBox.Location = new System.Drawing.Point(16, 51);
            this.HeroTextBox.Name = "HeroTextBox";
            this.HeroTextBox.Size = new System.Drawing.Size(122, 25);
            this.HeroTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "최대보스 / 난이도";
            // 
            // MaxBossTextBox
            // 
            this.MaxBossTextBox.Location = new System.Drawing.Point(290, 20);
            this.MaxBossTextBox.Name = "MaxBossTextBox";
            this.MaxBossTextBox.Size = new System.Drawing.Size(122, 25);
            this.MaxBossTextBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(566, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "집계";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "총 수입";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "보스돌이 수";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BossListView);
            this.groupBox4.Location = new System.Drawing.Point(566, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 324);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "캐릭별 보스 목록";
            // 
            // BossListView
            // 
            this.BossListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.BossListView.HideSelection = false;
            this.BossListView.Location = new System.Drawing.Point(16, 24);
            this.BossListView.Name = "BossListView";
            this.BossListView.Size = new System.Drawing.Size(515, 279);
            this.BossListView.TabIndex = 0;
            this.BossListView.UseCompatibleStateImageBehavior = false;
            this.BossListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "보스명";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "난이도";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "파티수";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "결정석값";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "삭제";
            // 
            // BossNameComboBox
            // 
            this.BossNameComboBox.FormattingEnabled = true;
            this.BossNameComboBox.Location = new System.Drawing.Point(167, 51);
            this.BossNameComboBox.Name = "BossNameComboBox";
            this.BossNameComboBox.Size = new System.Drawing.Size(117, 23);
            this.BossNameComboBox.TabIndex = 5;
            this.BossNameComboBox.SelectedIndexChanged += new System.EventHandler(this.BossNameComboBox_SelectedIndexChanged);
            // 
            // DfficultyComboBox
            // 
            this.DfficultyComboBox.FormattingEnabled = true;
            this.DfficultyComboBox.Location = new System.Drawing.Point(290, 51);
            this.DfficultyComboBox.Name = "DfficultyComboBox";
            this.DfficultyComboBox.Size = new System.Drawing.Size(117, 23);
            this.DfficultyComboBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 495);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "메이플 보스 가이드 v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader heroNum;
        private System.Windows.Forms.ColumnHeader heroName;
        private System.Windows.Forms.ColumnHeader maxBoss;
        private System.Windows.Forms.ColumnHeader stoneNum;
        private System.Windows.Forms.ColumnHeader stoneTotalPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MaxBossTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeroTextBox;
        private System.Windows.Forms.Button ListAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView BossListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ListView HeroListView;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DfficultyComboBox;
        private System.Windows.Forms.ComboBox BossNameComboBox;
    }
}

