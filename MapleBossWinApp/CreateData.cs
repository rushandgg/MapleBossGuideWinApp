using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MapleBossWinApp
{
    public class CreateData
    {   // 데이터를 저장할 때 쓸 class

        // StartFolder() : 데이터를 저장할 메인 폴더가 있는지 체크하고 없으면 생성
        // TotalHeroData() : 캐릭터 목록과 전체적인 보스 정보, HeroListView에 표시되는 정보
        // MiddleBossData() : 캐릭터 별 격파한 세부 보스 정보, BossDataGridView에 표시되는 정보
        // SaveAPIKey() : 로컬에 API Key 텍스트 파일을 저장
        // DeleteAPIKey() : 로컬에 저장된 API Key 텍스트 파일을 삭제
        // CheckAPIFile() : 로컬에 API Key 텍스트 파일이 있는지 체크

        public void StartFolder(string _mainFolderPath, ComboBox _comboBox)
        {   // 데이터를 저장할 폴더가 있는지 체크하고 없으면 폴더를 생성한다.

            if (!Directory.Exists(_mainFolderPath)) // 폴더가 존재하지 않으면 폴더 생성
            {
                Directory.CreateDirectory(_mainFolderPath);
            }
            else // 폴더가 존재하면 저장된 파일이 있는지 확인하고 있으면 저장된 파일 목록을 불러옴
            {
                LoadData loadData = new LoadData();
                loadData.DataList(_mainFolderPath, _comboBox);
            }
        }

        public void TotalHeroData(string _mainFolderPath, string _fileName, ListView _listView)
        {   // 현재 설정한 보스돌이의 캐릭터 정보를 저장한다.
            // 지정된 이름으로 된 폴더를 생성하고
            // 동일한 이름의 텍스트 파일을 생성한다.
            // 작업이 끝나면 MiddleBossData() 를 호출하여 세부 보스 데이터를 저장한다.

            string savePath = Path.Combine(_mainFolderPath, _fileName);

            // 지정한 이름으로 된 폴더 생성
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            // 동일한 이름의 텍스트 파일 생성
            string savePath2 = Path.Combine(savePath, _fileName+".txt"); // '메인폴더\\파일명폴더\\파일명.txt'
            using (StreamWriter sw = new StreamWriter(savePath2))
            { 
                // 각 행의 데이터 저장
                for (int i = 0; i < _listView.Items.Count; i++) 
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if(j == 8)
                        {
                            sw.Write(_listView.Items[i].SubItems[j].Text + "\n");
                        }
                        else
                        {
                            sw.Write(_listView.Items[i].SubItems[j].Text + ",");
                        }
                    }
                }
                sw.Close();
            }
        }

        public void MiddleBossData(string _mainFolderPath, string _fileName, List<String> _heroNameList, List<String[]> _middleBossList)
        {   // 캐릭터가 격파한 보스의 세부정보들을 텍스트 파일로 저장함

            if (_heroNameList.Count >0 && _middleBossList.Count > 0)
            { 
                string savePath = Path.Combine(_mainFolderPath, _fileName); // '메인폴더\\파일명폴더'

                // 캐릭터 별 보스 정보 저장
                string fileName = _fileName + "Boss.txt";
                string savePath2 = Path.Combine(savePath, fileName);

                using (StreamWriter sw = new StreamWriter(savePath2))
                {
                    for (int j = 0; j < _middleBossList.Count; j++)
                    {
                        string concatString = string.Join(",", _middleBossList[j]);
                        sw.Write(concatString + "\n"); // string[] 형태로 이루어진 데이터를 한줄씩 텍스트 파일에 기록
                    }
                    sw.Close();
                }

                // 해당 캐릭터의 장비메모 정보 저장
                /*
                string savePath4 = Path.Combine(savePath2, "item.txt"); // '메인폴더\\파일명폴더\\캐릭터명item.txt'
                using (StreamWriter sw = new StreamWriter(savePath4))
                {

                    for (int j = 0; j < _middleBossList.Count; j++)
                    {
                        sw.Write(_middleBossList[j] + "\n");
                    }

                    sw.Close();
                }
                */

                MessageBox.Show("저장되었습니다.");
            }
            else
            {
                MessageBox.Show("저장할 정보가 없습니다.");
            }
        }

        public void SaveAPIKey(string _mainFolderPath, string _apiKey)
        {   // 로컬에 API Key 텍스트 파일 저장

            string apiKeyFilePath = Path.Combine(_mainFolderPath, "nexonAPIKey.txt");
            string content = _apiKey;

            // API Key 저장
            File.WriteAllText(apiKeyFilePath, content);

            MessageBox.Show("내문서 폴더에 API Key가 저장되었습니다.");
        }
        
        public void DeleteAPIKey(string _mainFolderPath)
        {   // 로컬에 저장된 API Key 텍스트 파일 삭제

            try
            {
                // 삭제할 텍스트 파일 경로
                string apiKeyFilePath = Path.Combine(_mainFolderPath,  "nexonAPIKey.txt");

                // 텍스트 파일 삭제
                File.Delete(apiKeyFilePath);

                MessageBox.Show("내문서 폴더에 있는 API Key가 삭제되었습니다.");
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 API Key 파일이 없습니다.");
            }
        }

        public string CheckAPIFile(string _mainFolderPath)
        {   // 로컬에 저장된 API Key 텍스트 파일이 있는지 확인함

            string apiKey = "";
            string apiKeyFilePath = Path.Combine(_mainFolderPath, "nexonAPIKey.txt");

            // 메인 폴더 존재 확인
            if (Directory.Exists(_mainFolderPath))
            {
                try
                {
                    // API Key 파일이 존재하면 정보 읽기
                    apiKey = File.ReadAllText(apiKeyFilePath);
                }
                catch (Exception)
                {

                }
            }
            return apiKey;
        }
    }
}
