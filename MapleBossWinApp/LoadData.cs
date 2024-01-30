using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MapleBossWinApp
{
    public class LoadData
    {   // 데이터를 불러올 때 쓸 class

        // DataList() : 저장된 데이터 목록 불러옴
        // TotalHeroData() : 저장한 캐릭터 목록과 전체적인 보스 정보, HeroListView에 표시될 정보
        // MiddleBossData() : 캐릭터 별 격파한 세부 보스 정보들을 불러옴, BossDataGridView에 표시될 정보

        public void DataList(string _mainFolderPath, ComboBox _comboBox)
        {   // 폴더에 저장된 데이터 목록을 가져온다.

            // 폴더 내의 1단계 하위 디렉토리 가져오기
            var subdirectories = Directory.EnumerateDirectories(_mainFolderPath, "*", SearchOption.TopDirectoryOnly)
                .Select(subdirectory => Path.GetFileName(subdirectory));

            // 가져온 폴더의 이름을 comboBox의 목록으로 표시한다.
            if (subdirectories.Count() > 0)
            {
                string[] fileNameArray = subdirectories.ToArray();
                _comboBox.Items.AddRange(fileNameArray);

                _comboBox.Text = fileNameArray[0];
            }
        }

        public void TotalHeroData(string _mainFolderPath, string _fileName, ListView _listView, List<String> _heroNameList, List<String[]> _middleBossList, DataGridView _dataGridView)
        {   // 캐릭터 목록 정보를 읽고 HeroListView와 heroNameList에 저장한다.

            string filePath = Path.Combine(_mainFolderPath, _fileName);
            if (Directory.Exists(filePath))
            {
                _heroNameList.Clear();

                string filePath2 = Path.Combine(filePath, _fileName);
                StreamReader sr = new StreamReader(filePath2 + "txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    // 쉼표( , )를 기준으로 데이터를 분리한다.
                    string[] data = line.Split(',');
                    ListViewItem item = new ListViewItem(data[0]);
                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);
                    item.SubItems.Add(data[3]);
                    item.SubItems.Add(data[4]);
                    item.SubItems.Add(data[5]);
                    item.SubItems.Add(data[6]);
                    item.SubItems.Add(data[7]);
                    item.SubItems.Add(data[8]);

                    _listView.Items.Add(item);

                    _heroNameList.Add(data[1]);
                }

                MiddleBossData(_mainFolderPath, _fileName, _middleBossList, _dataGridView);
            }
        }

        public void MiddleBossData(string _mainFolderPath, string _fileName, List<String[]> _middleBossList, DataGridView _dataGridView)
        {
            string filePath = Path.Combine(_mainFolderPath, _fileName);
        }
    }
}
