using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
class EnteringInteger
{
    static void Main()
    {
        string Name, txt;
        int year, age, born;
               txt = Interaction.InputBox( "Lets acquainted","What is your surname");
        born=Int32.Parse(txt);
        Name = Interaction.InputBox("Lets acquainted", "What is your name");
        year = Int32.Parse(Name);
        age = year - born+10;
        MessageBox.Show("Hello "+Name+" you are "+age+" !");
    }
}
