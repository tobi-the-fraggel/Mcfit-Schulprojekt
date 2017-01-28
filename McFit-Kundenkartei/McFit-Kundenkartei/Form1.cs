using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace McFit_Kundenkartei
{
    public partial class Kundenverwaltung : Form
    {
        private List<Person> Liste = new List<Person>();
        public Kundenverwaltung()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_Kunde.Checked = true;            
        }

        private void button_Übernehmen_Click(object sender, EventArgs e)
        {          
            //p.Firstname = textBox_Vorname.Text;
            //p.Lastname = textBox_Nachname.Text;
            //p.DateOfBirth = textBox_Geburtsdatum.Text;

            //debugBox.SelectedText = p.Firstname + " " + "\n" + p.Lastname + "\n" + p.DateOfBirth;

            //Kunden k = new Kunden();
            Kunden k = new Kunden(textBox_Vorname.Text, textBox_Nachname.Text, textBox_Geburtsdatum.Text, Convert.ToDouble(textBox_Gewicht.Text), Convert.ToDouble(textBox_Groesse.Text));
            Liste.Add(k);
            this.refreshListe();
            //MessageBox.Show(p.Firstname + " " + p.Lastname + "\n" + p.DateOfBirth);
        }

        private void refreshListe()
        {
            this.listBox_Mitarbeiter.Items.Clear();
            foreach (Kunden k in Liste)
                this.listBox_Kunden.Items.Add(k.Firstname + " " + k.Lastname + " " + k.DateOfBirth + " " + k.Groeße + "cm" + " " + k.Gewicht + "kg" + " " + k.getBMI());
        }

        private void listBox_Mitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox_Mitarbeiter.SelectedIndex;
            textBox_Vorname.Text = Liste[i].Firstname;
            textBox_Nachname.Text = Liste[i].Lastname;
            textBox_Geburtsdatum.Text = Liste[i].DateOfBirth;
           
        }

        private void button_Löschen_Click(object sender, EventArgs e)
        {
            int i = listBox_Mitarbeiter.SelectedIndex;
            if (i == -1) return;
            Liste.RemoveAt(i);
            this.refreshListe();
            
        }
    

        private void button_Ändern_Click(object sender, EventArgs e)
        {
            int i = listBox_Mitarbeiter.SelectedIndex;
            Liste[listBox_Mitarbeiter.SelectedIndex].Firstname = textBox_Vorname.Text;
            Liste[listBox_Mitarbeiter.SelectedIndex].Lastname = textBox_Nachname.Text;
            Liste[listBox_Mitarbeiter.SelectedIndex].DateOfBirth = textBox_Geburtsdatum.Text;
            refreshListe();
        }

        private void button_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {
            if (saveFileList.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(@saveFileList.FileName, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Liste);
                stream.Close();
            }
        }

        private void button_Laden_Click(object sender, EventArgs e)
        {
            if (openFileList.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(@openFileList.FileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Liste = (List<Person>) formatter.Deserialize(stream);
                stream.Close();
                refreshListe();
            }
        }

        private void textBox_Vorname_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Mitarbeiter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mitarbeiter.Checked)
            {
                textBox_Mitarbeiternummer.Clear();
                textBox_Gehalt.Clear();
                textBox_Status.Clear();
                //listBox_Mitarbeiter.ClearSelected();

                textBox_Groesse.Visible = false;
                label_Groesse.Visible = false;
                textBox_Gewicht.Visible = false;
                label_Gewicht.Visible = false;
                listBox_Kunden.Visible = false;
                label_boxKunden.Visible = false;

                textBox_Mitarbeiternummer.Visible = true;
                label_Mitarbeiternummer.Visible = true;
                textBox_Gehalt.Visible = true;
                label_Gehalt.Visible = true;
                textBox_Status.Visible = true;
                label_Status.Visible = true;
                listBox_Mitarbeiter.Visible = true;
                label_boxMitarbeiter.Visible = true;
               
            }
        }

        private void radioButton_Kunde_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Kunde.Checked)
            {
                textBox_Groesse.Clear();
                textBox_Gewicht.Clear();
                //listBox_Kunden.ClearSelected();

                textBox_Mitarbeiternummer.Visible = false;
                label_Mitarbeiternummer.Visible = false;
                textBox_Gehalt.Visible = false;
                label_Gehalt.Visible = false;
                textBox_Status.Visible = false;
                label_Status.Visible = false;
                listBox_Mitarbeiter.Visible = false;
                label_boxMitarbeiter.Visible = false;

                textBox_Groesse.Visible = true;
                label_Groesse.Visible = true;
                textBox_Gewicht.Visible = true;
                label_Gewicht.Visible = true;
                listBox_Kunden.Visible = true;
                label_boxKunden.Visible = true;
            }
        }


    }
}
