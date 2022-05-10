using System;
using System.Windows.Forms;

namespace chessTeliki
{
    public partial class Form2 : Form
    {
       //επιστρεφονται στις αντιστοιχες public μεταβλητες τα περιεχομενα των textboxes & combobox
        public string use1
        {
            get { return textBox1.Text; }
        }
        public string use2
        {
            get { return textBox2.Text; }
        }
        public string minutes
        {
            get { return comboBox1.SelectedItem.ToString(); }
        }
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//Αρχικοποιω το combobox να δειχνει στο πρωτο στοιχειο του
           
        }

      //Εμφανιζει σχετικο μηνυμα εαν δεν εχει επιλεχθει καποια τιμη απο το combobox ή τουλαχιστον ενα textbox ειναι κενο διαφορετικα κλεινει την φορμα
      void allagh()
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || !(comboBox1.SelectedIndex > -1))
            {
                MessageBox.Show("Insert your data or choose an item from combobox");
            }
            else
            {
                //Δημιουργει αντικειμενο Datetime οπου παιρνει το Value του Datetimepicker και το μετατρεπει σε string
                //Υστερα καλει τον κατασκευαστη του Database και περναει ως ορισμα το ονομα του ενος παικτη,το ονομα του αλλου και την ημερομηνιια

                DateTime dt = dateTimePicker1.Value;
                string date = dt.ToString();
              
                Database databese = new Database(use1, use2, date);
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //καλειται η συναρτηση μολις πατηθει το button
            allagh();            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
