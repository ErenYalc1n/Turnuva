namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gsg = 0, fbg=0, bjkg=0, tsg = 0, gsy = 0, fby = 0, bjky = 0, tsy = 0, gsp = 0, fbp = 0, bjkp = 0, tsp = 0;
        int gss=0, fbs=0, bjks=0, tss=0;
        

        Random rnd =new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);
            int c = rnd.Next(0, 4);
            int d = rnd.Next(0, 4);
            label17.Text = a.ToString();
            label18.Text = b.ToString();
            label21.Text = c.ToString();
            label22.Text = d.ToString();
            gsg = gsg + a;
            fbg = fbg + b;
            bjkg = bjkg + c;
            tsg = tsg + d;
            gsy = gsy + b;
            fby = fby + a;
            bjky = bjky + d;
            tsy= tsy + c;
            if (a>b)
            {
                gsp = gsp + 3;
                gss = gss + 300;
            }
            else if (a<b)
            {
                fbp = fbp + 3;
                fbs = fbs + 300;
            }
            else
            {
                gsp = gsp + 1;
                fbp = fbp + 1;
                gss = gss + 100;
                fbs = fbs + 100;
            }

            if (c > d)
            {
                bjkp = bjkp + 3;
                bjks=bjks+ 300;
            }
            else if (c < d)
            {
                tsp = tsp + 3;
                tss= tss + 300;
            }
            else
            {
                bjkp = bjkp + 1;
                tsp = tsp + 1;
                bjks = bjks + 100;
                tss = tss + 100;
            }
            button1.Enabled= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a2 = rnd.Next(0, 4);
            int b2 = rnd.Next(0, 4);
            int c2 = rnd.Next(0, 4);
            int d2 = rnd.Next(0, 4);
            label25.Text = a2.ToString();
            label27.Text = b2.ToString();
            label24.Text = c2.ToString();
            label28.Text = d2.ToString();
            gsg = gsg + a2;
            fbg = fbg + b2;
            bjkg = bjkg + c2;
            tsg = tsg + d2;
            gsy = gsy + c2;
            fby = fby + d2;
            bjky = bjky + a2;
            tsy = tsy + b2;
            if (a2 > c2)
            {
                gsp = gsp + 3;
                gss = gss + 300;
            }
            else if (a2 < c2)
            {
                bjkp = bjkp + 3;
                bjks = bjks + 300;
            }
            else
            {
                gsp = gsp + 1;
                bjkp = bjkp + 1;
                gss = gss + 100;
                bjks = bjks + 100;
            }

            if (d2 > b2)
            {
                tsp = tsp + 3;
                tss = tss + 300;
            }
            else if (d2 < b2)
            {
                fbp = fbp + 3;
                fbs=fbs+ 300;
            }
            else
            {
                tsp = tsp + 1;
                fbp = fbp + 1;
                tss = tss + 100;
                fbs = fbs + 100;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a3 = rnd.Next(0, 4);
            int b3 = rnd.Next(0, 4);
            int c3 = rnd.Next(0, 4);
            int d3 = rnd.Next(0, 4);
            label31.Text = a3.ToString();
            label34.Text = b3.ToString();
            label33.Text = c3.ToString();
            label30.Text = d3.ToString();
            gsg = gsg + a3;
            fbg = fbg + b3;
            bjkg = bjkg + c3;
            tsg = tsg + d3;
            gsy = gsy + d3;
            fby = fby + c3;
            bjky = bjky + b3;
            tsy = tsy + a3;
            if (a3 > d3)
            {
                gsp = gsp + 3;
                gss = gss + 300;
            }
            else if (a3 < d3)
            {
                tsp = tsp + 3;
                tss = tss + 300;
            }
            else
            {
                gsp = gsp + 1;
                tsp = tsp + 1;
                gss = gss + 100;
                tss = tss + 100;
            }

            if (c3 > b3)
            {
                bjkp = bjkp + 3;
                bjks = bjks + 300;
            }
            else if (c3 < b3)
            {
                fbp = fbp + 3;
                fbs = fbs + 300;
            }
            else
            {
                bjkp = bjkp + 1;
                fbp = fbp + 1;
                bjks = bjks + 100;
                fbs = fbs + 100;
            }
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /* label39.Text = gsg.ToString();
             label44.Text = fbg.ToString();
             label47.Text = bjkg.ToString();
             label50.Text = tsg.ToString();
             label40.Text = gsy.ToString();
             label43.Text = fby.ToString();
             label46.Text = bjky.ToString();
             label49.Text = tsy.ToString();
             label41.Text = gsp.ToString();
             label42.Text = fbp.ToString();
             label45.Text = bjkp.ToString();
             label48.Text = tsp.ToString(); */
            gss = gss + (10 * (gsg - gsy)) + gsg;
            fbs = fbs + (10 * (fbg - fby)) + fbg;
            bjks = bjks + (10 * (bjkg - bjky)) + bjkg;
            tss = tss + (10 * (tsg - tsy)) + tsg;
            int[] dizi = { gss, fbs, bjks, tss};
            Array.Sort(dizi);
            Array.Reverse(dizi);
            label51.Text = dizi[0].ToString();
            label52.Text = dizi[1].ToString();
            label53.Text = dizi[2].ToString();
            label54.Text = dizi[3].ToString();
            if (dizi[0]==gss)
            {
                label13.Text = "Galatasaray";
                label39.Text = gsg.ToString();
                label40.Text = gsy.ToString();
                label41.Text = gsp.ToString();
                label55.Text = "**Þampiyon Galatasaray**";
            }
            else if (dizi[1]==gss)
            {
                label14.Text = "Galatasaray";
                label44.Text = gsg.ToString();
                label43.Text = gsy.ToString();
                label42.Text = gsp.ToString();
            }
            else if (dizi[2] == gss)
            {
                label15.Text = "Galatasaray";
                label47.Text = gsg.ToString();
                label46.Text = gsy.ToString();
                label45.Text = gsp.ToString();
            }
            else if (dizi[3] == gss)
            {
                label16.Text = "Galatasaray";
                label50.Text = gsg.ToString();
                label49.Text = gsy.ToString();
                label48.Text = gsp.ToString();
            }

            if (dizi[0] == fbs)
            {
                label13.Text = "Fenerbahçe";
                label39.Text = fbg.ToString();
                label40.Text = fby.ToString();
                label41.Text = fbp.ToString();
                label55.Text = "**Þampiyon Fenerbahçe**";
            }
            else if (dizi[1] == fbs)
            {
                label14.Text = "Fenerbahçe";
                label44.Text = fbg.ToString();
                label43.Text = fby.ToString();
                label42.Text = fbp.ToString();
            }
            else if (dizi[2] == fbs)
            {
                label15.Text = "Fenerbahçe";
                label47.Text = fbg.ToString();
                label46.Text = fby.ToString();
                label45.Text = fbp.ToString();
            }
            else if (dizi[3] == fbs)
            {
                label16.Text = "Fenerbahçe";
                label50.Text = fbg.ToString();
                label49.Text = fby.ToString();
                label48.Text = fbp.ToString();
            }

            if (dizi[0] == bjks)
            {
                label13.Text = "Beþiktaþ";
                label39.Text = bjkg.ToString();
                label40.Text = bjky.ToString();
                label41.Text = bjkp.ToString();
                label55.Text = "**Þampiyon Beþiktaþ**";
            }
            else if (dizi[1] == bjks)
            {
                label14.Text = "Beþiktaþ";
                label44.Text = bjkg.ToString();
                label43.Text = bjky.ToString();
                label42.Text = bjkp.ToString();
            }
            else if (dizi[2] == bjks)
            {
                label15.Text = "Beþiktaþ";
                label47.Text = bjkg.ToString();
                label46.Text = bjky.ToString();
                label45.Text = bjkp.ToString();
            }
            else if (dizi[3] == bjks)
            {
                label16.Text = "Beþiktaþ";
                label50.Text = bjkg.ToString();
                label49.Text = bjky.ToString();
                label48.Text = bjkp.ToString();
            }

            if (dizi[0] == tss)
            {
                label13.Text = "Trabzonspor";
                label39.Text = tsg.ToString();
                label40.Text = tsy.ToString();
                label41.Text = tsp.ToString();
                label55.Text = "**Þampiyon Trabzonspor**";
            }
            else if (dizi[1] == tss)
            {
                label14.Text = "Trabzonspor";
                label44.Text = tsg.ToString();
                label43.Text = tsy.ToString();
                label42.Text = tsp.ToString();
            }
            else if (dizi[2] == tss)
            {
                label15.Text = "Trabzonspor";
                label47.Text = tsg.ToString();
                label46.Text = tsy.ToString();
                label45.Text = tsp.ToString();
            }
            else if (dizi[3] == tss)
            {
                label16.Text = "Trabzonspor";
                label50.Text = tsg.ToString();
                label49.Text = tsy.ToString();
                label48.Text = tsp.ToString();
            }
            gsg = 0; fbg = 0; bjkg = 0; tsg = 0; gsy = 0; fby = 0; bjky = 0; tsy = 0;
            gsp = 0; fbp = 0; bjkp = 0; tsp = 0; gss = 0; fbs = 0; bjks = 0; tss = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
    }
}