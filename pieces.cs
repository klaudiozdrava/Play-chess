using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chessTeliki
{
    class pieces
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
      
        public bool ai = false;//Λογικη μεταβλητη που χρησιμευει για την μετακινηση στο πιονι
       
        public Bitmap destBitmap;
        PictureBox bp;//χρησιμευει για να μετατρεψει το backcolor της εικονας σε γκρι για να θυμαται ο χρηστης απο που μετακινησε το πιονι

        //Η μεθοδος αυτη εχει τον σκοπο της κινησης των πιονιων.Στην πραγματικοτητα βασικα αυτο που κανει ειναι να παρει ως ορισμα καποιο απο τα 64 pictureboxes
        //εαν το image του picturebox ειναι διαφορο του κενου τοτε θετουμε το ai=true δηλαδη οτι κραταμε στα χερια μας καποιο πιονι 
        //υστερα δημιουργουμε  Bitmap instance που παιρνει ως ορισμα το πλατος και υψος σε pixels της εικονας που κλικαραμε αρχικα 
        //Δημιουργειται Graphic instance στο οποιο τοποθτουμε ως ορισμα το Bitmap το οποιο θα αποθηκευσει την  εικονα
        //Επειτα με την μεθοδο DrawImage αποτυπωνουμε το picturebox στο οποιο εγινε το κλικ στο Bitmap instance
        //Το image που εγινε το κλικ ενω το ai=false θα παρει την τιμη null δηλαδη δεν θα εχει καποια εικονα 
        //Μολις πατησουμε για δευτερη φορα καποιο αλλο picturebox ή ακομα και το ιδιο θα πετυχει αυτην την φορα η πρωτη συνθηκη
        //και τωρα το picturebox που πατηθηκε θα μετατραπει στο image τοθ bitmap

      
        public void movepieces(PictureBox pb)
        {
            t.Interval = 1000;//1 sec
            t.Tick += new EventHandler(timer_Tick);
            if (ai)
            {
                pb.Image = destBitmap;
                ai = false;
                t.Stop();
                bp.BackColor = Color.Transparent;

            }
            else
            {
                if (pb.Image != null)
                {
                    ai = true;
                    destBitmap = new Bitmap(pb.Width, pb.Height);
                    Graphics g = Graphics.FromImage(destBitmap);
                    g.DrawImage(pb.Image, new Rectangle(0, 0, destBitmap.Width, destBitmap.Height));
                    g.Dispose();
                    pb.Image = null;
                    bp = pb;//στο picturebox που κλικαραμε μεταφερουμε την τιμη σε αλλο picturebox bp ωστε να γνωριζουμε σε ποιο picturebox θα πρπει το backcolor 
                    //να ειναι γκρι για οσο το χρονομετρο ειναι ενεργο δηλαδη για οσο ο χρηστης δεν εχει πατησει επανω σε αλλο picturebox
                    t.Start();
                }
            }

        }
        //Λειτουργει με την ιδια λογικη απλα δεν αλλαζει το backcolor σε γκρι με την βοηθεια του χρονομετρου
        //Επισης δεν θετει το image του picturebox σε null
        public void morepieces(PictureBox pic)
        {
            if (ai  )
            {
                pic.Image = destBitmap;
                ai = false;
               

            }
            else
            {
                if (pic.Image != null)
                {
                    ai = true;
                    destBitmap = new Bitmap(pic.Width, pic.Height);
                    Graphics g = Graphics.FromImage(destBitmap);
                    g.DrawImage(pic.Image, new Rectangle(0, 0, destBitmap.Width, destBitmap.Height));
                    g.Dispose();
                   
                  
                }
            }
        }


        void timer_Tick(object sender, EventArgs e)
        {
            bp.BackColor = Color.Gray;
        }
    }
}
