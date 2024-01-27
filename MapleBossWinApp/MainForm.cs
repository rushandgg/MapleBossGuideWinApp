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
using System.Diagnostics;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Web;

namespace MapleBossWinApp
{
    public partial class MainForm : Form
    {
        List<String> difficultyList = new List<string>(); // 전체 보스 난이도 List
        List<String> bossNameList = new List<string>(); // 전체 보스 이름 List
        List<String> bossPriceList = new List<string>(); // 전체 보스 결정석 값 List

        public List<String> heroNameList = new List<string>(); // 전체 캐릭터 명 List
        public List<String[]> middleBossList = new List<string[]>(); // 캐릭터가 격파한 보스 정보 List

        public int heroNo = 0;
        public string characterName = "";
        public string characterClass = "";
        public int characterLevel = 0;
        public string characterBattle = "";

        string currentCharacter = "";

        string mainFolderPath = ""; // 입력한 데이터들을 저장할 로컬 폴더 위치, 내문서 안에 들어감

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

                // API를 호출하여 정보 입력
                CharacterAdd characterAdd = new CharacterAdd(this);
                characterAdd.BasicInfo(apiKey, heroName);
            }
            else
            {
                MessageBox.Show("다시 입력해주세요.");
            }
        }

        public void HeroListViewAdd()
        {   // HeroListView에 데이터를 표시한다.

            // 최대보스 정보가 나올때까지 for문을 돌려 리스트를 완성한다.
            int isClear = 0;
            double totalBossPrice = 0;
            string maxBossName = BossNameComboBox.Text; // 최대로 잡을 수 있는 보스
            string maxBossDifficulty = DifficultyComboBox.Text; // 보스 난이도

            List<String> clearBossList = new List<string>();
            for (int i = bossNameList.Count - 1; i >= 0; i--)
            {
                string bossName = bossNameList[i];
                string difficulty = difficultyList[i];
                double bossPrice = Convert.ToInt32(bossPriceList[i]);

                if (maxBossName == bossName && maxBossDifficulty == difficulty) // 최대보스부터 카운트
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
            item.SubItems.Add(maxBossDifficulty);
            item.SubItems.Add(clearBossList.Count.ToString());

            totalBossPrice /= 100000000;
            double totalBossPrice2 = Math.Round(totalBossPrice, 2);
            item.SubItems.Add(totalBossPrice2.ToString() + "억");

            HeroListView.Items.Add(item);

            UpdateTotalLabel();

            // 추가한 정보를 바탕으로 DataGridView 보스 목록 표시, 표시한 데이터를 List에 저장
            SaveMiddleBossData(characterName, maxBossName, maxBossDifficulty); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // 내문서 폴더의 경로를 얻기
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // 새로 생성할 폴더의 이름
            string mainFolderName = "MapleBossGuideData";
            // 새로 생성할 폴더의 전체 경로
            mainFolderPath = Path.Combine(myDocumentsPath, mainFolderName);

            // 프로그램 시작 시 데이터를 저장할 폴더를 만든다.
            CreateData createData = new CreateData();
            createData.StartFolder(mainFolderPath, SaveFileListComboBox);

            // API Key가 저장되어 있으면 TextBox에 자동입력한다.
            APIKeyTextBox.Text = createData.CheckAPIFile(mainFolderPath);

            // 프로그램을 실행할 때 마다 결정석 값 목록을 로드한다.
            string csvFilePath = Path.Combine("BossList", "BossListMaster.csv");
            // StreamReader sr = new StreamReader(csvFilePath, Encoding.Default);
            StreamReader sr = new StreamReader("C:\\Users\\bso94\\Desktop\\BossListMaster.txt", Encoding.GetEncoding("UTF-8"));

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                // 쉼표( , )를 기준으로 데이터를 분리한다.
                string[] data = line.Split(',');
                difficultyList.Add(data[0]); // 난이도
                bossNameList.Add(data[1]); // 보스명
                bossPriceList.Add(data[2].Replace(",", "")); // 결정석 값
            }
            sr.Close();

            // 불러온 보스 이름들을 ComboBox의 요소로 추가한다.
            List<String> bossNameList2 = new List<string>();
            bossNameList2 = bossNameList.Distinct().ToList();
            string[] bossNameArray = bossNameList2.ToArray();
            BossNameComboBox.Items.AddRange(bossNameArray);
        }

        private void BossNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   // ComboBox의 보스 이름을 변경할 때 마다 보스에 해당하는 난이도를 ComboBox에 표시

            // 난이도 ComboBox 초기화
            DifficultyComboBox.Items.Clear();
            DifficultyComboBox.Text = "";
            
            // 선택 된 보스 이름
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

            // 난이도의 인덱스로 배열 만듬, 배열을 comboBox의 목록으로 표시
            string[] selectedDifficultyArray = selectedDifficultyList.ToArray();
            DifficultyComboBox.Items.AddRange(selectedDifficultyArray);

            DifficultyComboBox.Text = selectedDifficultyArray[0];
        }

        public void SaveMiddleBossData(string characterName, string maxBossName, string maxBossDiffculty)
        {   // Listview에 추가한 데이터를 DataGridView에 표시하고 List에 저장한다.

            // 표시할 DataGridView 초기화
            BossDataGridView.Rows.Clear(); 

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

                // 캐릭터 별 보스 정보를 List에 저장한다. 나중에 txt파일로 저장하거나 DataGridView에 표시할 때 씀
                string[] middleBossDataArray = { characterName, bossName, difficulty, "1", Math.Round(bossPrice / 100000000, 2).ToString() + "억" };
                middleBossList.Add(middleBossDataArray);
            }    
        }

        private void HeroListView_SelectedIndexChanged(object sender, EventArgs e)
        {   // ListView의 데이터를 선택할 때 마다 DataGridView에 데이터를 표시

            // 표시할 DataGridView 초기화
            BossDataGridView.Rows.Clear(); 

            if (HeroListView.SelectedItems.Count != 0)
            {
                int selectRow = HeroListView.SelectedItems[0].Index;
                string characterName = HeroListView.Items[selectRow].SubItems[1].Text; // 캐릭터 명
                currentCharacter = characterName;

                List<string[]> filteredList = middleBossList.Where(array => array.Contains(characterName)).ToList();

                foreach (string[] array in filteredList)
                {
                    BossDataGridView.Rows.Add(array[1], array[2], array[3], array[4], "삭제");
                }

                // 결정석 합계를 계산하고 ListView와 Label에 표시한다. 
                CalculateBossPrice calculateBossPrice = new CalculateBossPrice();
                string priceText = calculateBossPrice.MiddlePrice(BossDataGridView);
                MiddlePriceLabel.Text = "중간 수입 합계 : " + priceText;
                HeroListView.Items[selectRow].SubItems[7].Text = BossDataGridView.RowCount.ToString();
                HeroListView.Items[selectRow].SubItems[8].Text = priceText;
                
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
        {   // BossDataGridView의 Cell 가격이 변할 때 실행, 수정된 값으로 결정석 가격을 계산한다.

            // 선택된 행이 있을 경우
            if (BossDataGridView.Rows.Count > 0)
            {
                // 선택한 행의 값을 가져옴
                int currentRowIdx = BossDataGridView.CurrentCell.RowIndex; // 선택된 행 인덱스
                string bossName = BossDataGridView.Rows[currentRowIdx].Cells[0].Value.ToString(); // 보스명
                string difficulty = BossDataGridView.Rows[currentRowIdx].Cells[1].Value.ToString(); // 난이도
                string characterName = currentCharacter; // 선택한 캐릭터 명, middleBossList에 접근하기 위함 
                int partyNum = Convert.ToInt32(BossDataGridView.Rows[currentRowIdx].Cells[2].Value); // 파티수

                CalculateBossPrice calculateBossPrice = new CalculateBossPrice();
                if (BossDataGridView.CurrentCell.ColumnIndex == 1)
                {   // 난이도 변경했을 때 보스 가격 반영
                    difficulty = BossDataGridView.Rows[currentRowIdx].Cells[1].Value.ToString();
                }
                else if (BossDataGridView.CurrentCell.ColumnIndex == 2)
                {   // 파티수 변경했을 때 보스 가격 반영
                    partyNum = Convert.ToInt32(BossDataGridView.Rows[currentRowIdx].Cells[2].Value);
                }

                BossDataGridView.Rows[currentRowIdx].Cells[3].Value = calculateBossPrice.SinglePrice(bossNameList, difficultyList, bossPriceList, bossName, difficulty, partyNum);
                string priceText = calculateBossPrice.MiddlePrice(BossDataGridView);
                MiddlePriceLabel.Text = "중간 수입 합계 : " + priceText;
                HeroListView.Items[heroListViewRow].SubItems[8].Text = priceText;

                // 수정한 데이터를 들고있는 List에 반영한다.
                for (int i = 0; i < middleBossList.Count; i++)
                {
                    if (middleBossList[i].Contains(characterName) && middleBossList[i].Contains(bossName) && middleBossList[i].Contains(difficulty))
                    {
                        middleBossList[i][2] = difficulty;
                        middleBossList[i][3] = partyNum.ToString();
                        middleBossList[i][4] = BossDataGridView.Rows[currentRowIdx].Cells[3].Value.ToString();
                        break;
                    }
                }

                UpdateTotalLabel();
            }
        }

        private void BossDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   // BossDataGridView의 Cell을 클릭했을 때 실행

            // 선택된 행이 있을 경우
            if (BossDataGridView.Rows.Count > 0)
            {
                int currentRowIdx = BossDataGridView.CurrentCell.RowIndex;
                string bossName = BossDataGridView.Rows[currentRowIdx].Cells[0].Value.ToString();
                string difficulty = BossDataGridView.Rows[currentRowIdx].Cells[1].Value.ToString();
                int partyNum = Convert.ToInt32(BossDataGridView.Rows[currentRowIdx].Cells[2].Value);

                if (BossDataGridView.CurrentCell.ColumnIndex == 4) // 삭제 버튼을 눌렀을 때
                {
                    BossDataGridView.Rows.RemoveAt(currentRowIdx); // 해당 행 삭제

                    CalculateBossPrice calculateBossPrice = new CalculateBossPrice();
                    string priceText = calculateBossPrice.MiddlePrice(BossDataGridView);
                    MiddlePriceLabel.Text = "중간 수입 합계 : " + priceText;
                    HeroListView.Items[heroListViewRow].SubItems[7].Text = BossDataGridView.RowCount.ToString();
                    HeroListView.Items[heroListViewRow].SubItems[8].Text = priceText;

                    // 수정한 데이터를 들고있는 List에 반영한다.
                    for (int i = 0; i < middleBossList.Count; i++)
                    {
                        if (middleBossList[i].Contains(characterName) && middleBossList[i].Contains(bossName) && middleBossList[i].Contains(difficulty))
                        {
                            middleBossList.RemoveAt(i);
                            break;
                        }
                    }

                    UpdateTotalLabel();
                }
            }
        }

        private void UpdateTotalLabel()
        {   // 전체 집계를 표시할 Label들을 수정한다.

            int bossCount = 0; // 전체 결정석 수
            double bossTotalPrice = 0; // 전체 결정석 값

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

        private void APILinkLabel_Click(object sender, EventArgs e)
        {   // API등록 Link Label을 클릭하면 실행

            string apiUrl = "https://openapi.nexon.com/";

            Process.Start(new ProcessStartInfo(apiUrl) { UseShellExecute = true });
        }

        private void SaveAPIKeyButton_Click(object sender, EventArgs e)
        {   // API Key 저장 버튼을 누르면 실행

            if (APIKeyTextBox.TextLength > 0)
            {
                CreateData createData = new CreateData();
                createData.SaveAPIKey(mainFolderPath, APIKeyTextBox.Text);
            }
        }

        private void DeleteAPIKeyButton_Click(object sender, EventArgs e)
        {   // API Key 삭제 버튼을 누르면 실행

            CreateData createData = new CreateData();
            createData.DeleteAPIKey(mainFolderPath);
        }

        private void CharacterLoadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
