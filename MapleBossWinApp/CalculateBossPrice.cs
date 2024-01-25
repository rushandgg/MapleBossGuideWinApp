using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleBossWinApp
{
    public class CalculateBossPrice
    {
        public string SinglePrice(List<string> _bossNameList, List<string> _difficultyList, List<string> _bossPriceList, string _bossName, string _difficulty, int _partyNum)
        {
            // 보스 결정석 가격을 계산한다
            double bossPrice;
            string bossPrice2 = "억";
            List<int> indices = new List<int>();

            for (int i = 0; i < _bossNameList.Count; i++)
            {
                if (_bossNameList[i].Equals(_bossName))
                {
                    indices.Add(i);
                }
            }

            int idx = 0;
            for (int i = 0; i < indices.Count; i++)
            {
                if (_difficultyList[indices[i]] == _difficulty)
                {
                    idx = indices[i];
                }
            }

            bossPrice = Convert.ToDouble(_bossPriceList[idx]);
            bossPrice = bossPrice / _partyNum;
            bossPrice2 = Math.Round(bossPrice / 100000000, 2).ToString() + "억";
            return bossPrice2;
        }

        public string MiddlePrice(DataGridView _dataGridView) // DataGridView에서의 보스합계
        {
            double totalPrice = 0;
            string totalPrice2 = "";

            for (int i=0; i < _dataGridView.RowCount; i++)
            {
                double price = Convert.ToDouble(_dataGridView.Rows[i].Cells[3].Value.ToString().Replace("억", ""));
                totalPrice += price;
            }
            
            totalPrice2 = Math.Round(totalPrice, 2).ToString() + "억";
            
            return totalPrice2;
        }

        public string TotalPrice(ListView _listView) // ListView에서의 보스합계
        {
            double totalPrice = 0;
            string totalPrice2 = "";

            for (int i = 0; i < _listView.Items.Count; i++)
            {
                double price = Convert.ToDouble(_listView.Items[i].SubItems[8].ToString().Replace("억", ""));
                totalPrice += price;
            }

            totalPrice2 = Math.Round(totalPrice,2).ToString() + "억";

            return totalPrice2;
        }
    }
}
