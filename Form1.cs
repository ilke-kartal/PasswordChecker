using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            string pass;
            string lowerCaseRegex = "[a-z]";
            string upperCaseRegex = "[A-Z]";
            string digitRegex = "[0-9]";
            string spacialCharsRegex = "^[^<>{}\"/|;:.,~!?@#$%^=&*\\]\\\\()\\[¿§«»ω⊙¤°℃℉€¥£¢¡®©_+]*$";
            pass = passtxt.Text;
            string ann = "";
            int control = 0;

            if (passtxt.Text == "")
            {
                annlbl.Text = "";
            } else {
                string lastCharacter = pass.Substring(pass.Length - 1); // Girilen son karakteri kontrol etmek için, son karakteri bir değişkene atıyoruz.

                if (lastCharacter == " ")
                {
                    pass = pass.Substring(0, pass.Length - 1); // Son karakter boşluk ise, son karakteri silip yeni şifre değerimizi oluşturuyoruz.
                    passtxt.Text = pass; // Yeni şifre değerimizi textboxımızın text 'ine atıyoruz.
                    passtxt.SelectionStart = passtxt.Text.Length; // Textbox değerini yeniden oluşturduğumuz için, imleç en başa geliyor. İmleci yeniden sona getirmek için kullanıyoruz.
                }

                if (passtxt.Text.Length >= 5)
                {

                    ann = "Şifre içerisinde";

                    if (!Regex.Match(pass, lowerCaseRegex).Success)
                    {
                        ann += " en az bir tane küçük harf,";
                        control += 1;
                    }

                    if (!Regex.Match(pass, upperCaseRegex).Success)
                    {
                        ann += " en az bir tane büyük harf,";
                        control += 1;
                    }

                    if (!Regex.Match(pass, digitRegex).Success)
                    {
                        ann += " en az bir tane rakam,";
                        control += 1;
                    }

                    if (Regex.Match(pass, spacialCharsRegex).Success)
                    {
                        ann += " en az bir özel karakter,";
                        control += 1;
                    }

                    if (control > 0)
                    {
                        ann = ann.Remove(ann.Length - 1);
                        annlbl.Text = ann + " olmalı.";

                        switch (control)
                        {
                            case 1:
                                passStrMeter.BackColor = Color.GreenYellow;
                                passlbl.BackColor = Color.GreenYellow;
                                passStrMeter.Text = "Güçlü";
                                break;
                            case 2:
                                passStrMeter.BackColor = Color.Yellow;
                                passlbl.BackColor = Color.Yellow;
                                passStrMeter.Text = "Normal";
                                break;
                            case 3:
                                passStrMeter.BackColor = Color.Orange;
                                passlbl.BackColor = Color.Orange;
                                passStrMeter.Text = "Güçsüz";
                                break;
                            case 4:
                                passStrMeter.BackColor = Color.Red;
                                passlbl.BackColor = Color.Red;
                                passStrMeter.Text = "Çok Güçsüz";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        annlbl.Text = "Şifreniz uygundur.";
                        passStrMeter.BackColor = Color.Green;
                        passlbl.BackColor = Color.Green;
                        passStrMeter.Text = "Çok Güçlü";
                    }
                } else
                {
                    annlbl.Text = "Şifreniz 5 karakterden kısa olamaz.";
                }

            }


        }
    }
}