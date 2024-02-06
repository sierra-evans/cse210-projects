using System.Net;
using System.Reflection.Metadata;

public class Entry 
{
    public string date;
    public string prompt;
    public string response;

    public Entry(string date, string prompt, string response)
    {
        this.date = date;
        this.prompt = prompt;
        this.response = response;
    } 

    public Entry(string import) 
    {
        var sections = import.Split("|");
        this.date = sections[0];
        this.prompt = sections[1];
        this.response = sections[2];
    }

    public string ExportEntry()
    {
        return $"{date}|{prompt}|{response}";
    }

    public string DisplayEntry()
    {
        return $"{date}|Prompt: {prompt}|Response: {response}";
    }
}