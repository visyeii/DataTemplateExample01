using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace DataTemplateExample01
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int m_count = 0;
        string[] m_color_list = new string[] { "BlueViolet", "Brown", "BurlyWood", "CadetBlue" };
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ItemAdd_Click(object sender, RoutedEventArgs e)
        {
            if (m_color_list.Length > m_count)
            {
                var colorValue = System.Drawing.Color.FromName(m_color_list[m_count]);

                colorsListView.Items.Add(new NamedColor(colorValue.ToString(), new Color()
                {
                    //Windows.UI.ColorはFromName()メソッドが無いので変換
                    A = 255,
                    R = colorValue.R,
                    G = colorValue.G,
                    B = colorValue.B
                }));
                m_count++;
            }
        }
    }
}
