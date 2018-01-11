using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*
        // button1_click ： コントロール名_イベント名⇒イベントハンドラの書かれ方
        private void button1_Click(object sender, EventArgs e)
        {
            //コントロール名.メソッド名
            // メソッド：Hide() ⇒ コントロールを非表示にする
            label1.Hide();
            // メソッド：Show() ⇒ メッセージボックスに括弧内のメッセージを表示する
            MessageBox.Show("こんにちは");

        }
        */
        public class Animal
        {
            public string color;    // 色
            public string Sing() //鳴き声
            {
                return "動物の鳴き声";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

        }

        // _myBackColorという内部データを定義
        private Color _myBackColor;
        // MyBackColorというチェック処理を定義
        public Color MyBackColor
        {
            // チェックを実行しOKなら_myBackColorの値を返す
            get { return _myBackColor;}
            // チェックを実行しOKなら_myBackColorに値を設定する
            set { _myBackColor = value; }
        }
    }
}
