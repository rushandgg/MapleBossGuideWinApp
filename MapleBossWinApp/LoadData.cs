using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleBossWinApp
{
    public class LoadData
    {

        public void DataList(string _mainFolderPath, ComboBox _comboBox)
        {
            // 폴더 내의 1단계 하위 디렉토리 가져오기
            var subdirectories = Directory.EnumerateDirectories(_mainFolderPath, "*", SearchOption.TopDirectoryOnly)
                .Select(subdirectory => Path.GetFileName(subdirectory));

            // 각 폴더의 이름 출력
            if (subdirectories.Count() > 0)
            {
                string[] fileNameArray = subdirectories.ToArray();
                _comboBox.Items.AddRange(fileNameArray);

                _comboBox.Text = fileNameArray[0];
            }
        }

        public void TotalHeroData(string _mainFolderPath, string _fileName, ListView _listView, List<String> _heroNameList)
        {
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

                MiddleBossData(_mainFolderPath, )
            }
        }

        public void MiddleBossData(string _mainFolderPath, string _fileName, DataGridView _dataGridView)
        {
            string filePath = Path.Combine(_mainFolderPath, _fileName);
        }
    }
}
