using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using System.IO;

namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        SmtpClient sc = new SmtpClient();

        public MainWindow()
        {

            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }

        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Send message Canceled");
            }
            else
            {
                MessageBox.Show("Send message Completed");
            }
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage("ojsinfosys01@gmail.com" , tbTo.Text);

                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbBody.Text; //本文

                sc.Host = "smtp.gmail.com"; //SMTPサーバの設定
                sc.Port = 587;
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("ojsinfosys01@gmail.com" , "ojsInfosys2020");

                //添付ファイル
                System.Net.Mail.Attachment attachment;
                foreach (var item in lbFiles.Items)
                {
                    attachment = new System.Net.Mail.Attachment(item.ToString());
                    //attachment = new System.Net.Mail.Attachment(datapath+jpgname);//添付ファイルのパスを指定する

                    attachment.ContentType = new System.Net.Mime.ContentType("image/jpeg");
                    //Attachmentsに追加する
                    msg.Attachments.Add(attachment);

                }


                sc.SendMailAsync(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定画面表示
        private void btConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindow configWindow = new ConfigWindow();//設定画面のインスタンスを生成
            configWindow.Show();  //表示
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Config.GetInstance().DeSerialise();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Config.GetInstance().Serialise();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            // ダイアログのインスタンスを生成
            var dialog = new OpenFileDialog();

            // ファイルの種類を設定
            dialog.Filter = "全てのファイル (*.*)|*.*";

            // ダイアログを表示する
            if (dialog.ShowDialog() == true)
            {
                // 選択されたファイル名 (ファイルパス) をメッセージボックスに表示
                lbFiles.Items.Add(dialog.FileName);
            }
        }

        private void btRemove_Click(object sender, RoutedEventArgs e)
        {
            lbFiles.Items.Remove(lbFiles.SelectedItem);
        }
    }
}
