internal class program;

class Program
{
    private static void Main(String[] args)
    {
        SayaTubeUser user = new SayaTubeUser(null);
        SayaTubeVideo video1 = new SayaTubeVideo("SE7EN");
        SayaTubeVideo video2 = new SayaTubeVideo("BEAUTIFUL BOY");
        SayaTubeVideo video3 = new SayaTubeVideo("LADY BIRD");
        SayaTubeVideo video4 = new SayaTubeVideo("SCARFACE");
        SayaTubeVideo video5 = new SayaTubeVideo("FERRARI");
        SayaTubeVideo video6 = new SayaTubeVideo("OPPENHEIMER");
        SayaTubeVideo video7 = new SayaTubeVideo("TENET");
        SayaTubeVideo video8 = new SayaTubeVideo("INTERSTELLAR");
        SayaTubeVideo video9 = new SayaTubeVideo("THE GODFATHER");
        SayaTubeVideo video10 = new SayaTubeVideo("THE GODFATHER PART II");

        //membuat video
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        video1.PrintVideoDetails();
    }
}