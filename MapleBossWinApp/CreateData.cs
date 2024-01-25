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
        string mainFolderPath = "";

        public void StartFolder()
        {
            // 내문서 폴더의 경로를 얻기
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            // 새로 생성할 폴더의 이름
            string mainFolderName = "MapleBossGuideData";
            
            // 새로 생성할 폴더의 전체 경로
            mainFolderPath = Path.Combine(myDocumentsPath, mainFolderName);
                        
            // 폴더가 존재하지 않으면 폴더 생성
            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }
        }

        public void TotalHeroData(string _fileName, ListView _listView)
        {
            // 현재 설정한 보스돌이의 캐릭터 정보를 저장한다.
            string savePath = Path.Combine(mainFolderPath, _fileName+"txt");
            using (StreamWriter sw = new StreamWriter(savePath))
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
            }
            MessageBox.Show("저장되었습니다.");
        }

        public void MiddleBossData(_)

        public void DataFolder(_)
        {

        }

        public void SaveAPIKey(string _apiKey)
        {
            string apiKeyFilePath = mainFolderPath + "nexonAPIKey.txt";
            string content = _apiKey;

            // API Key 저장
            File.WriteAllText(apiKeyFilePath, content);

            MessageBox.Show("내문서 폴더에 API Key가 저장되었습니다.");
        }
        
        public void DeleteAPIKey()
        {
            try
            {
                // 삭제할 텍스트 파일 경로
                string apiKeyFilePath = mainFolderPath + "nexonAPIKey.txt";

                // 텍스트 파일 삭제
                File.Delete(apiKeyFilePath);

                MessageBox.Show("내문서 폴더에 있는 API Key가 삭제되었습니다.");
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 API Key 파일이 없습니다.");
            }
        }

        public string CheckAPIFile()
        {
            string apiKey = "";
            string apiKeyFilePath = mainFolderPath + "nexonAPIKey.txt";

            if (Directory.Exists(mainFolderPath))
            {
                try
                {
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
