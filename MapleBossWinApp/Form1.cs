using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MapleBossWinApp
{
    public partial class Form1 : Form
    {
        List<String> difficultyList = new List<string>();
        List<String> bossNameList = new List<string>();
        List<String> bossPriceList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ListAddBtn_Click(object sender, EventArgs e)
        {
            // 입력 받은 캐릭터명과 최대보스 정보를 가져옴
            string heroName = HeroTextBox.Text;
            string maxBossName = BossNameComboBox.Text;
            string maxBossDfficulty = DfficultyComboBox.Text;

            // 최대보스 정보가 나올때까지 for문을 돌려 리스트를 완성한다.
            ListViewItem item;
            
            for (int i = 0; i < bossNameList.Count; i++)
            {
                item = new ListViewItem();
                item.SubItems.Add("");
                HeroListView.Items.Add(item)
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // 프로그램을 실행할 때 마다 결정석 값 목록을 로드한다.
            StreamReader sr = new StreamReader("BossListMaster.csv");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                // 쉼표( , )를 기준으로 데이터를 분리한다.
                string[] data = line.Split(',');
                difficultyList.Add(data[0]);
                bossNameList.Add(data[1]);
                bossPriceList.Add(data[2].Replace("\"", ""));
            }

            // 목록 추가 부분의 ComboBox 아이템 추가
            List<String> bossNameList2 = new List<string>();
            bossNameList2 = bossNameList.Distinct().ToList();
            string[] bossNameArray = bossNameList2.ToArray();
            BossNameComboBox.Items.AddRange(bossNameArray);
        }

        private void BossNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox에서 선택된 보스가 바뀔 때마다 그 보스의 난이도 목록을 생성해야됨
            string bossName = BossNameComboBox.Text;
            List<int> bossIndices = FindIndicesOfBoss(difficultyList, bossName);


            // 난이도의 인덱스로 배열 만듬, 배열로 comboBox의 목록 표시
            string[] dfficultyArray = Array.Empty<string>();
            for (int i = 0; i < bossIndices.Count; i++) 
            {
                dfficultyArray.Append(difficultyList[bossIndices[i]]);
            }
            DfficultyComboBox.Items.AddRange(dfficultyArray);

            // 보스 이름에 맞는 난이도의 인덱스들을 가져옴
            List<int> FindIndicesOfBoss(List<string> list, string boss)
            {
                List<int> indices = new List<int>();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == boss)
                    {
                        indices.Add(i);
                    }
                }
                return indices;
            }
        }
    }
}
