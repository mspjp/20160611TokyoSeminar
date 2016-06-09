using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace SimpleUwp
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //button1のClickイベントを受け取る関数
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            int a = 2;  //aという変数を作成 2を入れる
            int b = 5;  //bという変数を作成 5を入れる
            int sum = a + b; //sumという変数にaとbの合計値を入れる
            string sum_str = sum.ToString(); //テキストボックスに入れるために文字列型(string)に変換する

            textBox1.Text = sum_str; //テキストボックスのTextプロパティに入れる

        }
    }
}
