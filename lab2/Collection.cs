using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Collection
    {
        public MyList<Asterism> Asterisms { get; set; } = new MyList<Asterism>();
        public MyList<Star> Stars { get; set; } = new MyList<Star>();
        public MyList<Planet> Planets { get; set; } = new MyList<Planet>();

        string currentFile = "..\\..\\..\\data.txt";
        string currentBinaryFile = "..\\..\\..\\data.dat";

        public void AddAsterism(Asterism asterism)
        {
            Asterisms.Add(asterism);
        }

        public void AddStar(Star star)
        {
            Stars.Add(star);
        }

        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
        }

        public void RemoveAsterism(Asterism asterism)
        {
            Asterisms.Remove(asterism);
        }
        public void RemoveStar(Star star)
        {
            Stars.Remove(star);
        }
        public void RemovePlanet(Planet planet)
        {
            Planets.Remove(planet);
        }

        public void ClearCollection()
        {
            Asterisms.Clear();
            Stars.Clear();
            Planets.Clear();
        }

        class Foo : IDisposable
        {
            public void Dispose()
            {

            }
        }

        public void Save_to_File()
        {
            string  path = currentFile;
            using (var foo = new Foo())
            {

            }

            using (StreamWriter sr = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sr.WriteLine(Asterisms.Count);
                foreach (var asterism in Asterisms)
                {
                    sr.WriteLine(asterism.Name);
                    sr.WriteLine(asterism.Position);
                }
                sr.WriteLine(Stars.Count);
                foreach (var star in Stars)
                {
                    sr.WriteLine(star.Name);
                    sr.WriteLine(star.Radius);
                    sr.WriteLine(star.Mass);
                    sr.WriteLine(star.Luminosity);                                      
                    sr.WriteLine(star.Type);
                }
                sr.WriteLine(Planets.Count);
                foreach (var planet in Planets)
                {
                    sr.WriteLine(planet.Name);
                    sr.WriteLine(planet.Radius);
                    sr.WriteLine(planet.Mass);
                    sr.WriteLine(planet.Rotation);
                    sr.WriteLine(planet.Star);
                    sr.WriteLine(planet.Orbit);
                    sr.WriteLine(planet.Rotation_around);
                }
            } 
        }

        public void SaveToBinaryFile()
        {
            
               string path = currentBinaryFile;
            using (BinaryWriter sr = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {

                sr.Write(Asterisms.Count);
                foreach (var asterism in Asterisms)
                {
                    sr.Write(asterism.Name);
                    sr.Write(asterism.Position);
                }
                sr.Write(Stars.Count);
                foreach (var star in Stars)
                {
                    sr.Write(star.Name);
                    sr.Write(star.Radius);
                    sr.Write(star.Mass);
                    sr.Write(star.Luminosity);
                    sr.Write(star.Type);
                }
                sr.Write(Planets.Count);
                foreach (var planet in Planets)
                {
                    sr.Write(planet.Name);
                    sr.Write(planet.Radius);
                    sr.Write(planet.Mass);
                    sr.Write(planet.Rotation);
                    sr.Write(planet.Star);
                    sr.Write(planet.Orbit);
                    sr.Write(planet.Rotation_around);
                }
            }
        }

        public void LoadfromFile(string path)
        {
            currentFile = path;
            ClearCollection();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                int AsterismCount = int.Parse(sr.ReadLine());
                for(int i=0; i<AsterismCount; i++)
                {
                    var tmpAsterism = new Asterism();
                    tmpAsterism.Name = sr.ReadLine();
                    tmpAsterism.Position = sr.ReadLine();
                    this.AddAsterism(tmpAsterism);
                }

                int StarCount = int.Parse(sr.ReadLine());
                for (int i = 0; i < StarCount; i++)
                {
                    var tmpStar = new Star();
                    tmpStar.Name = sr.ReadLine();
                    tmpStar.Radius = int.Parse(sr.ReadLine());
                    tmpStar.Mass = int.Parse(sr.ReadLine());
                    tmpStar.Luminosity = int.Parse(sr.ReadLine());
                    tmpStar.Type = sr.ReadLine();
                    this.AddStar(tmpStar);
                }

                int PlanetCount = int.Parse(sr.ReadLine());
                for (int i = 0; i < PlanetCount; i++)
                {
                    var tmpPlanet = new Planet();
                    tmpPlanet.Name = sr.ReadLine();
                    tmpPlanet.Radius = int.Parse(sr.ReadLine());
                    tmpPlanet.Mass = int.Parse(sr.ReadLine());
                    tmpPlanet.Rotation = int.Parse(sr.ReadLine());
                    tmpPlanet.Star = sr.ReadLine();
                    tmpPlanet.Orbit = int.Parse(sr.ReadLine());
                    tmpPlanet.Rotation_around = int.Parse(sr.ReadLine());
                    this.AddPlanet(tmpPlanet);
                }
            }
        }

        public void LoadFromBinaryFile(string path)
        {
            currentBinaryFile = path;
            ClearCollection();
            using (BinaryReader sr = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int AsterismCount = sr.ReadInt32();
                for(int i=0; i< AsterismCount; i++)
                {
                    var tmpAsterism = new Asterism();
                    tmpAsterism.Name = sr.ReadString();
                    tmpAsterism.Position = sr.ReadString();
                    this.AddAsterism(tmpAsterism);
                }
                int StarCount = sr.ReadInt32();
                for (int i = 0; i < StarCount; i++)
                {
                    var tmpStar = new Star();
                    tmpStar.Name = sr.ReadString();
                    tmpStar.Radius = sr.ReadDouble();
                    tmpStar.Mass = sr.ReadDouble();
                    tmpStar.Luminosity = sr.ReadDouble();
                    tmpStar.Type = sr.ReadString();
                    this.AddStar(tmpStar);
                }

                int PlanetCount = sr.ReadInt32();
                for (int i = 0; i < PlanetCount; i++)
                {
                    var tmpPlanet = new Planet();
                    tmpPlanet.Name = sr.ReadString();
                    tmpPlanet.Radius = sr.ReadDouble();
                    tmpPlanet.Mass = sr.ReadDouble();
                    tmpPlanet.Rotation = sr.ReadDouble();
                    tmpPlanet.Star = sr.ReadString();
                    tmpPlanet.Orbit = sr.ReadDouble();
                    tmpPlanet.Rotation_around = sr.ReadDouble();
                    this.AddPlanet(tmpPlanet);
                }
            }
        }
    }
}
