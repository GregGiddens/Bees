using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees
{
    public partial class Form1 : Form
    {
        //reference to a new instance of beesMain
        BeesMain beesMain = new BeesMain();

        public Form1()
        {
            InitializeComponent();

            //initialise beesMain
            beesMain.Start();

            //place each textbox from the form into textboxList
            beesMain.textboxList.Add(textBox1);
            beesMain.textboxList.Add(textBox2);
            beesMain.textboxList.Add(textBox3);
            beesMain.textboxList.Add(textBox4);
            beesMain.textboxList.Add(textBox5);
            beesMain.textboxList.Add(textBox6);
            beesMain.textboxList.Add(textBox7);
            beesMain.textboxList.Add(textBox8);
            beesMain.textboxList.Add(textBox9);
            beesMain.textboxList.Add(textBox10);
            beesMain.textboxList.Add(textBox11);
            beesMain.textboxList.Add(textBox12);
            beesMain.textboxList.Add(textBox13);
            beesMain.textboxList.Add(textBox14);
            beesMain.textboxList.Add(textBox15);
            beesMain.textboxList.Add(textBox16);
            beesMain.textboxList.Add(textBox17);
            beesMain.textboxList.Add(textBox18);
            beesMain.textboxList.Add(textBox19);
            beesMain.textboxList.Add(textBox20);
            beesMain.textboxList.Add(textBox21);
            beesMain.textboxList.Add(textBox22);
            beesMain.textboxList.Add(textBox23);
            beesMain.textboxList.Add(textBox24);
            beesMain.textboxList.Add(textBox25);
            beesMain.textboxList.Add(textBox26);
            beesMain.textboxList.Add(textBox27);
            beesMain.textboxList.Add(textBox28);
            beesMain.textboxList.Add(textBox29);
            beesMain.textboxList.Add(textBox30);

            //update the text on-screen
            beesMain.UpdateBeeText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        //click event for the button calls ButtonClicked method from beesMain
        private void button1_Click(object sender, EventArgs e)
        {
            beesMain.ButtonClicked();
        }
    }
}
