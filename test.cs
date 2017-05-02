using System;
using System.Windows.Forms;
   
class InstantiateHelloWorld
{
     public static void Main()
     {
          Form form   = new Form();
          form.Text   = "Instantiate " + form.Text;
          form.Paint += new PaintEventHandler(MyPaintHandler);
   
          Application.Run(form);
     }
     static void MyPaintHandler(object objSender, PaintEventArgs pea)
     {
          Form     form = (Form)objSender;
          Graphics graphics = pea.Graphics;
   
          graphics.DrawString("Hello from InstantiateHelloWorld!", 
                          form.Font, Brushes.Black, 0, 100);
     }
}