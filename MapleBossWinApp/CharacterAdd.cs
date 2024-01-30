using MapleStory.OpenAPI.Dto;
using MapleStory.OpenAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MapleBossWinApp
{
    public class CharacterAdd
    {   // Nexon Open API 호출을 통해 캐릭터 관련 데이터를 불러오는 class

        // API Key와 캐릭터명을 통해 데이터를 호출한다.
        // BasicInfo() : 직업, 레벨, 전투력 기본적인 정보 호출
        
        // 아이템 정보를 호출하는 함수 추가할 예정

        private readonly MainForm _mainForm;

        public CharacterAdd(MainForm form)
        {
            _mainForm = form;
        }

        public async void BasicInfo(string _APIKey, string _CharacterName)
        {   // 캐릭터의 기본적인 정보를 API 호출을 통해 불러온다.
            // 불러온 정보를 MainForm의 HeroListView에 표시한다.

            // API 실행을 위한 부분
            var apiKey = _APIKey; // 입력된 API Key
            var api = new MapleStoryAPI(apiKey);
            var dateTimeOffset = new DateTimeOffset(2023, 10, 15, 0, 0, 0, TimeSpan.FromHours(9));
            string characterName = _CharacterName; // 입력된 캐릭터명
            string ocid = "";

            string characterClass = "";
            int characterLevel = 0;
            string characterBattle = "";

            // 캐릭터 OCID를 가져옴
            try
            {
                var response = await api.GetCharacter(characterName);

                ocid = response.OCID;
            }
            catch (MapleStoryAPIException)
            {
                // handle MapleStoryApiException
            }
            catch (HttpRequestException)
            {
                // handle HttpRequestException
            }

            // 캐릭터 기본정보(캐릭터명, 직업, 레벨, 전투력)을 가져와 ListView에 표시한다.
            try
            {
                var response = await api.GetCharacterBasic(ocid);

                characterClass = response.CharacterClass;
                characterLevel = Convert.ToInt32(response.CharacterLevel);
            }
            catch (MapleStoryAPIException)
            {
                // handle MapleStoryApiException
            }
            catch (HttpRequestException)
            {
                // handle HttpRequestException
            }

            try
            {
                var response = await api.GetCharacterStat(ocid);

                var finalStats = response.FinalStat; // 전체 스탯
                CharacterFinalStatDTO battleScore = finalStats[finalStats.Count - 2]; // 전투력
                int battleScore2 = Convert.ToInt32(battleScore.StatValue);
                if (battleScore2 >= 100000000)
                {
                    characterBattle = (battleScore2 / 100000000).ToString() + "억" + ((battleScore2 - battleScore2 / 100000000 * 100000000) / 10000).ToString() + "만";
                }
                else if (battleScore2 >= 10000)
                {
                    characterBattle = (battleScore2 / 10000).ToString() + "만";
                }
                else
                {
                    characterBattle = battleScore2.ToString();
                }
            }
            catch (MapleStoryAPIException)
            {
                // handle MapleStoryApiException
            }
            catch (HttpRequestException)
            {
                // handle HttpRequestException
            }

            _mainForm.heroNo += 1;
            _mainForm.characterName = characterName;
            _mainForm.characterClass = characterClass;
            _mainForm.characterLevel = characterLevel;
            _mainForm.characterBattle = characterBattle;

            _mainForm.HeroListViewAdd();
        }
    }
}
