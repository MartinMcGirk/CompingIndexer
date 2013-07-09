using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompingIndexer
{
    public partial class IndexingRepoter : Form
    {
        private const String PAGE_ADDRESS = @"http://forums.moneysavingexpert.com/forumdisplay.php?f=72&order=desc&page={0}";
        
        public IndexingRepoter()
        {
            InitializeComponent();
            
        }

        private void HarvestCompetitionLinks(String path, int numPages)
        {
            HashSet<LinkItem> threadsOnAllPages = new HashSet<LinkItem>();
            for (int i = 1; i < numPages + 1; i++)
            {
                String pagePath = String.Format(path, i);
                String source = GetPageSource(pagePath);
                List<LinkItem> threadsOnPage = HarvestThreadLinks(source);
                foreach (var li in threadsOnPage)
                {
                    if (!threadsOnAllPages.Contains(li))
                    {
                        threadsOnAllPages.Add(li);
                    }
                }
            }
            AvailableCompetitions.DataSource = threadsOnAllPages.ToList();
            AvailableCompetitions.ValueMember = "Url";
            AvailableCompetitions.DisplayMember = "Title";
        }

        /// <summary>
        /// Parses out links to MSE forum threads. 
        /// </summary>
        /// <param name="source">The source of the page</param>
        /// <returns>A list of URLs</returns>
        private List<LinkItem> HarvestThreadLinks(String source)
        {
            HashSet<LinkItem> linksFound = new HashSet<LinkItem>(); //Hashset for speed of lookup

            Regex regex = new Regex("href=\"showthread.+(t=[0-9]+)\".*[>](.+)[<]", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            var matches = regex.Matches(source);
            foreach (Match match in matches)
            {
                String stub = "http://forums.moneysavingexpert.com/showthread.php?";
                String newThread = String.Format("{0}{1}", stub, match.Groups[1].Value);
                LinkItem li = new LinkItem(newThread, match.Groups[2].Value);
                if (!linksFound.Contains(li) && li.Title.StartsWith("E:"))
                {
                    bool okToAdd = true;
                    okToAdd = (excludeFacebook.Checked && (li.Title.Contains("Facebook") || li.Title.Contains("FB"))) ? false : okToAdd;
                    okToAdd = (excludeTwitter.Checked && (li.Title.Contains("Twitter") || li.Title.Contains("(TW)"))) ? false : okToAdd;
                    if (okToAdd)
                    {
                        linksFound.Add(li);
                    } 
                }
            }

            return linksFound.ToList();
        }

        private LinkItem HarvestCompetitionLink(String link, String title)
        {
            String source = GetPageSource(link);
            int trimIndex = source.IndexOf(@"<!-- message -->");
            if (trimIndex > -1)
            {
                String trimmedSource = source.Substring(trimIndex);
                Regex regex = new Regex("href=\"(http[s]{0,1}://[^\"]+)\"", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                var matches = regex.Matches(trimmedSource);
                return new LinkItem(matches[0].Groups[1].Value, title);
            }
            return new LinkItem(link, title);
        }

        /// <summary>
        /// Downloads the source of a webpage and returns it as a string for processing
        /// </summary>
        /// <param name="url">The URL of the page to get the source from</param>
        /// <returns>The source of the url as a string.</returns>
        private String GetPageSource(String url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        private void AvailableCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            LinkItem chosenLink = (LinkItem)AvailableCompetitions.SelectedItem;
            webBrowser.Navigate(chosenLink.Url);
            LinkItem actualLink = HarvestCompetitionLink(chosenLink.Url, chosenLink.Title);
            webBrowserActual.Navigate(actualLink.Url);
            textBoxLink.Text = actualLink.Url;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            HarvestCompetitionLinks(PAGE_ADDRESS, Convert.ToInt32(numPagesSelector.Value));
        }

       
    }

    class LinkItem
    {
        public String Url { get; set; }
        public String Title { get; set; }
        public LinkItem(String url, String title)
        {
            Url = url;
            Title = title;
        }
    }
}
