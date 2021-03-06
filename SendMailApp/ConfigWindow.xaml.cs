﻿using System;
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
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            //Config.csの初期設定に

            Config cf = (Config.GetInstance()).getDefaultStatus();

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }

        //適用（更新）
        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            //this looks really bad, but its works so i dont care anyway
            if (tbSmtp.Text == "")
                MessageBox.Show("SMTPサーバが指定されていません");
            else
            {
                if (tbUserName.Text == "")
                    MessageBox.Show("ユーザ名が指定されていません");
                else
                {
                    if (tbPassWord.Password == "")
                        MessageBox.Show("パスワードが指定されていません");
                    else
                    {
                        if (tbPort.Text == "")
                            MessageBox.Show("ポートが指定されていません");
                        else
                        {
                            if (tbSender.Text == "")
                                MessageBox.Show("送信元が指定されていません");
                            else
                            {

                                Config.GetInstance().UpdateStatus(
                                    tbSmtp.Text,
                                    tbUserName.Text,
                                    tbPassWord.Password,
                                    int.Parse(tbPort.Text),
                                    cbSsl.IsChecked ?? false);   //更新処理を呼び出す

                            }
                        }
                    }
                }
            }
            
        }

        //OKボタン
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            //jeez look at this mess
            if (tbSmtp.Text == "")
                MessageBox.Show("SMTPサーバが指定されていません");
            btApply_Click(sender, e);
            this.Close();

        }

        //キャンセルボタン
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance());

            if (tbSmtp.Text == cf.Smtp && tbPort.Text == cf.Port.ToString() &&
                tbSender.Text == cf.MailAddress && tbPassWord.Password == cf.PassWord)
            {
                this.Close();
            }
            else
            {
                //MessageBox.Show("blah");

                MessageBoxResult dRet = MessageBox.Show("変更を保存せず閉じますか？", " ", MessageBoxButton.YesNo);

                if (dRet == MessageBoxResult.Yes)
                {
                    this.Close();
                }
                else if (dRet == MessageBoxResult.No) //「いいえ」が選択された時
                {
                }
            }
        }

        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Config cf = (Config.GetInstance());

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }
    }
}