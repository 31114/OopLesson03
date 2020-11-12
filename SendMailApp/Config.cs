using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp {
    public class Config {
        //単一のインスタンス
        private static Config instance;
        
        //インスタンスの取得
        public static Config GetInstance() {
            if (instance == null) {
                instance = new Config();
            }
            return instance;
        }

        public string Smtp { get; set; }    //SMTPサーバー
        public string MailAddress { get; set; } //自メールアドレス（送信元）
        public string PassWord { get; set; }    //パスワード
        public int Port { get; set; }   //ポート番号   
        public bool Ssl { get; set; }   //SSL設定

        //コンストラクタ(外部からnewできないようにする)
        private Config() {}

        //初期設定用
        public void DefaultSet() {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config getDefaultStatus() {
            Config obj = new Config {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };
            return obj;
        }

        //設定データ更新
        //public bool UpdateStatus(Config cf) {
        public bool UpdateStatus(string smtp,string mailAddress, 
                                            string passWord,int port,bool ssl) {
            this.Smtp = smtp;
            this.MailAddress = mailAddress;
            this.PassWord = passWord;
            this.Port = port;
            this.Ssl = ssl;
            return true;
        }

        public void Serialise()
        {
            try
            {
                var setting = new Config
                {
                    Smtp = this.Smtp,
                    MailAddress = this.MailAddress,
                    PassWord = this.PassWord,
                    Port = this.Port,
                    Ssl = this.Ssl,
                };
                using (var write = XmlWriter.Create("Config.xml"))
                {
                    var serializer = new XmlSerializer(setting.GetType());
                    serializer.Serialize(write, setting);
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Serialise Error");
            }
        }

        public void DeSerialise()
        {
            try
            {
                using (var reader = XmlReader.Create("Config.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Config));
                    var setting = serializer.Deserialize(reader) as Config;
                    Console.WriteLine(setting);

                    this.Smtp = setting.Smtp;
                    this.MailAddress = setting.MailAddress;
                    this.PassWord = setting.PassWord;
                    this.Port = setting.Port;
                    this.Ssl = setting.Ssl;
                }
            }
            catch (FileNotFoundException)
            {
                //ConfigWindow表示
                ConfigWindow configWindow = new ConfigWindow();//設定画面のインスタンスを生成
                configWindow.Show();  //表示
                
                //XMLファイル作成
                Config cf = (Config.GetInstance()).getDefaultStatus();

                var setting = new Config
                {
                    Smtp = cf.Smtp,
                    MailAddress = cf.MailAddress,
                    PassWord = cf.PassWord,
                    Port = cf.Port,
                    Ssl = cf.Ssl,
                };
                using (var write = XmlWriter.Create("Config.xml"))
                {
                    var serializer = new XmlSerializer(setting.GetType());
                    serializer.Serialize(write, setting);
                }
            }
            catch(Exception)
            {
                System.Windows.MessageBox.Show("DeSerialise Error");
            }
        }
    }
}
