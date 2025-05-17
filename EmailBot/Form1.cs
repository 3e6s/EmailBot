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


            //نص الرسالة
            textBox3.Text = @"Dear Talent Acquisition Team's,

I hope this message finds you well.


";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var emails = textBox1.Text
                .Split(new[] { "\r\n", "\n", ",", " ", "–", "-" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => line.Contains("@") && line.Contains("."))
                .Distinct()
                .ToList();

            string subject = textBox2.Text.Trim();
            string bodyText = textBox3.Text.Trim().Replace("\n", "<br>"); // HTML body

            string fromEmail = "yourEmail@gmail.com";
            string password = "qyupfsjdx*******y"; // App Password

            string attachmentPath = @"C:\Users\Downloads\CV_Ab.pdf"; //Your Cv Path

            using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fromEmail, password)
            };

            int count = 0;
            foreach (string email in emails)
            {
                try
                {
                    using MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromEmail, "Eng. Abd");// من وين مرسل عادي تكتب اسمك
                    message.To.Add(email);
                    message.Subject = subject;
                    message.SubjectEncoding = System.Text.Encoding.UTF8;

                    message.Body = bodyText;
                    message.IsBodyHtml = true;
                    message.BodyEncoding = System.Text.Encoding.UTF8;

                    message.ReplyToList.Add(new MailAddress(fromEmail));
                    message.Headers.Add("X-Priority", "3"); // Normal priority

                    if (File.Exists(attachmentPath))
                        message.Attachments.Add(new Attachment(attachmentPath));

                    await smtp.SendMailAsync(message);
                    count++;
                    this.Text = $"Sent {count}/{emails.Count}";

                    await Task.Delay(3000); // ⏱️ تأخير 3 ثواني لتقليل احتمالية السبام
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Failed to send to {email}:\n{ex.Message}");
                }
            }

            MessageBox.Show($"✅ Finished sending. Total sent: {count}/{emails.Count}");
            this.Text = "EmailBot";
        }
    }
    }
