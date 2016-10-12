using SampleSolution.Interfaces.TrainSolution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SampleSolution.Data.Repository.TrainSolution
{
    public class EfDataReaderRepository :IDataReaderRepository
    {
        public EfDataReaderRepository()
        { 
        
        }
        public string[] LoadFromFile(string filePath)
        {
            if (String.IsNullOrEmpty(filePath))
                throw new ArgumentNullException("filePath", "File path cannot be null or empty.");
            if (!File.Exists(filePath))
                throw new ArgumentException("File path is not exist.");

            string[] values;
            using (StreamReader reader = new StreamReader(File.OpenRead(filePath)))
            {
                string line = reader.ReadLine();
                values = line.Split(',').Select(x =>x.Trim()).ToArray();
            }
            foreach(string value in values)
            {
                if(!CheckFormat(value))
                    throw new InvalidDataException("Invalid data format.");
            }
            return values;
        }

        public bool CheckFormat(string edge)
        {
            if (edge.Length < 3)
                return false;
            Regex rgx = new Regex(@"^[a-zA-Z][a-zA-Z]\d$");
            return rgx.IsMatch(edge);
        }
    }
}
