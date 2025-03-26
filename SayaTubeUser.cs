using System;
using System.Reflection;
using System.Diagnostics;


public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public String Username;

    
    public SayaTubeUser(String Username)
    {
        Debug.Assert(Username != null, "Username tidak diperbolehkan null");
        Debug.Assert(Username.Length <= 100, "Username tidak bisa melebihi 100 karakter");
        this.Username = Username;
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.Username = "";

    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        for (int i = 0; i < uploadedVideos.Count(); i++)
        {
            total += uploadedVideos[i].getPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo)
    {
        Debug.Assert(Username != null, "Username tidak diperbolehkan null");
        Debug.Assert(Username.Length <= 100, "Username tidak bisa melebihi 100 karakter");
        List<SayaTubeVideo> upload = new List<SayaTubeVideo>();
        SayaTubeVideo user = new SayaTubeVideo(null);
        upload.Add(new String(user.getTitle(), 0));

    }
    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + this.Username);
        for (int i = 0; i < uploadedVideos.Count(); i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
        }
    }

    public String playUsername()
    {
        return Username;
    }
}
