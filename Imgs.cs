using System.Net.Mime;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;

public class Imgs
{
   public static void Main()
   {
      // Instantiate an Automobile object.
      // Define a resource file named CarResources.resx.
      using (ResXResourceWriter resx = new ResXResourceWriter(@".\imgs.resx"))
      {
         resx.AddResource("CelestialEmporerCrown.png", Image.FromFile(@".\FDUEUtils\logo\CelestialEmporerCrown.png"));
      }
   }
}