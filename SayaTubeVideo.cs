using System;

public class SayaTubeVideo
{
	private int id;
	private String title;
	private int playCount;
    
	//DBC
    //Debug.Assert(title <= 200, "Title tidak boleh melebihi 200 karakter");
	//Debug.Assert(title != null, "Title tidak boleh null");
    public SayaTubeVideo(String title)
	{
		Random rand = new Random();
		this.id = rand.Next(10000, 99999);
        this.title = title;
		this.playCount = 0;
	}

    //Debug.Assert(playCount > 0 && playCount <= 25000000);
    public void IncreasePlayCount(int playCount)
	{
		this.playCount += playCount;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }

	public String getTitle()
	{
		return title;
	}

	public int getPlayCount()
	{
		return playCount;
	}
}
