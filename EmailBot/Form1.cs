using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail; //لازم تضمن مكتبة الايميل
using System.Windows.Forms;

namespace EmailBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //العنوان
            textBox2.Text = @"Coop Trainig";
           //نص الرسالة
            textBox3.Text = @"Dear Recruitment Team,

I hope this message finds you well.
               
My name is Fahad , a senior Software Engineering student at University,
expected to graduate in Summer 2025. As part of my graduation requirements,
I am seeking a Cooperative Training (Co-op) opportunity starting June 15, 2025, 
for a duration of 6 months.

Best regards,
Fahad  
Software Engineering Student – name University
Saudi Arabia
+966 55 698 8335
Fahad@gmail.com
LinkedIn: https://sa.linkedin.com/in/fahad-alfehaid-94aab823b
GPA: ? / 5 (Excellent)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emails = textBox1.Text
                //هنا راح يصفي الايميلات 
                .Split(new[] { "\r\n", "\n", ",", " ", "–", "-" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => line.Contains("@") && line.Contains("."))
                .Distinct()
                .ToList();

            string subject = textBox2.Text.Trim();
            string body = textBox3.Text.Trim();

            string fromEmail = "your email@gmail.com"; 
            string password = "your app password";   

            string attachmentPath = @"your CV path موقع السيرة الذاتيه";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fromEmail, password)
            };

            foreach (string email in emails)
            {
                try
                {
                    MailMessage message = new MailMessage(fromEmail, email, subject, body);
                    if (File.Exists(attachmentPath))
                    {
                        Attachment cv = new Attachment(attachmentPath);
                        message.Attachments.Add(cv);
                    }

                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {email}:\n{ex.Message}");
                }
            }

            MessageBox.Show("Emails sent successfully.");
        }
    }
}
