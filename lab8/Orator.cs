using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    [Serializable]
    public class Orator
    {
        private string reportTopic;
        private string section;
        private string name;
        private string country;
        private string city;
        private decimal membershipFee;

        public string ReportTopic
        {
            get { return reportTopic; }
            set { reportTopic = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public decimal MembershipFee
        {
            get { return membershipFee; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Membership fee can not be less then 0");
                }
                membershipFee = value;
            }
        }

        public Orator()
        {
        }

        public Orator(string reportTopic, string section, string name, string country, string city, int membershipFee)
        {
            ReportTopic = reportTopic;
            Section = section;
            Name = name;
            Country = country;
            City = city;
            MembershipFee = membershipFee;
        }

        public override string ToString()
        {
            return "Orator{ reportTopic = " + ReportTopic + ", section = " + Section + ", name = " + Name + ", country = " +
                Country + ", city = " + City + ", membershipFee = " + MembershipFee + "}";
        }
    }

    [Serializable]
    public class OratorList : IList<Orator>
    {

        private List<Orator> orators = new List<Orator>();

        public int Count
        {
            get { return orators.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public Orator this[int index] 
        {
            get { return orators[index]; }
            set { orators[index] = value; }
        }

        public void FillOrators()
        {
            orators.Add(new Orator("Topic 1", "Section 1", "Name 1", "Ukraine", "Lviv", 10));
            orators.Add(new Orator("Topic 2", "Section 1", "Name 2", "Ukraine", "Kyiv", 10));
            orators.Add(new Orator("Topic 3", "Section 1", "Name 3", "Ukraine", "Odessa", 10));

            orators.Add(new Orator("Topic 4", "Section 1", "Name 4", "Poland", "Krakow", 10));
            orators.Add(new Orator("Topic 5", "Section 1", "Name 5", "Poland", "Lodz", 10));
            orators.Add(new Orator("Topic 6", "Section 2", "Name 6", "Poland", "Wroclaw", 10));

            orators.Add(new Orator("Topic 7", "Section 2", "Name 7", "England", "London", 10));
            orators.Add(new Orator("Topic 8", "Section 2", "Name 8", "England", "Edinburgh", 10));
            orators.Add(new Orator("Topic 9", "Section 2", "Name 9", "England", "Belfast", 10));
        }

        public void ReduceMembershipFee(Predicate<Orator> suitableMembersDetector, Func<decimal, decimal> reduceFunction)
        {
            foreach(Orator orator in orators)
            {
                if (suitableMembersDetector(orator))
                {
                    orator.MembershipFee = reduceFunction(orator.MembershipFee);
                }
            }
        }

        public List<Orator> GetBy(Func<Orator, bool> suitableOratorDector) 
        {
            return orators.Where(suitableOratorDector).ToList();
        }

        public void WriteToFile(IFormatter formatter, string pathToFile)
        {
            using (FileStream fileStream = new FileStream(pathToFile, FileMode.Create))
            {
                formatter.Serialize(fileStream, this);
            }
        }

        public void ReadFromFile(IFormatter formatter, string pathToFile)
        {
            using (FileStream fileStream = new FileStream(pathToFile, FileMode.Open))
            {
                foreach (Orator o in formatter.Deserialize(fileStream) as OratorList)
                {
                    orators.Add(o);
                }
            }
        }

        public int IndexOf(Orator item)
        {
            return orators.IndexOf(item);
        }

        public void Insert(int index, Orator item)
        {
            orators.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            orators.RemoveAt(index);
        }

        public void Add(Orator item)
        {
            orators.Add(item);
        }

        public void Clear()
        {
            orators.Clear();
        }

        public bool Contains(Orator item)
        {
            return orators.Contains(item);
        }

        public void CopyTo(Orator[] array, int arrayIndex)
        {
            orators.CopyTo(array, arrayIndex);
        }

        public bool Remove(Orator item)
        {
            return orators.Remove(item);
        }

        public IEnumerator<Orator> GetEnumerator()
        {
            return orators.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return orators.GetEnumerator();
        }

        public void Sort(Comparison<Orator> comparator)
        {
            orators.Sort(comparator);
        }

    }

}
