using System;
using System.IO;
using System.Collections.Generic;

public class Read 
{
    public List<string> dataList = new List<string>();
        
    public List<string> ReadFile(string path)
    {
        string pathname = path;
        
        try
        {
            using (StreamReader sr = new StreamReader(pathname))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dataList.Add(line);
                }
            }
            
            return dataList;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo no fue encontrado.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
        
        return dataList;
    }

    public void Clear()
    {
        dataList.Clear();
    }
}