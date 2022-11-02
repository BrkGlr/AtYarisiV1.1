namespace AtYarisiV1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int bakiye, kazanc,  bahis;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "At Yarýþý oyunu V. 1.1";

            bakiye = 100;
            lblMisli1.Text = rnd.Next(1, 5).ToString();
            lblMisli2.Text = rnd.Next(1, 5).ToString();
            lblMisli3.Text = rnd.Next(1, 5).ToString();
            lblMisli4.Text = rnd.Next(1, 5).ToString();
            


            lblBakiye.Text = bakiye.ToString() + "$";

            

        }
        
        private void btnBasla_Click(object sender, EventArgs e)

        {
           
            try
            {
                bahis = Convert.ToInt32(txtBahis.Text);
                if (bahis == 0)
                {
                    MessageBox.Show("Lütfen Bahis Girniz");
                }
                else if (rdbAt1.Checked == true)
                {
                   if (timer1.Enabled == false)
                {
                        timer1.Start();
                        pctDurum.Show();
                        btnYeniden.Enabled = false;
                        btnBasla.Enabled = false;
                    }
                }


                else if (rdbAt2.Checked == true)
                {
                    if (timer1.Enabled == false)
                    {
                        timer1.Start();
                        pctDurum.Show();
                        btnYeniden.Enabled = false;
                        btnBasla.Enabled = false;
                    }
                }
                else if (rdbAt3.Checked == true)
                {
                    if (timer1.Enabled == false)
                    {
                        timer1.Start();
                        pctDurum.Show();
                        btnYeniden.Enabled = false;
                        btnBasla.Enabled = false;
                    }
                }
                else if (rdbAt4.Checked == true)
                {
                    if (timer1.Enabled == false)
                    {
                        timer1.Start();
                        pctDurum.Show();
                        btnYeniden.Enabled = false;
                        btnBasla.Enabled = false;
                    }
                }
                else 
                {
                    MessageBox.Show("Lütfen Bir Seçim Yapýnýz.");
                }





            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Sayýsal Bir Deðer Giriniz");
            }
            
            
                

           

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int durum = 1;



            pctAt1.Left = pctAt1.Left + rnd.Next(5, 20);
            pctAt2.Left = pctAt2.Left + rnd.Next(5, 20);
            pctAt3.Left = pctAt3.Left + rnd.Next(5, 20);
            pctAt4.Left = pctAt4.Left + rnd.Next(5, 20);
            pctAgac1.Left = pctAgac1.Left - 10;
            if (pctAgac1.Left < -60)
            {
                pctAgac1.Left = 1140;
            }
            pctAgac2.Left = pctAgac2.Left - 10;
            if (pctAgac2.Left < -60)
            {
                pctAgac2.Left = 1140;
            }
            pctAgac3.Left = pctAgac3.Left - 10;
            if (pctAgac3.Left < -60)
            {
                pctAgac3.Left = 1140;
            }
            pctAgac4.Left = pctAgac4.Left - 10;
            if (pctAgac4.Left < -60)
            {
                pctAgac4.Left = 1140;
            }
            pctSerit1.Left = pctSerit1.Left - 60;
            if (pctSerit1.Left < -60)
            {
                pctSerit1.Left = 1140;
            }
            pctSerit2.Left = pctSerit2.Left - 60;
            if (pctSerit2.Left < -60)
            {
                pctSerit2.Left = 1140;
            }
            pctSerit3.Left = pctSerit3.Left - 60;
            if (pctSerit3.Left < -60)
            {
                pctSerit3.Left = 1140;
            }
            pctSerit4.Left = pctSerit4.Left - 60;
            if (pctSerit4.Left < -60)
            {
                pctSerit4.Left = 1140;
            }
            pctSerit5.Left = pctSerit5.Left - 60;
            if (pctSerit5.Left < -60)
            {
                pctSerit5.Left = 1140;
            }

            if (pctAt1.Left > durum)
            {
                durum = pctAt1.Left;
                lblDurum.Text = "1 Numaralý ÞahBatur Yarýþý Önde Götürüyor.";
                pctDurum.Image = pctAt1.Image;
            }
            if (pctAt2.Left > durum)
            {
                durum = pctAt2.Left;
                lblDurum.Text = "2 Numaralý GülBatur Yarýþý Önde Götürüyor";
                pctDurum.Image = pctAt2.Image;
            }
            if (pctAt3.Left > durum)
            {
                durum = pctAt3.Left;
                lblDurum.Text = "3 Numaralý BozAyak Yarýþý Önde Götürüyor";
                pctDurum.Image = pctAt3.Image;
            }
            if (pctAt4.Left > durum)
            {
                durum = pctAt4.Left;
                lblDurum.Text = "4 Numaralý KaraSevda Yarýþý Önde Götürüyor";
                pctDurum.Image = pctAt4.Image;
            }


            if (pctAt1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("1 Numaralý ÞahBatur kazandý");
                btnYeniden.Enabled = true;
                btnBasla.Enabled = false;





            }
            else if (pctAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("2 Numaralý GülBatur kazandý");
                btnYeniden.Enabled = true;
                btnBasla.Enabled = false;
               

            }
            else if (pctAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("3 Numaralý BozAyak kazandý.");
                btnYeniden.Enabled = true;
                btnBasla.Enabled = false;


            }
            else if (pctAt4.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("4 Numaralý KaraSevda kazandý.");
                btnYeniden.Enabled = true;
                btnBasla.Enabled = false;

            }
            if (pctAt1.Right >= lblFinish.Left && rdbAt1.Checked == true)
            {

                kazanc = bahis * Convert.ToInt32(lblMisli1.Text);
                bakiye = bakiye + kazanc;
                lblKazanc.Text = kazanc.ToString() + "$";
                lblBakiye.Text = bakiye.ToString() + "$";

            }
            else if (pctAt1.Right >= lblFinish.Left && rdbAt1.Checked == false)
            {
                bakiye = bakiye - bahis;
                lblBakiye.Text = bakiye.ToString() + "$";
            }
            else if (pctAt2.Right >= lblFinish.Left && rdbAt2.Checked == true)
            {

                kazanc = bahis * Convert.ToInt32(lblMisli2.Text);
                bakiye = bakiye + kazanc;
                lblKazanc.Text = kazanc.ToString() + "$";
                lblBakiye.Text = bakiye.ToString() + "$";

            }
            else if (pctAt2.Right >= lblFinish.Left && rdbAt2.Checked == false)
            {
                bakiye = bakiye - bahis;
                lblBakiye.Text = bakiye.ToString() + "$";
            }
            else if (pctAt3.Right >= lblFinish.Left && rdbAt3.Checked == true)
            {

                kazanc = bahis * Convert.ToInt32(lblMisli3.Text);
                bakiye = bakiye + kazanc;
                lblKazanc.Text = kazanc.ToString() + "$";
                lblBakiye.Text = bakiye.ToString() + "$";

            }
            else if (pctAt3.Right >= lblFinish.Left && rdbAt3.Checked == false)
            {
                bakiye = bakiye - bahis;
                lblBakiye.Text = bakiye.ToString() + "$";
            }
            else if (pctAt4.Right >= lblFinish.Left && rdbAt4.Checked == true)
            {

                kazanc = bahis * Convert.ToInt32(lblMisli4.Text);
                bakiye = bakiye + kazanc;
                lblKazanc.Text = kazanc.ToString() + "$";
                lblBakiye.Text = bakiye.ToString() + "$";

            }
            else if (pctAt4.Right >= lblFinish.Left && rdbAt4.Checked == false)
            {
                bakiye = bakiye - bahis;
                lblBakiye.Text = bakiye.ToString() + "$";
            }



        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            pctAt1.Left = 12;
            pctAt2.Left = 12;
            pctAt3.Left = 12;
            pctAt4.Left = 12;
            lblDurum.Text = "";
            pctDurum.Hide();
            lblMisli1.Text = rnd.Next(1, 5).ToString();
            lblMisli2.Text = rnd.Next(1, 5).ToString();
            lblMisli3.Text = rnd.Next(1, 5).ToString();
            lblMisli4.Text = rnd.Next(1, 5).ToString();



            lblKazanc.Text=("");
            txtBahis.Text = ("");
            btnBasla.Enabled = true;
        }

    }






}




