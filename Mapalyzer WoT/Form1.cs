using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mapalyzer_WoT
{
    public partial class Form1 : Form
    {
        public bool isCleared = false;
        public int count = 0;
        public double mountainpass = 0f;
        public double glacier = 0f;
        public double north_america44 = 0f;
        public double north_america45 = 0f;
        public double fishing_bay = 0f;
        public double tundra = 0f;
        public double czech114 = 0f;
        public double malinovka = 0f;
        public double minsk = 0f;
        public double karelia = 0f;
        public double cliff = 0f;
        public double japort = 0f;
        public double asia_miao = 0f;
        public double airfield = 0f;
        public double ruinberg = 0f;
        public double westfeld = 0f;
        public double el_hallouf = 0f;
        public double asia_great_wall = 0f;
        public double monastery = 0f;
        public double mannerheim_line = 0f;
        public double canada_a = 0f;
        public double eiffel_tower_ctf = 0f;
        public double steppes = 0f;
        public double erlenberg = 0f;
        public double kharkiv = 0f;
        public double siegfried_line = 0f;
        public double himmelsdorf = 0f;
        public double hills = 0f;
        public double prohorovka = 0f;
        public double ensk = 0f;
        public double redshire = 0f;
        public double poland99 = 0f;
        public double dday = 0f;
        public double desert = 0f;
        public double murovanka = 0f;
        public double germany105 = 0f;
        public double fjord = 0f;
        public double lakeville = 0f;
        public double campania_big = 0f;
        public double munchen = 0f;
        public double lost_city_ctf = 0f;
        public double er_clime = 0f;
        public double epic_random_valley = 0f;
        public double er_alaska = 0f;
       
        public Form1()
        {
            InitializeComponent();
            lbl1.Text = "Select replays folder.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCleared)
            {
                const string message = "Everything is already reset.";
                const string caption = "Warning";
                var result = MessageBox.Show(this, message, caption,
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Warning);
                
            } else
            {
                
                lbl1.Text = "Stats reset.";
                dataGridView1.Rows.Clear();
                isCleared = true;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            lbl1.Text = "Select replays folder.";
            dataGridView1.Rows.Clear();
            isCleared = true;
            count = 0;
            mountainpass = 0f;
            glacier = 0f;
            north_america44 = 0f;
            north_america45 = 0f;
            fishing_bay = 0f;
            tundra = 0f;
            czech114 = 0f;
            malinovka = 0f;
            minsk = 0f;
            karelia = 0f;
            cliff = 0f;
            japort = 0f;
            asia_miao = 0f;
            airfield = 0f;
            ruinberg = 0f;
            westfeld = 0f;
            el_hallouf = 0f;
            asia_great_wall = 0f;
            monastery = 0f;
            mannerheim_line = 0f;
            canada_a = 0f;
            eiffel_tower_ctf = 0f;
            steppes = 0f;
            erlenberg = 0f;
            kharkiv = 0f;
            siegfried_line = 0f;
            himmelsdorf = 0f;
            hills = 0f;
            prohorovka = 0f;
            ensk = 0f;
            redshire = 0f;
            poland99 = 0f;
            dday = 0f;
            desert = 0f;
            murovanka = 0f;
            germany105 = 0f;
            fjord = 0f;
            lakeville = 0f;
            campania_big = 0f;
            munchen = 0f;
            lost_city_ctf = 0f;
            er_clime = 0f;
            epic_random_valley = 0f;
            er_alaska = 0f;
            if (vistaFolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                isCleared = false;
                
                lbl1.Text = vistaFolderBrowserDialog1.SelectedPath;
                DirectoryInfo dinfo = new DirectoryInfo(vistaFolderBrowserDialog1.SelectedPath);
                FileInfo[] Files = dinfo.GetFiles("*.wotreplay");
                if(Files.Length <= 0)
                {
                    
                    const string message = "No .wotreplay files found in directory.";
                    const string caption = "Error";
                    var result = MessageBox.Show(this,message, caption,
                                                 MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Warning);
                }
                foreach (FileInfo file in Files)
                {
                    if((file.Name != "replay_last_battle.wotreplay") && (file.Name != "temp.wotreplay") && !file.Name.Contains("Halloween") && !file.Name.Contains("hw21"))
                    {
                        count++;
                        if (file.Name.Contains("caucasus"))
                        {
                            mountainpass++;                    
                        }
                        if (file.Name.Contains("115_sweden"))
                        {
                            glacier++;
                        }
                        if (file.Name.Contains("44_north_america"))
                        {
                            north_america44++;
                        }
                        if (file.Name.Contains("45_north_america"))
                        {
                            north_america45++;
                        }
                        if (file.Name.Contains("fishing_bay"))
                        {
                            fishing_bay++;
                        }
                        if (file.Name.Contains("tundra"))
                        {
                            tundra++;
                        }
                        if (file.Name.Contains("114_czech"))
                        {
                            czech114++;
                        }
                        if (file.Name.Contains("minsk"))
                        {
                            minsk++;
                        }
                        if (file.Name.Contains("karelia"))
                        {
                            karelia++;
                        }
                        if (file.Name.Contains("cliff"))
                        {
                            cliff++;
                        }
                        if (file.Name.Contains("japort"))
                        {
                            japort++;
                        }
                        if (file.Name.Contains("asia_miao"))
                        {
                            asia_miao++;
                        }
                        if (file.Name.Contains("airfield"))
                        {
                            airfield++;
                        }
                        if (file.Name.Contains("ruinberg"))
                        {
                            ruinberg++;
                        }
                        if (file.Name.Contains("westfeld"))
                        {
                            westfeld++;
                        }
                        if (file.Name.Contains("el_hallouf"))
                        {
                            el_hallouf++;
                        }
                        if (file.Name.Contains("asia_great_wall"))
                        {
                            asia_great_wall++;
                        }
                        if (file.Name.Contains("monastery"))
                        {
                            monastery++;
                        }
                        if (file.Name.Contains("mannerheim_line"))
                        {
                            mannerheim_line++;
                        }
                        if (file.Name.Contains("canada_a"))
                        {
                            canada_a++;
                        }
                        if (file.Name.Contains("eiffel_tower_ctf"))
                        {
                            eiffel_tower_ctf++;
                        }
                        if (file.Name.Contains("steppes"))
                        {
                            steppes++;
                        }
                        if (file.Name.Contains("erlenberg"))
                        {
                            erlenberg++;
                        }
                        if (file.Name.Contains("kharkiv"))
                        {
                            kharkiv++;
                        }
                        if (file.Name.Contains("siegfried_line"))
                        {
                            siegfried_line++;
                        }
                        if (file.Name.Contains("himmelsdorf"))
                        {
                            himmelsdorf++;
                        }
                        if (file.Name.Contains("hills"))
                        {
                            hills++;
                        }
                        if (file.Name.Contains("prohorovka"))
                        {
                            prohorovka++;
                        }
                        if (file.Name.Contains("ensk"))
                        {
                            ensk++;
                        }
                        if (file.Name.Contains("redshire"))
                        {
                            redshire++;
                        }
                        if (file.Name.Contains("99_poland"))
                        {
                            poland99++;
                        }
                        if (file.Name.Contains("dday"))
                        {
                            dday++;
                        }
                        if (file.Name.Contains("desert"))
                        {
                            desert++;
                        }
                        if (file.Name.Contains("murovanka"))
                        {
                            murovanka++;
                        }
                        if (file.Name.Contains("105_germany"))
                        {
                            germany105++;
                        }
                        if (file.Name.Contains("fjord"))
                        {
                            fjord++;
                        }
                        if (file.Name.Contains("lakeville"))
                        {
                            lakeville++;
                        }
                        if (file.Name.Contains("campania_big"))
                        {
                            campania_big++;
                        }
                        if (file.Name.Contains("munchen"))
                        {
                            munchen++;
                        }
                        if (file.Name.Contains("lost_city_ctf"))
                        {
                            lost_city_ctf++;
                        }
                        if (file.Name.Contains("er_clime"))
                        {
                            er_clime++;
                        }
                        if (file.Name.Contains("epic_random_valley"))
                        {
                            epic_random_valley++;
                        }
                        if (file.Name.Contains("er_alaska"))
                        {
                            er_alaska++;
                        }
                        if (file.Name.Contains("malinovka"))
                        {
                            malinovka++;
                        }
                    }                    
                }
                dataGridView1.Rows.Add(Properties.Resources.mountainpass, "Mountain Pass", mountainpass, Math.Round((mountainpass / count)*100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.glacier, "Glacier", glacier, Math.Round((glacier / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.liveoaks, "Live Oaks", north_america44, Math.Round((north_america44 / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.highway, "Highway", north_america45, Math.Round((north_america45 / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.fishermansbay, "Fisherman's Bay", fishing_bay, Math.Round((fishing_bay / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.tundra, "Tundra", tundra, Math.Round((tundra / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.pilsen, "Pilsen", czech114, Math.Round((czech114 / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.malinovka, "Malinovka", malinovka, Math.Round((malinovka / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.minsk, "Minsk", minsk, Math.Round((minsk / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.karelia, "Karelia", karelia, Math.Round((karelia / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.cliff, "Cliff", cliff, Math.Round((cliff / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.safehaven, "Safe Haven", japort, Math.Round((japort / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.pearlriver, "Pearl River", asia_miao, Math.Round((asia_miao / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.airfield, "Airfield", airfield, Math.Round((airfield / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.ruinberg, "Ruinberg", ruinberg, Math.Round((ruinberg / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.westfield, "Westfield", westfeld, Math.Round((westfeld / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.elhalluf, "El Halluf", el_hallouf, Math.Round((el_hallouf / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.empiresborder, "Empire's Border", asia_great_wall, Math.Round((asia_great_wall / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.abbey, "Abbey", monastery, Math.Round((monastery / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.mannerheimline, "Mannerheim Line", mannerheim_line, Math.Round((mannerheim_line / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.serenecoast, "Serene Coast", canada_a, Math.Round((canada_a / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.paris, "Paris", eiffel_tower_ctf, Math.Round((eiffel_tower_ctf / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.steppes, "Steppes", steppes, Math.Round((steppes / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.erlenberg, "Erlenberg", erlenberg, Math.Round((erlenberg / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.kharkov, "Kharkov", kharkiv, Math.Round((kharkiv / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.siegfriedline, "Siegfried Line", siegfried_line, Math.Round((siegfried_line / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.himmelsdorf, "Himmelsdorf", himmelsdorf, Math.Round((himmelsdorf / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.mines, "Mines", hills, Math.Round((hills / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.prokhorovka, "Prokhorovka", prohorovka, Math.Round((prohorovka / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.ensk, "Ensk", ensk, Math.Round((ensk / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.redshire, "Redshire", redshire, Math.Round((redshire / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.studzianki, "Studzianki", poland99, Math.Round((poland99 / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.overlord, "Overlord", dday, Math.Round((dday / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.sandriver, "Sand River", desert, Math.Round((desert / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.murovanka, "Murovanka", murovanka, Math.Round((murovanka / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.berlin, "Berlin", germany105, Math.Round((germany105 / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.fjords, "Fjords", fjord, Math.Round((fjord / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.lakeville, "Lakeville", lakeville, Math.Round((lakeville / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.province, "Province", campania_big, Math.Round((campania_big / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.widepark, "Widepark", munchen, Math.Round((munchen / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.ghosttown, "Ghost Town", lost_city_ctf, Math.Round((lost_city_ctf / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.hinterland, "Hinterland", er_clime, Math.Round((er_clime / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.nebelburg, "Nebelburg", epic_random_valley, Math.Round((epic_random_valley / count) * 100, 2) + "%");
                dataGridView1.Rows.Add(Properties.Resources.klondike, "Klondike", er_alaska, Math.Round((er_alaska / count) * 100, 2) + "%");
                mountainpass = 0f;
                glacier = 0f;
                north_america44 = 0f;
                north_america45 = 0f;
                fishing_bay = 0f;
                tundra = 0f;
                czech114 = 0f;
                malinovka = 0f;
                minsk = 0f;
                karelia = 0f;
                cliff = 0f;
                japort = 0f;
                asia_miao = 0f;
                airfield = 0f;
                ruinberg = 0f;
                westfeld = 0f;
                el_hallouf = 0f;
                asia_great_wall = 0f;
                monastery = 0f;
                mannerheim_line = 0f;
                canada_a = 0f;
                eiffel_tower_ctf = 0f;
                steppes = 0f;
                erlenberg = 0f;
                kharkiv = 0f;
                siegfried_line = 0f;
                himmelsdorf = 0f;
                hills = 0f;
                prohorovka = 0f;
                ensk = 0f;
                redshire = 0f;
                poland99 = 0f;
                dday = 0f;
                desert = 0f;
                murovanka = 0f;
                germany105 = 0f;
                fjord = 0f;
                lakeville = 0f;
                campania_big = 0f;
                munchen = 0f;
                lost_city_ctf = 0f;
                er_clime = 0f;
                epic_random_valley = 0f;
                er_alaska = 0f;
                lbl1.Text = "Analyzed " + count + " battles";
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
