using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList temp = new ArrayList();
        ArrayList Denklem = new ArrayList();
        ArrayList Degiskenler = new ArrayList();
        string tersi;
        string denklem;

        List<ArrayList> Parantezler = new List<ArrayList>();
        List<ArrayList> Tablo = new List<ArrayList>();
        List<ArrayList> TabloY = new List<ArrayList>();
        ArrayList Tablo_degiskenler = new ArrayList();
        ArrayList cozumKumesi = new ArrayList();
        ArrayList Denenenindexler = new ArrayList();
        ArrayList listeBirinciTurYeniden = new ArrayList();
        int index;
        string text;
        bool a = false;
        char enson;

        DataTable t = new DataTable();
      

       

        bool Kontroller()
        {//2li imlicant kontrol
            //for (int i = 0; i < Denklem.Count; i++)//2tane implicant varsa
            //{
            //    GeciciyeDoldur(Denklem[i].ToString());
            //    index = 0;
            //    for (int v = 0; v < temp.Count; v++)
            //    {
            //        if (temp[v].ToString() == ";")
            //        {
            //            index++;
            //        }

            //    }
            //    if(index>1)
            //    {
            //        return true;
            //    }
             
            //}
            enson = '0';
            foreach (char item in denklem)
            {
                if (item=='.'&&enson!=')')
                {
                    return true;
                }
                enson = item;
            }



            return false;
        }
        void implicantara()
        {
            bool v = false;
            for (int i = 0; i < Denklem.Count; i++)
            {
                if (Denklem[i].ToString().Contains(";"))
                {
                    GeciciyeDoldur(Denklem[i].ToString());
                    TersiniBul(temp[temp.IndexOf(";") - 1].ToString() );
                    temp[temp.IndexOf(";") - 1] = tersi;
                    temp[temp.IndexOf(";")] = "+";
                    text = "";
                    foreach (string item in temp)
                    {
                        text += item;
                    }
                    Denklem[i] = text;
                      text = "";
                    v = true;
                    i--;
                }
            }
            if (v)
            {
                   foreach (string item in Denklem)
                    {
                        text += "(";
                        text += item+").";
                       
                    }
                    lbl_aciklama.Text += "Yeni fonksiyon =\n" + text + "\n";
            }
        }
        void AnaParantezleriSil()
        {
            for (int i = 0; i < Denklem.Count; i++)
            {
                Denklem[i] = Denklem[i].ToString().Substring(1);
                Denklem[i] = Denklem[i].ToString().Substring(0, Denklem[i].ToString().Length - 1);
            }
        }
        void DegiskenleriTespitEt()
        {
            for (int i = 0; i < Denklem.Count; i++)
            {
                GeciciyeDoldur(Denklem[i].ToString());
                for (int b = 0; b < temp.Count; b++)
                {
                    if (temp[b].ToString() != "+" && temp[b].ToString() != "(" && temp[b].ToString() != ")")
                    {
                        if (temp[b].ToString().Length == 1)
                        {
                            if (!Degiskenler.Contains(temp[b].ToString()))
                                Degiskenler.Add(temp[b].ToString());

                        }
                        else
                        {
                            TersiniBul(temp[b].ToString());
                            if (!Degiskenler.Contains(tersi))
                                Degiskenler.Add(tersi);
                        }
                    }
                }
            }
        }
        void ParantezleriOlustur()
        {
            for (int i = 0; i < Denklem.Count; i++)
            {
              Denklem[i]=  Denklem[i].ToString().Replace("+","");
                GeciciyeDoldur(Denklem[i].ToString());
                Parantezler.Add(new ArrayList());
                Parantezler[i].AddRange(temp);
               
            }
        }
        void TabloyuOlustur()
        {
           
            for (int i = 0; i < Degiskenler.Count * 2; i++)
            {
                Tablo.Add(new ArrayList());
                index = i / 2;
                if (i % 2 == 0)//normalleri için
                {

                    for (int a = 0; a < Denklem.Count; a++)
                    {
                        if (!Tablo_degiskenler.Contains(Degiskenler[index].ToString()))
                            Tablo_degiskenler.Add(Degiskenler[index].ToString());
                        GeciciyeDoldur(Denklem[a].ToString());
                        if (temp.Contains(Degiskenler[index].ToString()))
                            Tablo[i].Add("C" + a.ToString());


                    }
                }
                else// değilleri için
                {
                    for (int a = 0; a < Denklem.Count; a++)
                    {
                        GeciciyeDoldur(Denklem[a].ToString());
                        TersiniBul(Degiskenler[index].ToString());
                        if (!Tablo_degiskenler.Contains(tersi))
                            Tablo_degiskenler.Add(tersi);

                        if (temp.Contains(tersi))
                            Tablo[i].Add("C" + a.ToString());


                    }

                }
            }
        }
        void TabloyuGuncelle()
        {
            int index;
            for (int i = 0; i <Parantezler.Count; i++)
            { TersiniBul(cozumKumesi[cozumKumesi.Count - 1].ToString());
                if (Parantezler[i].Contains(cozumKumesi[cozumKumesi.Count-1].ToString() ))
                {
                    Parantezler.RemoveAt(i);
                    i--;
                }
                else if(Parantezler[i].Contains(tersi))
                {
                    Parantezler[i].Remove(tersi);
                }
            }
            if (Parantezler.Count != 0)
            {
                Tablo.Clear();



                for (int i = 0; i < Degiskenler.Count * 2; i++)
                {
                    index = i / 2;
                    Tablo.Add(new ArrayList());
                    TersiniBul(Degiskenler[index].ToString());
                    if (!cozumKumesi.Contains(Degiskenler[index].ToString()) || !cozumKumesi.Contains(tersi))
                    {

                   
                    if (i % 2 == 0)//normalleri için
                    {

                        for (int a = 0; a < Parantezler.Count; a++)
                        {
                       
                            if (Parantezler[a].Contains(Degiskenler[index].ToString()))
                                Tablo[i].Add("C" + a.ToString());


                        }
                    }
                    else// değilleri için
                    {
                        for (int a = 0; a < Parantezler.Count; a++)
                        {
                          
                          

                            if (Parantezler[a].Contains(tersi))
                                Tablo[i].Add("C" + a.ToString());


                        }

                    }
                    }
                }

                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[dataGridView1.Columns.Count-1].Width /= 2;

                for (int i = 0; i < Tablo_degiskenler.Count; i++)
                {
                 
                    dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value = Tablo[i].Count.ToString();
                }
                lbl_aciklama.Text += "Tablo güncellendi.\n";
                Denenenindexler.Clear();
                a = false;

                Coz();
            }
            else
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width /= 2;

                for (int i = 0; i < Tablo_degiskenler.Count; i++)
                {

                    dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value = "0";
                }
                lbl_aciklama.Text += "Tablo güncellendi.\n";
                CozumuYazdir();
            }
        }
        void Coz()
        {
      
            for (int i = 0; i < Tablo.Count; i++)
            {
                if (Tablo[i].Count == 0)
                {

                }
                else
                    break;
                if(i== Tablo.Count-1)
                {
                    NotSat();
                    return;
                }
            }
            for (int i = 0; i < Tablo.Count && TabloY.Count != 0; i++)
            {
                if (Tablo[i].Count == TabloY[i].Count)
                {

                }
                else
                    break;

                if (i == Tablo.Count - 1)
                {
                    NotSat();
                    return;
                }
            }
         
            for (int i = 0; i < Tablo.Count&&!a; i++)
            {
                if (Tablo[index].Count < Tablo[i].Count)
                {
                    index = i;
                }
            }
            
            nokta:
            lbl_aciklama.Text += "En çok kapsamaya sahip değişken = "+Tablo_degiskenler[index].ToString()+" dir.\nBir sonraki adım kontrol ediliyor\n";
          
            if (Silinebilirmi())//silinenbilir
            {
                lbl_aciklama.Text += Tablo_degiskenler[index].ToString() + " Değişkeni için bir sonraki adım sorunsuzdur.Bağlantılar yapılıyor.\n";
                if (cozumKumesi.Count==0)
                lbl_aciklama.Text+= Tablo_degiskenler[index].ToString()+" Değişkenine sahip  durumlar birbirine bağlanmıştır.\n";
                else
                    lbl_aciklama.Text += Tablo_degiskenler[index].ToString() + " Değişkenine sahip  durumlar bağlantılara eklenmişlerdir.\n";

                cozumKumesi.Add(Tablo_degiskenler[index].ToString());
                TabloY.Clear();
                TabloY.AddRange(Tablo);
                TabloyuGuncelle();
               
            }
            else//silinemez
            {
                lbl_aciklama.Text += Tablo_degiskenler[index].ToString() + "Değişkeni için bir sonraki adım uygun değildir.\nBir sonraki en büyük kapsamaya sahip değişken seçiliyor.\n";
               Denenenindexler.Add(index.ToString());
                if (Denenenindexler.Count == Parantezler.Count)
                {
                    NotSat();
                    return;
                }
                YenidenHesapla();
                goto nokta;

            }



        }


        bool Silinebilirmi()
        {
            ArrayList liste = new ArrayList();
            string a = Tablo_degiskenler[index].ToString();
            TersiniBul( a );


            for (int i = 0; i < Parantezler.Count; i++)
            {

                if ((Parantezler[i].Contains(tersi) && Parantezler[i].Count == 2) )
                    {
                        temp.Clear();
                        temp.AddRange(Parantezler[i]);
                        temp.Remove(tersi);
                    
                        liste.Add(temp[0].ToString());
                    }
                else if ((Parantezler[i].Contains(tersi) && Parantezler[i].Count == 1))
                {
                    return false;
                }

             
            }


            if (liste.Count==0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    TersiniBul(liste[i].ToString());
                    if (liste.Contains(tersi))
                    {
                        return false;
                    }
                }
            }
            return true;





        }
        void YenidenHesapla()
        {
            index = 0;
            for (int i = 0; i < Tablo.Count; i++)
            {
                if (Tablo[index].Count > Tablo[i].Count)
                {
                    index = i;
                }
            }
            for (int i = 0; i < Tablo.Count; i++)
            {
                if (Tablo[index].Count < Tablo[i].Count && !Denenenindexler.Contains(i.ToString()))
                {
                    index = i;
                }
            }

        }

        void DatagridviewTemizle()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns.RemoveAt(i);
                i--;
            }
        }

        void NotSat()
        {
            lbl_ck.Text = "";
            lbl_aciklama.Text = "";
            DatagridviewTemizle();
            if (listeBirinciTurYeniden.Count<=1)
            {
          
            MessageBox.Show("Girdiğiniz fonksiyonu 1 yapan herhangi bir kombinasyon yoktur.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                listeBirinciTurYeniden.RemoveAt(0);
                Tablo.Clear();
                Tablo_degiskenler.Clear();
                cozumKumesi.Clear();
                TabloyuOlustur();
                Parantezler.Clear();
                ParantezleriOlustur();
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[0].Width /= 2;
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[1].Width /= 2;

                for (int i = 0; i < Tablo_degiskenler.Count; i++)
                {
                    dataGridView1.Rows.Add(Tablo_degiskenler[i].ToString());
                    dataGridView1.Rows[i].Cells[1].Value = Tablo[i].Count.ToString();
                }
           
               index=Convert.ToInt32(listeBirinciTurYeniden[0].ToString());
                a = true;
                Coz();
            }
          
        }
        void CozumuYazdir()
        {
            if (SonKontrol())
            {
                for (int i = 0; i < cozumKumesi.Count; i++)
                {
                    if (cozumKumesi[i].ToString().Length==1)
                    {
                        lbl_ck.Text += cozumKumesi[i].ToString() + " = 1 ";
                       
                    }
                    else
                    {
                        TersiniBul(cozumKumesi[i].ToString());
                        lbl_ck.Text += tersi + " = 0 ";
                    }
                }
                lbl_aciklama.Text += "Sonucu 1 yapan değerler :\n";
                lbl_aciklama.Text += lbl_ck.Text;
            }
            else
                NotSat();
        }
        bool SonKontrol()
        {
            string a;
            for (int i = 0; i < Denklem.Count; i++)
            {
                a = Denklem[i].ToString();
                a.Replace("+", "");
                GeciciyeDoldur(a);
                for (int b = 0; b < cozumKumesi.Count; b++)
                {
                    if (temp.Contains(cozumKumesi[b].ToString()))
                    {
                        break;
                    }
                    else if(b==cozumKumesi.Count-1)
                    {
                        
                        return false;
                    }
                }
            }
            return true;
        }
        #region parçalama ve geçiciye doldurma 

        void GeciciyeDoldur(string a)
        {
            string gecici = a;
            temp.Clear();
            for (int v = 0; v < a.Length; v++)
            {

                if (gecici.Substring(v, 1) == "'")
                    temp[temp.Count - 1] = temp[temp.Count - 1].ToString() + "'";
                else
                    temp.Add(gecici.Substring(v, 1).ToString());
            }

        }
        void DegiskenleriListeyeCikar(string a, ArrayList array)
        {

            GeciciyeDoldur(a);
            array.Clear();
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].ToString() != "+")
                    array.Add(temp[i].ToString());
            }
        }
        void TersiniBul(string karakter)
        {
         
            if (karakter.Length == 1)
                tersi = karakter + "'";
            else if (karakter.Length == 2)
                tersi = karakter.Remove(karakter.Length - 1);
        }

        #endregion

        private void BTNCOZ_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            DatagridviewTemizle();
            listeBirinciTurYeniden.Clear();
            denklem = tb_denklem.Text;
            Denklem.Clear();
            lbl_ck.Text = "";
            Parantezler.Clear();
            lbl_aciklama.Text = "";
            Denenenindexler.Clear();
            Tablo.Clear();
            Tablo_degiskenler.Clear();
            cozumKumesi.Clear();
            Denklem.AddRange(denklem.Split('.'));
            AnaParantezleriSil();
            if (Kontroller())
            {
                NotSat();
                return;
            }
            implicantara();
            DegiskenleriTespitEt();
            ParantezleriOlustur();
            TabloyuOlustur();
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns[0].Width /= 2;
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns[1].Width /= 2;

            for (int i = 0; i < Tablo_degiskenler.Count; i++)
            {
                dataGridView1.Rows.Add(Tablo_degiskenler[i].ToString());
                dataGridView1.Rows[i].Cells[1].Value = Tablo[i].Count.ToString();
            }
            for (int i = 0; i < Tablo.Count; i++)
            {
                if (Tablo[index].Count < Tablo[i].Count)
                {
                    index = i;
                }
            }
            listeBirinciTurYeniden.Add(index.ToString());
            for (int i = 0; i < Tablo.Count; i++)
            {
                if (Tablo[index].Count == Tablo[i].Count && index != i)
                {
                    listeBirinciTurYeniden.Add(i.ToString());

                }
            }
            Coz();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
