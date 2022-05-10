using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chessTeliki
{
    public partial class Form1 : Form
    {
       
        int i,j; 
        static string data;
        pieces piece;

        public Form1()
        {
           
            InitializeComponent();
            piece = new pieces();
            using (Form2 f2 = new Form2())
            {
                f2.ShowDialog();
                label1.Text = f2.use1;
                label2.Text = f2.use2;
               
                data = f2.minutes;
                i  = Int32.Parse(data);//χρονος του 1ου παικτη
                j = Int32.Parse(data);//χρονος του 2ου παικτη
               
            }

            int seconds = i % 60;
            int minutes = i / 60;
            string time = minutes + ":" + seconds;
            button3.Text = time;
            button4.Text = time;

            timer1.Start();         
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //καλουμε την μεθοδο της κλασης pieces
           piece.movepieces(pictureBox1);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow


        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox9);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox19);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox2);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox3);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox4);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox5);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox6);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox7);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox8);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox9);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox10);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox11);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox12);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox13);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox14);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox15);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox16);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox17);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox18);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox20);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox21);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox22);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox23);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox24);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox25);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox26);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox27);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox28);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox29);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox30);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox31);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox32);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox33);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox34);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox35);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox36);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            piece.movepieces(pictureBox37);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox38_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox38);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox39_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox39);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox40_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox40);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox41_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox41);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox42_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox42);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox43_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox43);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox44_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox44);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox45_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox45);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox46_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox46);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox47_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox47);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox48_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox48);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox49_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox49);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox50_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox50);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox51_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox51);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox52_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox52);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox53_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox53);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox54_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox54);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox55_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox55);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox56_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox56);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox57_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox57);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox58_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox58);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox59_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox59);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox60_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox60);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox61_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox61);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox62_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox62);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox63_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox63);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        private void pictureBox64_MouseClick(object sender, MouseEventArgs e)
        {
            piece.movepieces(pictureBox64);
            if (piece.ai == true)
            {
                Bitmap bit = new Bitmap(piece.destBitmap);//Εχει σκοπο να αλλαζει τον κσερσορα την εικονα του δηλαδη 
                Cursor co = new Cursor(bit.GetHicon());//αυτο γινεται οταν η μεταβλητη ai της κλασης pieces ειναι αληθης για να φαινεται οτι ο χρηστης κραταει στο χερι του το πιονι
                this.Cursor = co;
            }

            else { this.Cursor = Cursors.Arrow; }//μολις αφεθει το πιονι σε καποιο picturebox τοτε ο κερσορας παιρνει την default value arrow

        }

        bool flag1, flag2;

        //τα κουμπια που τρεχουν τον χρονο του αντιπαλου
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();   
        }

       //Απλος κωδικας για μειωνονται τα δευτερολεπτα 
        private void timer1_Tick(object sender, EventArgs e)
        {
            --i;
            int seconds = i % 60;
            int minutes = i / 60;
            string time = minutes + ":" + seconds;
            button4.Text = time;
            if (i == 0)
            {
                timer1.Stop();
                MessageBox.Show(label1.Text + " Won");
                Application.Exit();
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            --j;
            int seconds = j % 60;
            int minutes = j / 60;
            string time = minutes + ":" + seconds;
            button3.Text = time;
            if (j == 0)
            {
                timer2.Stop();
                MessageBox.Show(label2.Text+" Won");
                Application.Exit();
               
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox65);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox66);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox67);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox68);
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox69);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox72);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox70);
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            piece.morepieces(pictureBox71);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
