using System;

string filePath1 = "prodotti_abbigliamento.txt"; 
string filePath2 = "prodotti_abbigliamento_aggiornati.txt"; 

StreamReader reader = new StreamReader(filePath1);
StreamWriter streamWriter = new StreamWriter(filePath2);


string line = reader.ReadLine();
line = reader.ReadLine();
string[] parts = line.Split(',');
string[] nomiOggetti = parts;
streamWriter.WriteLine("ID, Prodotto, Categoria, Prezzo, Disponibilità");
while (line != null)
{
    parts = line.Split(',');
    parts[3] = parts[3].Replace('.', ',');
    
    float prize = float.Parse(parts[3]);
    nomiOggetti[3] = (prize + ((prize / 100) * 10)).ToString();
    Console.WriteLine($"{parts[0]}, {parts[1]}, {parts[2]}, {nomiOggetti[3]}, {parts[4]}");
    streamWriter.WriteLine($"{parts[0]}, {parts[1]}, {parts[2]}, {nomiOggetti[3]}, {parts[4]}");

    line = reader.ReadLine();

}
reader.Close();
streamWriter.Close();