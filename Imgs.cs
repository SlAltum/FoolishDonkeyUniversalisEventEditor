using System.Net.Mime;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
public class Imgs{
	public static void Main(){
		using (ResXResourceWriter resx = new ResXResourceWriter(@".\imgs.resx")){
			resx.AddResource("CelestialEmporerCrown.png", Image.FromFile(@".\FDUEUtils\logo\CelestialEmporerCrown.png"));
			resx.AddResource("CelestialEmporerCrownSelected.png", Image.FromFile(@".\FDUEUtils\logo\CelestialEmporerCrownSelected.png"));
			resx.AddResource("KingsCrown.png", Image.FromFile(@".\FDUEUtils\logo\KingsCrown.png"));
			resx.AddResource("KingsCrownSelected.png", Image.FromFile(@".\FDUEUtils\logo\KingsCrownSelected.png"));
		}
	}
}
