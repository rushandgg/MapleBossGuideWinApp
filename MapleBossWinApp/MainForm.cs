using MapleStory.OpenAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MapleStory.OpenAPI;
using System.Security.Permissions;
using MapleStory.OpenAPI.Dto;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MapleBossWinApp
{
    public partial class MainForm : Form
    {
        List<String> difficultyList = new List<string>();
        List<String> bossNameList = new List<string>();
        List<String> bossPriceList = new List<string>();

        public int heroNo = 0;
        public string characterName = "";
        public string characterClass = "";
        public int characterLevel = 0;
        public string characterBattle = "";

        int heroListViewRow = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ListAddBtn_Click(object sender, EventArgs e)
        {
            if (BossNameComboBox.Text.Length > 0 && DifficultyComboBox.Text.Length > 0)
            {
                // 입력 받은 캐릭터명과 최대보스 정보를 가져옴
                string apiKey = APIKeyTextBox.Text;
                string heroName = HeroTextBox.Text; // 캐릭터명

                CharacterAdd characterAdd = new CharacterAdd(this);
                characterAdd.BasicInfo(apiKey, heroName);
            }
            else
            {
                MessageBox.Show("다시 입력해주세요.");
            }
        }

        public void HeroListViewAdd()
        {
            // 최대보스 정보가 나올때까지 for문을 돌려 리스트를 완성한다.
            int isClear = 0;
            double totalBossPrice = 0;
            string maxBossName = BossNameComboBox.Text; // 최대로 잡을 수 있는 보스
            string maxBossDfficulty = DifficultyComboBox.Text; // 보스 난이도

            List<String> clearBossList = new List<string>();
            for (int i = bossNameList.Count - 1; i >= 0; i--)
            {
                string bossName = bossNameList[i];
                string difficulty = difficultyList[i];
                double bossPrice = Convert.ToInt32(bossPriceList[i]);

                if (maxBossName == bossName && maxBossDfficulty == difficulty) // 최대보스부터 카운트
                {
                    isClear = 1;
                }
                if (isClear == 1 && clearBossList.Contains(bossName) == false) // 잡을 수 있는 보스이면서 이미 깬 보스가 아니라면
                {
                    clearBossList.Add(bossNameList[i]); // 잡은 보스 리스트에 추가
                    totalBossPrice += bossPrice;
                }
            }

            // 집계된 내용을 ListView에 추가함
            ListViewItem item = new ListViewItem(heroNo.ToString());
            item.SubItems.Add(characterName);
            item.SubItems.Add(characterClass);
            item.SubItems.Add(characterLevel.ToString());
            item.SubItems.Add(characterBattle);
            item.SubItems.Add(maxBossName);
            item.SubItems.Add(maxBossDfficulty);
            item.SubItems.Add(clearBossList.Count.ToString());

            totalBossPrice /= 100000000;
            double totalBossPrice2 = Math.Round(totalBossPrice, 2);
            item.SubItems.Add(totalBossPrice2.ToString() + "억");

            HeroListView.Items.Add(item);

            UpdateTotalLabel();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string csvFilePath = Path.Combine("BossList", "BossListMaster.csv");
            // 프로그램을 실행할 때 마다 결정석 값 목록을 로드한다.
            // StreamReader sr = new StreamReader(csvFilePath, Encoding.Default);
            StreamReader sr = new StreamReader("C:\\Users\\bso94\\Desktop\\BossListMaster.txt", Encoding.GetEncoding("UTF-8"));

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                // 쉼표( , )를 기준으로 데이터를 분리한다.
                string[] data = line.Split(',');
                difficultyList.Add(data[0]);
                bossNameList.Add(data[1]);
                bossPriceList.Add(data[2].Replace(",", ""));
            }

            // 목록 추가 부분의 ComboBox 아이템 추가
            List<String> bossNameList2 = new List<string>();
            bossNameList2 = bossNameList.Distinct().ToList();
            string[] bossNameArray = bossNameList2.ToArray();
            BossNameComboBox.Items.AddRange(bossNameArray);
        }

        private void BossNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DifficultyComboBox.Items.Clear();
            DifficultyComboBox.Text = "";
            // comboBox에서 선택된 보스가 바뀔 때마다 그 보스의 난이도 목록을 생성해야됨
            string bossName = BossNameComboBox.Text;

            List<String> selectedDifficultyList = new List<string>();
            for (int i = 0; i < bossNameList.Count; i++)
            {
                if (bossNameList[i] == bossName) // 선택된 보스이면 해당 난이도를 리스트에 추가
                {
                    selectedDifficultyList.Add(difficultyList[i]);

                    if (difficultyList[i] == "하드" || difficultyList[i] == "카오스") // 해당 보스의 마지막 난이도면 for문을 종료함
                    {
                        break;
                    }
                }
            }
            // 난이도의 인덱스로 배열 만듬, 배열로 comboBox의 목록 표시
            string[] selectedDifficultyArray = selectedDifficultyList.ToArray();
            DifficultyComboBox.Items.AddRange(selectedDifficultyArray);

            DifficultyComboBox.Text = selectedDifficultyArray[0];
        }

        private void HeroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            BossDataGridView.Rows.Clear();
            if (HeroListView.SelectedItems.Count != 0)
            {
                // 입력 받은 캐릭터명과 최대보스 정보를 가져옴
                int selectRow = HeroListView.SelectedItems[0].Index;
                string maxBossName = HeroListView.Items[selectRow].SubItems[5].Text; // 최대로 잡을 수 있는 보스
                string maxBossDiffculty = HeroListView.Items[selectRow].SubItems[6].Text;

                heroListViewRow = selectRow;

                // 최대보스 정보가 나올때까지 for문을 돌려 리스트를 완성한다.
                int isClear = 0;
                int bossNo = 0;
                List<String> clearBossList = new List<string>();
                for (int i = bossNameList.Count - 1; i >= 0; i--)
                {
                    string bossName = bossNameList[i];
                    string difficulty = difficultyList[i];
                    double bossPrice = Convert.ToInt32(bossPriceList[i]);

                    if (maxBossName == bossName && maxBossDiffculty == difficulty) // 최대보스부터 카운트
                    {
                        isClear = 1;
                    }
                    if (isClear == 1 && clearBossList.Contains(bossName) == false) // 잡을 수 있는 보스이면서 이미 깬 보스가 아니라면
                    {
                        bossNo += 1;
                        clearBossList.Add(bossName);
                        BossDataGridView.Rows.Add(bossName, difficulty, "1", Math.Round(bossPrice / 100000000, 2).ToString() + "억", "삭제");
                    }
                }

                CalculateBossPrice calculateBossPrice = new CalculateBossPrice();
                string priceText = calculateBossPrice.MiddlePrice(BossDataGridView);
                MiddlePriceLabel.Text = "중간 수입 합계 : " + priceText;
                HeroListView.Items[heroListViewRow].SubItems[7].Text = BossDataGridView.RowCount.ToString();
                HeroListView.Items[heroListViewRow].SubItems[8].Text = priceText;
                UpdateTotalLabel();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = MainTabControl.TabPages[0];
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = MainTabControl.TabPages[1];
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = MainTabControl.TabPages[2];
        }

        private void BossDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BossDataGridView.Rows.Count > 0)
            {
                int currentRowIdx = BossDataGridView.CurrentCell.RowIndex;
                string bossName = BossDataGridView.Rows[currentRowIdx].Cells[0].Value.ToString();
                string difficulty = BossDataGridView.Rows[currentRowIdx].Cells[1].Value.ToString();
                int partyNum = Convert.ToInt32(BossDataGridView.Rows[currentRowIdx].Cells[2].Value);

                CalculateBossPrice calculateBossPrice = new CalculateBossPrice();
                if (BossDataGridView.CurrentCell.ColumnIndex == 1)
                {
                    // 난이도 변경했을 때 보스 가격 반영
                    difficulty = BossDataGridView.Rows[currentRowIdx].Cells[1].Value.ToString();
                }
                else if (BossDataGridView.CurrentCell.ColumnIndex == 2)
                {
                    // 파티수 변경했을 때 보스 가격 반영
                    partyNum = Convert.ToInt32(BossDataGridView.Rows[currentRowIdx].Cells[2].Value);
                }

                BossDataGridView.Rows[currentRowIdx].Cells[3].Value = calculateBossPrice.SinglePrice(bossNameList, difficultyList, bossPriceList, bossName, difficulty, partyNum);
                string priceText = calculateBossPrice.MiddlePrice(BossDataGridView);
                MiddlePriceLabel.Text = "중간 수입 합계 : " + priceText;
                HeroListView.Items[heroListViewRow].SubItems[8].Text = priceText;

                UpdateTotalLabel();
            }
        }

        private void BossDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (BossDataGridView.Rows.Count > 0)
            {
                int currentRowIdx = BossDataGridView.CurrentCell.RowIndex;
                string bossName = BossDataGridView.Rows[currentRowIdx].Cells[0].Value.ToString();
                string difficulty = BossDataGridView.Rows[currentRowIdx].Cells[1].Value.ToString();
                int partyNum = Convert.ToInt32(BossDataGridView.Rows[currentRowIdx].Cells[2].Value);

                if (BossDataGridView.CurrentCell.ColumnIndex == 4) // 행을 삭제했을 때
                {
                    BossDataGridView.Rows.RemoveAt(currentRowIdx);

                    CalculateBossPrice calculateBossPrice = new CalculateBossPrice();
                    BossDataGridView.Rows[currentRowIdx].Cells[3].Value = calculateBossPrice.SinglePrice(bossNameList, difficultyList, bossPriceList, bossName, difficulty, partyNum);

                    string priceText = calculateBossPrice.MiddlePrice(BossDataGridView);
                    MiddlePriceLabel.Text = "중간 수입 합계 : " + priceText;
                    HeroListView.Items[heroListViewRow].SubItems[7].Text = BossDataGridView.RowCount.ToString();
                    HeroListView.Items[heroListViewRow].SubItems[8].Text = priceText;
                    UpdateTotalLabel();
                }
            }
        }

        private void UpdateTotalLabel()
        {
            int bossCount = 0;
            double bossTotalPrice = 0;
            for (int i = 0; i < HeroListView.Items.Count; i++)
            {
                string priceText = (HeroListView.Items[i].SubItems[8].Text).Replace("억", "");
                bossCount += Convert.ToInt32(HeroListView.Items[i].SubItems[7].Text);
                bossTotalPrice += Convert.ToDouble(priceText);
            }

            TotalHeroCountLabel.Text = "보스돌이 수 : " + HeroListView.Items.Count.ToString();
            TotalBossCountLabel.Text = "결정석 수 : " + bossCount.ToString();
            TotalPriceLabel.Text = "총 수입 : " + (Math.Round(bossTotalPrice, 2)).ToString() + "억";
        }
    }
}
