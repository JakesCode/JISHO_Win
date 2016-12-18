using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Newtonsoft.Json;

namespace JISHO_Win
{
    public partial class JISHOWIN : Form
    {
        public JISHOWIN()
        {
            InitializeComponent();
            searchBox.AutoSize = false;
            searchBox.Height = 35;
        }


        public class Meta
        {
            public int status { get; set; }
        }

        public class Japanese
        {
            public string word { get; set; }
            public string reading { get; set; }
        }

        public class Link
        {
            public string text { get; set; }
            public string url { get; set; }
        }

        public class Sens
        {
            public List<string> english_definitions { get; set; }
            public List<object> parts_of_speech { get; set; }
            public List<Link> links { get; set; }
            public List<object> tags { get; set; }
            public List<object> restrictions { get; set; }
            public List<object> see_also { get; set; }
            public List<object> antonyms { get; set; }
            public List<object> source { get; set; }
            public List<object> info { get; set; }
            public List<object> sentences { get; set; }
        }

        public class Attribution
        {
            public bool jmdict { get; set; }
            public bool jmnedict { get; set; }
            public object dbpedia { get; set; }
        }

        public class Datum
        {
            public bool is_common { get; set; }
            public List<object> tags { get; set; }
            public List<Japanese> japanese { get; set; }
            public List<Sens> senses { get; set; }
            public Attribution attribution { get; set; }
        }

        public class RootObject
        {
            public Meta meta { get; set; }
            public List<Datum> data { get; set; }
        }


        public RootObject serverResponse = new RootObject();

        private void JISHOWIN_Load(object sender, EventArgs e)
        {
        }

