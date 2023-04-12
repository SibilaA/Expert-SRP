using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string NameD { get; set; }
        public string Specialization { get; set; }
        public bool IsValid { get; set; }

        public Doctor(string named, string specialization)
        {
            this.NameD = named;
            this.Specialization = specialization;
            this.IsValid = Addme.AddMe(new string[]{named, specialization});
        }

        public override string ToString()
        {
            return $"{this.NameD}\n Especializado en: {this.Specialization}";
        }

    }
}
