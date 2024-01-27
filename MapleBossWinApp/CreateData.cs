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
    {

        public void StartFolder(string _mainFolderPath, ComboBox _comboBox)
        {                   
            // 폴더가 존재하지 않으면 폴더 생성
            if (!Directory.Exists(_mainFolderPath))
            {
                Directory.CreateDirectory(_mainFolderPath);
            }
            else
            {
                LoadData loadData = new LoadData();
                loadData.DataList(_mainFolderPath, _comboBox);
            }
        }

        public void TotalHeroData(string _mainFolderPath, string _fileName, ListView _listView)
        {
            // 현재 설정한 보스돌이의 캐릭터 정보를 저장한다.
            string savePath = Path.Combine(_mainFolderPath, _fileName);

            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            string savePath2 = Path.Combine(savePath, _fileName+".txt");
            using (StreamWriter sw = new StreamWriter(savePath2))
            { 
                // 각 행의 데이터 저장
                for (int i = 0; i < _listView.Items.Count; i++) 
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if(j == 8)
                        {
                            sw.Write(_listView.Items[i].SubItems[j] + "\n");
                        }
                        else
                        {
                            sw.Write(_listView.Items[i].SubItems[j] + ",");
                        }
                    }
                }
                sw.Close();
            }
            
        }

        public void MiddleBossData(string _mainFolderPath, string _fileName,List<String> _heroNameList, List<String> _middleBossList)
        {
            if (_heroNameList.Count >0 && _middleBossList.Count > 0)
            { 
                string savePath = Path.Combine(_mainFolderPath, _fileName);
                for (int i = 0; i < _heroNameList.Count; i++)
                {
                    // 캐릭터 별 정보를 저장할 폴더 생성
                    string savePath2 = Path.Combine(savePath, _heroNameList[i]); 
                    Directory.CreateDirectory(savePath2);

                    // 해당 캐릭터의 보스 정보 저장
                    string savePath3 = Path.Combine(savePath2, "boss.txt");
                    using (StreamWriter sw = new StreamWriter(savePath3))
                    {
                        
                        for (int j = 0; j < _middleBossList.Count; j++)
                        {
                            sw.Write(_middleBossList[j] + "\n");
                        }
                        sw.Close();
                    }

                    // 해당 캐릭터의 장비메모 정보 저장
                    string savePath4 = Path.Combine(savePath2, "item.txt");
                    using (StreamWriter sw = new StreamWriter(savePath4))
                    {
                        /*
                        for (int j = 0; j < _middleBossList.Count; j++)
                        {
                            sw.Write(_middleBossList[j] + "\n");
                        }
                        */
                        sw.Close();
                    }
                }
                MessageBox.Show("저장되었습니다.");
            }
            else
            {
                MessageBox.Show("저장할 정보가 없습니다.");
            }
        }

        public void SaveAPIKey(string _mainFolderPath, string _apiKey)
        {
            string apiKeyFilePath = _mainFolderPath + "nexonAPIKey.txt";
            string content = _apiKey;

            // API Key 저장
            File.WriteAllText(apiKeyFilePath, content);

            MessageBox.Show("내문서 폴더에 API Key가 저장되었습니다.");
        }
        
        public void DeleteAPIKey(string _mainFolderPath)
        {
            try
            {
                // 삭제할 텍스트 파일 경로
                string apiKeyFilePath = _mainFolderPath + "nexonAPIKey.txt";

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
        {
            string apiKey = "";
            string apiKeyFilePath = _mainFolderPath + "nexonAPIKey.txt";

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