        private async void makeCallToJisho(string query)
        {
            try
            {
                var responseString = await ("http://beta.jisho.org/api/v1/search/words?keyword=" + query)
                                .GetStringAsync();
                serverResponse = JsonConvert.DeserializeObject<RootObject>(responseString);
                Clipboard.SetText(responseString);
                parseResults();
            }
            catch (Flurl.Http.FlurlHttpException)
            {
                Label sorry = new Label() { AutoSize = true, Text = "Whoops!" + Environment.NewLine + "You're not connected to the internet...." + Environment.NewLine + "JishoWin needs a connection to run.", Location = new Point(mainPanel.Height / 9, mainPanel.Width / 2), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Mamelon", 15) };
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(sorry);
            }
        }

        private void parseResults()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Label() { AutoSize = true, Text = "[Top Result]", TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Mamelon", 15, FontStyle.Underline) });
            var ypos = 20;
            foreach (var singleResult in serverResponse.data)
            {
                for (int i = 0; i < singleResult.japanese.Count; i++)
                {
                    if(singleResult.japanese.Count == 1)
                    {
                        mainPanel.Controls.Add(new Label() { AutoSize = true, Font = new Font("Mamelon", 17), Location = new Point(0, ypos), Text = singleResult.japanese[i].reading });
                    }
                    else
                    {
                        mainPanel.Controls.Add(new Label() { AutoSize = true, Font = new Font("Mamelon", 17), Location = new Point(0, ypos), Text = singleResult.japanese[i].word });
                    }

                    ypos += 20;

                    if(singleResult.japanese.Count > 1)
                    {
                        PictureBox copyButton = new PictureBox() { SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(15, 15), Cursor = Cursors.Hand, ImageLocation = "img\\copy.png", Location = new Point(145, ypos - 17) };
                        ToolTip copyButtonTooltip = new ToolTip();
                        copyButtonTooltip.SetToolTip(copyButton, "Copy to clipboard");
                        copyButton.Click += delegate
                        {
                            Clipboard.SetText(singleResult.japanese[0].word);
                            NotifyIcon infoBalloon = new NotifyIcon() { Icon = new Icon("img\\icon.ico"), BalloonTipTitle = "Copied!", BalloonTipText = singleResult.japanese[0].word + " was added to your clipboard." };
                            infoBalloon.Visible = true;
                            infoBalloon.ShowBalloonTip(1100);
                            infoBalloon.BalloonTipClosed += delegate { infoBalloon.Dispose(); };
                        };
                        mainPanel.Controls.Add(copyButton);
                    }

                    PictureBox copyHiraganaButton = new PictureBox() { SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(15, 15), Cursor = Cursors.Hand, ImageLocation = "img\\copyHiragana.png", Location = new Point(165, ypos - 17) };
                    ToolTip copyHiraganaButtonTooltip = new ToolTip();
                    copyHiraganaButtonTooltip.SetToolTip(copyHiraganaButton, "Copy ひらがな to clipboard");
                    copyHiraganaButton.Click += delegate
                    {
                        Clipboard.SetText(singleResult.japanese[0].reading);
                        NotifyIcon infoBalloon = new NotifyIcon() { Icon = new Icon("img\\icon.ico"), BalloonTipTitle = "Copied!", BalloonTipText = singleResult.japanese[0].reading + " was added to your clipboard." };
                        infoBalloon.Visible = true;
                        infoBalloon.ShowBalloonTip(1100);
                        infoBalloon.BalloonTipClosed += delegate { infoBalloon.Dispose(); };
                    };
                    mainPanel.Controls.Add(copyHiraganaButton);

                    /*try
                    {
                        if (singleResult.senses[i].links.Count > 0)
                        {
                            PictureBox webButton = new PictureBox() { SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(15, 15), Cursor = Cursors.Hand, ImageLocation = "img\\web.png", Location = new Point(185, ypos - 17) };
                            ToolTip webButtonTooltip = new ToolTip();
                            webButtonTooltip.SetToolTip(webButton, singleResult.senses[i].links[0].text);
                            webButton.Click += delegate
                            {
                                MessageBox.Show(singleResult.senses[i].links[singleResult.senses[i].links.Count - 1].url);
                                System.Diagnostics.Process.Start(singleResult.senses[i].links[0].url);
                                this.Hide();
                            };
                            mainPanel.Controls.Add(webButton);
                        }
                    } catch (Exception)
                    {
                    } */
                    
                    
                    LinkLabel more;

                    try
                    {
                        more = new LinkLabel() { BackColor = Color.Transparent, AutoSize = true, Font = new Font("Mamelon", 13), Location = new Point(0, ypos), Text = singleResult.senses[0].english_definitions[0].Substring(0, 31) + "...." + " (Click for more)", LinkBehavior = LinkBehavior.HoverUnderline, LinkColor = Color.Black };
                    }
                    catch (Exception)
                    {
                        more = new LinkLabel() { BackColor = Color.Transparent, AutoSize = true, Font = new Font("Mamelon", 13), Location = new Point(0, ypos), Text = singleResult.senses[0].english_definitions[0] + " (Click for more)", LinkBehavior = LinkBehavior.HoverUnderline, LinkColor = Color.Black };
                    }

                    more.Click += delegate
                    {
                        showMoreDefinitions(singleResult);
                    };
                    mainPanel.Controls.Add(more);

                    ypos += 15;
                    mainPanel.Controls.Add(new Label() { BackColor = Color.Transparent, AutoSize = true, Font = new Font("Mamelon", 13), Location = new Point(0, ypos), Text = "(ひらがな)  -  " + singleResult.japanese[i].reading });
                    ypos += 40;
                }
            }
        }

        private void showMoreDefinitions(Datum singleWord)
        {
            JISHOWIN_DEFINITIONS definitionBox = new JISHOWIN_DEFINITIONS();
            definitionBox.word.Text = singleWord.japanese[0].word;
            try
            {
                definitionBox.primaryEnglishDefinition.Text = (singleWord.senses[0].english_definitions[0]).Substring(0, 24) + "....";
            } catch (Exception)
            {
                definitionBox.primaryEnglishDefinition.Text = (singleWord.senses[0].english_definitions[0]);
            }
            new ToolTip().SetToolTip(definitionBox.primaryEnglishDefinition, singleWord.senses[0].english_definitions[0]);

            if(singleWord.is_common)
            {
                definitionBox.commonIcon.Visible = true;
                definitionBox.commonLabel.Visible = true;
            }

            int ypos = 10;
            int ypos2 = 0;

            for (int x = 0; x < singleWord.senses.Count; x++)
            {
                for (int i = 0; i < singleWord.senses[x].info.Count; i++)
                {
                    definitionBox.info.Text += singleWord.senses[x].info[i] + Environment.NewLine;
                }

                for (int y = 0; y < singleWord.senses[x].english_definitions.Count; y++)
                {
                    LinkLabel singleWordLink = new LinkLabel() { Font = new Font("HonyaJi-Re", 11), Text = singleWord.senses[x].english_definitions[y], AutoSize = true, LinkBehavior = LinkBehavior.HoverUnderline, LinkColor = Color.Black, VisitedLinkColor = Color.Blue, Location = new Point(0, ypos) };
                    singleWordLink.Click += delegate
                    {
                        searchBox.Text = singleWordLink.Text;
                        definitionBox.Dispose();
                        searchButton_Click(null, null);
                    };
                    definitionBox.otherMeanings.Controls.Add(singleWordLink);
                    ypos += 15;
                }

                for (int y = 0; y < singleWord.senses[x].see_also.Count; y++)
                {
                    LinkLabel singleWordLink = new LinkLabel() { Font = new Font("HonyaJi-Re", 11), Text = singleWord.senses[x].see_also[y].ToString(), AutoSize = true, LinkBehavior = LinkBehavior.HoverUnderline, LinkColor = Color.Black, VisitedLinkColor = Color.Blue, Location = new Point(0, ypos2) };
                    singleWordLink.Click += delegate
                    {
                        searchBox.Text = singleWordLink.Text;
                        definitionBox.Dispose();
                        searchButton_Click(null, null);
                    };
                    definitionBox.similarPanel.Controls.Add(singleWordLink);
                    ypos2 += 15;
                }
            }

            definitionBox.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchBox.Text == "")
            {
                Label error = new Label() { AutoSize = true, Text = "Remember to type something up there ▲", TextAlign = ContentAlignment.TopLeft, Font = new Font("Mamelon", 15) };
                mainPanel.Controls.Add(error);
            }
            else
            {
                List<string> randomMessageList = new List<string> { "Running around wildly....", "Frantically reading the dictionary....", "Scurrying about....", "Remembering what " + searchBox.Text + " means....", "Flicking through lots of books....", "Memorising results....", "Wondering how the library got so messy....", "Daydreaming........ oh yes! Your search!", "Thinking about the future....", "Putting down books, picking up more...." };
                Label searching = new Label() { AutoSize = true, Text = randomMessageList[new Random().Next(0, randomMessageList.Count)], TextAlign = ContentAlignment.TopLeft, Font = new Font("Mamelon", 15) };
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(searching);

                PictureBox loadingGif = new PictureBox() {ImageLocation = "img\\loading.gif", Location = new Point(mainPanel.Height / 2 - 50, mainPanel.Width / 2 - 50), SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(100, 100)};
                mainPanel.Controls.Add(loadingGif);

                makeCallToJisho(searchBox.Text);
            }
            
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchButton_Click(null, null);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
