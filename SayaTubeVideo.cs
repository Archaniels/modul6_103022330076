using System;
using System.Diagnostics;


public class SayaTubeVideo
{
	private int id;
	private String title;
	private int playCount;
    
	//DBC
    public SayaTubeVideo(String title)
	{
        Debug.Assert(title.Length <= 200, "Title tidak boleh melebihi 200 karakter");
        Debug.Assert(title != null, "Title tidak boleh null");
        Random rand = new Random();
		this.id = rand.Next(10000, 99999);
        this.title = title;
		this.playCount = 0;
	}

    public void IncreasePlayCount(int playCount)
	{
        Debug.Assert(playCount > 0 && playCount <= 25000000);
		try
		{
			checked
			{
				this.playCount = playCount;
			}
		}
		catch (OverflowException e)
		{
			Console.WriteLine("Error: " + e.Message);
		}
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
