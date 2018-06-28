using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _106082046
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            string[] name = { "在教室", "在異世界", "在粉色房間", "在草野間", "在游泳池旁", "在河堤邊", "在舞台上", "在廁所裡", "在道場上", "在床上", "在水樂園", "在冰淇淋店", "在健身房", "在廢墟", "在廚房", "在地板上", "在便利商店" };
            int control = rnd.Next(0, name.Length);
            Date.Text = "asd";
            string result = name[control];
            MessageBox.Show(result);
            roleNAME.Text = result;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] name = { "帶著貓耳", "穿著黑絲襪", "頭戴粉色髮帶", "頭長貓耳", "帶著機車手套", "帶著金項鍊", "穿著膝上襪", "拿著衛生紙", "穿著比基尼", "穿著死庫水", "摸著gamemaker", "穿著紅高跟鞋", "滿身是血", "臉上一道刀疤", "全身布滿血絲", "有著黑色指甲", "綁著高馬尾" ,"綁著雙馬尾 " };
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] name = { "悲傷的", "愉悅的", "憤怒的", "滿臉疑惑的", "興奮的", "困擾的", "尷尬的", "瘋狂的", "霸道的", "難過的", "幼稚的", "鬱悶的", "放鬆的", "羞澀的", "外向的", "好動的", "一臉正常的" };
        }
    }
}
           