using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Security;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {

        //Private field and instantiate a new empty list
        private List<IValuable> valuables = new List<IValuable>();


        //Get Valuables method
        public List<IValuable> GetValuables()
        {
            return valuables;
        }

        
        // Add Merchandize method
        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }




        // Get Merchandise method
        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise && (valuable as Merchandise).ItemId == id)
                    return valuable;
                else if (valuable is Course && (valuable as Course).Name == id)
                    return valuable;
                else if (valuable is Amulet && (valuable as Amulet).ItemId == id)
                    return valuable;
            }
            return null;
        }

        // GetTotalValue  method
        public double GetTotalValue()
        {
            double totalValue = 0.0;            

            foreach (IValuable valuable in valuables)
            {
                totalValue += valuable.GetValue();
            }
            return totalValue;
        }

        public int Count()
        {
            int mycount = valuables.Count;
            return mycount;
        }

        // Save method
        public void Save()
        {
            Save("ValuableRepository.txt");            
        }


        // Save method with fileName
        public void Save(string fileName)
        {
            //StreamWriter sr = new StreamWriter(@"C:\Users\Justin\Datamatiker\Programmering\Kode\Disaheim\Disaheim\bin\Debug\net6.0\ValuableRepository.txt");
            StreamWriter sr = new StreamWriter(fileName);
            foreach (IValuable valuable in valuables)
            {
                sr.WriteLine(valuable);

                if (valuable is Book)
                {
                    Book book = (Book)valuable;
                    sr.WriteLine($"BOG; {book.ItemId}; {book.Title}; {book.Price}");
                }

                else if (valuable is Amulet)
                {
                    Amulet amulet = (Amulet)valuable;
                    sr.WriteLine($"AMULET; {amulet.ItemId}; {amulet.Design}; {amulet.Quality}");
                }

                else if (valuable is Course)
                {
                    Course course = (Course)valuable;
                    sr.WriteLine($"COURSE; {course.Name}; {course.DurationInMinutes}; {Course.CourseHourValue}");
                }
            }
            sr.Close();
        }
        
        // Load method
        public void Load()
        {
            Load("ValuableRepository.txt");
        }


        // Load method with fileName
        public void Load(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] variables = line.Split(";");
                    string elementInArray = variables[0];

                    switch (elementInArray)
                    {
                        case "BOG":
                            Book book = new Book(variables[1], variables[2], Convert.ToDouble(variables[3]));
                            AddValuable(book);
                            break;

                        case "AMULET":
                            Level quality = Level.low;

                            switch (variables[3])
                            {
                                case "low":
                                    quality = Level.high;
                                    break;

                                case "medium":
                                    quality = Level.medium;
                                    break;

                                case "high":
                                    quality = Level.low;
                                    break;                               
                            }

                            Amulet amulet = new Amulet(variables[1], quality, variables[2]);
                            AddValuable(amulet);
                            break;

                        case "COURSE":
                            Course course = new Course(variables[1], Convert.ToInt32(variables[2]));
                            AddValuable(course);
                            break;
                        
                    }
                }

                sr.Close();
            }
            
            
         
            catch (Exception)
            {
                Console.WriteLine("Error: An unknown error occurred while loading the file.");
            }            
        }


    }
}

