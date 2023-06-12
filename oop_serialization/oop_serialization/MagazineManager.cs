using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace oop_serialization
{
    [Serializable]
    internal class MagazineManager : IEnumerable
    {
        private List<Magazine> _magazines = new List<Magazine>();

        public void AddMagazine(Magazine magazine)
        {
            _magazines.Add(magazine);
        }
        public void DisplayMagazines()
        {
            foreach (var magazine in _magazines)
            {
                magazine.DisplayInfo();
                Console.WriteLine();
            }
        }
        public void SirializeMagazine(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fs = File.Create(filename))
            {
                formatter.Serialize(fs, _magazines);
            }
        }
        public void DeserializeMagazine(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fs = File.OpenRead(filename))
            {
                _magazines = (List<Magazine>)formatter.Deserialize(fs);
            }
        }
        public void ClearMagazine()
        {
            _magazines.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_magazines).GetEnumerator();
        }
    }
}
