using System.Drawing;
using System.Drawing.Imaging;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Give gif name:");
        string gifName = Console.ReadLine();
        var pic = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        FramesFromAnimatedGIF(pic + "\\Backgrounds\\Anim\\", gifName+".gif");
    }

    public static void FramesFromAnimatedGIF(string rootFolder, string gifName)
    {
        Uri uri = new Uri(rootFolder + gifName);
        Stream s = new System.Net.WebClient().OpenRead(uri.ToString());
        Image originalGif = Image.FromStream(s);

        int Length = originalGif.GetFrameCount(FrameDimension.Time);

        for (int i = 1; i <= Length; i++)
        {
            Thread.Sleep(200);
            originalGif.SelectActiveFrame(FrameDimension.Time, i);
            originalGif.Save(rootFolder + i + ".png", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        originalGif.Dispose();


    }
}
