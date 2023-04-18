using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einde_programmeertool
{
    public partial class frmEinde : Form
    {
        public frmEinde()
        {
            InitializeComponent();
        }

        private void btnAdvies_Click(object sender, EventArgs e)
        {
           {
              try    // is voor een mooie foutmelding
              {
               lbxAdvies.Items.Clear();    //Listbox word gecleard

                int begin = int.Parse(txtBegin.Text); // variable int aangemaakt
                int einde = int.Parse(txtEinde.Text);   // variable int aangemaakt
                    int Stap = int.Parse(txtStap.Text);     // variable int aangemaakt

                    if (rdbFor.Checked) //for of while luss
                   {
                        if (rdbGelijkAan.Checked)    // gelijk button is aangeklikt

                        {
                            if (rdbKleiner.Checked)        // van laag naar hoog tellen
                            {

                                if (rdbPlus.Checked)      // van laag naar hoog plus tellen
                                {
                                    lbxAdvies.Items.Add("for (int i = " + begin + " ; i < " + einde + " ; i+=" + Stap + ")");          // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");          // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");          // de code die wordt weergegeven

                                    if (einde < begin)    // foutmelding dat einde is dat begin
                                    {
                                        lbxAdvies.Items.Clear();       //listbox wordt leeg gemaakt
                                        MessageBox.Show("Er is een fout opgetreden");       //de foutmelding

                                    }
                                }
                                else        //als rdbPlus niet geselecteerd is word deze code gebruikt
                                {
                                    lbxAdvies.Items.Add("for (int i = " + begin + " ; i < " + einde + " ; i-=" + Stap + ")");          // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");          // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");          // de code die wordt weergegeven
                                }
                            }
                            else//als rdbKleiner niet geselecteerd is word deze code gebruikt
                            {
                                if (rdbPlus.Checked)//als rdbPlus is geselecteerd
                                {
                                    lbxAdvies.Items.Add("for (int i = " + begin + " ; i > " + einde + " ; i+=" + Stap + ")");              // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");          // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");              // de code die wordt weergegeven

                                    if (einde < begin)//kijkt naar de getallen die zijn ingevoerd bij tekstbalk een kijkt of het eind getal kleiner is dan het begin getal
                                    {
                                        lbxAdvies.Items.Clear();//listbox word leeg gemaakt
                                        MessageBox.Show("Er is een fout opgetreden");//maak een massagebox aan een zegt dat er een fout is opgetreden

                                    }
                                }
                                else//als rdbplus niet geselecteerd is word deze code gebruikt
                                {
                                    lbxAdvies.Items.Add("for (int i = " + begin + " ; i > " + einde + " ; i-=" + Stap + ")");              // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");                  // de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");                  // de code die wordt weergegeven
                                }
                            }
                        }
                        else            //als rdbGelijkAan niet geselecteerd is word deze code gebruikt
                        {
                            lbxAdvies.Items.Clear();//listbox wordt leeg gemaakt
                            MessageBox.Show("Gelijk aan niet geselecteerd"); //zegt dat gelijkaan niet geselecteerd is
                        }
                   
                   }
               
                 else    //als rdbFor niet geselecteerd is word deze code gebruikt
                 {
                    if (rdbGelijkAan.Checked)//als gelijkaan is geselecteerd
                        {

                        if (rdbKleiner.Checked)//als rdbkleiner is geselecteerd
                        {

                            if (rdbPlus.Checked)//als plus is geselecteerd
                            {
                                    lbxAdvies.Items.Add("int i = " + begin + ";");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("while (i < " + einde + ")");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("i+=" + Stap + ";");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");  // de code die wordt weergegeven

                                    if (einde < begin)//kijkt of het einde kleiner is dan het begin getal
                                    {
                                        lbxAdvies.Items.Clear();//listbox wordt leeg gemaakt
                                        MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                    }
                            }
                            else//als rdbPlus niet geselecteerd is word deze code gebruikt
                            {
                                    lbxAdvies.Items.Add("int i = " + begin + ";");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("while (i < " + einde + ")");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("i-=" + Stap + ";");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");// de code die wordt weergegeven

                                if (einde < begin)//kijkt of het einde kleiner is dan het begin
                                {
                                        lbxAdvies.Items.Clear();//listbox wordt leeg gemaakt
                                        MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                }
                            }
                        }
                         else//als rdbKleiner niet geselecteerd is word deze code gebruikt
                         {
                            if (rdbPlus.Checked)//kijkt of rdbPlus is geselecteerd
                            {
                                    lbxAdvies.Items.Add("int i = " + begin + ";");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("while (i > " + einde + ")");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("{");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("i+=" + Stap + ";");// de code die wordt weergegeven
                                    lbxAdvies.Items.Add("}");// de code die wordt weergegeven

                                    if (einde < begin)//kijkt of het eind getal kleiner is dan het begin getal
                                    {
                                        lbxAdvies.Items.Clear();//listbox wordt leeg gemaakt
                                        MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                    }
                            }
                               else//als rdbPlus niet geselecteerd is word deze code gebruikt
                               {
                                  lbxAdvies.Items.Add("int i = " + begin + ";");// de code die wordt weergegeven
                                  lbxAdvies.Items.Add("while (i > " + einde + ")");// de code die wordt weergegeven
                                  lbxAdvies.Items.Add("{");// de code die wordt weergegeven
                                  lbxAdvies.Items.Add("i-=" + Stap + ";");// de code die wordt weergegeven
                                  lbxAdvies.Items.Add("}");// de code die wordt weergegeven

                                    if (einde < begin)//kijkt of het eind getal kleiner is dan het begin getal
                                    {
                                        lbxAdvies.Items.Clear();//listbox wordt leeg gemaakt
                                        MessageBox.Show("Er is een fout opgetreden");//zegt dat er een fout is opgetreden

                                    }
                               }
                         }
                    }
                        else//als rdbGelijkaan niet geselecteerd is word deze code gebruikt
                        {
                            lbxAdvies.Items.Clear();//listbox wordt leeg gemaakt
                            MessageBox.Show("Gelijk aan niet geselecteerd");//zegt dat gelijk niet geselecteerd is

                        }
                 }
              }
              catch
              {
                    MessageBox.Show("Er is een fout opgetreden");         // foutmelding
              }
           }
        }
    }
}